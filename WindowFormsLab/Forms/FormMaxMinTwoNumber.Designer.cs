namespace WindowFormsLab
{
    partial class FormMaxMinTwoNumber
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
            this.tbNumberA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNumberB = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumberA
            // 
            this.tbNumberA.BackColor = System.Drawing.Color.Gray;
            this.tbNumberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberA.Location = new System.Drawing.Point(35, 23);
            this.tbNumberA.Name = "tbNumberA";
            this.tbNumberA.Size = new System.Drawing.Size(300, 27);
            this.tbNumberA.TabIndex = 0;
            this.tbNumberA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEnter);
            this.panel1.Controls.Add(this.tbNumberB);
            this.panel1.Controls.Add(this.tbNumberA);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 189);
            this.panel1.TabIndex = 1;
            // 
            // tbNumberB
            // 
            this.tbNumberB.BackColor = System.Drawing.Color.Gray;
            this.tbNumberB.Location = new System.Drawing.Point(35, 86);
            this.tbNumberB.Multiline = true;
            this.tbNumberB.Name = "tbNumberB";
            this.tbNumberB.Size = new System.Drawing.Size(300, 29);
            this.tbNumberB.TabIndex = 1;
            this.tbNumberB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.IndianRed;
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(95, 133);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(184, 31);
            this.btEnter.TabIndex = 2;
            this.btEnter.Text = "ENTER";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // FormMaxMinTwoNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 192);
            this.Controls.Add(this.panel1);
            this.Name = "FormMaxMinTwoNumber";
            this.Text = "Max Min Two Number";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumberA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbNumberB;
    }
}

