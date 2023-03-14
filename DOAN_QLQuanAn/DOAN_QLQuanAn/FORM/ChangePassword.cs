using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_QLQuanAn.DAO;
using DOAN_QLQuanAn.DTO;

namespace DOAN_QLQuanAn
{
    public partial class ChangePassword : Form
    {
        public ChangePassword(string tenDangnhap, string tenHienThi)
        {
            InitializeComponent();
            txtTenDangNhap.Text = tenDangnhap;
            txtTenHienThi.Text = tenHienThi;
        }

        void ResetPass(string userName, string passWord)
        {
            if (AccountDAO.Instance.ResetPassword(userName, passWord))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công.");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại.");
            }
        }

        private void btCapNhatMK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTenDangNhap.Text;
                string displayName = txtTenHienThi.Text;
                string password = txtMKCu.Text;
                string newPassWord = txtMKMoi.Text;
                string reenterPass = txtNhaplaiMK.Text;

                if (!newPassWord.Equals(reenterPass))
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
                }
                else
                {
                    if (AccountDAO.Instance.UpdatePassWordAccount(userName, displayName, password, newPassWord))
                    {
                        ResetPass(userName, newPassWord);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đúng mật khấu");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btThoatCN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btHienMK_Click(object sender, EventArgs e)
        {
            if (txtMKCu.PasswordChar == '*')
            {
                btAnMK.BringToFront();
                txtMKCu.PasswordChar = '\0';
            }
        }

        private void btAnMK_Click(object sender, EventArgs e)
        {
            if (txtMKCu.PasswordChar == '\0')
            {
                btHienMK.BringToFront();
                txtMKCu.PasswordChar = '*';
            }
        }

        private void btHienMKMoi_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.PasswordChar == '*')
            {
                btAnMKMoi.BringToFront();
                txtMKMoi.PasswordChar = '\0';
            }
        }

        private void btAnMKMoi_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.PasswordChar == '\0')
            {
                btHienMKMoi.BringToFront();
                txtMKMoi.PasswordChar = '*';
            }
        }

        private void btHideNewPass_Click(object sender, EventArgs e)
        {
            if (txtNhaplaiMK.PasswordChar == '\0')
            {
                btShowNewPass.BringToFront();
                txtNhaplaiMK.PasswordChar = '*';
            }
        }

        private void btShowNewPass_Click(object sender, EventArgs e)
        {
            if (txtNhaplaiMK.PasswordChar == '*')
            {
                btHideNewPass.BringToFront();
                txtNhaplaiMK.PasswordChar = '\0';
            }
        }
    }
}
