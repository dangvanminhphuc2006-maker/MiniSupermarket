namespace MiniSupermarket.WinForms
{
    partial class FormRoleManagement
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
            grpList = new System.Windows.Forms.GroupBox();
            dgvRoles = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpInfo = new System.Windows.Forms.GroupBox();
            btnLoad = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtDescription = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtRoleName = new System.Windows.Forms.TextBox();
            lblRoleName = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblId = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblReady = new System.Windows.Forms.ToolStripStatusLabel();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            grpInfo.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvRoles);
            grpList.Location = new System.Drawing.Point(12, 12);
            grpList.Name = "grpList";
            grpList.Size = new System.Drawing.Size(475, 410);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Danh sách Vai trò";
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = System.Drawing.SystemColors.Window;
            dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colRoleName, colDescription });
            dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRoles.Location = new System.Drawing.Point(3, 19);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new System.Drawing.Size(469, 388);
            dgvRoles.TabIndex = 0;
            dgvRoles.CellClick += dgvRoles_CellClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.FillWeight = 25F;
            colId.HeaderText = "Mã ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colRoleName
            // 
            colRoleName.DataPropertyName = "RoleName";
            colRoleName.FillWeight = 45F;
            colRoleName.HeaderText = "Tên Vai trò";
            colRoleName.Name = "colRoleName";
            colRoleName.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "Description";
            colDescription.FillWeight = 60F;
            colDescription.HeaderText = "Mô Tả";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(btnLoad);
            grpInfo.Controls.Add(btnDelete);
            grpInfo.Controls.Add(btnUpdate);
            grpInfo.Controls.Add(btnAdd);
            grpInfo.Controls.Add(txtDescription);
            grpInfo.Controls.Add(lblDescription);
            grpInfo.Controls.Add(txtRoleName);
            grpInfo.Controls.Add(lblRoleName);
            grpInfo.Controls.Add(txtId);
            grpInfo.Controls.Add(lblId);
            grpInfo.Location = new System.Drawing.Point(495, 12);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new System.Drawing.Size(295, 410);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin Vai trò";
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(16, 320);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(262, 32);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Tải lại danh sách";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(198, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(80, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(107, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(80, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(16, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(80, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(16, 172);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Mô tả quyền hạn vai trò...";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(262, 130);
            txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(16, 150);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(41, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Mô Tả:";
            // 
            // txtRoleName
            // 
            txtRoleName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtRoleName.Location = new System.Drawing.Point(16, 108);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.PlaceholderText = "Ví dụ: Admin, Cashier...";
            txtRoleName.Size = new System.Drawing.Size(262, 25);
            txtRoleName.TabIndex = 3;
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new System.Drawing.Point(16, 86);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new System.Drawing.Size(68, 15);
            lblRoleName.TabIndex = 2;
            lblRoleName.Text = "Tên Vai trò:";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(16, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(262, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(16, 26);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(43, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Mã ID:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblReady });
            statusStrip1.Location = new System.Drawing.Point(0, 431);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(802, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblReady
            // 
            lblReady.Name = "lblReady";
            lblReady.Size = new System.Drawing.Size(217, 17);
            lblReady.Text = "Sẵn sàng | Quản lý Vai trò nhân sự (Roles)";
            // 
            // FormRoleManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(802, 453);
            Controls.Add(statusStrip1);
            Controls.Add(grpInfo);
            Controls.Add(grpList);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRoleManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý siêu thị - Quản lý Vai trò (Roles)";
            Load += FormRoleManagement_Load;
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblReady;
    }
}
