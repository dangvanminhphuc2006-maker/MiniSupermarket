namespace MiniSupermarket.WinForms
{
    partial class FormLogin
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
            lblTitle = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            panelHeader = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Navy;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(420, 65);
            panelHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUser.Location = new Point(45, 90);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(111, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên đăng nhập:";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10.5F);
            txtUser.Location = new Point(45, 115);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Nhập tài khoản (vd: admin/cashier)...";
            txtUser.Size = new Size(330, 26);
            txtUser.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPass.Location = new Point(45, 155);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(75, 19);
            lblPass.TabIndex = 2;
            lblPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10.5F);
            txtPass.Location = new Point(45, 180);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Nhập mật khẩu (vd: 123456)...";
            txtPass.Size = new Size(330, 26);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(45, 235);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập hệ thống";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 310);
            Controls.Add(panelHeader);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - MiniSupermarket System";
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPass;
        private TextBox txtPass;
        private Button btnLogin;
        private Panel panelHeader;
    }
}
