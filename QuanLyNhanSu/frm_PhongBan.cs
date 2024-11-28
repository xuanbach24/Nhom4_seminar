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
    public partial class frm_PhongBan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5CIML19;Initial Catalog=QuanLyPhongBan;Integrated Security=True;Encrypt=False");
        public frm_PhongBan()
        {
            InitializeComponent();
        }

        private void frm_PhongBan_Load(object sender, EventArgs e)
        {
            loadgrid();
            loadChart();
        }

        public void loadChart()
        {
            bieudotron.Series.Clear();
            con.Open();
            // Tạo series cho biểu đồ tròn
            Series series = new Series("Số Lượng Nhân Viên Trong Phòng Ban", ViewType.Pie);

            // Kết nối đến cơ sở dữ liệu và lấy dữ liệu số lượng nhân viên theo phòng ban
            string query = "SELECT pb.TenPhongBan, COUNT(nv.MaNhanVien) AS SoLuongNhanVien " +
                           "FROM PhongBan pb " +
                           "LEFT JOIN NhanVien nv ON pb.MaPhongBan = nv.MaPhongBan " +
                           "GROUP BY pb.TenPhongBan";

            DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt); // Đổ dữ liệu vào DataTable

            // Thêm dữ liệu vào series
            foreach (DataRow row in dt.Rows)
            {
                string tenPhongBan = row["TenPhongBan"].ToString();
                int soLuongNhanVien = Convert.ToInt32(row["SoLuongNhanVien"]);

                series.Points.Add(new SeriesPoint(tenPhongBan, soLuongNhanVien));
            }

            // Thêm series vào biểu đồ
            bieudotron.Series.Add(series);

            // Thiết lập định dạng cho nhãn
            series.Label.TextPattern = "{A}: {VP: p0}";
            con.Close();
        }
        void loadgrid()
        {
            string cmd = "select* from phongban";
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd,con);
            sa.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
