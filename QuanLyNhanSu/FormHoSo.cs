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
    public partial class FormHoSo : Form
    {
        public FormHoSo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetData(string maNV, string tenNV, string ngaySinh, string gioiTinh, string soCCCD, string chucVu, string donVi, string trangThai)
        {
            lblMaNV.Text = maNV;       
            lblTenNV.Text = tenNV;    
            lblNgaySinh.Text = ngaySinh; 
            lblGioiTinh.Text = gioiTinh; 
            lblSoCCCD.Text = soCCCD;   
            lblChucVu.Text = chucVu;   
            lblDonVi.Text = donVi;     
            lblTrangThai.Text = trangThai; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormChamCong frmtl = new FormChamCong();
            frmtl.ShowDialog();
        }
    }
}
