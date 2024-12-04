using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ChuongTrinhPhaMa
{

    public partial class Form1 : Form
    {
        // Tạo biến cờ để kiểm soát việc chọn trong txtInput và txtOutput
        private bool isInputSelectionChanging = false;
        private bool isOutputSelectionChanging = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           txtInput.SelectionChanged += txtInput_SelectionChanged;
           txtOutput.SelectionChanged += txtOutput_SelectionChanged;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ textbox_input
            string input = txtInput.Text.Trim().Replace(" ", "").Replace("\r", "").Replace("\n", "").ToUpper();

            txtInput.Text = input;

            // Tạo danh sách chữ cái tiếng Anh
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Tạo từ điển để lưu tần suất xuất hiện của các ký tự
            Dictionary<char, int> tsuat_Single = new Dictionary<char, int>();

            // Tạo từ điển để lưu tần suất xuất hiện của các cặp chữ (digrams)
            Dictionary<string, int> tsuat_Digram = new Dictionary<string, int>();

            // Tạo từ điển để lưu tần suất xuất hiện của các trigram
            Dictionary<string, int> tsuat_Trigram = new Dictionary<string, int>();

            // Thống kê tần suất của từng ký tự
            foreach (char c in input)
            {
                if (char.IsLetter(c)) // Chỉ thống kê ký tự chữ cái
                {
                    if (tsuat_Single.ContainsKey(c))
                        tsuat_Single[c]++;
                    else
                        tsuat_Single[c] = 1;
                }
                // Thêm các chữ cái không xuất hiện trong chuỗi vào dgv_singleWord với tần số là 0
                foreach (char chuThieu in alphabet)
                {
                    if (!tsuat_Single.ContainsKey(chuThieu))
                    {
                        tsuat_Single[chuThieu] = 0;
                    }
                }
            }

            // Thống kê tần suất của từng cặp chữ (digrams)
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsLetter(input[i]) && char.IsLetter(input[i + 1])) // Chỉ thống kê nếu cả hai ký tự đều là chữ cái
                {
                    string digram = input.Substring(i, 2); // Lấy cặp chữ
                    if (tsuat_Digram.ContainsKey(digram))
                        tsuat_Digram[digram]++;
                    else
                        tsuat_Digram[digram] = 1;
                }
            }

            // Thống kê tần suất của các trigram
            for (int i = 0; i < input.Length - 2; i++)
            {
                if (char.IsLetter(input[i]) && char.IsLetter(input[i + 1]) && char.IsLetter(input[i + 2]))
                {
                    string trigram = input.Substring(i, 3);
                    if (tsuat_Trigram.ContainsKey(trigram))
                        tsuat_Trigram[trigram]++;
                    else
                        tsuat_Trigram[trigram] = 1;
                }
            }

            // Xóa dữ liệu cũ
            dgvSingleWord.Rows.Clear();
            dgv_Digram.Rows.Clear();
            dgv_Trigram.Rows.Clear();
            txtOutput.Clear();

            // Thêm dữ liệu từ tsuat_Single vào dgv_singleWord
            foreach (var data in tsuat_Single.OrderBy(c => c.Key).OrderByDescending(c => c.Value))
            {
                dgvSingleWord.Rows.Add(data.Key, data.Value, ""); // Cột 'Thay' để trống (cho nhập tay sau)
            }

            // Thêm dữ liệu vào dgv_diagram
            foreach (var data in tsuat_Digram.OrderByDescending(c => c.Value))
            {
                dgv_Digram.Rows.Add(data.Key, data.Value);
            }

            // Thêm dữ liệu vào dgv_trigram
            foreach (var data in tsuat_Trigram.OrderByDescending(x => x.Value))
            {
                dgv_Trigram.Rows.Add(data.Key, data.Value);
            }
        }

        private void btn_PhaMa_Click(object sender, EventArgs e)
        {
            // Tạo từ điển để lưu các sự thay thế
            Dictionary<char, char> substitutions = new Dictionary<char, char>();

            // Lặp qua từng hàng trong dgv_single để lấy sự thay thế
            foreach (DataGridViewRow row in dgvSingleWord.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[2].Value != null)
                {
                    char originalChar = Convert.ToChar(row.Cells[0].Value);

                    // Lấy giá trị cột "Thay"
                    string substituteValue = row.Cells[2].Value.ToString();

                    // Chỉ thực hiện thay thế nếu ô "Thay" chứa đúng 1 ký tự
                    if (!string.IsNullOrEmpty(substituteValue) && substituteValue.Length == 1)
                    {
                        char substituteChar = substituteValue[0];

                        // Thêm vào từ điển
                        if (!substitutions.ContainsKey(originalChar))
                        {
                            substitutions.Add(originalChar, substituteChar);
                        }
                    }
                }
            }

            // Chỉ hiển thị những chữ đã được thay thế
            StringBuilder decryptedText = new StringBuilder();

            // Lặp qua từng ký tự trong văn bản mã hóa
            foreach (char c in txtInput.Text)
            {
                // Nếu ký tự có sự thay thế thì thêm ký tự thay thế vào txtOutput
                if (substitutions.ContainsKey(c))
                {
                    decryptedText.Append(substitutions[c]); // Thêm ký tự thay thế
                }
                else
                {
                    decryptedText.Append(' '); // Thay ký tự chưa được thay bằng khoảng trắng
                }
            }

            // Hiển thị kết quả mới vào txtOutput
            txtOutput.Text = decryptedText.ToString().Trim().Replace("\n", "").Replace("\r", "");
        }

        //////////////////////////////////////////////////////////////////////////////
        ///Bôi đen Input và Output
        private void txtInput_SelectionChanged(object sender, EventArgs e)
        {
            if (!isInputSelectionChanging)
            {
                try
                {
                    isOutputSelectionChanging = true; // Bắt đầu thay đổi chọn trong txtOutput

                    // Xóa highlight hiện tại của txtOutput
                    txtOutput.SelectAll();
                    txtOutput.SelectionBackColor = DefaultBackColor;
                    txtOutput.SelectionColor = Color.Black;

                    int selectionStart = txtInput.SelectionStart;
                    int selectionLength = txtInput.SelectionLength;

                    if (selectionLength > 0)
                    {
                        // Chọn vùng tương ứng trong txtOutput
                        txtOutput.Select(selectionStart, selectionLength);
                        txtOutput.SelectionBackColor = Color.CornflowerBlue; // Highlight màu xanh
                        txtOutput.SelectionColor = Color.White;
                    }
                    else
                    {
                        // Nếu không có gì được chọn thì không cần highlight
                        txtOutput.Select(0, 0);
                    }
                }
                finally
                {
                    isOutputSelectionChanging = false; // Kết thúc thay đổi chọn trong txtOutput
                }
            }
        }

        private void txtOutput_SelectionChanged(object sender, EventArgs e)
        {
            if (!isOutputSelectionChanging)
            {
                try
                {
                    isInputSelectionChanging = true; // Bắt đầu thay đổi chọn trong txtInput

                    // Xóa highlight hiện tại của txtInput
                    txtInput.SelectAll();
                    txtInput.SelectionBackColor = Color.White;
                    txtInput.SelectionColor = Color.Black;

                    int selectionStartOutput = txtOutput.SelectionStart;
                    int selectionLengthOutput = txtOutput.SelectionLength;

                    if (selectionLengthOutput > 0)
                    {
                        // Tính vị trí bắt đầu cần chọn trong txtInput tương ứng với vị trí chọn trong txtOutput
                        int selectionStartInput = 0;
                        int count = 0;

                        // Xử lý để tìm đúng vị trí trong txtInput tương ứng với txtOutput
                        for (int i = 0; i < txtInput.Text.Length; i++)
                        {
                            if (txtInput.Text[i] != ' ') // Bỏ qua khoảng trắng
                            {
                                count++;
                            }
                            // Điều kiện để ánh xạ từ txtOutput sang txtInput
                            if (count == selectionStartOutput + 1)
                            {
                                selectionStartInput = i;
                                break;
                            }
                        }

                        // Bôi đen tương ứng trong txtInput
                        txtInput.Select(selectionStartInput, selectionLengthOutput);
                        txtInput.SelectionBackColor = Color.CornflowerBlue; // Highlight màu xanh
                        txtInput.SelectionColor = Color.White;
                    }
                    else
                    {
                        // Nếu không có gì được chọn thì không cần highlight
                        txtInput.Select(0, 0);
                    }
                }
                finally
                {
                    isInputSelectionChanging = false; // Kết thúc thay đổi chọn trong txtInput
                }
            }
        }
    }
}
