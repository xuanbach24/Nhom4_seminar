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
    public partial class frm_DuAn : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-A5CIML19;Initial Catalog=QuanLyPhongBan;Integrated Security=True;Encrypt=False");

        public frm_DuAn()
        {
            InitializeComponent();
        }

        private void frm_DuAn_Load(object sender, EventArgs e)
        {
            loadgrid();
        }
        void loadgrid()
        {
            string cmd = "select* from duan";
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd, con);
            sa.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
