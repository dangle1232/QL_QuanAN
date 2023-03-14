namespace DOAN_QLQuanAn.REPORT
{
    partial class ReportHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportHoaDon));
            this.hoaDonTTBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAn_QLTechCenterFoodDataSet3 = new DOAN_QLQuanAn.DoAn_QLTechCenterFoodDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtRP = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRP = new System.Windows.Forms.Button();
            this.numKhuyenMai = new System.Windows.Forms.NumericUpDown();
            this.hoaDonTTBanTableAdapter = new DOAN_QLQuanAn.DoAn_QLTechCenterFoodDataSet3TableAdapters.HoaDonTTBanTableAdapter();
            this.dateNow = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn_QLTechCenterFoodDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonTTBanBindingSource
            // 
            this.hoaDonTTBanBindingSource.DataMember = "HoaDonTTBan";
            this.hoaDonTTBanBindingSource.DataSource = this.doAn_QLTechCenterFoodDataSet3;
            // 
            // doAn_QLTechCenterFoodDataSet3
            // 
            this.doAn_QLTechCenterFoodDataSet3.DataSetName = "DoAn_QLTechCenterFoodDataSet3";
            this.doAn_QLTechCenterFoodDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource8.Name = "DataSetInHoaDon";
            reportDataSource8.Value = this.hoaDonTTBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_QLQuanAn.REPORT.reportHoaDonTT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(456, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtRP
            // 
            this.txtRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRP.Location = new System.Drawing.Point(164, 19);
            this.txtRP.Margin = new System.Windows.Forms.Padding(2);
            this.txtRP.Name = "txtRP";
            this.txtRP.Size = new System.Drawing.Size(136, 22);
            this.txtRP.TabIndex = 7;
            this.txtRP.Text = "Bàn ";
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(149, 330);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(128, 22);
            this.txtNgay.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập tên bàn: ";
            // 
            // btRP
            // 
            this.btRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRP.Image = ((System.Drawing.Image)(resources.GetObject("btRP.Image")));
            this.btRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRP.Location = new System.Drawing.Point(319, 15);
            this.btRP.Margin = new System.Windows.Forms.Padding(2);
            this.btRP.Name = "btRP";
            this.btRP.Size = new System.Drawing.Size(100, 29);
            this.btRP.TabIndex = 8;
            this.btRP.Text = "In hóa đơn";
            this.btRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRP.UseVisualStyleBackColor = true;
            this.btRP.Click += new System.EventHandler(this.btRP_Click);
            // 
            // numKhuyenMai
            // 
            this.numKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKhuyenMai.Location = new System.Drawing.Point(239, 192);
            this.numKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.numKhuyenMai.Name = "numKhuyenMai";
            this.numKhuyenMai.Size = new System.Drawing.Size(38, 22);
            this.numKhuyenMai.TabIndex = 11;
            // 
            // hoaDonTTBanTableAdapter
            // 
            this.hoaDonTTBanTableAdapter.ClearBeforeFill = true;
            // 
            // dateNow
            // 
            this.dateNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNow.CustomFormat = "dd/MM/yyyy";
            this.dateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNow.Location = new System.Drawing.Point(161, 218);
            this.dateNow.Margin = new System.Windows.Forms.Padding(2);
            this.dateNow.Name = "dateNow";
            this.dateNow.Size = new System.Drawing.Size(128, 24);
            this.dateNow.TabIndex = 12;
            this.dateNow.Value = new System.DateTime(2022, 10, 14, 0, 0, 0, 0);
            // 
            // ReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 614);
            this.Controls.Add(this.txtRP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRP);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateNow);
            this.Controls.Add(this.numKhuyenMai);
            this.Controls.Add(this.txtNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.ReportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonTTBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn_QLTechCenterFoodDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtRP;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRP;
        private System.Windows.Forms.NumericUpDown numKhuyenMai;
        private System.Windows.Forms.BindingSource hoaDonTTBanBindingSource;
        private DoAn_QLTechCenterFoodDataSet3 doAn_QLTechCenterFoodDataSet3;
        private DoAn_QLTechCenterFoodDataSet3TableAdapters.HoaDonTTBanTableAdapter hoaDonTTBanTableAdapter;
        private System.Windows.Forms.DateTimePicker dateNow;
    }
}