namespace MiniSupermarket.WinForms
{
    partial class FormCustomerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();

            panelSearch = new System.Windows.Forms.Panel();
            lblCustomerCount = new System.Windows.Forms.Label();
            cboFilterPoints = new System.Windows.Forms.ComboBox();
            lblFilterPoints = new System.Windows.Forms.Label();
            cboFilterRank = new System.Windows.Forms.ComboBox();
            lblFilterRank = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            txtKeyword = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();

            panelGrid = new System.Windows.Forms.Panel();
            dgvCustomers = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();

            panelDetails = new System.Windows.Forms.Panel();
            groupActions = new System.Windows.Forms.GroupBox();
            btnClear = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();

            groupCustomerDetails = new System.Windows.Forms.GroupBox();
            lblRankTip = new System.Windows.Forms.Label();
            cbMembershipRank = new System.Windows.Forms.ComboBox();
            lblMembershipRank = new System.Windows.Forms.Label();
            txtRewardPoints = new System.Windows.Forms.TextBox();
            lblRewardPoints = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            lblPhoneNumber = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            lblCustomerName = new System.Windows.Forms.Label();
            txtCustomerId = new System.Windows.Forms.TextBox();
            lblCustomerId = new System.Windows.Forms.Label();

            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblReady = new System.Windows.Forms.ToolStripStatusLabel();

            panelSearch.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panelDetails.SuspendLayout();
            groupActions.SuspendLayout();
            groupCustomerDetails.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // panelSearch
            // 
            panelSearch.BackColor = System.Drawing.Color.White;
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Controls.Add(lblCustomerCount);
            panelSearch.Controls.Add(cboFilterPoints);
            panelSearch.Controls.Add(lblFilterPoints);
            panelSearch.Controls.Add(cboFilterRank);
            panelSearch.Controls.Add(lblFilterRank);
            panelSearch.Controls.Add(btnLoad);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(txtKeyword);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            panelSearch.Location = new System.Drawing.Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new System.Windows.Forms.Padding(12);
            panelSearch.Size = new System.Drawing.Size(1040, 100);
            panelSearch.TabIndex = 0;

            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblSearch.Location = new System.Drawing.Point(15, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(135, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm khách hàng:";

            // 
            // txtKeyword
            // 
            txtKeyword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtKeyword.Location = new System.Drawing.Point(155, 17);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Tên hoặc số điện thoại...";
            txtKeyword.Size = new System.Drawing.Size(230, 24);
            txtKeyword.TabIndex = 1;
            txtKeyword.KeyDown += txtKeyword_KeyDown;

            // 
            // lblFilterRank
            // 
            lblFilterRank.AutoSize = true;
            lblFilterRank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblFilterRank.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblFilterRank.Location = new System.Drawing.Point(15, 61);
            lblFilterRank.Name = "lblFilterRank";
            lblFilterRank.Size = new System.Drawing.Size(68, 17);
            lblFilterRank.TabIndex = 2;
            lblFilterRank.Text = "Hạng thẻ:";

            // 
            // cboFilterRank
            // 
            cboFilterRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFilterRank.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboFilterRank.FormattingEnabled = true;
            cboFilterRank.Items.AddRange(new object[] { "Tất cả hạng", "Chuẩn", "Bạc", "Vàng", "Kim cương" });
            cboFilterRank.Location = new System.Drawing.Point(95, 55);
            cboFilterRank.Name = "cboFilterRank";
            cboFilterRank.Size = new System.Drawing.Size(145, 24);
            cboFilterRank.TabIndex = 3;
            cboFilterRank.SelectedIndexChanged += cboFilterRank_SelectedIndexChanged;

            // 
            // lblFilterPoints
            // 
            lblFilterPoints.AutoSize = true;
            lblFilterPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblFilterPoints.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblFilterPoints.Location = new System.Drawing.Point(260, 61);
            lblFilterPoints.Name = "lblFilterPoints";
            lblFilterPoints.Size = new System.Drawing.Size(74, 17);
            lblFilterPoints.TabIndex = 7;
            lblFilterPoints.Text = "Tích điểm:";

            // 
            // cboFilterPoints
            // 
            cboFilterPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFilterPoints.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboFilterPoints.FormattingEnabled = true;
            cboFilterPoints.Items.AddRange(new object[] { "Tất cả khách hàng", "Có điểm", "Chưa có điểm" });
            cboFilterPoints.Location = new System.Drawing.Point(340, 55);
            cboFilterPoints.Name = "cboFilterPoints";
            cboFilterPoints.Size = new System.Drawing.Size(160, 24);
            cboFilterPoints.TabIndex = 8;
            cboFilterPoints.SelectedIndexChanged += cboFilterPoints_SelectedIndexChanged;

            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.FromArgb(41, 100, 180);
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(395, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(85, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "🔍 Tìm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            // 
            // btnLoad
            // 
            btnLoad.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnLoad.ForeColor = System.Drawing.Color.White;
            btnLoad.Location = new System.Drawing.Point(487, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(95, 30);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "🔄 Làm mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;

            // 
            // lblCustomerCount
            // 
            lblCustomerCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCustomerCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblCustomerCount.ForeColor = System.Drawing.Color.FromArgb(41, 100, 180);
            lblCustomerCount.Location = new System.Drawing.Point(600, 58);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.Size = new System.Drawing.Size(415, 20);
            lblCustomerCount.TabIndex = 6;
            lblCustomerCount.Text = "Tổng số: 0 khách";
            lblCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // panelGrid
            // 
            panelGrid.BackColor = System.Drawing.Color.FromArgb(244, 245, 247);
            panelGrid.Controls.Add(dgvCustomers);
            panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGrid.Location = new System.Drawing.Point(0, 100);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new System.Windows.Forms.Padding(12);
            panelGrid.Size = new System.Drawing.Size(700, 538);
            panelGrid.TabIndex = 1;

            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.GridColor = System.Drawing.Color.FromArgb(230, 233, 238);

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(24, 30, 48);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(24, 30, 48);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeight = 36;
            dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colPhone, colAddress, colPoints, colRank });

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;

            dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.Location = new System.Drawing.Point(12, 12);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowTemplate.Height = 32;
            dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new System.Drawing.Size(676, 554);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            dgvCustomers.CellFormatting += dgvCustomers_CellFormatting;

            // 
            // colId
            // 
            colId.DataPropertyName = "CustomerId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colId.DefaultCellStyle = dataGridViewCellStyle3;
            colId.FillWeight = 14F;
            colId.HeaderText = "Mã ID";
            colId.Name = "colId";
            colId.ReadOnly = true;

            // 
            // colName
            // 
            colName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            colName.DefaultCellStyle = dataGridViewCellStyle4;
            colName.FillWeight = 40F;
            colName.HeaderText = "Họ và Tên Khách hàng";
            colName.Name = "colName";
            colName.ReadOnly = true;

            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colPhone.DefaultCellStyle = dataGridViewCellStyle5;
            colPhone.FillWeight = 24F;
            colPhone.HeaderText = "Số Điện Thoại";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;

            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.FillWeight = 46F;
            colAddress.HeaderText = "Địa Chỉ Cư Trú";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;

            // 
            // colPoints
            // 
            colPoints.DataPropertyName = "RewardPoints";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colPoints.DefaultCellStyle = dataGridViewCellStyle6;
            colPoints.FillWeight = 22F;
            colPoints.HeaderText = "Điểm Tích Lũy";
            colPoints.Name = "colPoints";
            colPoints.ReadOnly = true;

            // 
            // colRank
            // 
            colRank.DataPropertyName = "MembershipRank";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colRank.DefaultCellStyle = dataGridViewCellStyle6;
            colRank.FillWeight = 22F;
            colRank.HeaderText = "Hạng Thẻ";
            colRank.Name = "colRank";
            colRank.ReadOnly = true;

            // 
            // panelDetails
            // 
            panelDetails.BackColor = System.Drawing.Color.White;
            panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDetails.Controls.Add(groupActions);
            panelDetails.Controls.Add(groupCustomerDetails);
            panelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            panelDetails.Location = new System.Drawing.Point(700, 100);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new System.Windows.Forms.Padding(12);
            panelDetails.Size = new System.Drawing.Size(340, 538);
            panelDetails.TabIndex = 2;

            // 
            // groupCustomerDetails
            // 
            groupCustomerDetails.Controls.Add(lblRankTip);
            groupCustomerDetails.Controls.Add(cbMembershipRank);
            groupCustomerDetails.Controls.Add(lblMembershipRank);
            groupCustomerDetails.Controls.Add(txtRewardPoints);
            groupCustomerDetails.Controls.Add(lblRewardPoints);
            groupCustomerDetails.Controls.Add(txtAddress);
            groupCustomerDetails.Controls.Add(lblAddress);
            groupCustomerDetails.Controls.Add(txtPhoneNumber);
            groupCustomerDetails.Controls.Add(lblPhoneNumber);
            groupCustomerDetails.Controls.Add(txtCustomerName);
            groupCustomerDetails.Controls.Add(lblCustomerName);
            groupCustomerDetails.Controls.Add(txtCustomerId);
            groupCustomerDetails.Controls.Add(lblCustomerId);
            groupCustomerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            groupCustomerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            groupCustomerDetails.Location = new System.Drawing.Point(12, 12);
            groupCustomerDetails.Name = "groupCustomerDetails";
            groupCustomerDetails.Padding = new System.Windows.Forms.Padding(10);
            groupCustomerDetails.Size = new System.Drawing.Size(314, 420);
            groupCustomerDetails.TabIndex = 0;
            groupCustomerDetails.TabStop = false;
            groupCustomerDetails.Text = "Thông tin chi tiết khách hàng";

            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblCustomerId.Location = new System.Drawing.Point(12, 25);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new System.Drawing.Size(107, 15);
            lblCustomerId.TabIndex = 0;
            lblCustomerId.Text = "Mã khách hàng ID:";

            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtCustomerId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtCustomerId.Location = new System.Drawing.Point(12, 45);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new System.Drawing.Size(290, 24);
            txtCustomerId.TabIndex = 1;

            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblCustomerName.Location = new System.Drawing.Point(12, 77);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new System.Drawing.Size(125, 15);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên khách hàng (*):";

            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtCustomerName.Location = new System.Drawing.Point(12, 97);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Nhập họ và tên đầy đủ...";
            txtCustomerName.Size = new System.Drawing.Size(290, 24);
            txtCustomerName.TabIndex = 3;

            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblPhoneNumber.Location = new System.Drawing.Point(12, 129);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new System.Drawing.Size(105, 15);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại (*):";

            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtPhoneNumber.Location = new System.Drawing.Point(12, 149);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Ví dụ: 0901234567...";
            txtPhoneNumber.Size = new System.Drawing.Size(290, 24);
            txtPhoneNumber.TabIndex = 5;

            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblAddress.Location = new System.Drawing.Point(12, 181);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(86, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Địa chỉ cư trú:";

            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtAddress.Location = new System.Drawing.Point(12, 201);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Địa chỉ liên hệ, nơi cư trú...";
            txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtAddress.Size = new System.Drawing.Size(290, 50);
            txtAddress.TabIndex = 7;

            // 
            // lblRewardPoints
            // 
            lblRewardPoints.AutoSize = true;
            lblRewardPoints.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRewardPoints.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblRewardPoints.Location = new System.Drawing.Point(12, 260);
            lblRewardPoints.Name = "lblRewardPoints";
            lblRewardPoints.Size = new System.Drawing.Size(124, 15);
            lblRewardPoints.TabIndex = 8;
            lblRewardPoints.Text = "Điểm tích lũy hiện tại:";

            // 
            // txtRewardPoints
            // 
            txtRewardPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            txtRewardPoints.Location = new System.Drawing.Point(12, 280);
            txtRewardPoints.Name = "txtRewardPoints";
            txtRewardPoints.Size = new System.Drawing.Size(290, 24);
            txtRewardPoints.TabIndex = 9;
            txtRewardPoints.Text = "0";

            // 
            // lblMembershipRank
            // 
            lblMembershipRank.AutoSize = true;
            lblMembershipRank.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblMembershipRank.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblMembershipRank.Location = new System.Drawing.Point(12, 312);
            lblMembershipRank.Name = "lblMembershipRank";
            lblMembershipRank.Size = new System.Drawing.Size(117, 15);
            lblMembershipRank.TabIndex = 10;
            lblMembershipRank.Text = "Hạng thẻ thành viên:";

            // 
            // cbMembershipRank
            // 
            cbMembershipRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbMembershipRank.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cbMembershipRank.FormattingEnabled = true;
            cbMembershipRank.Items.AddRange(new object[] { "Chuẩn", "Bạc", "Vàng", "Kim cương" });
            cbMembershipRank.Location = new System.Drawing.Point(12, 332);
            cbMembershipRank.Name = "cbMembershipRank";
            cbMembershipRank.Size = new System.Drawing.Size(290, 24);
            cbMembershipRank.TabIndex = 11;

            // 
            // lblRankTip
            // 
            lblRankTip.AutoSize = true;
            lblRankTip.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            lblRankTip.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            lblRankTip.Location = new System.Drawing.Point(12, 370);
            lblRankTip.Name = "lblRankTip";
            lblRankTip.Size = new System.Drawing.Size(280, 26);
            lblRankTip.TabIndex = 12;
            lblRankTip.Text = "💡 Phân hạng: Chuẩn (<100đ) | Bạc (100đ)\r\nVàng (300đ) | Kim cương (500đ trở lên)";

            // 
            // groupActions
            // 
            groupActions.Controls.Add(btnClear);
            groupActions.Controls.Add(btnDelete);
            groupActions.Controls.Add(btnUpdate);
            groupActions.Controls.Add(btnAdd);
            groupActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupActions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            groupActions.Location = new System.Drawing.Point(12, 422);
            groupActions.Name = "groupActions";
            groupActions.Padding = new System.Windows.Forms.Padding(10);
            groupActions.Size = new System.Drawing.Size(314, 142);
            groupActions.TabIndex = 1;
            groupActions.TabStop = false;
            groupActions.Text = "Hành động tác vụ";

            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(10, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(140, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(162, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(140, 38);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "✏️ Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;

            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(10, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(140, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑  Xóa KH";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;

            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.Location = new System.Drawing.Point(162, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(140, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "🔄 Làm mới ô";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblReady });
            statusStrip1.Location = new System.Drawing.Point(0, 638);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1040, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";

            // 
            // lblReady
            // 
            lblReady.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblReady.ForeColor = System.Drawing.Color.FromArgb(80, 90, 105);
            lblReady.Name = "lblReady";
            lblReady.Size = new System.Drawing.Size(280, 17);
            lblReady.Text = "Sẵn sàng | Quản lý Khách hàng thân thiết (EF Core)";

            // 
            // FormCustomerManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(244, 245, 247);
            ClientSize = new System.Drawing.Size(1040, 660);
            Controls.Add(panelGrid);
            Controls.Add(panelDetails);
            Controls.Add(panelSearch);
            Controls.Add(statusStrip1);
            Font = new System.Drawing.Font("Segoe UI", 9.75F);
            Name = "FormCustomerManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý siêu thị - Quản lý Khách hàng (Customers)";
            Load += FormCustomerManagement_Load;

            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panelDetails.ResumeLayout(false);
            groupActions.ResumeLayout(false);
            groupCustomerDetails.ResumeLayout(false);
            groupCustomerDetails.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblFilterRank;
        private System.Windows.Forms.ComboBox cboFilterRank;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblFilterPoints;
        private System.Windows.Forms.ComboBox cboFilterPoints;

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.GroupBox groupCustomerDetails;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtRewardPoints;
        private System.Windows.Forms.Label lblRewardPoints;
        private System.Windows.Forms.ComboBox cbMembershipRank;
        private System.Windows.Forms.Label lblMembershipRank;
        private System.Windows.Forms.Label lblRankTip;

        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblReady;
    }
}
