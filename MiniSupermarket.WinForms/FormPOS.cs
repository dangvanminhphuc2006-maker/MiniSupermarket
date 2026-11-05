using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSupermarket.WinForms.Services;

namespace MiniSupermarket.WinForms
{
    public partial class FormPOS : Form
    {
        private readonly List<CartItemDto> _cart = new();
        private readonly Button _btnRedeemPoints;
        private readonly Label _lblPointsDiscount;
        private int _customerRewardPoints;
        private int _redeemPoints;

        public FormPOS()
        {
            InitializeComponent();
            SetupCartGrid();
            _btnRedeemPoints = new Button
            {
                BackColor = Color.FromArgb(238, 244, 255),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.FromArgb(41, 100, 180),
                Location = new Point(10, 140),
                Size = new Size(290, 28),
                Text = "Dùng 50 điểm (-50.000 đ)"
            };
            _btnRedeemPoints.FlatAppearance.BorderColor = Color.FromArgb(190, 210, 240);
            _btnRedeemPoints.Click += btnRedeemPoints_Click;
            _lblPointsDiscount = new Label
            {
                AutoSize = true,
                ForeColor = Color.FromArgb(40, 130, 80),
                Location = new Point(10, 170),
                Text = "Ưu đãi điểm: 0 đ"
            };
            groupCustomer.Controls.Add(_btnRedeemPoints);
            groupCustomer.Controls.Add(_lblPointsDiscount);
            groupCustomer.Height = 205;
            UpdateLoyaltyControls();
        }

        private void SetupCartGrid()
        {
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Barcode",
                HeaderText = "Mã vạch",
                Width = 125
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Tên Sản Phẩm",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            var colUnitPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Đơn Giá (đ)",
                Width = 110
            };
            colUnitPrice.DefaultCellStyle.Format = "N0";
            colUnitPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCart.Columns.Add(colUnitPrice);

            var colQuantity = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "SL",
                Width = 70
            };
            colQuantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCart.Columns.Add(colQuantity);

            var colTotalPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Thành Tiền (đ)",
                Width = 130
            };
            colTotalPrice.DefaultCellStyle.Format = "N0";
            colTotalPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTotalPrice.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dgvCart.Columns.Add(colTotalPrice);
        }

        // Bắt sự kiện quét mã Barcode
        private async void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                string barcode = txtBarcode.Text.Trim();
                txtBarcode.Clear();
                await AddProductToCartByBarcodeAsync(barcode);
            }

        }

        private async Task AddProductToCartByBarcodeAsync(string barcode)
        {
            try
            {
                // Gọi API tra cứu sản phẩm theo Barcode
                var product = await ApiClientService.Client.GetFromJsonAsync<ProductDto>($"products/barcode/{barcode}");
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm có mã vạch này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (product.StockQuantity <= 0)
                {
                    MessageBox.Show($"Sản phẩm '{product.ProductName}' hiện đã hết hàng trong kho!", "Hết hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingItem = _cart.FirstOrDefault(c => c.ProductId == product.ProductId);
                if (existingItem != null)
                {
                    if (existingItem.Quantity + 1 > product.StockQuantity)
                    {
                        MessageBox.Show($"Kho chỉ còn {product.StockQuantity} sản phẩm!", "Cảnh báo tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    existingItem.Quantity++;
                }
                else
                {
                    _cart.Add(new CartItemDto
                    {
                        ProductId = product.ProductId,
                        Barcode = product.Barcode,
                        ProductName = product.ProductName,
                        UnitPrice = product.Price,
                        Quantity = 1
                    });
                }

                UpdateCartDisplay();
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Không tìm thấy sản phẩm có mã vạch này. Vui lòng kiểm tra lại mã.", "Không tìm thấy sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Không thể kết nối máy chủ để tra cứu mã hàng. Kiểm tra mạng rồi thử lại.", "Mất kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (JsonException)
            {
                MessageBox.Show("Máy chủ trả về dữ liệu sản phẩm không hợp lệ. Vui lòng thử lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm sản phẩm vào giỏ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnSelectProduct_Click(object? sender, EventArgs e)
        {
            using var dialog = new FormPOSLookupDialog<ProductDto>(
                "Chọn sản phẩm",
                "Nhập tên hoặc mã vạch sản phẩm...",
                async keyword =>
                {
                    string query = Uri.EscapeDataString(keyword);
                    var page = await ApiClientService.Client.GetFromJsonAsync<LookupPageDto<ProductDto>>(
                        $"products/paged?keyword={query}&pageNumber=1&pageSize=50");
                    return page?.Items ?? throw new InvalidOperationException("Máy chủ không trả về danh sách sản phẩm.");
                },
                (nameof(ProductDto.Barcode), "Mã vạch"),
                (nameof(ProductDto.ProductName), "Tên sản phẩm"),
                (nameof(ProductDto.Price), "Giá bán"),
                (nameof(ProductDto.StockQuantity), "Tồn kho"));

            if (dialog.ShowDialog(this) == DialogResult.OK && dialog.SelectedItem is ProductDto product)
            {
                await AddProductToCartByBarcodeAsync(product.Barcode);
            }
        }

        private void UpdateCartDisplay()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart;

            decimal total = _cart.Sum(x => x.TotalPrice);
            if (_redeemPoints > 0 && _redeemPoints * 1000m > total)
            {
                _redeemPoints = 0;
            }
            lblTotalAmount.Text = $"{Math.Max(0, total - _redeemPoints * 1000m):N0} đ";
            UpdateLoyaltyControls();
            CalculateChange();
        }

        private void txtCashReceived_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {
            decimal total = _cart.Sum(x => x.TotalPrice) - _redeemPoints * 1000m;
            string rawText = txtCashReceived.Text.Replace(".", "").Replace(",", "").Trim();

            if (decimal.TryParse(rawText, out decimal cashReceived))
            {
                decimal change = cashReceived - total;
                if (change >= 0)
                {
                    lblChange.Text = $"{change:N0} đ";
                    lblChange.ForeColor = Color.FromArgb(40, 167, 69);
                }
                else
                {
                    lblChange.Text = "Chưa đủ tiền!";
                    lblChange.ForeColor = Color.FromArgb(220, 53, 69);
                }
            }
            else
            {
                lblChange.Text = "0 đ";
                lblChange.ForeColor = Color.FromArgb(40, 167, 69);
            }
        }

        private void btnCashExact_Click(object sender, EventArgs e)
        {
            decimal total = Math.Max(0, _cart.Sum(x => x.TotalPrice) - _redeemPoints * 1000m);
            txtCashReceived.Text = total > 0 ? total.ToString("N0", CultureInfo.InvariantCulture).Replace(",", ".") : "0";
        }

        private void btnCashQuick_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string amountStr = btn.Text.Replace(".", "").Trim();
                txtCashReceived.Text = amountStr;
            }
        }

        private async void btnLookupCustomer_Click(object sender, EventArgs e)
        {
            await SelectCustomerAsync();
        }

        private async void txtCustomerPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LookupCustomerAsync();
            }
        }

        private async Task LookupCustomerAsync()
        {
            string phone = txtCustomerPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                await SelectCustomerAsync();
                return;
            }

            _customerRewardPoints = 0;
            _redeemPoints = 0;
            lblCustomerName.Text = "Đang tra cứu khách hàng...";
            lblCustomerPoints.Text = "Đang xác minh điểm tích lũy";
            UpdateCartDisplay();

            try
            {
                var customer = await ApiClientService.Client.GetFromJsonAsync<CustomerDto>($"customers/by-phone/{phone}");
                if (customer != null)
                {
                    SetSelectedCustomer(customer);
                }
                else
                {
                    lblCustomerName.Text = "Không tìm thấy khách hàng";
                    lblCustomerPoints.Text = "Chưa có thông tin điểm";
                    UpdateLoyaltyControls();
                }
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _customerRewardPoints = 0;
                _redeemPoints = 0;
                lblCustomerName.Text = "Khách hàng chưa đăng ký";
                lblCustomerPoints.Text = "Chưa có thông tin điểm";
                UpdateCartDisplay();
            }
            catch (HttpRequestException)
            {
                lblCustomerName.Text = "Chưa thể xác minh khách hàng";
                lblCustomerPoints.Text = "Không thể tải thông tin điểm";
                MessageBox.Show("Không thể kết nối máy chủ để tra cứu khách hàng. Kiểm tra mạng rồi thử lại.", "Mất kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (JsonException)
            {
                lblCustomerName.Text = "Không thể xác minh khách hàng";
                lblCustomerPoints.Text = "Dữ liệu điểm không hợp lệ";
                MessageBox.Show("Máy chủ trả về dữ liệu khách hàng không hợp lệ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task SelectCustomerAsync()
        {
            using var dialog = new FormPOSLookupDialog<CustomerDto>(
                "Chọn khách hàng thành viên",
                "Nhập tên hoặc số điện thoại khách hàng...",
                async keyword =>
                {
                    string query = Uri.EscapeDataString(keyword);
                    var page = await ApiClientService.Client.GetFromJsonAsync<LookupPageDto<CustomerDto>>(
                        $"customers/paged?keyword={query}&pageNumber=1&pageSize=50");
                    return page?.Items ?? throw new InvalidOperationException("Máy chủ không trả về danh sách khách hàng.");
                },
                (nameof(CustomerDto.CustomerName), "Tên khách hàng"),
                (nameof(CustomerDto.PhoneNumber), "Số điện thoại"),
                (nameof(CustomerDto.RewardPoints), "Điểm"),
                (nameof(CustomerDto.MembershipRank), "Hạng"));
            dialog.InitialKeyword = txtCustomerPhone.Text.Trim();

            if (dialog.ShowDialog(this) == DialogResult.OK && dialog.SelectedItem is CustomerDto customer)
            {
                SetSelectedCustomer(customer);
            }
        }

        private void SetSelectedCustomer(CustomerDto customer)
        {
            txtCustomerPhone.Text = customer.PhoneNumber;
            _customerRewardPoints = customer.RewardPoints;
            _redeemPoints = 0;
            lblCustomerName.Text = $"{customer.CustomerName} ({customer.MembershipRank})";
            lblCustomerPoints.Text = $"Điểm tích lũy: {customer.RewardPoints} điểm";
            UpdateCartDisplay();
        }

        private void btnRedeemPoints_Click(object? sender, EventArgs e)
        {
            if (_redeemPoints > 0)
            {
                _redeemPoints = 0;
            }
            else
            {
                decimal total = _cart.Sum(item => item.TotalPrice);
                if (_customerRewardPoints < 50)
                {
                    MessageBox.Show("Khách hàng cần có ít nhất 50 điểm để đổi ưu đãi.", "Chưa đủ điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (total < 50000m)
                {
                    MessageBox.Show("Hóa đơn cần từ 50.000 đ để sử dụng ưu đãi 50 điểm.", "Hóa đơn chưa đủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _redeemPoints = 50;
            }

            UpdateCartDisplay();
        }

        private void UpdateLoyaltyControls()
        {
            _btnRedeemPoints.Enabled = _customerRewardPoints >= 50 || _redeemPoints > 0;
            _btnRedeemPoints.Text = _redeemPoints > 0
                ? "Bỏ sử dụng điểm"
                : $"Dùng 50 điểm (-50.000 đ) | Có {_customerRewardPoints:N0} điểm";
            _lblPointsDiscount.Text = $"Ưu đãi điểm: {(_redeemPoints * 1000m):N0} đ";
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ sản phẩm trong giỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _cart.Clear();
                UpdateCartDisplay();
                txtCashReceived.Clear();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow?.DataBoundItem is CartItemDto selectedItem)
            {
                _cart.Remove(selectedItem);
                UpdateCartDisplay();
            }
        }

        private async void btnCheckout_Click(object sender, EventArgs e)
        {
            await PerformCheckoutAsync();
        }

        private async Task PerformCheckoutAsync()
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng quét sản phẩm trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = _cart.Sum(x => x.TotalPrice);
            decimal payable = Math.Max(0, total - _redeemPoints * 1000m);
            string rawText = txtCashReceived.Text.Replace(".", "").Replace(",", "").Trim();
            if (!decimal.TryParse(rawText, out decimal cashReceived) || cashReceived < payable)
            {
                MessageBox.Show("Tiền khách đưa chưa đủ để thanh toán đơn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCashReceived.Focus();
                return;
            }

            var orderRequest = new
            {
                CashierUsername = SessionManager.CurrentUsername,
                CustomerPhone = txtCustomerPhone.Text.Trim(),
                RedeemPoints = _redeemPoints,
                Items = _cart.Select(i => new { i.ProductId, i.Quantity, i.UnitPrice }).ToList()
            };

            try
            {
                var response = await ApiClientService.Client.PostAsJsonAsync("orders/checkout", orderRequest);
                if (response.IsSuccessStatusCode)
                {
                    decimal discount = _redeemPoints * 1000m;
                    decimal change = cashReceived - payable;
                    decimal cartTotal = _cart.Sum(item => item.TotalPrice);
                    MessageBox.Show($"Thanh toán thành công!\nTổng tiền: {cartTotal:N0} đ\nƯu đãi điểm: {discount:N0} đ\nKhách cần trả: {payable:N0} đ\nKhách đưa: {cashReceived:N0} đ\nTiền thừa: {change:N0} đ\nĐã in hóa đơn thanh toán.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _cart.Clear();
                    _redeemPoints = 0;
                    _customerRewardPoints = 0;
                    UpdateCartDisplay();
                    txtCashReceived.Clear();
                    txtCustomerPhone.Clear();
                    lblCustomerName.Text = "Khách vãng lai";
                    lblCustomerPoints.Text = "Điểm tích lũy: 0 điểm";
                    txtBarcode.Focus();
                }
                else
                {
                    string message = await ReadApiErrorAsync(response);
                    MessageBox.Show($"Thanh toán thất bại: {message}", "Không thể thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Không kết nối được máy chủ. Hóa đơn chưa được thanh toán; vui lòng kiểm tra mạng rồi thử lại.", "Mất kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (JsonException)
            {
                MessageBox.Show("Máy chủ trả về dữ liệu thanh toán không hợp lệ. Vui lòng kiểm tra trạng thái hóa đơn trước khi thử lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hoàn tất thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static async Task<string> ReadApiErrorAsync(HttpResponseMessage response)
        {
            string content = await response.Content.ReadAsStringAsync();
            try
            {
                using var document = JsonDocument.Parse(content);
                if (document.RootElement.TryGetProperty("message", out var message))
                {
                    return message.GetString() ?? "Máy chủ từ chối thanh toán.";
                }
            }
            catch (JsonException)
            {
                if (!string.IsNullOrWhiteSpace(content))
                {
                    return content;
                }
            }

            return response.StatusCode switch
            {
                System.Net.HttpStatusCode.Unauthorized => "Phiên đăng nhập đã hết hạn. Vui lòng đăng nhập lại.",
                System.Net.HttpStatusCode.Forbidden => "Tài khoản không có quyền thanh toán.",
                _ => "Máy chủ từ chối giao dịch. Vui lòng kiểm tra lại giỏ hàng."
            };
        }

        private void FormPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnCheckout.PerformClick();
            }
        }
    }

    public class LookupPageDto<T>
    {
        public List<T> Items { get; set; } = new();
    }
}
