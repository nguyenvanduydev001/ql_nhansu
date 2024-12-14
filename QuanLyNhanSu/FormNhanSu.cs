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
    public partial class FormNhanSu : Form
    {
        private Timer timer;
        public FormNhanSu()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void FormNhanSu_Load(object sender, EventArgs e)
        {
            //dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Rows.Add("NV00001", "Phạm Thị Bảy", "05/01/1991", "Nữ", "123456789", "Kế toán viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00002", "Nguyễn Văn A", "10/03/1985", "Nam", "987654321", "Trưởng phòng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00003", "Trần Thị C", "12/07/1993", "Nữ", "456123789", "Nhân viên IT", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00004", "Lê Văn D", "01/02/1990", "Nam", "741852963", "Kỹ sư", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00005", "Nguyễn Thị E", "23/05/1995", "Nữ", "852963741", "Nhân sự", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00006", "Đặng Văn F", "18/08/1987", "Nam", "159753456", "Trợ lý", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00007", "Võ Thị G", "30/09/1992", "Nữ", "963852741", "Thư ký", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00008", "Bùi Văn H", "15/06/1986", "Nam", "258369147", "Nhân viên kho", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00009", "Hoàng Thị I", "01/11/1994", "Nữ", "369852147", "Kỹ thuật viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00010", "Nguyễn Văn K", "28/12/1980", "Nam", "147258369", "Giám đốc", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00011", "Trần Văn L", "07/04/1993", "Nam", "951753258", "Nhân viên bán hàng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00012", "Lê Thị M", "12/09/1988", "Nữ", "123789456", "Nhân viên lễ tân", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00013", "Phạm Văn N", "19/03/1990", "Nam", "789456123", "Bảo vệ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00014", "Đinh Thị O", "22/06/1997", "Nữ", "456789123", "Quản lý dự án", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00015", "Lý Văn P", "08/02/1983", "Nam", "741369852", "Kỹ sư xây dựng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00016", "Nguyễn Thị Q", "17/08/1991", "Nữ", "963147258", "Chuyên viên marketing", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00017", "Vũ Văn R", "05/11/1984", "Nam", "852741963", "Nhân viên kinh doanh", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00018", "Đặng Thị S", "25/07/1996", "Nữ", "258147369", "Thủ kho", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00019", "Nguyễn Văn T", "30/10/1985", "Nam", "951852753", "Tài xế", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00020", "Hoàng Thị U", "06/01/1990", "Nữ", "753951456", "Kế toán", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00021", "Nguyễn Văn An", "11/12/1991", "Nam", "123456721", "Nhân viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00022", "Phạm Thị Bình", "23/07/1992", "Nữ", "123456722", "Kỹ sư", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00023", "Trần Văn C", "15/08/1993", "Nam", "123456723", "Nhân viên IT", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00024", "Nguyễn Thị D", "09/09/1994", "Nữ", "123456724", "Trưởng phòng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00025", "Lê Văn E", "12/10/1995", "Nam", "123456725", "Kế toán viên", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00026", "Bùi Thị F", "07/11/1996", "Nữ", "123456726", "Thư ký", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00027", "Nguyễn Văn G", "03/05/1997", "Nam", "123456727", "Lao động phổ thông", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00028", "Đặng Thị H", "14/06/1998", "Nữ", "123456728", "Nhân viên kế toán", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00029", "Lý Văn I", "01/01/1999", "Nam", "123456729", "Trưởng nhóm", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00030", "Ngô Thị K", "19/03/1990", "Nữ", "123456730", "Giám đốc", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00031", "Nguyễn Văn L", "11/02/1989", "Nam", "123456731", "Kỹ thuật viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00032", "Phạm Văn M", "05/04/1988", "Nam", "123456732", "Nhân viên kỹ thuật", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00033", "Nguyễn Thị N", "13/12/1987", "Nữ", "123456733", "Quản lý", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00034", "Bùi Thị O", "25/06/1986", "Nữ", "123456734", "Kỹ sư xây dựng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00035", "Võ Văn P", "30/07/1985", "Nam", "123456735", "Nhân viên hành chính", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00036", "Nguyễn Thị Q", "20/05/1984", "Nữ", "123456736", "Kế toán trưởng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00037", "Phạm Văn R", "09/08/1983", "Nam", "123456737", "Thư ký trưởng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00038", "Lê Thị S", "28/02/1982", "Nữ", "123456738", "Nhân viên văn phòng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00039", "Nguyễn Văn T", "31/03/1981", "Nam", "123456739", "Trưởng phòng kỹ thuật", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00040", "Bùi Thị U", "15/10/1980", "Nữ", "123456740", "Kỹ sư môi trường", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00041", "Phạm Văn V", "12/09/1990", "Nam", "123456741", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00042", "Nguyễn Thị W", "18/08/1991", "Nữ", "123456742", "Kỹ thuật viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00043", "Trần Văn X", "20/10/1992", "Nam", "123456743", "Kỹ sư", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00044", "Lê Thị Y", "11/12/1993", "Nữ", "123456744", "Nhân viên IT", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00045", "Ngô Văn Z", "22/01/1994", "Nam", "123456745", "Nhân viên kế toán", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00046", "Phan Thị A1", "09/02/1995", "Nữ", "123456746", "Thư ký", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00047", "Bùi Văn B1", "13/03/1996", "Nam", "123456747", "Trưởng nhóm", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00048", "Đặng Thị C1", "25/04/1997", "Nữ", "123456748", "Kỹ sư điện", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00049", "Nguyễn Văn D1", "31/05/1998", "Nam", "123456749", "Nhân viên kỹ thuật", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00050", "Trần Thị E1", "19/06/1999", "Nữ", "123456750", "Giám đốc", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00051", "Phạm Văn F1", "10/07/1990", "Nam", "123456751", "Nhân viên hành chính", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00052", "Nguyễn Thị G1", "08/08/1991", "Nữ", "123456752", "Kế toán trưởng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00053", "Trần Văn H1", "22/09/1992", "Nam", "123456753", "Thư ký trưởng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00054", "Lê Thị I1", "16/10/1993", "Nữ", "123456754", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00055", "Ngô Văn J1", "11/11/1994", "Nam", "123456755", "Kỹ sư môi trường", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00056", "Phan Thị K1", "30/12/1995", "Nữ", "123456756", "Nhân viên kế toán", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00057", "Bùi Văn L1", "01/01/1996", "Nam", "123456757", "Trưởng phòng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00058", "Đặng Thị M1", "15/02/1997", "Nữ", "123456758", "Kỹ thuật viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00059", "Nguyễn Văn N1", "03/03/1998", "Nam", "123456759", "Kỹ sư xây dựng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00060", "Trần Thị O1", "19/04/1999", "Nữ", "123456760", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00061", "Lê Văn P1", "01/06/1990", "Nam", "123456761", "Nhân viên kỹ thuật", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00062", "Phạm Thị Q1", "12/07/1991", "Nữ", "123456762", "Kế toán viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00063", "Ngô Văn R1", "23/08/1992", "Nam", "123456763", "Nhân viên IT", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00064", "Trần Thị S1", "14/09/1993", "Nữ", "123456764", "Thư ký", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00065", "Nguyễn Văn T1", "05/10/1994", "Nam", "123456765", "Kỹ sư môi trường", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00066", "Bùi Thị U1", "16/11/1995", "Nữ", "123456766", "Nhân viên hành chính", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00067", "Phan Văn V1", "27/12/1996", "Nam", "123456767", "Trưởng phòng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00068", "Đặng Thị W1", "18/01/1997", "Nữ", "123456768", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00069", "Lê Văn X1", "09/02/1998", "Nam", "123456769", "Kỹ sư xây dựng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00070", "Phạm Thị Y1", "20/03/1999", "Nữ", "123456770", "Giám đốc", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00071", "Ngô Văn Z1", "10/04/1990", "Nam", "123456771", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00072", "Nguyễn Thị A2", "22/05/1991", "Nữ", "123456772", "Kỹ thuật viên", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00073", "Trần Văn B2", "14/06/1992", "Nam", "123456773", "Nhân viên IT", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00074", "Lê Thị C2", "06/07/1993", "Nữ", "123456774", "Kế toán trưởng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00075", "Nguyễn Văn D2", "18/08/1994", "Nam", "123456775", "Nhân viên kỹ thuật", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00076", "Bùi Thị E2", "10/09/1995", "Nữ", "123456776", "Thư ký trưởng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00077", "Phan Văn F2", "02/10/1996", "Nam", "123456777", "Kỹ thuật viên", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00078", "Đặng Thị G2", "14/11/1997", "Nữ", "123456778", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00079", "Lê Văn H2", "06/12/1998", "Nam", "123456779", "Kỹ sư xây dựng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00080", "Phạm Thị I2", "28/01/1999", "Nữ", "123456780", "Giám đốc", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00081", "Ngô Văn J2", "10/02/1990", "Nam", "123456781", "Trưởng phòng", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00082", "Nguyễn Thị K2", "22/03/1991", "Nữ", "123456782", "Nhân viên hành chính", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00083", "Trần Văn L2", "14/04/1992", "Nam", "123456783", "Nhân viên IT", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00084", "Lê Thị M2", "06/05/1993", "Nữ", "123456784", "Kế toán viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00085", "Nguyễn Văn N2", "18/06/1994", "Nam", "123456785", "Thư ký", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00086", "Bùi Thị O2", "10/07/1995", "Nữ", "123456786", "Nhân viên kỹ thuật", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00087", "Phan Văn P2", "02/08/1996", "Nam", "123456787", "Trưởng nhóm", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00088", "Đặng Thị Q2", "14/09/1997", "Nữ", "123456788", "Kỹ sư môi trường", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00089", "Lê Văn R2", "06/10/1998", "Nam", "123456789", "Giám đốc", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00090", "Phạm Thị S2", "28/11/1999", "Nữ", "123456790", "Nhân viên IT", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00091", "Ngô Văn T2", "10/12/1990", "Nam", "123456791", "Kỹ thuật viên", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00092", "Nguyễn Thị U2", "22/01/1991", "Nữ", "123456792", "Kế toán viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00093", "Trần Văn V2", "14/02/1992", "Nam", "123456793", "Nhân viên hành chính", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00094", "Lê Thị W2", "06/03/1993", "Nữ", "123456794", "Nhân viên hỗ trợ", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00095", "Nguyễn Văn X2", "18/04/1994", "Nam", "123456795", "Thư ký", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00096", "Bùi Thị Y2", "10/05/1995", "Nữ", "123456796", "Kỹ sư xây dựng", "CTY FPT HRM", "Đã Nghỉ Việc");
            dataGridView2.Rows.Add("NV00097", "Phan Văn Z2", "02/06/1996", "Nam", "123456797", "Nhân viên IT", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00098", "Đặng Thị A3", "14/07/1997", "Nữ", "123456798", "Kỹ sư môi trường", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00099", "Lê Văn B3", "06/08/1998", "Nam", "123456799", "Kế toán viên", "CTY FPT HRM", "Đang Làm Việc");
            dataGridView2.Rows.Add("NV00100", "Phạm Thị C3", "28/09/1999", "Nữ", "123456800", "Giám đốc", "CTY FPT HRM", "Đang Làm Việc");
        }

        private void ToolStripMenuItemHeThong_Click(object sender, EventArgs e)
        {
            FormMain frmMain = new FormMain();
            frmMain.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ToolStripButtonDanhMuc_Click(object sender, EventArgs e)
        {
            FormDanhMuc frmDanhMuc = new FormDanhMuc();
            frmDanhMuc.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ không
            if (e.RowIndex >= 0) // Đảm bảo không click vào header
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                string maNV = selectedRow.Cells[0].Value?.ToString();
                string tenNV = selectedRow.Cells[1].Value?.ToString();
                string ngaySinh = selectedRow.Cells[2].Value?.ToString();
                string gioiTinh = selectedRow.Cells[3].Value?.ToString();
                string soCCCD = selectedRow.Cells[4].Value?.ToString();
                string chucVu = selectedRow.Cells[5].Value?.ToString();
                string donVi = selectedRow.Cells[6].Value?.ToString();
                string trangThai = selectedRow.Cells[7].Value?.ToString();

                // Khởi tạo và truyền dữ liệu vào FormHoSo
                FormHoSo formHoSo = new FormHoSo();
                formHoSo.Text = $"Hồ sơ nhân viên - {tenNV}";
                formHoSo.SetData(maNV, tenNV, ngaySinh, gioiTinh, soCCCD, chucVu, donVi, trangThai); // Gọi hàm truyền dữ liệu (bạn tự định nghĩa)

                // Hiển thị FormHoSo
                formHoSo.ShowDialog();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            FormBangLuong frmBangLuong = new FormBangLuong();
            frmBangLuong.Show();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            FormChamCong frmChamCong = new FormChamCong();
            frmChamCong.Show();
        }
    }
}
