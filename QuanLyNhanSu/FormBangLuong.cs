using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormBangLuong : Form
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["XemChiTietLuong"].Index)
            {
                // Bạn có thể mở một cửa sổ chi tiết lương hoặc xử lý theo cách bạn muốn
                string maNhanVien = dataGridView1.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                MessageBox.Show($"Chi tiết lương của nhân viên {maNhanVien}");
            }
        }

        private void FormBangLuong_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Tạo DataTable giả lập dữ liệu
                DataTable dt = new DataTable();

                // Thêm cột vào DataTable
                dt.Columns.Add("MaNhanVien", typeof(string));
                dt.Columns.Add("HoTen", typeof(string));
                dt.Columns.Add("NgaySinh", typeof(string));
                dt.Columns.Add("GioiTinh", typeof(string));
                dt.Columns.Add("XemChiTietLuong", typeof(string));  // Cột Xem chi tiết lương
                dt.Columns.Add("MaBangLuong", typeof(string));     // Cột Mã Bảng Lương
                dt.Columns.Add("LuongCoBan", typeof(decimal));     // Cột Lương Cơ Bản
                dt.Columns.Add("Thuong", typeof(decimal));         // Cột Thưởng
                dt.Columns.Add("PhuCap", typeof(decimal));         // Cột Phụ Cấp
                dt.Columns.Add("TongLuong", typeof(decimal));      // Cột Tổng Lương
                dt.Columns.Add("NgayNhanLuong", typeof(string));   // Cột Ngày Nhận Lương

                // Thêm dữ liệu giả
                Random rand = new Random();
                for (int i = 1; i <= 100; i++)
                {
                    string maNV = $"NV{i:D4}";
                    string hoTen = $"Nhân Viên {i}";
                    string ngaySinh = "01/01/1990";  // Ngày sinh giả định
                    string gioiTinh = i % 2 == 0 ? "Nam" : "Nữ";  // Giới tính giả định

                    decimal luongCoBan = rand.Next(7000000, 15000000);  // Lương cơ bản ngẫu nhiên
                    decimal thuong = rand.Next(1000000, 3000000);        // Thưởng ngẫu nhiên
                    decimal phuCap = rand.Next(500000, 1500000);          // Phụ cấp ngẫu nhiên
                    decimal tongLuong = luongCoBan + thuong + phuCap;     // Tổng lương

                    // Ngày nhận lương giả định (ngày cuối tháng)
                    string ngayNhanLuong = DateTime.Now.ToString("dd/MM/yyyy");

                    // Mã bảng lương giả định theo mã nhân viên
                    string maBangLuong = "BL" + maNV.Substring(2);

                    // Thêm dòng vào bảng dữ liệu
                    dt.Rows.Add(maNV, hoTen, ngaySinh, gioiTinh, "Xem chi tiết", maBangLuong, luongCoBan, thuong, phuCap, tongLuong, ngayNhanLuong);
                }

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = dt;

                // Định dạng cột (tùy chỉnh nếu cần)
                dataGridView1.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
                dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dataGridView1.Columns["XemChiTietLuong"].HeaderText = "Xem Chi Tiết Lương";
                dataGridView1.Columns["MaBangLuong"].HeaderText = "Mã Bảng Lương";
                dataGridView1.Columns["LuongCoBan"].HeaderText = "Lương Cơ Bản";
                dataGridView1.Columns["Thuong"].HeaderText = "Thưởng";
                dataGridView1.Columns["PhuCap"].HeaderText = "Phụ Cấp";
                dataGridView1.Columns["TongLuong"].HeaderText = "Tổng Lương";
                dataGridView1.Columns["NgayNhanLuong"].HeaderText = "Ngày Nhận Lương";

                // Cấu hình kích thước cột để dễ nhìn
                dataGridView1.Columns["XemChiTietLuong"].Width = 150;
                dataGridView1.Columns["MaBangLuong"].Width = 100;
                dataGridView1.Columns["LuongCoBan"].Width = 120;
                dataGridView1.Columns["Thuong"].Width = 120;
                dataGridView1.Columns["PhuCap"].Width = 120;
                dataGridView1.Columns["TongLuong"].Width = 120;
                dataGridView1.Columns["NgayNhanLuong"].Width = 120;

                // Định dạng Lương Cơ Bản, Thưởng, Phụ Cấp, Tổng Lương với dấu phân cách hàng nghìn và thêm "đ" phía sau
                CultureInfo viVN = new CultureInfo("vi-VN");
                dataGridView1.Columns["LuongCoBan"].DefaultCellStyle.Format = "#,0 đ";
                dataGridView1.Columns["Thuong"].DefaultCellStyle.Format = "#,0 đ";
                dataGridView1.Columns["PhuCap"].DefaultCellStyle.Format = "#,0 đ";
                dataGridView1.Columns["TongLuong"].DefaultCellStyle.Format = "#,0 đ";
                dataGridView1.Columns["LuongCoBan"].DefaultCellStyle.FormatProvider = viVN;
                dataGridView1.Columns["Thuong"].DefaultCellStyle.FormatProvider = viVN;
                dataGridView1.Columns["PhuCap"].DefaultCellStyle.FormatProvider = viVN;
                dataGridView1.Columns["TongLuong"].DefaultCellStyle.FormatProvider = viVN;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            FormChamCong frmChamCong = new FormChamCong();
            frmChamCong.Show();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            FormNhanSu frmNhanSu= new FormNhanSu();
            frmNhanSu.Show();
        }

        private void ToolStripButtonDanhMuc_Click(object sender, EventArgs e)
        {
            FormDanhMuc frmDanhMuc = new FormDanhMuc();
            frmDanhMuc.Show();
        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {
            FormMain frmMain = new FormMain();
            frmMain.Show();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
