
namespace DOAN_QLQuanAn
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.picThoat = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhaplaiMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCapNhatMK = new Guna.UI2.WinForms.Guna2Button();
            this.btThoatCN = new Guna.UI2.WinForms.Guna2Button();
            this.btHideNewPass = new System.Windows.Forms.Button();
            this.btShowNewPass = new System.Windows.Forms.Button();
            this.btHienMKMoi = new System.Windows.Forms.Button();
            this.btAnMKMoi = new System.Windows.Forms.Button();
            this.btHienMK = new System.Windows.Forms.Button();
            this.btAnMK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenDangNhap.Location = new System.Drawing.Point(169, 57);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(195, 24);
            this.txtTenDangNhap.TabIndex = 15;
            // 
            // picThoat
            // 
            //this.picThoat.Image = global::DOAN_QLQuanAn.Properties.Resources.cancel_50px;
            this.picThoat.ImageRotate = 0F;
            this.picThoat.Location = new System.Drawing.Point(362, 6);
            this.picThoat.Name = "picThoat";
            this.picThoat.ShadowDecoration.Parent = this.picThoat;
            this.picThoat.Size = new System.Drawing.Size(18, 22);
            this.picThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThoat.TabIndex = 12;
            this.picThoat.TabStop = false;
            this.picThoat.Click += new System.EventHandler(this.picThoat_Click);
            // 
            // txtMKCu
            // 
            this.txtMKCu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMKCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(169, 151);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(195, 24);
            this.txtMKCu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHienThi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenHienThi.Location = new System.Drawing.Point(169, 103);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.ReadOnly = true;
            this.txtTenHienThi.Size = new System.Drawing.Size(195, 24);
            this.txtTenHienThi.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên hiển thị: ";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMKMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(169, 198);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(195, 24);
            this.txtMKMoi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(22, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txtNhaplaiMK
            // 
            this.txtNhaplaiMK.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNhaplaiMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaplaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaplaiMK.Location = new System.Drawing.Point(169, 245);
            this.txtNhaplaiMK.Name = "txtNhaplaiMK";
            this.txtNhaplaiMK.PasswordChar = '*';
            this.txtNhaplaiMK.Size = new System.Drawing.Size(195, 24);
            this.txtNhaplaiMK.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(22, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nhập lại MK mới:";
            // 
            // btCapNhatMK
            // 
            this.btCapNhatMK.BorderRadius = 10;
            this.btCapNhatMK.CheckedState.Parent = this.btCapNhatMK;
            this.btCapNhatMK.CustomImages.Parent = this.btCapNhatMK;
            this.btCapNhatMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCapNhatMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCapNhatMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCapNhatMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCapNhatMK.DisabledState.Parent = this.btCapNhatMK;
            this.btCapNhatMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCapNhatMK.ForeColor = System.Drawing.Color.White;
            this.btCapNhatMK.HoverState.Parent = this.btCapNhatMK;
            this.btCapNhatMK.Location = new System.Drawing.Point(47, 303);
            this.btCapNhatMK.Name = "btCapNhatMK";
            this.btCapNhatMK.ShadowDecoration.Parent = this.btCapNhatMK;
            this.btCapNhatMK.Size = new System.Drawing.Size(128, 38);
            this.btCapNhatMK.TabIndex = 3;
            this.btCapNhatMK.Text = "Cập nhật";
            this.btCapNhatMK.Click += new System.EventHandler(this.btCapNhatMK_Click);
            // 
            // btThoatCN
            // 
            this.btThoatCN.BorderRadius = 10;
            this.btThoatCN.CheckedState.Parent = this.btThoatCN;
            this.btThoatCN.CustomImages.Parent = this.btThoatCN;
            this.btThoatCN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThoatCN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThoatCN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThoatCN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThoatCN.DisabledState.Parent = this.btThoatCN;
            this.btThoatCN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btThoatCN.ForeColor = System.Drawing.Color.White;
            this.btThoatCN.HoverState.Parent = this.btThoatCN;
            this.btThoatCN.Location = new System.Drawing.Point(211, 303);
            this.btThoatCN.Name = "btThoatCN";
            this.btThoatCN.ShadowDecoration.Parent = this.btThoatCN;
            this.btThoatCN.Size = new System.Drawing.Size(128, 38);
            this.btThoatCN.TabIndex = 4;
            this.btThoatCN.Text = "Thoát";
            this.btThoatCN.Click += new System.EventHandler(this.btThoatCN_Click);
            // 
            // btHideNewPass
            // 
            this.btHideNewPass.Image = ((System.Drawing.Image)(resources.GetObject("btHideNewPass.Image")));
            this.btHideNewPass.Location = new System.Drawing.Point(331, 247);
            this.btHideNewPass.Name = "btHideNewPass";
            this.btHideNewPass.Size = new System.Drawing.Size(32, 20);
            this.btHideNewPass.TabIndex = 27;
            this.btHideNewPass.UseVisualStyleBackColor = true;
            this.btHideNewPass.Click += new System.EventHandler(this.btHideNewPass_Click);
            // 
            // btShowNewPass
            // 
            this.btShowNewPass.Image = ((System.Drawing.Image)(resources.GetObject("btShowNewPass.Image")));
            this.btShowNewPass.Location = new System.Drawing.Point(331, 247);
            this.btShowNewPass.Name = "btShowNewPass";
            this.btShowNewPass.Size = new System.Drawing.Size(32, 20);
            this.btShowNewPass.TabIndex = 28;
            this.btShowNewPass.UseVisualStyleBackColor = true;
            this.btShowNewPass.Click += new System.EventHandler(this.btShowNewPass_Click);
            // 
            // btHienMKMoi
            // 
            this.btHienMKMoi.Image = ((System.Drawing.Image)(resources.GetObject("btHienMKMoi.Image")));
            this.btHienMKMoi.Location = new System.Drawing.Point(331, 201);
            this.btHienMKMoi.Name = "btHienMKMoi";
            this.btHienMKMoi.Size = new System.Drawing.Size(32, 19);
            this.btHienMKMoi.TabIndex = 30;
            this.btHienMKMoi.UseVisualStyleBackColor = true;
            this.btHienMKMoi.Click += new System.EventHandler(this.btHienMKMoi_Click);
            // 
            // btAnMKMoi
            // 
            this.btAnMKMoi.Image = ((System.Drawing.Image)(resources.GetObject("btAnMKMoi.Image")));
            this.btAnMKMoi.Location = new System.Drawing.Point(331, 201);
            this.btAnMKMoi.Name = "btAnMKMoi";
            this.btAnMKMoi.Size = new System.Drawing.Size(32, 19);
            this.btAnMKMoi.TabIndex = 29;
            this.btAnMKMoi.UseVisualStyleBackColor = true;
            this.btAnMKMoi.Click += new System.EventHandler(this.btAnMKMoi_Click);
            // 
            // btHienMK
            // 
            this.btHienMK.Image = ((System.Drawing.Image)(resources.GetObject("btHienMK.Image")));
            this.btHienMK.Location = new System.Drawing.Point(331, 154);
            this.btHienMK.Name = "btHienMK";
            this.btHienMK.Size = new System.Drawing.Size(32, 19);
            this.btHienMK.TabIndex = 32;
            this.btHienMK.UseVisualStyleBackColor = true;
            this.btHienMK.Click += new System.EventHandler(this.btHienMK_Click);
            // 
            // btAnMK
            // 
            this.btAnMK.Image = ((System.Drawing.Image)(resources.GetObject("btAnMK.Image")));
            this.btAnMK.Location = new System.Drawing.Point(331, 154);
            this.btAnMK.Name = "btAnMK";
            this.btAnMK.Size = new System.Drawing.Size(32, 19);
            this.btAnMK.TabIndex = 31;
            this.btAnMK.UseVisualStyleBackColor = true;
            this.btAnMK.Click += new System.EventHandler(this.btAnMK_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 371);
            this.Controls.Add(this.btHienMK);
            this.Controls.Add(this.btAnMK);
            this.Controls.Add(this.btHienMKMoi);
            this.Controls.Add(this.btAnMKMoi);
            this.Controls.Add(this.btShowNewPass);
            this.Controls.Add(this.btHideNewPass);
            this.Controls.Add(this.btThoatCN);
            this.Controls.Add(this.btCapNhatMK);
            this.Controls.Add(this.txtNhaplaiMK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHienThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btCapNhatMK;
        private System.Windows.Forms.TextBox txtNhaplaiMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox picThoat;
        private Guna.UI2.WinForms.Guna2Button btThoatCN;
        private System.Windows.Forms.Button btShowNewPass;
        private System.Windows.Forms.Button btHideNewPass;
        private System.Windows.Forms.Button btHienMK;
        private System.Windows.Forms.Button btAnMK;
        private System.Windows.Forms.Button btHienMKMoi;
        private System.Windows.Forms.Button btAnMKMoi;
    }
}