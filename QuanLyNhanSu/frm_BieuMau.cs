using DevExpress.XtraRichEdit;
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frm_BieuMau : Form
    {
        public frm_BieuMau()
        {
            InitializeComponent();
            SetupRichEditControl();
        }
        private void SetupRichEditControl()
        {
            richEditControl1.Dock = DockStyle.Fill; // Đảm bảo chiếm toàn bộ không gian
        }

        private void frm_BieuMau_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\xuanb\TL Nam2\CN .NET\QuanLyNhanSu\don-xin-nghi-thai-san.doc";

            try
            {
                // Tải tài liệu vào RichEditControl
                richEditControl1.LoadDocument(filePath, DocumentFormat.OpenXml);
                MessageBox.Show("Tài liệu đã được tự động tải thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải tài liệu: " + ex.Message);
            }
        }

        public void btn_luu_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx|Rich Text Format (*.rtf)|*.rtf|PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Lưu tài liệu dưới dạng";

                // Hiển thị hộp thoại lưu
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;

                    try
                    {
                        // Xác định định dạng file dựa trên đuôi file người dùng chọn
                        if (selectedFilePath.EndsWith(".docx"))
                        {
                            richEditControl1.SaveDocument(selectedFilePath, DocumentFormat.OpenXml);
                        }
                        else if (selectedFilePath.EndsWith(".rtf"))
                        {
                            richEditControl1.SaveDocument(selectedFilePath, DocumentFormat.Rtf);
                        }
                        else if (selectedFilePath.EndsWith(".pdf"))
                        {
                            richEditControl1.ExportToPdf(selectedFilePath);
                        }

                        MessageBox.Show("Tài liệu đã được lưu thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu tài liệu: " + ex.Message);
                    }
                }
            }
        }
    }
}
