
namespace Bai4_MD5_NguyenKhacDuyHung_63132095
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
            this.label2 = new System.Windows.Forms.Label();
            this.rtbPathFile = new System.Windows.Forms.RichTextBox();
            this.rtbmd5 = new System.Windows.Forms.RichTextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "MD5";
            // 
            // rtbPathFile
            // 
            this.rtbPathFile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPathFile.Location = new System.Drawing.Point(160, 55);
            this.rtbPathFile.Multiline = false;
            this.rtbPathFile.Name = "rtbPathFile";
            this.rtbPathFile.Size = new System.Drawing.Size(500, 40);
            this.rtbPathFile.TabIndex = 2;
            this.rtbPathFile.Text = "";
            // 
            // rtbmd5
            // 
            this.rtbmd5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbmd5.Location = new System.Drawing.Point(160, 135);
            this.rtbmd5.Multiline = false;
            this.rtbmd5.Name = "rtbmd5";
            this.rtbmd5.ReadOnly = true;
            this.rtbmd5.Size = new System.Drawing.Size(500, 40);
            this.rtbmd5.TabIndex = 3;
            this.rtbmd5.Text = "";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFile.Location = new System.Drawing.Point(676, 55);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(60, 40);
            this.btnChonFile.TabIndex = 4;
            this.btnChonFile.Text = "...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(290, 190);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(200, 50);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 253);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.rtbmd5);
            this.Controls.Add(this.rtbPathFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "File MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbPathFile;
        private System.Windows.Forms.RichTextBox rtbmd5;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnCheck;
    }
}

