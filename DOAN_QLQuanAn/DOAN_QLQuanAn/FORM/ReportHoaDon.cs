using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DOAN_QLQuanAn.REPORT
{
    public partial class ReportHoaDon : Form
    {
        public ReportHoaDon(int khuyenMai) //Bill z, int km
        {
            InitializeComponent();

            numKhuyenMai.Value = khuyenMai;

            DateTime now = DateTime.Now;
            now = dateNow.Value;
            dateNow.Value = new DateTime(now.Year, now.Month, now.Day);
        }

        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            //    // TODO: This line of code loads data into the 'DoAn_QLTechCenterFoodDataSet.USP_GetListBillByTableName' table. You can move, or remove it, as needed.
            //    this.USP_GetListBillByTableNameTableAdapter.Fill(this.doAn_QLTechCenterFoodDataSet.USP_GetListBillByTableName);
            //    //this.reportViewer1.RefreshReport();
            //    this.reportViewer1.RefreshReport();
        }

        private void btRP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã số bàn cần in hóa đơn!!");
                }
                else
                {
                    //int rp = int.Parse(txtRP.Text);
                    //Code Report hóa đơn
                    this.hoaDonTTBanTableAdapter.Fill(this.doAn_QLTechCenterFoodDataSet3.HoaDonTTBan, txtRP.Text);
                    Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("tenBan",txtRP.Text),
                        new Microsoft.Reporting.WinForms.ReportParameter("Ngay",dateNow.Text),
                        new Microsoft.Reporting.WinForms.ReportParameter("khuyenMai",numKhuyenMai.Value.ToString())
                    };
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
