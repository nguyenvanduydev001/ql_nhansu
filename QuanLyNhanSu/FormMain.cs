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
    public partial class FormMain : Form
    {
        private Timer timer;
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick; 
            timer.Start(); 
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ToolStripMenuItemDangXuat_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Hide();
        }

        private void ToolStripMenuItemDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormDoiPassword formDoiPassword = new FormDoiPassword();
            formDoiPassword.ShowDialog();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ToolStripMenuItemChuNang_Click(object sender, EventArgs e)
        {
            FormChucNang f = new FormChucNang();
            f.Show();
        }

        private void ToolStripMenuItemTroGiup_Click(object sender, EventArgs e)
        {
            FormTroGiup f = new FormTroGiup();
            f.Show();
        }

        private void toolStripButtonThietLap_Click(object sender, EventArgs e)
        {
            FormThietLap f = new FormThietLap();
            f.Show();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
