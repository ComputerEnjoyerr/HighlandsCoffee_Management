namespace GUI
{
    partial class frmThanhToan
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
            this.flpKhuyenMai = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlChonBan = new System.Windows.Forms.Panel();
            this.cboBanAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbxInHoaDon = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlChonBan.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // flpKhuyenMai
            // 
            this.flpKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpKhuyenMai.AutoScroll = true;
            this.flpKhuyenMai.Location = new System.Drawing.Point(11, 99);
            this.flpKhuyenMai.Name = "flpKhuyenMai";
            this.flpKhuyenMai.Size = new System.Drawing.Size(355, 600);
            this.flpKhuyenMai.TabIndex = 10;
            // 
            // pnlChonBan
            // 
            this.pnlChonBan.Controls.Add(this.cboBanAn);
            this.pnlChonBan.Controls.Add(this.label1);
            this.pnlChonBan.Location = new System.Drawing.Point(11, 12);
            this.pnlChonBan.Name = "pnlChonBan";
            this.pnlChonBan.Size = new System.Drawing.Size(355, 80);
            this.pnlChonBan.TabIndex = 9;
            // 
            // cboBanAn
            // 
            this.cboBanAn.FormattingEnabled = true;
            this.cboBanAn.Location = new System.Drawing.Point(169, 24);
            this.cboBanAn.Name = "cboBanAn";
            this.cboBanAn.Size = new System.Drawing.Size(121, 26);
            this.cboBanAn.TabIndex = 1;
            this.cboBanAn.SelectedIndexChanged += new System.EventHandler(this.cboBanAn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn bàn thanh toán:";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.cbxInHoaDon);
            this.pnlMain.Controls.Add(this.btnThanhToan);
            this.pnlMain.Controls.Add(this.textBox3);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtKhuyenMai);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtThanhTien);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtTongMon);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.dgvChiTietHoaDon);
            this.pnlMain.Location = new System.Drawing.Point(372, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(411, 687);
            this.pnlMain.TabIndex = 8;
            // 
            // cbxInHoaDon
            // 
            this.cbxInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxInHoaDon.AutoSize = true;
            this.cbxInHoaDon.Location = new System.Drawing.Point(140, 646);
            this.cbxInHoaDon.Name = "cbxInHoaDon";
            this.cbxInHoaDon.Size = new System.Drawing.Size(96, 22);
            this.cbxInHoaDon.TabIndex = 4;
            this.cbxInHoaDon.Text = "In hóa đơn";
            this.cbxInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Location = new System.Drawing.Point(276, 620);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(118, 48);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(113, 580);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 29);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền:";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKhuyenMai.Enabled = false;
            this.txtKhuyenMai.Location = new System.Drawing.Point(91, 542);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(185, 24);
            this.txtKhuyenMai.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giảm giá:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(91, 509);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(185, 24);
            this.txtThanhTien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thành tiền:";
            // 
            // txtTongMon
            // 
            this.txtTongMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongMon.Enabled = false;
            this.txtTongMon.Location = new System.Drawing.Point(91, 479);
            this.txtTongMon.Name = "txtTongMon";
            this.txtTongMon.Size = new System.Drawing.Size(65, 24);
            this.txtTongMon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng món:";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(4, 3);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(404, 464);
            this.dgvChiTietHoaDon.TabIndex = 0;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 711);
            this.Controls.Add(this.flpKhuyenMai);
            this.Controls.Add(this.pnlChonBan);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhToan";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.pnlChonBan.ResumeLayout(false);
            this.pnlChonBan.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKhuyenMai;
        private System.Windows.Forms.Panel pnlChonBan;
        private System.Windows.Forms.ComboBox cboBanAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox cbxInHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
    }
}