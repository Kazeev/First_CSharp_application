namespace WinFormsApp1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRun = new System.Windows.Forms.Button();
            this.textIn = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSerch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(87, 386);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Tag = "";
            this.buttonRun.Text = "Найти";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonPush);
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(12, 124);
            this.textIn.Multiline = true;
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(229, 177);
            this.textIn.TabIndex = 1;
            this.textIn.Tag = "";
            // 
            // textOut
            // 
            this.textOut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOut.Location = new System.Drawing.Point(12, 321);
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(229, 62);
            this.textOut.TabIndex = 2;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(12, 28);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(229, 20);
            this.reg.TabIndex = 3;
            this.reg.Text = "\\s";
            this.reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регулярное выражение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст для поиска";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textSerch
            // 
            this.textSerch.Location = new System.Drawing.Point(12, 54);
            this.textSerch.Name = "textSerch";
            this.textSerch.Size = new System.Drawing.Size(229, 46);
            this.textSerch.TabIndex = 8;
            this.textSerch.Text = "Выбор файла с текстом ";
            this.textSerch.UseVisualStyleBackColor = true;
            this.textSerch.Click += new System.EventHandler(this.textSerch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(253, 421);
            this.Controls.Add(this.textSerch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.buttonRun);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Izi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button textSerch;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox reg;

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label textOut;

        private System.Windows.Forms.TextBox textIn;
        
        #endregion
    }
}