using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormDoiPassword : Form
    {
        public FormDoiPassword()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string currentPassword = "123456";
            string enteredCurrentPassword = txtMatKhauHienTai.Text;
            string newPassword = txtMatKhauMoi.Text;
            string confirmNewPassword = txtXacNhanMatKhauMoi.Text;

            if (enteredCurrentPassword != currentPassword)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            Application.OpenForms["FormMain"]?.Close(); 
            this.Close();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
