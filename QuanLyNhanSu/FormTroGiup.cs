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
    public partial class FormTroGiup : Form
    {
        private Timer timer;
        public FormTroGiup()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
        }

        private void ToolStripMenuItemChuNang_Click(object sender, EventArgs e)
        {
            FormChucNang f = new FormChucNang();
            f.Show(); 
        }

        private void FormTroGiup_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
