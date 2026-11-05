using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
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

            panelSearch = new System.Windows.Forms.Panel();
            lblCategoryCount = new System.Windows.Forms.Label();
            btnOpenCustomers = new System.Windows.Forms.Button();
            btnOpenRoles = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            txtKeyword = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();

            panelGrid = new System.Windows.Forms.Panel();
            dgvCategories = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();

            panelDetails = new System.Windows.Forms.Panel();
            groupActions = new System.Windows.Forms.GroupBox();
            btnClear = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();

            groupCategoryDetails = new System.Windows.Forms.GroupBox();
            lblTip = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtCategoryName = new System.Windows.Forms.TextBox();
            lblCategoryName = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblId = new System.Windows.Forms.Label();

            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblReady = new System.Windows.Forms.ToolStripStatusLabel();
            lblApiUrl = new System.Windows.Forms.ToolStripStatusLabel();

            panelSearch.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            panelDetails.SuspendLayout();
            groupActions.SuspendLayout();
            groupCategoryDetails.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // panelSearch
            // 
            panelSearch.BackColor = System.Drawing.Color.White;
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Controls.Add(lblCategoryCount);
            panelSearch.Controls.Add(btnOpenCustomers);
            panelSearch.Controls.Add(btnOpenRoles);
            panelSearch.Controls.Add(btnLoad);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(txtKeyword);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            panelSearch.Location = new System.Drawing.Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new System.Windows.Forms.Padding(12);
            panelSearch.Size = new System.Drawing.Size(1040, 60);
            panelSearch.TabIndex = 0;

            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblSearch.Location = new System.Drawing.Point(15, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(130, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm danh mục:";

            // 
            // txtKeyword
            // 
            txtKeyword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtKeyword.Location = new System.Drawing.Point(150, 17);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Nhập tên hoặc mã nhóm hàng...";
            txtKeyword.Size = new System.Drawing.Size(230, 24);
            txtKeyword.TabIndex = 1;
            txtKeyword.KeyDown += txtKeyword_KeyDown;

            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.FromArgb(41, 100, 180);
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(390, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(85, 30);
            btnSearch.TabIndex = 2;
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
            btnLoad.Location = new System.Drawing.Point(482, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(95, 30);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "🔄 Làm mới";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;

            // 
            // btnOpenRoles
            // 
            btnOpenRoles.BackColor = System.Drawing.Color.FromArgb(244, 245, 247);
            btnOpenRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOpenRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 215, 225);
            btnOpenRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenRoles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnOpenRoles.ForeColor = System.Drawing.Color.FromArgb(50, 60, 75);
            btnOpenRoles.Location = new System.Drawing.Point(585, 14);
            btnOpenRoles.Name = "btnOpenRoles";
            btnOpenRoles.Size = new System.Drawing.Size(95, 30);
            btnOpenRoles.TabIndex = 4;
            btnOpenRoles.Text = "🛡️ Vai trò";
            btnOpenRoles.UseVisualStyleBackColor = false;
            btnOpenRoles.Click += btnOpenRoles_Click;

            // 
            // btnOpenCustomers
            // 
            btnOpenCustomers.BackColor = System.Drawing.Color.FromArgb(244, 245, 247);
            btnOpenCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOpenCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 215, 225);
            btnOpenCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            btnOpenCustomers.ForeColor = System.Drawing.Color.FromArgb(50, 60, 75);
            btnOpenCustomers.Location = new System.Drawing.Point(688, 14);
            btnOpenCustomers.Name = "btnOpenCustomers";
            btnOpenCustomers.Size = new System.Drawing.Size(115, 30);
            btnOpenCustomers.TabIndex = 5;
            btnOpenCustomers.Text = "👥 Khách hàng";
            btnOpenCustomers.UseVisualStyleBackColor = false;
            btnOpenCustomers.Click += btnOpenCustomers_Click;

            // 
            // lblCategoryCount
            // 
            lblCategoryCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblCategoryCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblCategoryCount.ForeColor = System.Drawing.Color.FromArgb(41, 100, 180);
            lblCategoryCount.Location = new System.Drawing.Point(820, 20);
            lblCategoryCount.Name = "lblCategoryCount";
            lblCategoryCount.Size = new System.Drawing.Size(200, 20);
            lblCategoryCount.TabIndex = 6;
            lblCategoryCount.Text = "Tổng số: 0 danh mục";
            lblCategoryCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // panelGrid
            // 
            panelGrid.BackColor = System.Drawing.Color.FromArgb(244, 245, 247);
            panelGrid.Controls.Add(dgvCategories);
            panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGrid.Location = new System.Drawing.Point(0, 60);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new System.Windows.Forms.Padding(12);
            panelGrid.Size = new System.Drawing.Size(700, 578);
            panelGrid.TabIndex = 1;

            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = System.Drawing.Color.White;
            dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategories.GridColor = System.Drawing.Color.FromArgb(230, 233, 238);

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(24, 30, 48);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(24, 30, 48);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeight = 36;
            dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colDesc });

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;

            dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.Location = new System.Drawing.Point(12, 12);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowTemplate.Height = 32;
            dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new System.Drawing.Size(676, 554);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellClick += dgvCategories_CellClick;

            // 
            // colId
            // 
            colId.DataPropertyName = "CategoryId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colId.DefaultCellStyle = dataGridViewCellStyle3;
            colId.FillWeight = 16F;
            colId.HeaderText = "Mã ID";
            colId.Name = "colId";
            colId.ReadOnly = true;

            // 
            // colName
            // 
            colName.DataPropertyName = "CategoryName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            colName.DefaultCellStyle = dataGridViewCellStyle4;
            colName.FillWeight = 44F;
            colName.HeaderText = "Tên Nhóm hàng (Danh mục)";
            colName.Name = "colName";
            colName.ReadOnly = true;

            // 
            // colDesc
            // 
            colDesc.DataPropertyName = "Description";
            colDesc.FillWeight = 60F;
            colDesc.HeaderText = "Mô Tả Chi Tiết";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;

            // 
            // panelDetails
            // 
            panelDetails.BackColor = System.Drawing.Color.White;
            panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelDetails.Controls.Add(groupActions);
            panelDetails.Controls.Add(groupCategoryDetails);
            panelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            panelDetails.Location = new System.Drawing.Point(700, 60);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new System.Windows.Forms.Padding(12);
            panelDetails.Size = new System.Drawing.Size(340, 578);
            panelDetails.TabIndex = 2;

            // 
            // groupCategoryDetails
            // 
            groupCategoryDetails.Controls.Add(lblTip);
            groupCategoryDetails.Controls.Add(txtDescription);
            groupCategoryDetails.Controls.Add(lblDescription);
            groupCategoryDetails.Controls.Add(txtCategoryName);
            groupCategoryDetails.Controls.Add(lblCategoryName);
            groupCategoryDetails.Controls.Add(txtId);
            groupCategoryDetails.Controls.Add(lblId);
            groupCategoryDetails.Dock = System.Windows.Forms.DockStyle.Top;
            groupCategoryDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            groupCategoryDetails.Location = new System.Drawing.Point(12, 12);
            groupCategoryDetails.Name = "groupCategoryDetails";
            groupCategoryDetails.Padding = new System.Windows.Forms.Padding(10);
            groupCategoryDetails.Size = new System.Drawing.Size(314, 420);
            groupCategoryDetails.TabIndex = 0;
            groupCategoryDetails.TabStop = false;
            groupCategoryDetails.Text = "Thông tin chi tiết nhóm hàng";

            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblId.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblId.Location = new System.Drawing.Point(12, 28);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(107, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Mã nhóm hàng ID:";

            // 
            // txtId
            // 
            txtId.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            txtId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtId.Location = new System.Drawing.Point(12, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(290, 24);
            txtId.TabIndex = 1;

            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblCategoryName.Location = new System.Drawing.Point(12, 85);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new System.Drawing.Size(126, 15);
            lblCategoryName.TabIndex = 2;
            lblCategoryName.Text = "Tên nhóm hàng (*):";

            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtCategoryName.Location = new System.Drawing.Point(12, 105);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Nhập tên nhóm hàng...";
            txtCategoryName.Size = new System.Drawing.Size(290, 24);
            txtCategoryName.TabIndex = 3;

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDescription.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            lblDescription.Location = new System.Drawing.Point(12, 145);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(78, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Mô tả chi tiết:";

            // 
            // txtDescription
            // 
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtDescription.Location = new System.Drawing.Point(12, 165);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Mô tả chi tiết đặc điểm nhóm hàng...";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(290, 195);
            txtDescription.TabIndex = 5;

            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            lblTip.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            lblTip.Location = new System.Drawing.Point(12, 375);
            lblTip.Name = "lblTip";
            lblTip.Size = new System.Drawing.Size(270, 13);
            lblTip.TabIndex = 6;
            lblTip.Text = "💡 Phân nhóm giúp quản lý giá, tồn kho và bán hàng POS";

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
            btnDelete.Text = "🗑  Xóa";
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
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblReady, lblApiUrl });
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
            lblReady.Size = new System.Drawing.Size(52, 17);
            lblReady.Text = "Sẵn sàng";

            // 
            // lblApiUrl
            // 
            lblApiUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblApiUrl.ForeColor = System.Drawing.Color.FromArgb(110, 120, 135);
            lblApiUrl.Name = "lblApiUrl";
            lblApiUrl.Size = new System.Drawing.Size(130, 17);
            lblApiUrl.Text = " | API: localhost:5000";

            // 
            // FormCategoryManagement
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
            Name = "FormCategoryManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý siêu thị - Danh mục Nhóm hàng";
            Load += FormCategoryManagement_Load;

            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            panelDetails.ResumeLayout(false);
            groupActions.ResumeLayout(false);
            groupCategoryDetails.ResumeLayout(false);
            groupCategoryDetails.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnOpenRoles;
        private System.Windows.Forms.Button btnOpenCustomers;
        private System.Windows.Forms.Label lblCategoryCount;

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.GroupBox groupCategoryDetails;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTip;

        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblReady;
        private System.Windows.Forms.ToolStripStatusLabel lblApiUrl;
    }
}