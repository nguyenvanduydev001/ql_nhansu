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
    public partial class FormChucNang : Form
    {
        private Timer timer;
        public FormChucNang()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormChucNang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain f  = new FormMain();
            f.Show();
        }

        private void ToolStripMenuItemTroGiup_Click(object sender, EventArgs e)
        {
            FormTroGiup f = new FormTroGiup();
            f.Show(); 
        }

        private void FormChucNang_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ToolStripButtonDanhMuc_Click(object sender, EventArgs e)
        {
            FormDanhMuc DanhMuc = new FormDanhMuc();
            DanhMuc.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            FormNhanSu nhanSu = new FormNhanSu();
            nhanSu.Show();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            FormBangLuong formBangLuong = new FormBangLuong();
            formBangLuong.Show();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            FormChamCong frmChamCong = new FormChamCong();
            frmChamCong.Show();
        }
    }
}
