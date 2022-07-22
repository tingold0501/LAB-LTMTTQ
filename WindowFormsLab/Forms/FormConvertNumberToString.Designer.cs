namespace WindowFormsLab.Forms
{
    partial class FormConvertNumberToString
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
            this.tbNumberN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumberN
            // 
            this.tbNumberN.Location = new System.Drawing.Point(12, 12);
            this.tbNumberN.Multiline = true;
            this.tbNumberN.Name = "tbNumberN";
            this.tbNumberN.Size = new System.Drawing.Size(349, 31);
            this.tbNumberN.TabIndex = 0;
            this.tbNumberN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumberN.TextChanged += new System.EventHandler(this.tbNumberN_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormConvertNumberToString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 127);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNumberN);
            this.Name = "FormConvertNumberToString";
            this.Text = "FormConvertNumberToString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumberN;
        private System.Windows.Forms.Button button1;
    }
}