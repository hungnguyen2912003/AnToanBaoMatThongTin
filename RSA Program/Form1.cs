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

namespace Bai7_RSA_NguyenKhacDuyHung_63132095
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string BytesToHexaString(byte[] b)
        {
            var s = new StringBuilder();
            for (int i = 0; i < b.Length; i++)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chuơng trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSAParameters parameters = rsa.ExportParameters(true);

            rtbPvalue.Text = BytesToHexaString(parameters.P);
            rtbQvalue.Text = BytesToHexaString(parameters.Q);
            rtbModvalue.Text = BytesToHexaString(parameters.Modulus);
            rtbDvalue.Text = BytesToHexaString(parameters.D);
            rtbDPvalue.Text = BytesToHexaString(parameters.DP);
            rtbDQvalue.Text = BytesToHexaString(parameters.DQ);
            rtbIQvalue.Text = BytesToHexaString(parameters.InverseQ);
            rtbExvalue.Text = BytesToHexaString(parameters.Exponent);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine(rtbPvalue.Text);
                    sw.WriteLine(rtbQvalue.Text);
                    sw.WriteLine(rtbModvalue.Text);
                    sw.WriteLine(rtbDvalue.Text);
                    sw.WriteLine(rtbDPvalue.Text);
                    sw.WriteLine(rtbDQvalue.Text);
                    sw.WriteLine(rtbIQvalue.Text);
                    sw.WriteLine(rtbExvalue.Text);
                    sw.Close();
                    MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn tệp";
            ofd.Filter = "Tất cả các tệp (*.*)|*.*";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    rtbPvalue.Text = sr.ReadLine();
                    rtbQvalue.Text = sr.ReadLine();
                    rtbModvalue.Text = sr.ReadLine();
                    rtbDvalue.Text = sr.ReadLine();
                    rtbDPvalue.Text = sr.ReadLine();
                    rtbDQvalue.Text = sr.ReadLine();
                    rtbIQvalue.Text = sr.ReadLine();
                    rtbExvalue.Text = sr.ReadLine();
                    sr.Close();
                    MessageBox.Show("Đã nạp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi nạp file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoadMaGoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn tệp";
            ofd.Filter = "Tất cả các tệp (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbFileGoc.Text = ofd.FileName;
            }
        }

        private void btnLoadMaHoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn tệp";
            ofd.Filter = "Tất cả các tệp (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbFileMaHoa.Text = ofd.FileName;
            }
        }

        private void btnLoadGiaiMa_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn tệp";
            ofd.Filter = "Tất cả các tệp (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbFileGiaiMa.Text = ofd.FileName;
            }
        }

        private void ImportParameters(RSACryptoServiceProvider rsa)
        {
            RSAParameters parameters = new RSAParameters();
            if (rtbPvalue.Text.Trim() != "")
                parameters.P = HexaStringToBytes(rtbPvalue.Text);
            if (rtbQvalue.Text.Trim() != "")
                parameters.Q = HexaStringToBytes(rtbQvalue.Text);
            if (rtbModvalue.Text.Trim() != "")
                parameters.Modulus = HexaStringToBytes(rtbModvalue.Text);
            if (rtbDvalue.Text.Trim() != "")
                parameters.D = HexaStringToBytes(rtbDvalue.Text);
            if (rtbDPvalue.Text.Trim() != "")
                parameters.DP = HexaStringToBytes(rtbDPvalue.Text);
            if (rtbDQvalue.Text.Trim() != "")
                parameters.DQ = HexaStringToBytes(rtbDQvalue.Text);
            if (rtbIQvalue.Text.Trim() != "")
                parameters.InverseQ = HexaStringToBytes(rtbIQvalue.Text);
            if (rtbExvalue.Text.Trim() != "")
                parameters.Exponent = HexaStringToBytes(rtbExvalue.Text);
            rsa.ImportParameters(parameters);
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem file ban đầu đã có hay chưa
            if (string.IsNullOrWhiteSpace(rtbFileGoc.Text) || string.IsNullOrWhiteSpace(rtbFileMaHoa.Text))
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ file cần thiết để thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileStream fsIn = new FileStream(rtbFileGoc.Text, FileMode.Open);
            FileStream fsOut = new FileStream(rtbFileMaHoa.Text, FileMode.Create);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            ImportParameters(rsa);

            int mblock = 117;

            byte[] data = new byte[mblock];
            int leng;

            try
            {
                do
                {
                    leng = fsIn.Read(data, 0, mblock);
                    if (leng > 0)
                    {
                        byte[] edata;
                        if (leng == mblock)
                        {
                            edata = rsa.Encrypt(data, false);
                        }
                        else
                        {
                            byte[] data1 = new byte[leng];
                            for (int i = 0; i < leng; i++)
                            {
                                data1[i] = data[i];
                            }
                            edata = rsa.Encrypt(data1, false);
                        }
                        fsOut.Write(edata, 0, edata.Length);
                    }
                } while (leng == mblock);
                fsOut.Close();
                MessageBox.Show("Mã hoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem file ban đầu đã có hay chưa
            if (string.IsNullOrWhiteSpace(rtbFileMaHoa.Text) || string.IsNullOrWhiteSpace(rtbFileGiaiMa.Text))
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ file cần thiết để thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FileStream fsIn = new FileStream(rtbFileMaHoa.Text, FileMode.Open);
            FileStream fsOut = new FileStream(rtbFileGiaiMa.Text, FileMode.Create);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            ImportParameters(rsa);

            int mblock = 128;

            byte[] data = new byte[mblock];
            int leng;

            try
            {
                do
                {
                    leng = fsIn.Read(data, 0, mblock);
                    if (leng > 0)
                    {
                        byte[] ddata;
                        if (leng == mblock)
                        {
                            ddata = rsa.Decrypt(data, false);
                        }
                        else
                        {
                            byte[] data1 = new byte[leng];
                            for (int i = 0; i < leng; i++)
                            {
                                data1[i] = data[i];
                            }
                            ddata = rsa.Decrypt(data1, false);
                        }
                        fsOut.Write(ddata, 0, ddata.Length);
                    }
                } while (leng == mblock);
                fsOut.Close();
                MessageBox.Show("Giải mã thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
