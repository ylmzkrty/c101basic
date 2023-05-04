namespace WriteOnPicture
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
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.TxtText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(51, 140);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(260, 42);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.Text = "Choose Color";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnPicture
            // 
            this.BtnPicture.Location = new System.Drawing.Point(51, 63);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(260, 42);
            this.BtnPicture.TabIndex = 1;
            this.BtnPicture.Text = "Choose Picture";
            this.BtnPicture.UseVisualStyleBackColor = true;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(51, 284);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(260, 42);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(51, 214);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(260, 42);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // TxtText
            // 
            this.TxtText.AutoSize = true;
            this.TxtText.Location = new System.Drawing.Point(56, 398);
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(63, 24);
            this.TxtText.TabIndex = 4;
            this.TxtText.Text = "Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 6;
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(131, 443);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(180, 30);
            this.TxtSize.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 404);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(994, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtText);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.BtnColor);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label TxtText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

