namespace MiniSupermarket.WinForms
{
    partial class FormQuickReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelControlBar = new Panel();
            btnExport = new Button();
            btnRunReport = new Button();
            dtpReportDate = new DateTimePicker();
            lblSelectDate = new Label();
            panelCards = new TableLayoutPanel();
            cardOrders = new Panel();
            lblTotalOrders = new Label();
            lblOrdersTitle = new Label();
            cardRevenue = new Panel();
            lblTotalRevenue = new Label();
            lblRevenueTitle = new Label();
            cardBestSeller = new Panel();
            lblBestSeller = new Label();
            lblBestSellerTitle = new Label();
            cardAverage = new Panel();
            lblAverageOrder = new Label();
            lblAverageTitle = new Label();
            panelContent = new Panel();
            groupNotes = new GroupBox();
            lblNotes = new Label();
            panelControlBar.SuspendLayout();
            panelCards.SuspendLayout();
            cardOrders.SuspendLayout();
            cardRevenue.SuspendLayout();
            cardBestSeller.SuspendLayout();
            cardAverage.SuspendLayout();
            panelContent.SuspendLayout();
            groupNotes.SuspendLayout();
            SuspendLayout();
            // 
            // panelControlBar
            // 
            panelControlBar.BackColor = Color.White;
            panelControlBar.BorderStyle = BorderStyle.FixedSingle;
            panelControlBar.Controls.Add(btnExport);
            panelControlBar.Controls.Add(btnRunReport);
            panelControlBar.Controls.Add(dtpReportDate);
            panelControlBar.Controls.Add(lblSelectDate);
            panelControlBar.Dock = DockStyle.Top;
            panelControlBar.Location = new Point(0, 0);
            panelControlBar.Name = "panelControlBar";
            panelControlBar.Padding = new Padding(15, 12, 15, 12);
            panelControlBar.Size = new Size(1040, 65);
            panelControlBar.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(108, 117, 125);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(480, 16);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(130, 32);
            btnExport.TabIndex = 3;
            btnExport.Text = "🖨 In báo cáo ca";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnRunReport
            // 
            btnRunReport.BackColor = Color.FromArgb(41, 100, 180);
            btnRunReport.Cursor = Cursors.Hand;
            btnRunReport.FlatAppearance.BorderSize = 0;
            btnRunReport.FlatStyle = FlatStyle.Flat;
            btnRunReport.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnRunReport.ForeColor = Color.White;
            btnRunReport.Location = new Point(320, 16);
            btnRunReport.Name = "btnRunReport";
            btnRunReport.Size = new Size(150, 32);
            btnRunReport.TabIndex = 2;
            btnRunReport.Text = "📊 Xem doanh thu ca";
            btnRunReport.UseVisualStyleBackColor = false;
            btnRunReport.Click += btnRunReport_Click;
            // 
            // dtpReportDate
            // 
            dtpReportDate.CustomFormat = "dd/MM/yyyy";
            dtpReportDate.Font = new Font("Segoe UI", 10F);
            dtpReportDate.Format = DateTimePickerFormat.Custom;
            dtpReportDate.Location = new Point(145, 19);
            dtpReportDate.Name = "dtpReportDate";
            dtpReportDate.Size = new Size(160, 25);
            dtpReportDate.TabIndex = 1;
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSelectDate.ForeColor = Color.FromArgb(24, 30, 48);
            lblSelectDate.Location = new Point(15, 22);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(124, 19);
            lblSelectDate.TabIndex = 0;
            lblSelectDate.Text = "Chọn ngày báo cáo:";
            // 
            // panelCards
            // 
            panelCards.ColumnCount = 4;
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.Controls.Add(cardOrders, 0, 0);
            panelCards.Controls.Add(cardRevenue, 1, 0);
            panelCards.Controls.Add(cardBestSeller, 2, 0);
            panelCards.Controls.Add(cardAverage, 3, 0);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 65);
            panelCards.Name = "panelCards";
            panelCards.Padding = new Padding(15);
            panelCards.RowCount = 1;
            panelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCards.Size = new Size(1040, 145);
            panelCards.TabIndex = 1;
            // 
            // cardOrders
            // 
            cardOrders.BackColor = Color.FromArgb(231, 241, 255);
            cardOrders.BorderStyle = BorderStyle.FixedSingle;
            cardOrders.Controls.Add(lblTotalOrders);
            cardOrders.Controls.Add(lblOrdersTitle);
            cardOrders.Dock = DockStyle.Fill;
            cardOrders.Location = new Point(18, 18);
            cardOrders.Margin = new Padding(3, 3, 10, 3);
            cardOrders.Name = "cardOrders";
            cardOrders.Padding = new Padding(15);
            cardOrders.Size = new Size(324, 144);
            cardOrders.TabIndex = 0;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.Dock = DockStyle.Fill;
            lblTotalOrders.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTotalOrders.ForeColor = Color.FromArgb(35, 91, 165);
            lblTotalOrders.Location = new Point(15, 45);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(292, 82);
            lblTotalOrders.TabIndex = 1;
            lblTotalOrders.Text = "0 đơn";
            lblTotalOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.Dock = DockStyle.Top;
            lblOrdersTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblOrdersTitle.ForeColor = Color.FromArgb(70, 95, 130);
            lblOrdersTitle.Location = new Point(15, 15);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(292, 30);
            lblOrdersTitle.TabIndex = 0;
            lblOrdersTitle.Text = "TỔNG HÓA ĐƠN";
            lblOrdersTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.FromArgb(230, 247, 237);
            cardRevenue.BorderStyle = BorderStyle.FixedSingle;
            cardRevenue.Controls.Add(lblTotalRevenue);
            cardRevenue.Controls.Add(lblRevenueTitle);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(362, 18);
            cardRevenue.Margin = new Padding(10, 3, 10, 3);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(15);
            cardRevenue.Size = new Size(316, 144);
            cardRevenue.TabIndex = 1;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Dock = DockStyle.Fill;
            lblTotalRevenue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.FromArgb(31, 130, 77);
            lblTotalRevenue.Location = new Point(15, 45);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(284, 82);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "0 đ";
            lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.Dock = DockStyle.Top;
            lblRevenueTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.FromArgb(70, 110, 85);
            lblRevenueTitle.Location = new Point(15, 15);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(284, 30);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "TỔNG DOANH THU";
            lblRevenueTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardBestSeller
            // 
            cardBestSeller.BackColor = Color.FromArgb(255, 243, 224);
            cardBestSeller.BorderStyle = BorderStyle.FixedSingle;
            cardBestSeller.Controls.Add(lblBestSeller);
            cardBestSeller.Controls.Add(lblBestSellerTitle);
            cardBestSeller.Dock = DockStyle.Fill;
            cardBestSeller.Location = new Point(698, 18);
            cardBestSeller.Margin = new Padding(10, 3, 3, 3);
            cardBestSeller.Name = "cardBestSeller";
            cardBestSeller.Padding = new Padding(15);
            cardBestSeller.Size = new Size(327, 144);
            cardBestSeller.TabIndex = 2;
            // 
            // lblBestSeller
            // 
            lblBestSeller.Dock = DockStyle.Fill;
            lblBestSeller.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblBestSeller.ForeColor = Color.FromArgb(173, 103, 0);
            lblBestSeller.Location = new Point(15, 45);
            lblBestSeller.Name = "lblBestSeller";
            lblBestSeller.Size = new Size(295, 82);
            lblBestSeller.TabIndex = 1;
            lblBestSeller.Text = "Chưa có dữ liệu";
            lblBestSeller.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBestSellerTitle
            // 
            lblBestSellerTitle.Dock = DockStyle.Top;
            lblBestSellerTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblBestSellerTitle.ForeColor = Color.FromArgb(130, 100, 65);
            lblBestSellerTitle.Location = new Point(15, 15);
            lblBestSellerTitle.Name = "lblBestSellerTitle";
            lblBestSellerTitle.Size = new Size(295, 30);
            lblBestSellerTitle.TabIndex = 0;
            lblBestSellerTitle.Text = "BÁN CHẠY NHẤT";
            lblBestSellerTitle.TextAlign = ContentAlignment.MiddleCenter;
            //
            // cardAverage
            //
            cardAverage.BackColor = Color.FromArgb(241, 236, 255);
            cardAverage.BorderStyle = BorderStyle.FixedSingle;
            cardAverage.Controls.Add(lblAverageOrder);
            cardAverage.Controls.Add(lblAverageTitle);
            cardAverage.Dock = DockStyle.Fill;
            cardAverage.Margin = new Padding(10, 3, 3, 3);
            cardAverage.Name = "cardAverage";
            cardAverage.Padding = new Padding(12);
            cardAverage.TabIndex = 3;
            //
            // lblAverageOrder
            //
            lblAverageOrder.Dock = DockStyle.Fill;
            lblAverageOrder.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblAverageOrder.ForeColor = Color.FromArgb(105, 75, 170);
            lblAverageOrder.Location = new Point(12, 45);
            lblAverageOrder.Name = "lblAverageOrder";
            lblAverageOrder.Size = new Size(200, 82);
            lblAverageOrder.TabIndex = 1;
            lblAverageOrder.Text = "0 đ";
            lblAverageOrder.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblAverageTitle
            //
            lblAverageTitle.Dock = DockStyle.Top;
            lblAverageTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAverageTitle.ForeColor = Color.FromArgb(95, 85, 120);
            lblAverageTitle.Location = new Point(12, 12);
            lblAverageTitle.Name = "lblAverageTitle";
            lblAverageTitle.Size = new Size(200, 30);
            lblAverageTitle.TabIndex = 0;
            lblAverageTitle.Text = "TRUNG BÌNH / HÓA ĐƠN";
            lblAverageTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(groupNotes);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 210);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(15);
            panelContent.Size = new Size(1040, 450);
            panelContent.TabIndex = 2;
            // 
            // groupNotes
            // 
            groupNotes.BackColor = Color.White;
            groupNotes.Controls.Add(lblNotes);
            groupNotes.Dock = DockStyle.Fill;
            groupNotes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupNotes.Location = new Point(15, 15);
            groupNotes.Name = "groupNotes";
            groupNotes.Padding = new Padding(15);
            groupNotes.Size = new Size(1010, 100);
            groupNotes.TabIndex = 0;
            groupNotes.TabStop = false;
            groupNotes.Text = "📌 Thông tin & Phân tích hiệu suất ca bán";
            // 
            // lblNotes
            // 
            lblNotes.Dock = DockStyle.Fill;
            lblNotes.Font = new Font("Segoe UI", 9F);
            lblNotes.ForeColor = Color.FromArgb(50, 60, 75);
            lblNotes.Location = new Point(15, 33);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(980, 337);
            lblNotes.TabIndex = 0;
            lblNotes.Text = "Chọn ngày báo cáo để xem số liệu bán hàng.";
            // 
            // FormQuickReport
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1040, 660);
            Controls.Add(panelContent);
            Controls.Add(panelCards);
            Controls.Add(panelControlBar);
            Font = new Font("Segoe UI", 9.75F);
            Name = "FormQuickReport";
            Text = "FormQuickReport";
            Load += FormQuickReport_Load;
            panelControlBar.ResumeLayout(false);
            panelControlBar.PerformLayout();
            panelCards.ResumeLayout(false);
            cardOrders.ResumeLayout(false);
            cardRevenue.ResumeLayout(false);
            cardBestSeller.ResumeLayout(false);
            cardAverage.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            groupNotes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControlBar;
        private Label lblSelectDate;
        private DateTimePicker dtpReportDate;
        private Button btnRunReport;
        private Button btnExport;
        private TableLayoutPanel panelCards;
        private Panel cardOrders;
        private Label lblOrdersTitle;
        private Label lblTotalOrders;
        private Panel cardRevenue;
        private Label lblRevenueTitle;
        private Label lblTotalRevenue;
        private Panel cardBestSeller;
        private Label lblBestSellerTitle;
        private Label lblBestSeller;
        private Panel cardAverage;
        private Label lblAverageTitle;
        private Label lblAverageOrder;
        private Panel panelContent;
        private GroupBox groupNotes;
        private Label lblNotes;
    }
}
