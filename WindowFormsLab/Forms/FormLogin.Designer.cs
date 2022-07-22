namespace WindowFormsLab.Forms
{
    partial class FormLogin
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
            this.lBoxDetails = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbASP = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.rdioFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lBoxDetails);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbASP);
            this.panel1.Controls.Add(this.cbC);
            this.panel1.Controls.Add(this.rdioFemale);
            this.panel1.Controls.Add(this.rdoMale);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 446);
            this.panel1.TabIndex = 0;
            // 
            // lBoxDetails
            // 
            this.lBoxDetails.FormattingEnabled = true;
            this.lBoxDetails.ItemHeight = 16;
            this.lBoxDetails.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Phú Quốc",
            "Đà Lạt",
            "Phú Yên"});
            this.lBoxDetails.Location = new System.Drawing.Point(12, 212);
            this.lBoxDetails.Name = "lBoxDetails";
            this.lBoxDetails.Size = new System.Drawing.Size(326, 148);
            this.lBoxDetails.TabIndex = 6;
            this.lBoxDetails.SelectedIndexChanged += new System.EventHandler(this.lBoxDetails_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbASP
            // 
            this.cbASP.AutoSize = true;
            this.cbASP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbASP.Location = new System.Drawing.Point(493, 246);
            this.cbASP.Name = "cbASP";
            this.cbASP.Size = new System.Drawing.Size(62, 22);
            this.cbASP.TabIndex = 4;
            this.cbASP.TabStop = false;
            this.cbASP.Text = "ASP";
            this.cbASP.UseVisualStyleBackColor = true;
            this.cbASP.Click += new System.EventHandler(this.checkButton);
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbC.Location = new System.Drawing.Point(493, 195);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(51, 22);
            this.cbC.TabIndex = 3;
            this.cbC.Text = "C#";
            this.cbC.UseVisualStyleBackColor = true;
            this.cbC.Click += new System.EventHandler(this.checkButton);
            // 
            // rdioFemale
            // 
            this.rdioFemale.AutoSize = true;
            this.rdioFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioFemale.Location = new System.Drawing.Point(493, 89);
            this.rdioFemale.Name = "rdioFemale";
            this.rdioFemale.Size = new System.Drawing.Size(84, 22);
            this.rdioFemale.TabIndex = 2;
            this.rdioFemale.Text = "Female";
            this.rdioFemale.UseVisualStyleBackColor = true;
            this.rdioFemale.Click += new System.EventHandler(this.radioButton);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(493, 28);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(65, 22);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.Click += new System.EventHandler(this.radioButton);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(103, 80);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(217, 24);
            this.tbAddress.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(103, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(217, 24);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowFormsLab.Properties.Resources.logo_dai_hoc_gia_dinh2;
            this.pictureBox1.Location = new System.Drawing.Point(652, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lBoxDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbASP;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.RadioButton rdioFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}