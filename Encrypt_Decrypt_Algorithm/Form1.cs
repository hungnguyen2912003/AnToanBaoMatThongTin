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

namespace Bai4_NguyenKhacDuyHung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbAlgorithm.Items.Add("AES");
            cbbAlgorithm.Items.Add("DES");
            cbbAlgorithm.Items.Add("TripleDES");
            cbbAlgorithm.Items.Add("Rijndael");

            cbbAlgorithm.SelectedItem = "DES";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            var cipher = GetAlgorithm();
            cipher.GenerateKey();
            cipher.GenerateIV();

            rtbKey.Text = BytesToHexaString(cipher.Key);
            rtbIV.Text = BytesToHexaString(cipher.IV);
        }

        private SymmetricAlgorithm GetAlgorithm()
        {
            switch (cbbAlgorithm.Text)
            {
                case "AES": return new AesCryptoServiceProvider();
                case "DES": return new DESCryptoServiceProvider();
                case "TripleDES": return new TripleDESCryptoServiceProvider();
                case "Rijndael": return new RijndaelManaged();
                default: return new DESCryptoServiceProvider();
            }
        }

        private string BytesToHexaString(byte[] b)
        {
            var s = new StringBuilder();
            for(int i = 0; i < b.Length; i++)
            {
                s.Append(b[i].ToString("x2"));
            }
            return s.ToString();
        }

        private byte[] HexaStringToBytes(string hex)
        {
            int n = hex.Length;
            byte[] bytes = new byte[n / 2];

            for (int i = 0; i < n; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }

        private void cbbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbAlgorithm.Text)
            {
                case "AES":
                    txtKeyinfo.Text = Aes.Create().KeySize.ToString() + " bít";
                    txtBlockinfo.Text = Aes.Create().BlockSize.ToString() + " bít";
                    break;
                case "DES":
                    txtKeyinfo.Text = DES.Create().KeySize.ToString() + " bít";
                    txtBlockinfo.Text = DES.Create().BlockSize.ToString() + " bít";
                    break;
                case "TripleDES":
                    txtKeyinfo.Text = TripleDES.Create().KeySize.ToString() + " bít";
                    txtBlockinfo.Text = TripleDES.Create().BlockSize.ToString() + " bít";
                    break;
                case "Rijndael":
                    txtKeyinfo.Text = Rijndael.Create().KeySize.ToString() + " bít";
                    txtBlockinfo.Text = Rijndael.Create().BlockSize.ToString() + " bít";
                    break;
                default:
                    txtKeyinfo.Text = DES.Create().KeySize.ToString() + " bít";
                    txtBlockinfo.Text = DES.Create().BlockSize.ToString() + " bít";
                    break;
            }
        }

        private void btnLoadFileBanRo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn tệp";
                dialog.Filter = "Tất cả các tệp (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn tệp đã chọn trong TextBox
                    rtbPathBanRo.Text = dialog.FileName;
                }
            }
        }

        private void btnLoadFileBanMa_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn tệp";
                dialog.Filter = "Tất cả các tệp (*.*)|*.*";

                // Hiển thị hộp thoại chọn tệp
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn tệp đã chọn trong TextBox
                    rtbPathBanMa.Text = dialog.FileName;
                }
            }
        }

        private void btnLoadFileBanGiai_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn tệp";
                dialog.Filter = "Tất cả các tệp (*.*)|*.*";

                // Hiển thị hộp thoại chọn tệp
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị đường dẫn tệp đã chọn trong TextBox
                    rtbPathBanGiai.Text = dialog.FileName;
                }
            }
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbKey.Text) || string.IsNullOrEmpty(rtbIV.Text))
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin Key và IV của thuật toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text Files|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                string key = rtbKey.Text;
                string iv = rtbIV.Text;
                string type = cbbAlgorithm.Text;

                try
                {
                    string content = $"Key: {key}\nIV: {iv}\nType: {type}";
                    File.WriteAllText(fileName, content);

                    MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files|*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string fileName = file.FileName;
                string[] lines = File.ReadAllLines(fileName);

                if (lines.Length >= 3)
                {
                    rtbKey.Text = lines[0].Substring(5);
                    rtbIV.Text = lines[1].Substring(4);
                    string type = lines[2].Substring(6);

                    // Set giá trị cho ComboBox
                    cbbAlgorithm.SelectedItem = type;
                }
                else
                {
                    MessageBox.Show("File không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem thuật toán đã được lựa chọn hay chưa
            if (cbbAlgorithm.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thuật toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra xem ô richtextbox của khóa và IV đã được điền hay chưa
            if (string.IsNullOrWhiteSpace(rtbKey.Text) || string.IsNullOrWhiteSpace(rtbIV.Text))
            {
                MessageBox.Show("Vui lòng cung cấp Key và IV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra xem file ban đầu đã có hay chưa
            if (string.IsNullOrWhiteSpace(rtbPathBanRo.Text) || string.IsNullOrWhiteSpace(rtbPathBanMa.Text))
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ file cần thiết để thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu tất cả điều kiện đều đã được thỏa mãn, thực hiện mã hóa
            try
            {
                string fileBanRo = rtbPathBanRo.Text;
                string fileBanMa = rtbPathBanMa.Text;
                string thuatToan = cbbAlgorithm.SelectedItem.ToString();

                var fsIn = new FileStream(fileBanRo, FileMode.Open);
                var fsOut = new FileStream(fileBanMa, FileMode.Create);

                var cipher = GetAlgorithm();
                cipher.Key = HexaStringToBytes(rtbKey.Text);
                cipher.IV = HexaStringToBytes(rtbIV.Text);

                ICryptoTransform t;
                t = cipher.CreateEncryptor();
                var stream = new CryptoStream(fsOut, t, CryptoStreamMode.Write);
                var len = (int)fsIn.Length;
                var data = new byte[len];
                fsIn.Read(data, 0, len);
                stream.Write(data, 0, len);

                stream.Close();
                fsOut.Close();
                fsIn.Close();
                MessageBox.Show("Mã hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem thuật toán đã được lựa chọn hay chưa
            if (cbbAlgorithm.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thuật toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra xem ô richtextbox của khóa và IV đã được điền hay chưa
            if (string.IsNullOrWhiteSpace(rtbKey.Text) || string.IsNullOrWhiteSpace(rtbIV.Text))
            {
                MessageBox.Show("Vui lòng cung cấp Key và IV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbPathBanMa.Text) || string.IsNullOrEmpty(rtbPathBanGiai.Text))
            {
                MessageBox.Show("Vui lòng chọn file bản mã hoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Nếu tất cả điều kiện đều đã được thỏa mãn, thực hiện mã hóa
            try
            {
                string fileBanMa = rtbPathBanMa.Text;
                string fileBanGiai = rtbPathBanGiai.Text;
                string thuatToan = cbbAlgorithm.SelectedItem.ToString();

                var fsIn = new FileStream(fileBanMa, FileMode.Open);
                var fsOut = new FileStream(fileBanGiai, FileMode.Create);

                var cipher = GetAlgorithm();
                cipher.Key = HexaStringToBytes(rtbKey.Text);
                cipher.IV = HexaStringToBytes(rtbIV.Text);

                ICryptoTransform t;
                t = cipher.CreateDecryptor();
                var stream = new CryptoStream(fsOut, t, CryptoStreamMode.Write);
                var len = (int)fsIn.Length;
                var data = new byte[len];
                fsIn.Read(data, 0, len);
                stream.Write(data, 0, len);

                stream.Close();
                fsOut.Close();
                fsIn.Close();
                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
