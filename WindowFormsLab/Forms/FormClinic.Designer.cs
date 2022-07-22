namespace WindowFormsLab.Forms
{
    partial class FormClinic
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.btTinhTong = new System.Windows.Forms.Button();
            this.numberTrongRang = new System.Windows.Forms.NumericUpDown();
            this.numberNhoRang = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxNiemRang = new System.Windows.Forms.CheckBox();
            this.checkBoxTayRang = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTrongRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNhoRang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 575);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTong);
            this.groupBox2.Controls.Add(this.btTinhTong);
            this.groupBox2.Controls.Add(this.numberTrongRang);
            this.groupBox2.Controls.Add(this.numberNhoRang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CheckBoxNiemRang);
            this.groupBox2.Controls.Add(this.checkBoxTayRang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 340);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch Vụ";
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(190, 259);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(167, 28);
            this.tbTong.TabIndex = 7;
            // 
            // btTinhTong
            // 
            this.btTinhTong.Location = new System.Drawing.Point(45, 255);
            this.btTinhTong.Name = "btTinhTong";
            this.btTinhTong.Size = new System.Drawing.Size(110, 32);
            this.btTinhTong.TabIndex = 6;
            this.btTinhTong.Text = "Tính Tổng";
            this.btTinhTong.UseVisualStyleBackColor = true;
            // 
            // numberTrongRang
            // 
            this.numberTrongRang.Location = new System.Drawing.Point(242, 171);
            this.numberTrongRang.Name = "numberTrongRang";
            this.numberTrongRang.Size = new System.Drawing.Size(76, 28);
            this.numberTrongRang.TabIndex = 5;
            // 
            // numberNhoRang
            // 
            this.numberNhoRang.Location = new System.Drawing.Point(242, 123);
            this.numberNhoRang.Name = "numberNhoRang";
            this.numberNhoRang.Size = new System.Drawing.Size(76, 28);
            this.numberNhoRang.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trồng Răng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhổ Răng";
            // 
            // CheckBoxNiemRang
            // 
            this.CheckBoxNiemRang.AutoSize = true;
            this.CheckBoxNiemRang.Location = new System.Drawing.Point(242, 47);
            this.CheckBoxNiemRang.Name = "CheckBoxNiemRang";
            this.CheckBoxNiemRang.Size = new System.Drawing.Size(130, 26);
            this.CheckBoxNiemRang.TabIndex = 1;
            this.CheckBoxNiemRang.Text = "Niềm Răng";
            this.CheckBoxNiemRang.UseVisualStyleBackColor = true;
            // 
            // checkBoxTayRang
            // 
            this.checkBoxTayRang.AutoSize = true;
            this.checkBoxTayRang.Location = new System.Drawing.Point(36, 47);
            this.checkBoxTayRang.Name = "checkBoxTayRang";
            this.checkBoxTayRang.Size = new System.Drawing.Size(119, 26);
            this.checkBoxTayRang.TabIndex = 0;
            this.checkBoxTayRang.Text = "Tẩy Răng";
            this.checkBoxTayRang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckName);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // btnCheckName
            // 
            this.btnCheckName.Location = new System.Drawing.Point(297, 75);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(122, 38);
            this.btnCheckName.TabIndex = 4;
            this.btnCheckName.Text = "Kiểm Tra";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // lbGender
            // 
            this.lbGender.FormattingEnabled = true;
            this.lbGender.ItemHeight = 18;
            this.lbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.lbGender.Location = new System.Drawing.Point(119, 75);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(154, 22);
            this.lbGender.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Và Tên";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(119, 32);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(300, 24);
            this.tbFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG TÍNH TIỀN PHÒNG KHÁM";
            // 
            // FormClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 576);
            this.Controls.Add(this.panel1);
            this.Name = "FormClinic";
            this.Text = "FormClinic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTrongRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNhoRang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckBoxNiemRang;
        private System.Windows.Forms.CheckBox checkBoxTayRang;
        private System.Windows.Forms.NumericUpDown numberTrongRang;
        private System.Windows.Forms.NumericUpDown numberNhoRang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.Button btTinhTong;
        private System.Windows.Forms.Button btnCheckName;
    }
}