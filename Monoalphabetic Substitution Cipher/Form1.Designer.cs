namespace ChuongTrinhPhaMa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ThongKe = new Button();
            btn_PhaMa = new Button();
            dgvSingleWord = new DataGridView();
            chu = new DataGridViewTextBoxColumn();
            tanso = new DataGridViewTextBoxColumn();
            replace = new DataGridViewTextBoxColumn();
            dgv_Trigram = new DataGridView();
            trigram = new DataGridViewTextBoxColumn();
            tanso_dgv3 = new DataGridViewTextBoxColumn();
            dgv_Digram = new DataGridView();
            digram_column = new DataGridViewTextBoxColumn();
            tanso_diagram = new DataGridViewTextBoxColumn();
            txtInput = new RichTextBox();
            txtOutput = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSingleWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Trigram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Digram).BeginInit();
            SuspendLayout();
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ThongKe.Location = new Point(52, 298);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(130, 40);
            btn_ThongKe.TabIndex = 1;
            btn_ThongKe.Text = "Thống Kê";
            btn_ThongKe.UseVisualStyleBackColor = true;
            btn_ThongKe.Click += btn_ThongKe_Click;
            // 
            // btn_PhaMa
            // 
            btn_PhaMa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PhaMa.Location = new Point(434, 298);
            btn_PhaMa.Name = "btn_PhaMa";
            btn_PhaMa.Size = new Size(130, 40);
            btn_PhaMa.TabIndex = 2;
            btn_PhaMa.Text = "Phá Mã";
            btn_PhaMa.UseVisualStyleBackColor = true;
            btn_PhaMa.Click += btn_PhaMa_Click;
            // 
            // dgvSingleWord
            // 
            dgvSingleWord.AllowUserToAddRows = false;
            dgvSingleWord.AllowUserToDeleteRows = false;
            dgvSingleWord.AllowUserToResizeColumns = false;
            dgvSingleWord.AllowUserToResizeRows = false;
            dgvSingleWord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSingleWord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSingleWord.Columns.AddRange(new DataGridViewColumn[] { chu, tanso, replace });
            dgvSingleWord.Location = new Point(638, 12);
            dgvSingleWord.MultiSelect = false;
            dgvSingleWord.Name = "dgvSingleWord";
            dgvSingleWord.RowHeadersVisible = false;
            dgvSingleWord.RowHeadersWidth = 51;
            dgvSingleWord.Size = new Size(202, 630);
            dgvSingleWord.TabIndex = 5;
            // 
            // chu
            // 
            chu.FillWeight = 88.23529F;
            chu.HeaderText = "Chữ";
            chu.MinimumWidth = 6;
            chu.Name = "chu";
            chu.ReadOnly = true;
            // 
            // tanso
            // 
            tanso.FillWeight = 105.882355F;
            tanso.HeaderText = "TầnSố";
            tanso.MinimumWidth = 6;
            tanso.Name = "tanso";
            tanso.ReadOnly = true;
            // 
            // replace
            // 
            replace.FillWeight = 105.882355F;
            replace.HeaderText = "Thay";
            replace.MinimumWidth = 6;
            replace.Name = "replace";
            // 
            // dgv_Trigram
            // 
            dgv_Trigram.AllowUserToAddRows = false;
            dgv_Trigram.AllowUserToDeleteRows = false;
            dgv_Trigram.AllowUserToResizeColumns = false;
            dgv_Trigram.AllowUserToResizeRows = false;
            dgv_Trigram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Trigram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Trigram.Columns.AddRange(new DataGridViewColumn[] { trigram, tanso_dgv3 });
            dgv_Trigram.Location = new Point(1018, 12);
            dgv_Trigram.Name = "dgv_Trigram";
            dgv_Trigram.RowHeadersVisible = false;
            dgv_Trigram.RowHeadersWidth = 51;
            dgv_Trigram.Size = new Size(152, 629);
            dgv_Trigram.TabIndex = 6;
            // 
            // trigram
            // 
            trigram.HeaderText = "Trigram";
            trigram.MinimumWidth = 6;
            trigram.Name = "trigram";
            trigram.ReadOnly = true;
            // 
            // tanso_dgv3
            // 
            tanso_dgv3.HeaderText = "TầnSố";
            tanso_dgv3.MinimumWidth = 6;
            tanso_dgv3.Name = "tanso_dgv3";
            tanso_dgv3.ReadOnly = true;
            // 
            // dgv_Digram
            // 
            dgv_Digram.AllowUserToAddRows = false;
            dgv_Digram.AllowUserToDeleteRows = false;
            dgv_Digram.AllowUserToResizeColumns = false;
            dgv_Digram.AllowUserToResizeRows = false;
            dgv_Digram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Digram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Digram.Columns.AddRange(new DataGridViewColumn[] { digram_column, tanso_diagram });
            dgv_Digram.Location = new Point(846, 12);
            dgv_Digram.Name = "dgv_Digram";
            dgv_Digram.RowHeadersVisible = false;
            dgv_Digram.RowHeadersWidth = 51;
            dgv_Digram.Size = new Size(166, 630);
            dgv_Digram.TabIndex = 7;
            // 
            // digram_column
            // 
            digram_column.HeaderText = "Digram";
            digram_column.MinimumWidth = 6;
            digram_column.Name = "digram_column";
            digram_column.ReadOnly = true;
            // 
            // tanso_diagram
            // 
            tanso_diagram.HeaderText = "TầnSố";
            tanso_diagram.MinimumWidth = 6;
            tanso_diagram.Name = "tanso_diagram";
            tanso_diagram.ReadOnly = true;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(620, 280);
            txtInput.TabIndex = 8;
            txtInput.Text = "";
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(12, 344);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(620, 297);
            txtOutput.TabIndex = 9;
            txtOutput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(386, 656);
            label1.Name = "label1";
            label1.Size = new Size(415, 27);
            label1.TabIndex = 10;
            label1.Text = "Nguyễn Khắc Duy Hưng - 63132095";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(dgv_Digram);
            Controls.Add(dgv_Trigram);
            Controls.Add(dgvSingleWord);
            Controls.Add(btn_PhaMa);
            Controls.Add(btn_ThongKe);
            Name = "Form1";
            Text = "Chương trình giải mã";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSingleWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Trigram).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Digram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_ThongKe;
        private Button btn_PhaMa;
        private DataGridView dgvSingleWord;
        private DataGridView dgv_Trigram;
        private DataGridView dgv_Digram;
        private DataGridViewTextBoxColumn chu;
        private DataGridViewTextBoxColumn tanso;
        private DataGridViewTextBoxColumn replace;
        private DataGridViewTextBoxColumn trigram;
        private DataGridViewTextBoxColumn tanso_dgv3;
        private DataGridViewTextBoxColumn digram_column;
        private DataGridViewTextBoxColumn tanso_diagram;
        private RichTextBox txtInput;
        private RichTextBox txtOutput;
        private Label label1;
    }
}
