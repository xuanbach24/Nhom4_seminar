using DevExpress.XtraBars;
using DevExpress.XtraRichEdit;
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
    public partial class frm_ribbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        frm_BieuMau frm_BieuMau1;
        public frm_ribbon()
        {
            InitializeComponent();
            btn_xuatbieumau.Enabled = false;
        }

        void openForm(Type typeform)
        {
            foreach(Form frm in MdiChildren)
            {
                if(frm.GetType() == typeform)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f=(Form) Activator.CreateInstance(typeform);
            f.MdiParent = this;
            f.Show();
            btn_xuatbieumau.Enabled = false;

        }
        private void btn_phongban_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frm_PhongBan));
        }

        private void btn_nhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frm_NhanVien));

        }

        private void btn_duan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frm_DuAn));

        }

        private void btn_phutrach_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frm_phutrach));

        }

        private void btn_BieuMau_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frm_BieuMau));
            btn_xuatbieumau.Enabled = true;

        }

        private void btn_xuatbieumau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_BieuMau1.btn_luu_Click(frm_BieuMau1.btn_luu, EventArgs.Empty);
        }
    }
}