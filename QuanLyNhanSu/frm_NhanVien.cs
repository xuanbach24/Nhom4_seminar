using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{

    public partial class frm_NhanVien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5CIML19;Initial Catalog=QuanLyPhongBan;Integrated Security=True;Encrypt=False");

        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            loadgrid();
            loadbieudo();
        }

        public void loadbieudo()
        {
            // Xóa các series hiện có trong biểu đồ
            bieudocot.Series.Clear();

            // Tạo series cho biểu đồ cột
            Series series = new Series("Số Lượng Nhân Viên", ViewType.Bar);

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu số lượng nhân viên theo khoảng thời gian làm việc
            string query = @"
        SELECT 
            SUM(CASE WHEN DATEDIFF(YEAR, NgayThue, GETDATE()) < 1 THEN 1 ELSE 0 END) AS Duoi1Nam,
            SUM(CASE WHEN DATEDIFF(YEAR, NgayThue, GETDATE()) BETWEEN 1 AND 3 THEN 1 ELSE 0 END) AS Tu1Den3Nam,
            SUM(CASE WHEN DATEDIFF(YEAR, NgayThue, GETDATE()) BETWEEN 3 AND 5 THEN 1 ELSE 0 END) AS Tu3Den5Nam,
            SUM(CASE WHEN DATEDIFF(YEAR, NgayThue, GETDATE()) > 5 THEN 1 ELSE 0 END) AS Tren5Nam
        FROM NhanVien;";

            DataTable result = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(result); // Đổ dữ liệu vào DataTable

            // Thêm dữ liệu vào series
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                // Thêm các điểm vào series cho từng khoảng thời gian
                series.Points.Add(new SeriesPoint("Dưới 1 năm", Convert.ToInt32(row["Duoi1Nam"])));
                series.Points.Add(new SeriesPoint("Từ 1 đến 3 năm", Convert.ToInt32(row["Tu1Den3Nam"])));
                series.Points.Add(new SeriesPoint("Từ 3 đến 5 năm", Convert.ToInt32(row["Tu3Den5Nam"])));
                series.Points.Add(new SeriesPoint("Trên 5 năm", Convert.ToInt32(row["Tren5Nam"])));
            }

            // Thêm series vào biểu đồ
            bieudocot.Series.Add(series);

            // Thiết lập định dạng cho nhãn
            series.Label.TextPattern = "{A}: {V}";

            // Tùy chỉnh các thuộc tính khác của biểu đồ nếu cần
            // Ví dụ: thiết lập tiêu đề
            bieudocot.Titles.Clear();
            bieudocot.Titles.Add(new ChartTitle { Text = "Số Lượng Nhân Viên Theo Thời Gian Làm Việc" });
        }
        void loadgrid()
        {
            string cmd = "select* from NhanVien";
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd, con);
            sa.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
