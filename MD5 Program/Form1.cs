using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Bai4_MD5_NguyenKhacDuyHung_63132095
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn tệp";
            ofd.Filter = "Tất cả các tệp (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbPathFile.Text = ofd.FileName;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu đường dẫn tới tệp rỗng
            if (string.IsNullOrEmpty(rtbPathFile.Text))
            {
                MessageBox.Show("Vui lòng chọn tệp trước khi kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string file = rtbPathFile.Text;

            try
            {
                // Tạo đối tượng MD5
                using (MD5 md5 = MD5.Create())
                {
                    // Đọc toàn bộ tệp và tính toán hash
                    using (FileStream stream = File.OpenRead(file))
                    {
                        byte[] hash = md5.ComputeHash(stream);

                        // Chuyển đổi hash thành chuỗi dạng hex
                        StringBuilder sb = new StringBuilder();
                        foreach (byte b in hash)
                        {
                            sb.Append(b.ToString("x2"));
                        }

                        // Hiển thị giá trị MD5 trong rtbmd5
                        rtbmd5.Text = sb.ToString().ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi không thể đọc tệp hoặc tính toán MD5
                MessageBox.Show($"Đã có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
