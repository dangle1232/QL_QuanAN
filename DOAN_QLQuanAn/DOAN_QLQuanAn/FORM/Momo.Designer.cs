
namespace DOAN_QLQuanAn
{
    partial class Momo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Momo));
            this.Payment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.btTaoQR = new System.Windows.Forms.Button();
            this.picMomo = new System.Windows.Forms.PictureBox();
            this.btHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMomo)).BeginInit();
            this.SuspendLayout();
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.ForeColor = System.Drawing.Color.Black;
            this.Payment.Location = new System.Drawing.Point(292, 26);
            this.Payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(172, 13);
            this.Payment.TabIndex = 10;
            this.Payment.Text = "Quét mã QR MoMo để thanh toán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SDT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số tiền:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(107, 84);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(152, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(107, 124);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(152, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(107, 168);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 20);
            this.txtMail.TabIndex = 4;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(107, 213);
            this.txtTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(152, 20);
            this.txtTien.TabIndex = 0;
            // 
            // btTaoQR
            // 
            this.btTaoQR.BackColor = System.Drawing.Color.White;
            this.btTaoQR.FlatAppearance.BorderSize = 0;
            this.btTaoQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTaoQR.Location = new System.Drawing.Point(184, 258);
            this.btTaoQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTaoQR.Name = "btTaoQR";
            this.btTaoQR.Size = new System.Drawing.Size(74, 32);
            this.btTaoQR.TabIndex = 1;
            this.btTaoQR.Text = "Tạo mã";
            this.btTaoQR.UseVisualStyleBackColor = false;
            this.btTaoQR.Click += new System.EventHandler(this.btTaoQR_Click);
            // 
            // picMomo
            // 
            this.picMomo.BackColor = System.Drawing.Color.Transparent;
            this.picMomo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMomo.Image = global::DOAN_QLQuanAn.Properties.Resources.MoMo_Logo;
            this.picMomo.Location = new System.Drawing.Point(295, 54);
            this.picMomo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMomo.Name = "picMomo";
            this.picMomo.Size = new System.Drawing.Size(253, 258);
            this.picMomo.TabIndex = 9;
            this.picMomo.TabStop = false;
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.White;
            this.btHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btHelp.FlatAppearance.BorderSize = 0;
            this.btHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelp.Image = ((System.Drawing.Image)(resources.GetObject("btHelp.Image")));
            this.btHelp.Location = new System.Drawing.Point(-2, 2);
            this.btHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(66, 28);
            this.btHelp.TabIndex = 11;
            this.btHelp.Text = "Help";
            this.btHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // Momo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btTaoQR);
            this.Controls.Add(this.picMomo);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Payment);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Momo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Momo";
            this.Load += new System.EventHandler(this.Momo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMomo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.PictureBox picMomo;
        private System.Windows.Forms.Button btTaoQR;
        private System.Windows.Forms.Button btHelp;
    }
}