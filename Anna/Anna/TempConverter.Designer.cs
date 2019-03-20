namespace Anna
{
    partial class TempConverter
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
            this.FtoCbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FahrenheitBox = new System.Windows.Forms.TextBox();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FtoCbtn
            // 
            this.FtoCbtn.Location = new System.Drawing.Point(86, 72);
            this.FtoCbtn.Name = "FtoCbtn";
            this.FtoCbtn.Size = new System.Drawing.Size(75, 46);
            this.FtoCbtn.TabIndex = 0;
            this.FtoCbtn.Text = "Convert";
            this.FtoCbtn.UseVisualStyleBackColor = true;
            this.FtoCbtn.Click += new System.EventHandler(this.FtoCbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Celsius";
            // 
            // FahrenheitBox
            // 
            this.FahrenheitBox.Location = new System.Drawing.Point(12, 36);
            this.FahrenheitBox.Name = "FahrenheitBox";
            this.FahrenheitBox.Size = new System.Drawing.Size(100, 20);
            this.FahrenheitBox.TabIndex = 3;
            this.FahrenheitBox.TextChanged += new System.EventHandler(this.FahrenheitBox_TextChanged);
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(133, 36);
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(100, 20);
            this.CelsiusBox.TabIndex = 4;
            this.CelsiusBox.TextChanged += new System.EventHandler(this.CelsiusBox_TextChanged);
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 659);
            this.Controls.Add(this.CelsiusBox);
            this.Controls.Add(this.FahrenheitBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FtoCbtn);
            this.Name = "TempConverter";
            this.Text = "TempConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FtoCbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FahrenheitBox;
        private System.Windows.Forms.TextBox CelsiusBox;
    }
}