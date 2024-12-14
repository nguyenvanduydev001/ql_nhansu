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
    public partial class FormChamCong : Form
    {
        public FormChamCong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripButtonDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            // Tạo DataTable giả lập dữ liệu
            DataTable dt = new DataTable();

            // Thêm cột vào DataTable
            dt.Columns.Add("MaNhanVien", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("NgaySinh", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(string));
            dt.Columns.Add("T3 01/03", typeof(string));
            dt.Columns.Add("T4 02/03", typeof(string));
            dt.Columns.Add("T5 03/03", typeof(string));
            dt.Columns.Add("T6 04/03", typeof(string));
            dt.Columns.Add("T7 05/03", typeof(string));
            dt.Columns.Add("T8 06/03", typeof(string));
            dt.Columns.Add("T9 07/03", typeof(string));
            dt.Columns.Add("T10 08/03", typeof(string));
            dt.Columns.Add("T11 09/03", typeof(string));
            dt.Columns.Add("T12 10/03", typeof(string));
            dt.Columns.Add("T13 11/03", typeof(string));
            dt.Columns.Add("T14 12/03", typeof(string));
            dt.Columns.Add("T15 13/03", typeof(string));
            dt.Columns.Add("T16 14/03", typeof(string));
            dt.Columns.Add("T17 15/03", typeof(string));
            dt.Columns.Add("T18 16/03", typeof(string));
            dt.Columns.Add("T19 17/03", typeof(string));
            dt.Columns.Add("T20 18/03", typeof(string));
            dt.Columns.Add("T21 19/03", typeof(string));
            dt.Columns.Add("T22 20/03", typeof(string));
            dt.Columns.Add("T23 21/03", typeof(string));
            dt.Columns.Add("T24 22/03", typeof(string));
            dt.Columns.Add("T25 23/03", typeof(string));
            dt.Columns.Add("T26 24/03", typeof(string));
            dt.Columns.Add("T27 25/03", typeof(string));
            dt.Columns.Add("T28 26/03", typeof(string));
            dt.Columns.Add("T29 27/03", typeof(string));
            dt.Columns.Add("T30 28/03", typeof(string));


            // Thêm hàng dữ liệu giả
            dt.Rows.Add("NV0001", "Phạm Thị Bảy", "05/01/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0002", "Nguyễn Văn An", "10/03/1985", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0003", "Trần Thị C", "12/07/1993", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0004", "Lê Văn Dũng", "20/11/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0005", "Hoàng Thị Mai", "15/05/1988", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0006", "Nguyễn Văn Bình", "08/09/1992", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0007", "Phạm Thị Hoa", "25/12/1987", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0008", "Trần Văn Hòa", "15/04/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0009", "Lê Thị Hạnh", "05/07/1994", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0010", "Hoàng Văn Lộc", "10/10/1985", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0011", "Phạm Văn Khoa", "20/06/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0012", "Nguyễn Thị Lan", "22/11/1993", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0013", "Trần Văn Minh", "30/01/1986", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0014", "Lê Thị Ngọc", "13/02/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0015", "Hoàng Văn Tuấn", "19/05/1988", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0016", "Nguyễn Thị Thu", "06/03/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0017", "Phạm Văn Hải", "09/08/1992", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0018", "Trần Thị Hương", "12/12/1993", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0019", "Lê Văn Phú", "17/09/1985", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0020", "Hoàng Thị Thủy", "03/11/1987", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0021", "Nguyễn Văn Tài", "28/02/1994", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0022", "Phạm Thị Minh", "15/05/1989", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0023", "Trần Văn Nam", "23/07/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0024", "Lê Thị Diễm", "30/04/1988", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0025", "Hoàng Văn Sơn", "10/01/1986", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0026", "Nguyễn Thị Phương", "25/08/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0027", "Phạm Văn Đạt", "15/12/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0028", "Trần Thị Lý", "18/06/1993", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0029", "Lê Văn Khôi", "09/09/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0030", "Hoàng Thị Quỳnh", "04/11/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0031", "Nguyễn Văn Tiến", "11/03/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0032", "Phạm Thị Cúc", "16/07/1994", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0033", "Trần Văn Hùng", "27/02/1988", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0034", "Lê Thị Dung", "03/12/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0035", "Hoàng Văn Hưng", "20/05/1991", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0036", "Nguyễn Thị Oanh", "28/06/1986", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0037", "Phạm Văn Thịnh", "12/01/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0038", "Trần Thị Vân", "22/04/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0039", "Lê Văn Lâm", "06/09/1993", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0040", "Hoàng Thị Nguyệt", "10/10/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0041", "Nguyễn Văn Dương", "15/08/1988", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0042", "Phạm Thị Xuân", "27/07/1989", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0043", "Trần Văn Phong", "11/03/1985", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0044", "Lê Thị Mỹ", "19/06/1994", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0045", "Hoàng Văn Thanh", "22/02/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0046", "Nguyễn Thị Hà", "13/08/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0047", "Phạm Văn Tâm", "05/12/1986", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0048", "Trần Thị Thanh", "20/04/1993", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0049", "Lê Văn Quang", "08/07/1985", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0050", "Hoàng Thị Đào", "16/11/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0051", "Nguyễn Văn Vỹ", "09/09/1991", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0052", "Phạm Thị Điệp", "12/03/1989", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0053", "Trần Văn Kiên", "19/05/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0054", "Lê Thị Lan", "24/07/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0055", "Hoàng Văn Đức", "17/12/1993", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0056", "Nguyễn Thị Hương", "05/02/1988", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0057", "Phạm Văn Lâm", "20/01/1992", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0058", "Trần Thị Tươi", "09/03/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0059", "Lê Văn Quốc", "13/04/1991", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0060", "Hoàng Thị Giang", "11/09/1994", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0061", "Nguyễn Văn Thảo", "07/06/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0062", "Phạm Thị Thương", "25/08/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0063", "Trần Văn Đạo", "30/11/1986", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0064", "Lê Thị Thanh", "23/01/1987", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0065", "Hoàng Văn Hưng", "29/04/1988", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0066", "Nguyễn Thị Tâm", "03/09/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0067", "Phạm Văn Hải", "12/06/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0068", "Trần Thị Yến", "16/07/1993", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0069", "Lê Văn Đường", "05/01/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0070", "Hoàng Thị Trâm", "18/10/1987", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0071", "Nguyễn Văn Đạt", "21/02/1994", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0072", "Phạm Thị Diễm", "15/03/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0073", "Trần Văn Minh", "12/07/1988", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0074", "Lê Thị Minh", "24/06/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0075", "Hoàng Văn Thế", "09/12/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0076", "Nguyễn Thị Kim", "30/09/1986", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0077", "Phạm Văn Thịnh", "06/04/1993", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0078", "Trần Thị Mai", "02/08/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0079", "Lê Văn Hải", "11/02/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0080", "Hoàng Thị Nhung", "03/01/1994", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0081", "Nguyễn Văn Khánh", "17/05/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0082", "Phạm Thị Đoan", "24/07/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0083", "Trần Văn Quân", "28/09/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0084", "Lê Thị Bình", "09/11/1989", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0085", "Hoàng Văn Tuấn", "22/01/1991", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0086", "Nguyễn Thị Lan", "19/06/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0087", "Phạm Văn Quý", "04/03/1988", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0088", "Trần Thị Minh", "12/12/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0089", "Lê Văn Duy", "25/09/1993", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0090", "Hoàng Thị Lâm", "05/04/1987", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0091", "Nguyễn Văn Hoài", "11/10/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0092", "Phạm Thị Mộng", "17/07/1991", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0093", "Trần Văn Thái", "02/08/1990", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0094", "Lê Thị Nữ", "14/03/1992", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0095", "Hoàng Văn Kinh", "21/05/1986", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0096", "Nguyễn Thị Quý", "10/06/1990", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0097", "Phạm Văn Tiến", "12/11/1987", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0098", "Trần Thị Hoa", "18/01/1994", "Nữ", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0099", "Lê Văn Bảo", "29/08/1989", "Nam", "+", "+", "+", "+", "+");
            dt.Rows.Add("NV0100", "Hoàng Thị Vân", "15/02/1993", "Nữ", "+", "+", "+", "+", "+");


            // Gắn dữ liệu vào DataGridView
            dataGridView1.DataSource = dt;

            // Định dạng cột (tùy chỉnh nếu cần)
            dataGridView1.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void copyToolStripButton_Click_1(object sender, EventArgs e)
        {
            FormBangLuong frmBangLuong = new FormBangLuong();
            frmBangLuong.Show();
        }

        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            FormNhanSu frmNhanSu= new FormNhanSu();
            frmNhanSu.Show();
        }

        private void ToolStripButtonDanhMuc_Click_1(object sender, EventArgs e)
        {
            FormDanhMuc frmDanhMuc = new FormDanhMuc();
            frmDanhMuc.Show();
        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {
            FormMain frmMain = new FormMain();
            frmMain.Show();
        }
    }
}
