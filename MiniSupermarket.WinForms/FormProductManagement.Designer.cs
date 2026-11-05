namespace MiniSupermarket.WinForms
{
    partial class FormProductManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelSearch = new Panel();
            btnRefresh = new Button();
            btnExportCsv = new Button();
            btnSearch = new Button();
            cboFilterCategory = new ComboBox();
            lblFilterCategory = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            panelGrid = new Panel();
            dgvProducts = new DataGridView();
            panelPagination = new Panel();
            btnPrev = new Button();
            lblPaging = new Label();
            btnNext = new Button();
            panelDetails = new Panel();
            groupActions = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupProductDetails = new GroupBox();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            nudStock = new NumericUpDown();
            lblStock = new Label();
            nudPrice = new NumericUpDown();
            lblPrice = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtBarcode = new TextBox();
            lblBarcode = new Label();
            txtId = new TextBox();
            lblId = new Label();
            panelSearch.SuspendLayout();
            panelGrid.SuspendLayout();
            panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelDetails.SuspendLayout();
            groupActions.SuspendLayout();
            groupProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(btnRefresh);
            panelSearch.Controls.Add(btnExportCsv);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(cboFilterCategory);
            panelSearch.Controls.Add(lblFilterCategory);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(12);
            panelSearch.Size = new Size(1040, 60);
            panelSearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(810, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 30);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "🔄 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.FromArgb(40, 130, 80);
            btnExportCsv.Cursor = Cursors.Hand;
            btnExportCsv.FlatAppearance.BorderSize = 0;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExportCsv.ForeColor = Color.White;
            btnExportCsv.Location = new Point(915, 14);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(105, 30);
            btnExportCsv.TabIndex = 6;
            btnExportCsv.Text = "📥 Xuất CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 100, 180);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(715, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "🔍 Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboFilterCategory
            // 
            cboFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCategory.Font = new Font("Segoe UI", 9.5F);
            cboFilterCategory.FormattingEnabled = true;
            cboFilterCategory.Location = new Point(480, 17);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(220, 24);
            cboFilterCategory.TabIndex = 3;
            cboFilterCategory.SelectedIndexChanged += cboFilterCategory_SelectedIndexChanged;
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblFilterCategory.ForeColor = Color.FromArgb(70, 80, 95);
            lblFilterCategory.Location = new Point(395, 20);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(82, 17);
            lblFilterCategory.TabIndex = 2;
            lblFilterCategory.Text = "Nhóm hàng:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(140, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tên hoặc mã vạch...";
            txtSearch.Size = new Size(240, 24);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(70, 80, 95);
            lblSearch.Location = new Point(15, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(122, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm sản phẩm:";
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvProducts);
            panelGrid.Controls.Add(panelPagination);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 60);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(12);
            panelGrid.Size = new Size(700, 600);
            panelGrid.TabIndex = 1;
            // 
            // panelPagination
            // 
            panelPagination.BackColor = Color.White;
            panelPagination.BorderStyle = BorderStyle.FixedSingle;
            panelPagination.Controls.Add(lblPaging);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(btnPrev);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(12, 544);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(676, 44);
            panelPagination.TabIndex = 1;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(41, 100, 180);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(10, 6);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(130, 30);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "⏪ Trang trước";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblPaging
            // 
            lblPaging.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPaging.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblPaging.ForeColor = Color.FromArgb(40, 50, 70);
            lblPaging.Location = new Point(146, 6);
            lblPaging.Name = "lblPaging";
            lblPaging.Size = new Size(384, 30);
            lblPaging.TabIndex = 1;
            lblPaging.Text = "Trang 1 / 1 (Tổng: 0 SP)";
            lblPaging.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(41, 100, 180);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(536, 6);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(130, 30);
            btnNext.TabIndex = 2;
            btnNext.Text = "Trang sau ⏩";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 30, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(12, 12);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowTemplate.Height = 30;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(676, 576);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.White;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(groupActions);
            panelDetails.Controls.Add(groupProductDetails);
            panelDetails.Dock = DockStyle.Right;
            panelDetails.Location = new Point(700, 60);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new Padding(12);
            panelDetails.Size = new Size(340, 600);
            panelDetails.TabIndex = 2;
            // 
            // groupActions
            // 
            groupActions.Controls.Add(btnClear);
            groupActions.Controls.Add(btnDelete);
            groupActions.Controls.Add(btnUpdate);
            groupActions.Controls.Add(btnAdd);
            groupActions.Dock = DockStyle.Bottom;
            groupActions.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            groupActions.Location = new Point(12, 442);
            groupActions.Name = "groupActions";
            groupActions.Padding = new Padding(10);
            groupActions.Size = new Size(314, 144);
            groupActions.TabIndex = 1;
            groupActions.TabStop = false;
            groupActions.Text = "Hành động tác vụ";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(162, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "🔄 Làm mới ô nhập";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(10, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑  Xóa sản phẩm";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 152, 0);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(162, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 38);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "✏️ Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(10, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupProductDetails
            // 
            groupProductDetails.Controls.Add(cboCategory);
            groupProductDetails.Controls.Add(lblCategory);
            groupProductDetails.Controls.Add(nudStock);
            groupProductDetails.Controls.Add(lblStock);
            groupProductDetails.Controls.Add(nudPrice);
            groupProductDetails.Controls.Add(lblPrice);
            groupProductDetails.Controls.Add(txtProductName);
            groupProductDetails.Controls.Add(lblProductName);
            groupProductDetails.Controls.Add(txtBarcode);
            groupProductDetails.Controls.Add(lblBarcode);
            groupProductDetails.Controls.Add(txtId);
            groupProductDetails.Controls.Add(lblId);
            groupProductDetails.Dock = DockStyle.Top;
            groupProductDetails.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            groupProductDetails.Location = new Point(12, 12);
            groupProductDetails.Name = "groupProductDetails";
            groupProductDetails.Padding = new Padding(10);
            groupProductDetails.Size = new Size(314, 420);
            groupProductDetails.TabIndex = 0;
            groupProductDetails.TabStop = false;
            groupProductDetails.Text = "Thông tin chi tiết sản phẩm";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 9.5F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(12, 355);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(290, 24);
            cboCategory.TabIndex = 11;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F);
            lblCategory.ForeColor = Color.FromArgb(70, 80, 95);
            lblCategory.Location = new Point(12, 335);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(106, 15);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Nhóm hàng (Loại):";
            // 
            // nudStock
            // 
            nudStock.Font = new Font("Segoe UI", 9.5F);
            nudStock.Location = new Point(12, 295);
            nudStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(290, 24);
            nudStock.TabIndex = 9;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F);
            lblStock.ForeColor = Color.FromArgb(70, 80, 95);
            lblStock.Location = new Point(12, 275);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(99, 15);
            lblStock.TabIndex = 8;
            lblStock.Text = "Số lượng tồn kho:";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 0;
            nudPrice.Font = new Font("Segoe UI", 9.5F);
            nudPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.Location = new Point(12, 235);
            nudPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(290, 24);
            nudPrice.TabIndex = 7;
            nudPrice.ThousandsSeparator = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.ForeColor = Color.FromArgb(70, 80, 95);
            lblPrice.Location = new Point(12, 215);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(78, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Đơn giá (VNĐ):";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 9.5F);
            txtProductName.Location = new Point(12, 175);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Nhập tên sản phẩm...";
            txtProductName.Size = new Size(290, 24);
            txtProductName.TabIndex = 5;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9F);
            lblProductName.ForeColor = Color.FromArgb(70, 80, 95);
            lblProductName.Location = new Point(12, 155);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(83, 15);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 9.5F);
            txtBarcode.Location = new Point(12, 115);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "Nhập mã vạch Barcode...";
            txtBarcode.Size = new Size(290, 24);
            txtBarcode.TabIndex = 3;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI", 9F);
            lblBarcode.ForeColor = Color.FromArgb(70, 80, 95);
            lblBarcode.Location = new Point(12, 95);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(99, 15);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Mã vạch Barcode:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(240, 240, 240);
            txtId.Font = new Font("Segoe UI", 9.5F);
            txtId.Location = new Point(12, 55);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(290, 24);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F);
            lblId.ForeColor = Color.FromArgb(70, 80, 95);
            lblId.Location = new Point(12, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Mã định danh:";
            // 
            // FormProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 247);
            ClientSize = new Size(1040, 660);
            Controls.Add(panelGrid);
            Controls.Add(panelDetails);
            Controls.Add(panelSearch);
            Font = new Font("Segoe UI", 9.75F);
            Name = "FormProductManagement";
            Text = "FormProductManagement";
            Load += FormProductManagement_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelDetails.ResumeLayout(false);
            groupActions.ResumeLayout(false);
            groupProductDetails.ResumeLayout(false);
            groupProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private ComboBox cboFilterCategory;
        private Label lblFilterCategory;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnExportCsv;
        private Panel panelGrid;
        private DataGridView dgvProducts;
        private Panel panelPagination;
        private Button btnPrev;
        private Label lblPaging;
        private Button btnNext;
        private Panel panelDetails;
        private GroupBox groupProductDetails;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtBarcode;
        private Label lblBarcode;
        private TextBox txtProductName;
        private Label lblProductName;
        private NumericUpDown nudPrice;
        private Label lblPrice;
        private NumericUpDown nudStock;
        private Label lblStock;
        private ComboBox cboCategory;
        private Label lblCategory;
        private GroupBox groupActions;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
