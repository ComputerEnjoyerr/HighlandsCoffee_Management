﻿namespace GUI
{
    partial class frmAdChiNhanh
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
            this.flpChiNhanh = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtDongCua = new System.Windows.Forms.DateTimePicker();
            this.dtMoCua = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbQuanLy = new System.Windows.Forms.ComboBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpChiNhanh
            // 
            this.flpChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpChiNhanh.AutoScroll = true;
            this.flpChiNhanh.Location = new System.Drawing.Point(12, 47);
            this.flpChiNhanh.Name = "flpChiNhanh";
            this.flpChiNhanh.Size = new System.Drawing.Size(950, 330);
            this.flpChiNhanh.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtDiaChi);
            this.pnlMain.Controls.Add(this.button6);
            this.pnlMain.Controls.Add(this.button4);
            this.pnlMain.Controls.Add(this.button3);
            this.pnlMain.Controls.Add(this.button2);
            this.pnlMain.Controls.Add(this.dtDongCua);
            this.pnlMain.Controls.Add(this.dtMoCua);
            this.pnlMain.Controls.Add(this.cbStatus);
            this.pnlMain.Controls.Add(this.cbQuanLy);
            this.pnlMain.Controls.Add(this.txtTenCN);
            this.pnlMain.Controls.Add(this.txtTienThue);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtMaCN);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(13, 383);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(949, 275);
            this.pnlMain.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(143, 91);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(242, 79);
            this.txtDiaChi.TabIndex = 41;
            this.txtDiaChi.Text = "";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(401, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 41);
            this.button6.TabIndex = 37;
            this.button6.Text = "Hoàn tác";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(702, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 58);
            this.button4.TabIndex = 38;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 58);
            this.button3.TabIndex = 39;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 58);
            this.button2.TabIndex = 40;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtDongCua
            // 
            this.dtDongCua.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDongCua.Location = new System.Drawing.Point(505, 90);
            this.dtDongCua.Name = "dtDongCua";
            this.dtDongCua.Size = new System.Drawing.Size(126, 24);
            this.dtDongCua.TabIndex = 36;
            // 
            // dtMoCua
            // 
            this.dtMoCua.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtMoCua.Location = new System.Drawing.Point(505, 58);
            this.dtMoCua.Name = "dtMoCua";
            this.dtMoCua.Size = new System.Drawing.Size(126, 24);
            this.dtMoCua.TabIndex = 36;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(183, 214);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(202, 26);
            this.cbStatus.TabIndex = 35;
            // 
            // cbQuanLy
            // 
            this.cbQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuanLy.FormattingEnabled = true;
            this.cbQuanLy.Location = new System.Drawing.Point(505, 120);
            this.cbQuanLy.Name = "cbQuanLy";
            this.cbQuanLy.Size = new System.Drawing.Size(141, 26);
            this.cbQuanLy.TabIndex = 35;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(143, 60);
            this.txtTenCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(242, 24);
            this.txtTenCN.TabIndex = 30;
            // 
            // txtTienThue
            // 
            this.txtTienThue.Location = new System.Drawing.Point(183, 183);
            this.txtTienThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Size = new System.Drawing.Size(202, 24);
            this.txtTienThue.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Giờ đóng cửa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tiền thuê mặt bằng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Trạng thái hoạt động:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Giờ mở cửa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quản lý:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(505, 27);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 24);
            this.txtPhone.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên chi nhánh";
            // 
            // txtMaCN
            // 
            this.txtMaCN.Enabled = false;
            this.txtMaCN.Location = new System.Drawing.Point(143, 28);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.ReadOnly = true;
            this.txtMaCN.Size = new System.Drawing.Size(141, 24);
            this.txtMaCN.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã chi nhánh:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(119, 13);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(303, 24);
            this.txtTim.TabIndex = 17;
            this.txtTim.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(12, 16);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(104, 18);
            this.lbTim.TabIndex = 16;
            this.lbTim.Text = "Tìm chi nhánh:";
            // 
            // frmAdChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 661);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flpChiNhanh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdChiNhanh";
            this.Text = "frmAdChiNhanh";
            this.Load += new System.EventHandler(this.frmAdChiNhanh_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpChiNhanh;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtMoCua;
        private System.Windows.Forms.ComboBox cbQuanLy;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDongCua;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCN;
    }
}