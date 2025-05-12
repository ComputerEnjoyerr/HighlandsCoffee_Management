namespace GUI
{
    partial class frmBanAn
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nbrSucNgoi = new System.Windows.Forms.NumericUpDown();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpBanAn = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSucNgoi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.cboTrangThai);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.nbrSucNgoi);
            this.pnlMain.Controls.Add(this.btnHoanTac);
            this.pnlMain.Controls.Add(this.txtTen);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtMa);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(770, 188);
            this.pnlMain.TabIndex = 25;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(639, 104);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 60);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(502, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 60);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(365, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 60);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nbrSucNgoi
            // 
            this.nbrSucNgoi.Location = new System.Drawing.Point(137, 82);
            this.nbrSucNgoi.Name = "nbrSucNgoi";
            this.nbrSucNgoi.Size = new System.Drawing.Size(168, 28);
            this.nbrSucNgoi.TabIndex = 13;
            this.nbrSucNgoi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(29, 123);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 41);
            this.btnHoanTac.TabIndex = 9;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(137, 51);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(168, 28);
            this.txtTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sức ngồi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(137, 20);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(168, 28);
            this.txtMa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bàn:";
            // 
            // flpBanAn
            // 
            this.flpBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBanAn.AutoScroll = true;
            this.flpBanAn.Location = new System.Drawing.Point(12, 206);
            this.flpBanAn.Name = "flpBanAn";
            this.flpBanAn.Size = new System.Drawing.Size(770, 493);
            this.flpBanAn.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Đã đặt"});
            this.cboTrangThai.Location = new System.Drawing.Point(423, 23);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(190, 30);
            this.cboTrangThai.TabIndex = 17;
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 711);
            this.Controls.Add(this.flpBanAn);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanAn";
            this.Text = "frmAdBanAn";
            this.Load += new System.EventHandler(this.frmAdBanAn_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSucNgoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpBanAn;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.NumericUpDown nbrSucNgoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label4;
    }
}