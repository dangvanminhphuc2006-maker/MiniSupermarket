namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblListCount;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoSubtitle;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();

            this.pnlList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblListCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInfoSubtitle = new System.Windows.Forms.Label();

            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // FORM
            // =========================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(1050, 650);

            this.MinimumSize =
                new System.Drawing.Size(950, 600);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý nhóm hàng";

            this.Name =
                "FormCategoryManagement";

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            // =========================================================
            // HEADER
            // =========================================================

            this.pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(0, 102, 204);

            this.pnlHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlHeader.Height = 82;

            this.pnlHeader.Controls.Add(
                this.lblTitle);

            this.pnlHeader.Controls.Add(
                this.lblSubtitle);

            // TITLE

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    20F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.White;

            this.lblTitle.Location =
                new System.Drawing.Point(25, 12);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Text =
                "Quản lý nhóm hàng";

            // SUBTITLE

            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    220, 235, 255);

            this.lblSubtitle.Location =
                new System.Drawing.Point(28, 50);

            this.lblSubtitle.Name =
                "lblSubtitle";

            this.lblSubtitle.Text =
                "Quản lý danh mục hàng hóa trong siêu thị";

            // =========================================================
            // SEARCH PANEL
            // =========================================================

            this.pnlSearch.BackColor =
                System.Drawing.Color.White;

            this.pnlSearch.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.pnlSearch.Height = 75;

            this.pnlSearch.Controls.Add(
                this.lblSearch);

            this.pnlSearch.Controls.Add(
                this.txtSearch);

            this.pnlSearch.Controls.Add(
                this.btnSearch);

            this.pnlSearch.Controls.Add(
                this.btnReload);

            // LABEL SEARCH

            this.lblSearch.AutoSize = true;

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblSearch.ForeColor =
                System.Drawing.Color.FromArgb(
                    52, 58, 64);

            this.lblSearch.Location =
                new System.Drawing.Point(20, 28);

            this.lblSearch.Name =
                "lblSearch";

            this.lblSearch.Text =
                "Tìm kiếm:";

            // TEXT SEARCH

            this.txtSearch.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtSearch.ForeColor =
                System.Drawing.Color.Gray;

            this.txtSearch.Location =
                new System.Drawing.Point(90, 22);

            this.txtSearch.Name =
                "txtSearch";

            this.txtSearch.Size =
                new System.Drawing.Size(310, 25);

            this.txtSearch.TabIndex = 0;

            this.txtSearch.Text =
                "Nhập từ khóa...";

            this.txtSearch.Enter +=
                new System.EventHandler(
                    this.txtSearch_Enter);

            this.txtSearch.Leave +=
                new System.EventHandler(
                    this.txtSearch_Leave);

            // SEARCH BUTTON

            this.btnSearch.BackColor =
                System.Drawing.Color.FromArgb(
                    0, 123, 255);

            this.btnSearch.FlatAppearance.BorderSize = 0;

            this.btnSearch.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnSearch.ForeColor =
                System.Drawing.Color.White;

            this.btnSearch.Location =
                new System.Drawing.Point(410, 21);

            this.btnSearch.Name =
                "btnSearch";

            this.btnSearch.Size =
                new System.Drawing.Size(90, 28);

            this.btnSearch.TabIndex = 1;

            this.btnSearch.Text =
                "Tìm kiếm";

            this.btnSearch.UseVisualStyleBackColor =
                false;

            this.btnSearch.Click +=
                new System.EventHandler(
                    this.btnSearch_Click);

            // RELOAD BUTTON

            this.btnReload.BackColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.btnReload.FlatAppearance.BorderSize = 0;

            this.btnReload.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnReload.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnReload.ForeColor =
                System.Drawing.Color.White;

            this.btnReload.Location =
                new System.Drawing.Point(508, 21);

            this.btnReload.Name =
                "btnReload";

            this.btnReload.Size =
                new System.Drawing.Size(85, 28);

            this.btnReload.TabIndex = 2;

            this.btnReload.Text =
                "Tải lại";

            this.btnReload.UseVisualStyleBackColor =
                false;

            this.btnReload.Click +=
                new System.EventHandler(
                    this.btnReload_Click);

            // =========================================================
            // LIST PANEL
            // =========================================================

            this.pnlList.BackColor =
                System.Drawing.Color.White;

            this.pnlList.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlList.Location =
                new System.Drawing.Point(20, 172);

            this.pnlList.Name =
                "pnlList";

            this.pnlList.Size =
                new System.Drawing.Size(635, 420);

            this.pnlList.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.pnlList.Controls.Add(
                this.lblListTitle);

            this.pnlList.Controls.Add(
                this.lblListCount);

            this.pnlList.Controls.Add(
                this.dataGridView1);

            // LIST TITLE

            this.lblListTitle.AutoSize = true;

            this.lblListTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblListTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblListTitle.Location =
                new System.Drawing.Point(18, 14);

            this.lblListTitle.Name =
                "lblListTitle";

            this.lblListTitle.Text =
                "Danh sách nhóm hàng";

            // LIST COUNT

            this.lblListCount.AutoSize = true;

            this.lblListCount.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F);

            this.lblListCount.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblListCount.Location =
                new System.Drawing.Point(20, 43);

            this.lblListCount.Name =
                "lblListCount";

            this.lblListCount.Text =
                "Tổng cộng: 0 nhóm hàng";

            // =========================================================
            // DATAGRIDVIEW
            // =========================================================

            this.dataGridView1.AllowUserToAddRows =
                false;

            this.dataGridView1.AllowUserToDeleteRows =
                false;

            this.dataGridView1.AllowUserToResizeRows =
                false;

            this.dataGridView1.AutoGenerateColumns =
                false;

            this.dataGridView1.BackgroundColor =
                System.Drawing.Color.White;

            this.dataGridView1.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dataGridView1.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dataGridView1.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dataGridView1.ColumnHeadersHeight =
                38;

            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dataGridView1.EnableHeadersVisualStyles =
                false;

            this.dataGridView1.GridColor =
                System.Drawing.Color.FromArgb(
                    233, 236, 239);

            this.dataGridView1.Location =
                new System.Drawing.Point(18, 72);

            this.dataGridView1.MultiSelect =
                false;

            this.dataGridView1.Name =
                "dataGridView1";

            this.dataGridView1.ReadOnly =
                true;

            this.dataGridView1.RowHeadersVisible =
                false;

            this.dataGridView1.RowTemplate.Height =
                36;

            this.dataGridView1.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView1.Size =
                new System.Drawing.Size(597, 330);

            this.dataGridView1.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.dataGridView1.TabIndex = 3;

            this.dataGridView1.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colID,
                    this.colName,
                    this.colDescription
                });

            this.dataGridView1.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dataGridView1_CellClick);

            // HEADER COLOR

            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(
                    0, 102, 204);

            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            // CELL COLOR

            this.dataGridView1.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            this.dataGridView1.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.dataGridView1.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(
                    219, 238, 255);

            this.dataGridView1.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(
                    0, 64, 128);

            // =========================================================
            // COLUMNS
            // =========================================================

            this.colID.DataPropertyName =
                "ID";

            this.colID.HeaderText =
                "Mã";

            this.colID.Name =
                "colID";

            this.colID.ReadOnly = true;

            this.colID.Width = 60;

            this.colName.DataPropertyName =
                "Name";

            this.colName.HeaderText =
                "Tên nhóm hàng";

            this.colName.Name =
                "colName";

            this.colName.ReadOnly = true;

            this.colName.Width = 190;

            this.colDescription.DataPropertyName =
                "Description";

            this.colDescription.HeaderText =
                "Mô tả";

            this.colDescription.Name =
                "colDescription";

            this.colDescription.ReadOnly = true;

            this.colDescription.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            // =========================================================
            // INFO PANEL
            // =========================================================

            this.pnlInfo.BackColor =
                System.Drawing.Color.White;

            this.pnlInfo.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.pnlInfo.Location =
                new System.Drawing.Point(675, 172);

            this.pnlInfo.Name =
                "pnlInfo";

            this.pnlInfo.Size =
                new System.Drawing.Size(355, 420);

            this.pnlInfo.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.pnlInfo.Controls.Add(
                this.lblInfoTitle);

            this.pnlInfo.Controls.Add(
                this.lblInfoSubtitle);

            this.pnlInfo.Controls.Add(
                this.lblID);

            this.pnlInfo.Controls.Add(
                this.txtID);

            this.pnlInfo.Controls.Add(
                this.lblName);

            this.pnlInfo.Controls.Add(
                this.txtName);

            this.pnlInfo.Controls.Add(
                this.lblDescription);

            this.pnlInfo.Controls.Add(
                this.txtDescription);

            this.pnlInfo.Controls.Add(
                this.btnAdd);

            this.pnlInfo.Controls.Add(
                this.btnUpdate);

            this.pnlInfo.Controls.Add(
                this.btnDelete);

            // INFO TITLE

            this.lblInfoTitle.AutoSize = true;

            this.lblInfoTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.lblInfoTitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.lblInfoTitle.Location =
                new System.Drawing.Point(20, 14);

            this.lblInfoTitle.Name =
                "lblInfoTitle";

            this.lblInfoTitle.Text =
                "Thông tin nhóm hàng";

            // INFO SUBTITLE

            this.lblInfoSubtitle.AutoSize = true;

            this.lblInfoSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    8.5F);

            this.lblInfoSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.lblInfoSubtitle.Location =
                new System.Drawing.Point(20, 43);

            this.lblInfoSubtitle.Name =
                "lblInfoSubtitle";

            this.lblInfoSubtitle.Text =
                "Chọn nhóm hàng để xem hoặc chỉnh sửa";

            // =========================================================
            // ID
            // =========================================================

            this.lblID.AutoSize = true;

            this.lblID.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblID.ForeColor =
                System.Drawing.Color.FromArgb(
                    73, 80, 87);

            this.lblID.Location =
                new System.Drawing.Point(20, 82);

            this.lblID.Name =
                "lblID";

            this.lblID.Text =
                "Mã nhóm hàng";

            this.txtID.BackColor =
                System.Drawing.Color.FromArgb(
                    241, 243, 245);

            this.txtID.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtID.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtID.ForeColor =
                System.Drawing.Color.FromArgb(
                    108, 117, 125);

            this.txtID.Location =
                new System.Drawing.Point(20, 103);

            this.txtID.Name =
                "txtID";

            this.txtID.ReadOnly = true;

            this.txtID.Size =
                new System.Drawing.Size(310, 25);

            this.txtID.TabIndex = 4;

            // =========================================================
            // NAME
            // =========================================================

            this.lblName.AutoSize = true;

            this.lblName.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblName.ForeColor =
                System.Drawing.Color.FromArgb(
                    73, 80, 87);

            this.lblName.Location =
                new System.Drawing.Point(20, 143);

            this.lblName.Name =
                "lblName";

            this.lblName.Text =
                "Tên nhóm hàng *";

            this.txtName.BackColor =
                System.Drawing.Color.White;

            this.txtName.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtName.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtName.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.txtName.Location =
                new System.Drawing.Point(20, 164);

            this.txtName.Name =
                "txtName";

            this.txtName.Size =
                new System.Drawing.Size(310, 25);

            this.txtName.TabIndex = 5;

            // =========================================================
            // DESCRIPTION
            // =========================================================

            this.lblDescription.AutoSize = true;

            this.lblDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lblDescription.ForeColor =
                System.Drawing.Color.FromArgb(
                    73, 80, 87);

            this.lblDescription.Location =
                new System.Drawing.Point(20, 204);

            this.lblDescription.Name =
                "lblDescription";

            this.lblDescription.Text =
                "Mô tả";

            this.txtDescription.BackColor =
                System.Drawing.Color.White;

            this.txtDescription.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.txtDescription.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.txtDescription.Location =
                new System.Drawing.Point(20, 225);

            this.txtDescription.Multiline =
                true;

            this.txtDescription.Name =
                "txtDescription";

            this.txtDescription.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            this.txtDescription.Size =
                new System.Drawing.Size(310, 80);

            this.txtDescription.TabIndex = 6;

            // =========================================================
            // BUTTON ADD
            // =========================================================

            this.btnAdd.BackColor =
                System.Drawing.Color.FromArgb(
                    40, 167, 69);

            this.btnAdd.FlatAppearance.BorderSize = 0;

            this.btnAdd.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAdd.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnAdd.ForeColor =
                System.Drawing.Color.White;

            this.btnAdd.Location =
                new System.Drawing.Point(20, 330);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(95, 35);

            this.btnAdd.TabIndex = 7;

            this.btnAdd.Text =
                "Thêm mới";

            this.btnAdd.UseVisualStyleBackColor =
                false;

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // =========================================================
            // BUTTON UPDATE
            // =========================================================

            this.btnUpdate.BackColor =
                System.Drawing.Color.FromArgb(
                    255, 193, 7);

            this.btnUpdate.FlatAppearance.BorderSize = 0;

            this.btnUpdate.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnUpdate.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnUpdate.ForeColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.btnUpdate.Location =
                new System.Drawing.Point(125, 330);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(95, 35);

            this.btnUpdate.TabIndex = 8;

            this.btnUpdate.Text =
                "Cập nhật";

            this.btnUpdate.UseVisualStyleBackColor =
                false;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // =========================================================
            // BUTTON DELETE
            // =========================================================

            this.btnDelete.BackColor =
                System.Drawing.Color.FromArgb(
                    220, 53, 69);

            this.btnDelete.FlatAppearance.BorderSize = 0;

            this.btnDelete.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDelete.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btnDelete.ForeColor =
                System.Drawing.Color.White;

            this.btnDelete.Location =
                new System.Drawing.Point(230, 330);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(100, 35);

            this.btnDelete.TabIndex = 9;

            this.btnDelete.Text =
                "Xóa nhóm";

            this.btnDelete.UseVisualStyleBackColor =
                false;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // =========================================================
            // STATUS STRIP
            // =========================================================

            this.statusStrip1.BackColor =
                System.Drawing.Color.FromArgb(
                    33, 37, 41);

            this.statusStrip1.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.statusStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.lblStatus
                });

            this.statusStrip1.Location =
                new System.Drawing.Point(
                    0,
                    628);

            this.statusStrip1.Name =
                "statusStrip1";

            this.statusStrip1.Size =
                new System.Drawing.Size(
                    1050,
                    22);

            this.statusStrip1.TabIndex = 10;

            // STATUS

            this.lblStatus.ForeColor =
                System.Drawing.Color.White;

            this.lblStatus.Name =
                "lblStatus";

            this.lblStatus.Size =
                new System.Drawing.Size(
                    39,
                    17);

            this.lblStatus.Text =
                "Ready";

            // =========================================================
            // ADD CONTROLS
            // =========================================================

            this.Controls.Add(
                this.pnlHeader);

            this.Controls.Add(
                this.pnlSearch);

            this.Controls.Add(
                this.pnlList);

            this.Controls.Add(
                this.pnlInfo);

            this.Controls.Add(
                this.statusStrip1);

            // =========================================================
            // LOAD
            // =========================================================

            this.Load +=
                new System.EventHandler(
                    this.FormCategoryManagement_Load_1);

            // =========================================================
            // END
            // =========================================================

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridView1)).EndInit();

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();

            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();

            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();

            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();

            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
