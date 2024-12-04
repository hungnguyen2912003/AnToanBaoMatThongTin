
namespace Bai4_NguyenKhacDuyHung
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAlgorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyinfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlockinfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbKey = new System.Windows.Forms.RichTextBox();
            this.rtbIV = new System.Windows.Forms.RichTextBox();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbPathBanRo = new System.Windows.Forms.RichTextBox();
            this.rtbPathBanMa = new System.Windows.Forms.RichTextBox();
            this.rtbPathBanGiai = new System.Windows.Forms.RichTextBox();
            this.btnLoadFileBanRo = new System.Windows.Forms.Button();
            this.btnLoadFileBanMa = new System.Windows.Forms.Button();
            this.btnLoadFileBanGiai = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thuật toán mã hoá";
            // 
            // cbbAlgorithm
            // 
            this.cbbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlgorithm.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAlgorithm.FormattingEnabled = true;
            this.cbbAlgorithm.Location = new System.Drawing.Point(310, 40);
            this.cbbAlgorithm.Name = "cbbAlgorithm";
            this.cbbAlgorithm.Size = new System.Drawing.Size(300, 45);
            this.cbbAlgorithm.TabIndex = 1;
            this.cbbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbbAlgorithm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin khoá:";
            // 
            // txtKeyinfo
            // 
            this.txtKeyinfo.AutoSize = true;
            this.txtKeyinfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyinfo.Location = new System.Drawing.Point(790, 50);
            this.txtKeyinfo.Name = "txtKeyinfo";
            this.txtKeyinfo.Size = new System.Drawing.Size(0, 29);
            this.txtKeyinfo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(880, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin block:";
            // 
            // txtBlockinfo
            // 
            this.txtBlockinfo.AutoSize = true;
            this.txtBlockinfo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlockinfo.Location = new System.Drawing.Point(1050, 50);
            this.txtBlockinfo.Name = "txtBlockinfo";
            this.txtBlockinfo.Size = new System.Drawing.Size(0, 29);
            this.txtBlockinfo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khoá (dạng hexa)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "IV (dạng hexa)";
            // 
            // rtbKey
            // 
            this.rtbKey.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbKey.Location = new System.Drawing.Point(250, 120);
            this.rtbKey.Multiline = false;
            this.rtbKey.Name = "rtbKey";
            this.rtbKey.Size = new System.Drawing.Size(870, 40);
            this.rtbKey.TabIndex = 8;
            this.rtbKey.Text = "";
            // 
            // rtbIV
            // 
            this.rtbIV.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbIV.Location = new System.Drawing.Point(250, 195);
            this.rtbIV.Multiline = false;
            this.rtbIV.Name = "rtbIV";
            this.rtbIV.Size = new System.Drawing.Size(870, 40);
            this.rtbIV.TabIndex = 9;
            this.rtbIV.Text = "";
            // 
            // btnGenKey
            // 
            this.btnGenKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenKey.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenKey.Location = new System.Drawing.Point(925, 270);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(195, 50);
            this.btnGenKey.TabIndex = 10;
            this.btnGenKey.Text = "Sinh Khoá&&IV";
            this.btnGenKey.UseVisualStyleBackColor = false;
            this.btnGenKey.Click += new System.EventHandler(this.btnGenKey_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveKey.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveKey.Location = new System.Drawing.Point(700, 270);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(195, 50);
            this.btnSaveKey.TabIndex = 11;
            this.btnSaveKey.Text = "Lưu Khoá&&IV";
            this.btnSaveKey.UseVisualStyleBackColor = false;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadKey.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadKey.Location = new System.Drawing.Point(475, 270);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(195, 50);
            this.btnLoadKey.TabIndex = 12;
            this.btnLoadKey.Text = "Nạp Khoá&&IV";
            this.btnLoadKey.UseVisualStyleBackColor = false;
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "File ban đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "File mã hoá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "File giải mã";
            // 
            // rtbPathBanRo
            // 
            this.rtbPathBanRo.EnableAutoDragDrop = true;
            this.rtbPathBanRo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPathBanRo.Location = new System.Drawing.Point(229, 345);
            this.rtbPathBanRo.Multiline = false;
            this.rtbPathBanRo.Name = "rtbPathBanRo";
            this.rtbPathBanRo.Size = new System.Drawing.Size(720, 40);
            this.rtbPathBanRo.TabIndex = 16;
            this.rtbPathBanRo.Text = "";
            // 
            // rtbPathBanMa
            // 
            this.rtbPathBanMa.EnableAutoDragDrop = true;
            this.rtbPathBanMa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPathBanMa.Location = new System.Drawing.Point(229, 423);
            this.rtbPathBanMa.Multiline = false;
            this.rtbPathBanMa.Name = "rtbPathBanMa";
            this.rtbPathBanMa.Size = new System.Drawing.Size(720, 40);
            this.rtbPathBanMa.TabIndex = 17;
            this.rtbPathBanMa.Text = "";
            // 
            // rtbPathBanGiai
            // 
            this.rtbPathBanGiai.EnableAutoDragDrop = true;
            this.rtbPathBanGiai.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPathBanGiai.Location = new System.Drawing.Point(229, 497);
            this.rtbPathBanGiai.Multiline = false;
            this.rtbPathBanGiai.Name = "rtbPathBanGiai";
            this.rtbPathBanGiai.Size = new System.Drawing.Size(720, 40);
            this.rtbPathBanGiai.TabIndex = 18;
            this.rtbPathBanGiai.Text = "";
            // 
            // btnLoadFileBanRo
            // 
            this.btnLoadFileBanRo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadFileBanRo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileBanRo.Location = new System.Drawing.Point(956, 338);
            this.btnLoadFileBanRo.Name = "btnLoadFileBanRo";
            this.btnLoadFileBanRo.Size = new System.Drawing.Size(164, 50);
            this.btnLoadFileBanRo.TabIndex = 19;
            this.btnLoadFileBanRo.Text = "Chọn File...";
            this.btnLoadFileBanRo.UseVisualStyleBackColor = false;
            this.btnLoadFileBanRo.Click += new System.EventHandler(this.btnLoadFileBanRo_Click);
            // 
            // btnLoadFileBanMa
            // 
            this.btnLoadFileBanMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadFileBanMa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileBanMa.Location = new System.Drawing.Point(956, 415);
            this.btnLoadFileBanMa.Name = "btnLoadFileBanMa";
            this.btnLoadFileBanMa.Size = new System.Drawing.Size(164, 50);
            this.btnLoadFileBanMa.TabIndex = 20;
            this.btnLoadFileBanMa.Text = "Chọn File...";
            this.btnLoadFileBanMa.UseVisualStyleBackColor = false;
            this.btnLoadFileBanMa.Click += new System.EventHandler(this.btnLoadFileBanMa_Click);
            // 
            // btnLoadFileBanGiai
            // 
            this.btnLoadFileBanGiai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoadFileBanGiai.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileBanGiai.Location = new System.Drawing.Point(956, 490);
            this.btnLoadFileBanGiai.Name = "btnLoadFileBanGiai";
            this.btnLoadFileBanGiai.Size = new System.Drawing.Size(164, 50);
            this.btnLoadFileBanGiai.TabIndex = 21;
            this.btnLoadFileBanGiai.Text = "Chọn File...";
            this.btnLoadFileBanGiai.UseVisualStyleBackColor = false;
            this.btnLoadFileBanGiai.Click += new System.EventHandler(this.btnLoadFileBanGiai_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaHoa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.Location = new System.Drawing.Point(170, 570);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(250, 60);
            this.btnMaHoa.TabIndex = 22;
            this.btnMaHoa.Text = "Mã hoá";
            this.btnMaHoa.UseVisualStyleBackColor = false;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGiaiMa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.Location = new System.Drawing.Point(470, 570);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(250, 60);
            this.btnGiaiMa.TabIndex = 23;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = false;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(770, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 60);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Thoát chương trình";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.btnLoadFileBanGiai);
            this.Controls.Add(this.btnLoadFileBanMa);
            this.Controls.Add(this.btnLoadFileBanRo);
            this.Controls.Add(this.rtbPathBanGiai);
            this.Controls.Add(this.rtbPathBanMa);
            this.Controls.Add(this.rtbPathBanRo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoadKey);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.btnGenKey);
            this.Controls.Add(this.rtbIV);
            this.Controls.Add(this.rtbKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBlockinfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeyinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbAlgorithm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAlgorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtKeyinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtBlockinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbKey;
        private System.Windows.Forms.RichTextBox rtbIV;
        private System.Windows.Forms.Button btnGenKey;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbPathBanRo;
        private System.Windows.Forms.RichTextBox rtbPathBanMa;
        private System.Windows.Forms.RichTextBox rtbPathBanGiai;
        private System.Windows.Forms.Button btnLoadFileBanRo;
        private System.Windows.Forms.Button btnLoadFileBanMa;
        private System.Windows.Forms.Button btnLoadFileBanGiai;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnExit;
    }
}

