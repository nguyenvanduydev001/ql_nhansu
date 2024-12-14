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
    public partial class FormDanhMuc : Form
    {
        private Timer timer;
        public FormDanhMuc()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormDanhMuc_Load_1(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {
            FormMain Main = new FormMain();
            Main.Show();
        }

        private void ToolStripMenuItemTroGiup_Click(object sender, EventArgs e)
        {
            FormChucNang ChucNang = new FormChucNang();
            ChucNang.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            FormNhanSu Nhansu = new FormNhanSu();
            Nhansu.Show();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            FormChamCong frmChamCong = new FormChamCong();
            frmChamCong.Show();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            FormBangLuong frmBangLuong = new FormBangLuong();
            frmBangLuong.Show();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
