using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net.Http.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSupermarket.WinForms.Services;

namespace MiniSupermarket.WinForms
{
    public partial class FormQuickReport : Form
    {
        private readonly Panel _chartCanvas;
        private readonly Label _chartSubtitle;
        private readonly DateTimePicker _fromDatePicker;
        private readonly DateTimePicker _toDatePicker;
        private readonly DataGridView _topSellersGrid;
        private List<DailyRevenueViewDto> _dailyRevenue = new();
        private List<TopSellingProductViewDto> _topSellers = new();

        public FormQuickReport()
        {
            InitializeComponent();

            lblOrdersTitle.Text = "HÓA ĐƠN HÔM NAY";
            lblRevenueTitle.Text = "DOANH THU HÔM NAY";
            lblBestSellerTitle.Text = "KHÁCH MỚI HÔM NAY";
            lblAverageTitle.Text = "MẶT HÀNG SẮP HẾT";
            btnExport.Text = "📥 Xuất CSV";

            _fromDatePicker = CreateDatePicker(DateTime.Today.AddDays(-6));
            _toDatePicker = CreateDatePicker(DateTime.Today);
            panelControlBar.Controls.Clear();
            panelControlBar.Controls.Add(CreateControlLabel("Từ ngày:", new Point(15, 22)));
            _fromDatePicker.Location = new Point(80, 19);
            panelControlBar.Controls.Add(_fromDatePicker);
            panelControlBar.Controls.Add(CreateControlLabel("Đến ngày:", new Point(260, 22)));
            _toDatePicker.Location = new Point(330, 19);
            panelControlBar.Controls.Add(_toDatePicker);
            btnRunReport.Location = new Point(505, 16);
            btnRunReport.Size = new Size(140, 32);
            btnRunReport.Text = "📊 Xem báo cáo";
            btnExport.Location = new Point(655, 16);
            btnExport.Size = new Size(120, 32);
            panelControlBar.Controls.Add(btnRunReport);
            panelControlBar.Controls.Add(btnExport);

            var dashboard = new TableLayoutPanel
            {
                BackColor = Color.FromArgb(244, 246, 249),
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Padding = new Padding(2),
                RowCount = 2
            };
            dashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 72F));
            dashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));

            var chartCard = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Margin = new Padding(3, 3, 3, 8),
                Padding = new Padding(0)
            };
            var chartHeader = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Height = 54,
                Padding = new Padding(18, 8, 18, 4)
            };
            var chartTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(29, 42, 62),
                Location = new Point(15, 7),
                Text = "DOANH THU THEO NGÀY"
            };
            _chartSubtitle = new Label
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(112, 124, 142),
                Location = new Point(400, 10),
                Size = new Size(560, 20),
                Text = "Chọn khoảng ngày để xem xu hướng doanh thu",
                TextAlign = ContentAlignment.MiddleRight
            };
            _chartCanvas = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(12, 0, 12, 8)
            };
            _chartCanvas.Paint += ChartCanvas_Paint;
            chartHeader.Controls.Add(chartTitle);
            chartHeader.Controls.Add(_chartSubtitle);
            chartCard.Controls.Add(_chartCanvas);
            chartCard.Controls.Add(chartHeader);

            var chartRow = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                RowCount = 1,
                BackColor = Color.FromArgb(244, 246, 249)
            };
            chartRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72F));
            chartRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            chartRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chartRow.Controls.Add(chartCard, 0, 0);

            var topSellersCard = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Margin = new Padding(3, 3, 3, 8)
            };
            var topSellersTitle = new Label
            {
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(29, 42, 62),
                Height = 48,
                Padding = new Padding(12, 14, 8, 8),
                Text = "TOP 5 SẢN PHẨM BÁN CHẠY"
            };
            _topSellersGrid = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            _topSellersGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TopSellingProductViewDto.ProductName),
                HeaderText = "Sản phẩm",
                FillWeight = 55
            });
            _topSellersGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TopSellingProductViewDto.TotalQuantitySold),
                HeaderText = "SL",
                FillWeight = 18
            });
            var salesColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(TopSellingProductViewDto.TotalSalesAmount),
                HeaderText = "Doanh thu",
                FillWeight = 35
            };
            salesColumn.DefaultCellStyle.Format = "N0";
            _topSellersGrid.Columns.Add(salesColumn);
            topSellersCard.Controls.Add(_topSellersGrid);
            topSellersCard.Controls.Add(topSellersTitle);
            chartRow.Controls.Add(topSellersCard, 1, 0);

            panelContent.Controls.Clear();
            groupNotes.Dock = DockStyle.Fill;
            dashboard.Controls.Add(chartRow, 0, 0);
            dashboard.Controls.Add(groupNotes, 0, 1);
            panelContent.Controls.Add(dashboard);
        }

        private static DateTimePicker CreateDatePicker(DateTime value) => new()
        {
            CustomFormat = "dd/MM/yyyy",
            Format = DateTimePickerFormat.Custom,
            Font = new Font("Segoe UI", 9.5F),
            Size = new Size(150, 25),
            Value = value
        };

        private static Label CreateControlLabel(string text, Point location) => new()
        {
            AutoSize = true,
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
            ForeColor = Color.FromArgb(24, 30, 48),
            Location = location,
            Text = text
        };

        private async void FormQuickReport_Load(object sender, EventArgs e)
        {
            // Kiểm tra phân quyền cấp Action
            if (!IsAdministrativeRole())
            {
                MessageBox.Show("Bạn không có quyền xem dữ liệu tài chính của siêu thị!", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            await LoadDashboardAsync();
        }

        private async void btnRunReport_Click(object sender, EventArgs e)
        {
            // Kiểm tra phân quyền bảo vệ lần 2
            if (!IsAdministrativeRole())
            {
                MessageBox.Show("Bạn không có quyền xem dữ liệu tài chính của siêu thị!", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            await LoadDashboardAsync();
        }

        private static bool IsAdministrativeRole() =>
            SessionManager.CurrentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
            SessionManager.CurrentRole.Equals("Manager", StringComparison.OrdinalIgnoreCase);

        private async Task LoadDashboardAsync()
        {
            try
            {
                btnRunReport.Enabled = false;
                btnRunReport.Text = "Đang tải dữ liệu...";

                DateTime fromDate = _fromDatePicker.Value.Date;
                DateTime toDate = _toDatePicker.Value.Date;
                if (fromDate > toDate)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Khoảng ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var summary = await ApiClientService.Client.GetFromJsonAsync<DashboardSummaryViewDto>("reports/dashboard-summary");
                if (summary == null) throw new InvalidOperationException("Máy chủ không trả về số liệu tổng quan.");
                lblTotalRevenue.Text = $"{summary.TodayRevenue:N0} đ";
                lblTotalOrders.Text = $"{summary.TodayOrders:N0} đơn";
                lblBestSeller.Text = summary.NewCustomersToday.ToString("N0");
                lblAverageOrder.Text = summary.LowStockProducts.ToString("N0");

                string from = Uri.EscapeDataString(fromDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                string to = Uri.EscapeDataString(toDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                _dailyRevenue = await ApiClientService.Client.GetFromJsonAsync<List<DailyRevenueViewDto>>(
                    $"reports/revenue-by-day?fromDate={from}&toDate={to}") ?? new List<DailyRevenueViewDto>();

                var sellersResponse = await ApiClientService.Client.GetFromJsonAsync<TopSellingProductsResponseDto>("reports/top-selling-products?top=5");
                _topSellers = sellersResponse?.Data ?? new List<TopSellingProductViewDto>();
                _topSellersGrid.DataSource = _topSellers;

                var peakDay = _dailyRevenue.OrderByDescending(item => item.Revenue).FirstOrDefault();
                decimal rangeRevenue = _dailyRevenue.Sum(item => item.Revenue);
                _chartSubtitle.Text = peakDay != null && peakDay.Revenue > 0
                    ? $"Tổng {rangeRevenue:N0} đ  •  Cao điểm {peakDay.Date:dd/MM} ({peakDay.Revenue:N0} đ)"
                    : $"Tổng {rangeRevenue:N0} đ  •  Chưa phát sinh doanh thu";
                _chartCanvas.Invalidate();
                lblNotes.Text = $"Tổng quan hôm nay: {summary.TodayOrders:N0} hóa đơn, doanh thu {summary.TodayRevenue:N0} đ, " +
                                $"{summary.NewCustomersToday:N0} khách mới và {summary.LowStockProducts:N0} mặt hàng tồn kho thấp (≤ 10).\n" +
                                $"Khoảng báo cáo: {fromDate:dd/MM/yyyy} – {toDate:dd/MM/yyyy} | " +
                                $"Top bán chạy: {(_topSellers.FirstOrDefault()?.ProductName ?? "Chưa có dữ liệu")}.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRunReport.Enabled = true;
                btnRunReport.Text = "📊 Xem báo cáo";
            }
        }

        private void ChartCanvas_Paint(object? sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float left = 78;
            float right = 22;
            float top = 14;
            float bottom = 30;
            float plotWidth = Math.Max(1, _chartCanvas.ClientSize.Width - left - right);
            float plotHeight = Math.Max(1, _chartCanvas.ClientSize.Height - top - bottom);
            float baseline = top + plotHeight;
            decimal maxRevenue = _dailyRevenue.Count == 0 ? 0 : _dailyRevenue.Max(item => item.Revenue);
            decimal scaleMaximum = maxRevenue > 0 ? maxRevenue * 1.15m : 1m;

            using var gridPen = new Pen(Color.FromArgb(231, 236, 243), 1);
            using var axisFont = new Font("Segoe UI", 8F);
            using var axisBrush = new SolidBrush(Color.FromArgb(112, 124, 142));
            using var baselinePen = new Pen(Color.FromArgb(194, 204, 216), 1.2F);
            float slotWidth = plotWidth / Math.Max(1, _dailyRevenue.Count);

            for (int tick = 0; tick <= 4; tick++)
            {
                float y = top + plotHeight * tick / 4F;
                graphics.DrawLine(gridPen, left, y, left + plotWidth, y);
                decimal tickValue = scaleMaximum * (4 - tick) / 4m;
                string label = FormatAxisRevenue(tickValue);
                var labelSize = graphics.MeasureString(label, axisFont);
                graphics.DrawString(label, axisFont, axisBrush, left - labelSize.Width - 9, y - labelSize.Height / 2);
            }

            graphics.DrawLine(baselinePen, left, baseline, left + plotWidth, baseline);

            if (maxRevenue <= 0 || _dailyRevenue.Count == 0)
            {
                using var emptyFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                using var emptyBrush = new SolidBrush(Color.FromArgb(132, 144, 160));
                const string emptyMessage = "Chưa có doanh thu trong khoảng ngày được chọn";
                var emptySize = graphics.MeasureString(emptyMessage, emptyFont);
                graphics.DrawString(
                    emptyMessage,
                    emptyFont,
                    emptyBrush,
                    left + (plotWidth - emptySize.Width) / 2,
                    top + (plotHeight - emptySize.Height) / 2);
            }
            else
            {
                float barWidth = Math.Min(42F, slotWidth * 0.62F);
                var peak = _dailyRevenue.OrderByDescending(item => item.Revenue).First();

                for (int index = 0; index < _dailyRevenue.Count; index++)
                {
                    var item = _dailyRevenue[index];
                    if (item.Revenue <= 0) continue;

                    float barHeight = Math.Max(3F, (float)(item.Revenue / scaleMaximum) * plotHeight);
                    float x = left + index * slotWidth + (slotWidth - barWidth) / 2;
                    var barBounds = new RectangleF(x, baseline - barHeight, barWidth, barHeight);
                    Color startColor = item.Date.Date == peak.Date.Date
                        ? Color.FromArgb(45, 154, 111)
                        : Color.FromArgb(77, 151, 221);
                    Color endColor = item.Date.Date == peak.Date.Date
                        ? Color.FromArgb(31, 184, 130)
                        : Color.FromArgb(74, 190, 190);

                    using var barPath = CreateRoundedRectangle(barBounds, Math.Min(6F, barWidth / 3F));
                    using var barBrush = new LinearGradientBrush(barBounds, startColor, endColor, LinearGradientMode.Vertical);
                    graphics.FillPath(barBrush, barPath);
                }
            }

            int labelStep = Math.Max(1, (int)Math.Ceiling(_dailyRevenue.Count / 10d));
            for (int index = 0; index < _dailyRevenue.Count; index += labelStep)
            {
                string label = _dailyRevenue[index].Date.ToString("dd/MM", CultureInfo.InvariantCulture);
                float x = left + index * slotWidth + (slotWidth - graphics.MeasureString(label, axisFont).Width) / 2;
                graphics.DrawString(label, axisFont, axisBrush, x, baseline + 7);
            }
        }

        private static GraphicsPath CreateRoundedRectangle(RectangleF bounds, float radius)
        {
            var path = new GraphicsPath();
            radius = Math.Min(radius, bounds.Height / 2F);
            float diameter = radius * 2;
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddLine(bounds.Right, bounds.Top + radius, bounds.Right, bounds.Bottom);
            path.AddLine(bounds.Right, bounds.Bottom, bounds.Left, bounds.Bottom);
            path.AddLine(bounds.Left, bounds.Bottom, bounds.Left, bounds.Top + radius);
            path.CloseFigure();
            return path;
        }

        private static string FormatAxisRevenue(decimal amount)
        {
            if (amount >= 1_000_000_000m) return $"{amount / 1_000_000_000m:0.#} tỷ";
            if (amount >= 1_000_000m) return $"{amount / 1_000_000m:0.#} tr";
            if (amount >= 1_000m) return $"{amount / 1_000m:0.#}k";
            return $"{amount:N0}";
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (_dailyRevenue.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu doanh thu để xuất.", "Chưa có dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "csv",
                FileName = $"doanh-thu-{_fromDatePicker.Value:yyyyMMdd}-{_toDatePicker.Value:yyyyMMdd}.csv",
                Filter = "Tệp CSV (*.csv)|*.csv"
            };
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                var lines = new List<string> { "Ngày,Doanh thu (VNĐ),Số hóa đơn" };
                lines.AddRange(_dailyRevenue.Select(item =>
                    $"{item.Date:yyyy-MM-dd},{item.Revenue.ToString(CultureInfo.InvariantCulture)},{item.Orders}"));
                await File.WriteAllLinesAsync(dialog.FileName, lines, new UTF8Encoding(true));
                MessageBox.Show("Đã xuất báo cáo doanh thu ra tệp CSV.", "Xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi tệp CSV: " + ex.Message, "Lỗi xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class DashboardSummaryViewDto
    {
        public decimal TodayRevenue { get; set; }
        public int TodayOrders { get; set; }
        public int NewCustomersToday { get; set; }
        public int LowStockProducts { get; set; }
    }

    public class DailyRevenueViewDto
    {
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }
        public int Orders { get; set; }
    }

    public class TopSellingProductViewDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int TotalQuantitySold { get; set; }
        public decimal TotalSalesAmount { get; set; }
    }

    public class TopSellingProductsResponseDto
    {
        public List<TopSellingProductViewDto> Data { get; set; } = new();
    }
}
