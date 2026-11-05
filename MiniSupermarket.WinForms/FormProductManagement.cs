/*
 * Họ tên sinh viên: Đặng Văn Minh Phúc
 * Mã sinh viên: 2124110256
 * Lớp học phần: CCQ2411D
 * Mô tả: Code-behind xử lý hiển thị danh sách phân trang LINQ, lọc nhóm hàng, tìm kiếm và CRUD sản phẩm kết nối Web API
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSupermarket.WinForms.Services;

namespace MiniSupermarket.WinForms
{
    // Lớp nhận dữ liệu DTO từ API về Client
    public class ProductItemViewDto
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }

    public class CategoryComboDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }

    public class PagedViewResult<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public List<T> Items { get; set; } = new();
    }

    public partial class FormProductManagement : Form
    {
        private int _currentPage = 1;
        private readonly int _pageSize = 5;
        private int _totalPages = 1;
        private bool _isLoaded = false;

        public FormProductManagement()
        {
            InitializeComponent();
            SetupProductsGrid();
        }

        private void SetupProductsGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductId",
                HeaderText = "Mã SP",
                Width = 70
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Barcode",
                HeaderText = "Mã Vạch",
                Width = 130
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Tên Sản Phẩm",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            var colPrice = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Đơn Giá (đ)",
                Width = 115
            };
            colPrice.DefaultCellStyle.Format = "N0";
            colPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns.Add(colPrice);

            var colStock = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockQuantity",
                HeaderText = "Tồn Kho",
                Width = 85
            };
            colStock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns.Add(colStock);
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryName",
                HeaderText = "Nhóm Hàng",
                Width = 160
            });
        }

        private async void FormProductManagement_Load(object sender, EventArgs e)
        {
            await LoadCategoriesComboAsync(); // Nạp nhóm hàng vào ComboBox
            await LoadProductsPagedAsync();   // Nạp bảng sản phẩm phân trang
            _isLoaded = true;
        }

        // 1. Tải danh sách nhóm hàng lên ComboBox (chi tiết & lọc)
        private async Task LoadCategoriesComboAsync()
        {
            try
            {
                var categories = await ApiClientService.Client
                    .GetFromJsonAsync<List<CategoryComboDto>>("categories");

                if (categories != null)
                {
                    // ComboBox chi tiết trong thông tin sản phẩm
                    cboCategory.DataSource = new List<CategoryComboDto>(categories);
                    cboCategory.DisplayMember = "CategoryName";
                    cboCategory.ValueMember = "CategoryId";

                    // ComboBox bộ lọc nhóm hàng trên thanh tìm kiếm
                    var filterList = new List<CategoryComboDto>
                    {
                        new CategoryComboDto { CategoryId = 0, CategoryName = "-- Tất cả nhóm hàng --" }
                    };
                    filterList.AddRange(categories);
                    cboFilterCategory.DataSource = filterList;
                    cboFilterCategory.DisplayMember = "CategoryName";
                    cboFilterCategory.ValueMember = "CategoryId";
                    cboFilterCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Gọi API phân trang và hiển thị dữ liệu lên DataGridView
        private async Task LoadProductsPagedAsync()
        {
            try
            {
                string search = txtSearch.Text.Trim();
                int catId = (cboFilterCategory.SelectedValue != null && cboFilterCategory.SelectedValue is int cId) ? cId : 0;

                string url = $"products/paged?keyword={Uri.EscapeDataString(search)}&pageNumber={_currentPage}&pageSize={_pageSize}";
                if (catId > 0)
                {
                    url += $"&categoryId={catId}";
                }

                var result = await ApiClientService.Client.GetFromJsonAsync<PagedViewResult<ProductItemViewDto>>(url);
                if (result != null)
                {
                    _currentPage = result.CurrentPage;
                    _totalPages = result.TotalPages == 0 ? 1 : result.TotalPages;

                    // Hiển thị dữ liệu lên bảng
                    dgvProducts.DataSource = result.Items;

                    // Cập nhật nhãn phân trang
                    lblPaging.Text = $"Trang {_currentPage} / {_totalPages} (Tổng: {result.TotalItems} SP)";

                    // Bật/tắt nút điều hướng
                    btnPrev.Enabled = _currentPage > 1;
                    btnNext.Enabled = _currentPage < _totalPages;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu sản phẩm: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Sự kiện chuyển trang
        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadProductsPagedAsync();
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                await LoadProductsPagedAsync();
            }
        }

        // 4. Sự kiện tìm kiếm & lọc
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            _currentPage = 1; // Khi tìm kiếm từ khóa mới, luôn quay về trang 1
            await LoadProductsPagedAsync();
        }

        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _currentPage = 1;
                await LoadProductsPagedAsync();
            }
        }

        private async void cboFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                _currentPage = 1;
                await LoadProductsPagedAsync();
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cboFilterCategory.Items.Count > 0)
            {
                cboFilterCategory.SelectedIndex = 0;
            }
            ClearInputs();
            _currentPage = 1;
            await LoadProductsPagedAsync();
        }

        // 5. Chọn dòng hiển thị lên Form chi tiết
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].DataBoundItem is ProductItemViewDto prod)
            {
                txtId.Text = prod.ProductId.ToString();
                txtBarcode.Text = prod.Barcode;
                txtProductName.Text = prod.ProductName;
                nudPrice.Value = prod.Price;
                nudStock.Value = prod.StockQuantity;
                if (prod.CategoryId > 0)
                {
                    cboCategory.SelectedValue = prod.CategoryId;
                }

            }
        }

        private void dgvProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.CellStyle == null ||
                dgvProducts.Columns[e.ColumnIndex].DataPropertyName != "StockQuantity" ||
                e.Value == null ||
                !int.TryParse(e.Value.ToString(), out int stockQuantity) ||
                stockQuantity > 10)
            {
                return;
            }

            e.CellStyle.BackColor = stockQuantity <= 0
                ? Color.LightCoral
                : Color.FromArgb(255, 218, 185);
            e.CellStyle.ForeColor = Color.FromArgb(130, 35, 25);
            e.CellStyle.Font = new Font(dgvProducts.Font, FontStyle.Bold);
        }

        private async void btnExportCsv_Click(object? sender, EventArgs e)
        {
            try
            {
                var products = await ApiClientService.Client.GetFromJsonAsync<List<ProductItemViewDto>>("products");
                if (products == null || products.Count == 0)
                {
                    MessageBox.Show("Danh mục hiện chưa có sản phẩm để xuất.", "Chưa có dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using var dialog = new SaveFileDialog
                {
                    AddExtension = true,
                    DefaultExt = "csv",
                    FileName = $"danh-muc-san-pham-{DateTime.Today:yyyyMMdd}.csv",
                    Filter = "Tệp CSV (*.csv)|*.csv"
                };
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                var lines = new List<string>
                {
                    "Mã sản phẩm,Mã vạch,Tên sản phẩm,Đơn giá (VNĐ),Tồn kho,Nhóm hàng"
                };
                lines.AddRange(products.Select(product => string.Join(",",
                    product.ProductId.ToString(CultureInfo.InvariantCulture),
                    EscapeCsv(product.Barcode),
                    EscapeCsv(product.ProductName),
                    product.Price.ToString(CultureInfo.InvariantCulture),
                    product.StockQuantity.ToString(CultureInfo.InvariantCulture),
                    EscapeCsv(product.CategoryName))));

                await File.WriteAllLinesAsync(dialog.FileName, lines, new UTF8Encoding(true));
                MessageBox.Show("Đã xuất danh mục sản phẩm và số lượng tồn kho ra tệp CSV.", "Xuất danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xuất danh mục sản phẩm: " + ex.Message, "Lỗi xuất tệp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string value) =>
            "\"" + value.Replace("\"", "\"\"") + "\"";

        // 6. Thêm mới sản phẩm qua API
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text) || string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã vạch và tên sản phẩm!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm hàng cho sản phẩm!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newProd = new
            {
                Barcode = txtBarcode.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Price = nudPrice.Value,
                StockQuantity = (int)nudStock.Value,
                CategoryId = Convert.ToInt32(cboCategory.SelectedValue)
            };

            try
            {
                var res = await ApiClientService.Client.PostAsJsonAsync("products", newProd);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadProductsPagedAsync();
                    ClearInputs();
                }
                else
                {
                    var err = await res.Content.ReadAsStringAsync();
                    MessageBox.Show("Thêm thất bại. " + err, "Cảnh báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối máy chủ: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 7. Cập nhật sản phẩm qua API
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa từ danh sách!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = int.Parse(txtId.Text);
            var updateProd = new
            {
                ProductId = id,
                Barcode = txtBarcode.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Price = nudPrice.Value,
                StockQuantity = (int)nudStock.Value,
                CategoryId = Convert.ToInt32(cboCategory.SelectedValue)
            };

            try
            {
                var res = await ApiClientService.Client.PutAsJsonAsync($"products/{id}", updateProd);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadProductsPagedAsync();
                }
                else
                {
                    var err = await res.Content.ReadAsStringAsync();
                    MessageBox.Show("Cập nhật thất bại: " + err, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối máy chủ: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 8. Xóa sản phẩm qua API
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null && string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ danh sách!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = !string.IsNullOrEmpty(txtId.Text) 
                ? int.Parse(txtId.Text) 
                : Convert.ToInt32(dgvProducts.CurrentRow?.Cells["ProductId"]?.Value ?? 0);

            if (id <= 0) return;

            string name = txtProductName.Text;
            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm #{id} ({name})?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var res = await ApiClientService.Client.DeleteAsync($"products/{id}");
                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadProductsPagedAsync();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Mã lỗi: " + res.StatusCode, "Cảnh báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối máy chủ: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtBarcode.Clear();
            txtProductName.Clear();
            nudPrice.Value = 0;
            nudStock.Value = 0;
            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }
    }
}
