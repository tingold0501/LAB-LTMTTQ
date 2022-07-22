namespace WindowFormsLab.Forms
{
    partial class FormSumANumber
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNumberN = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEnter);
            this.panel1.Controls.Add(this.tbNumberN);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 148);
            this.panel1.TabIndex = 0;
            // 
            // tbNumberN
            // 
            this.tbNumberN.Location = new System.Drawing.Point(35, 18);
            this.tbNumberN.Multiline = true;
            this.tbNumberN.Name = "tbNumberN";
            this.tbNumberN.Size = new System.Drawing.Size(314, 28);
            this.tbNumberN.TabIndex = 0;
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.IndianRed;
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(74, 70);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(235, 32);
            this.btEnter.TabIndex = 1;
            this.btEnter.Text = "ENTER";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // FormSumANumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 151);
            this.Controls.Add(this.panel1);
            this.Name = "FormSumANumber";
            this.Text = "FormSumANumber";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbNumberN;
    }
}