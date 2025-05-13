namespace GUI
{
    partial class frmDatMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatMon));
            this.tabBanAn = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDatMon = new System.Windows.Forms.TabPage();
            this.pnlMain2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.pnlDatMon = new System.Windows.Forms.Panel();
            this.nbrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.btnChonKhach = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbBan = new System.Windows.Forms.Label();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.imlSanPham = new System.Windows.Forms.ImageList(this.components);
            this.tabBanAn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabDatMon.SuspendLayout();
            this.pnlMain2.SuspendLayout();
            this.pnlDatMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBanAn
            // 
            this.tabBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBanAn.Controls.Add(this.tabPage1);
            this.tabBanAn.Controls.Add(this.tabDatMon);
            this.tabBanAn.Location = new System.Drawing.Point(0, 0);
            this.tabBanAn.Name = "tabBanAn";
            this.tabBanAn.SelectedIndex = 0;
            this.tabBanAn.Size = new System.Drawing.Size(794, 711);
            this.tabBanAn.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpBan);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bàn ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpBan
            // 
            this.flpBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBan.Location = new System.Drawing.Point(3, 3);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(780, 674);
            this.flpBan.TabIndex = 0;
            // 
            // tabDatMon
            // 
            this.tabDatMon.Controls.Add(this.pnlMain2);
            this.tabDatMon.Location = new System.Drawing.Point(4, 27);
            this.tabDatMon.Name = "tabDatMon";
            this.tabDatMon.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatMon.Size = new System.Drawing.Size(786, 680);
            this.tabDatMon.TabIndex = 1;
            this.tabDatMon.Text = "Đặt món";
            this.tabDatMon.UseVisualStyleBackColor = true;
            // 
            // pnlMain2
            // 
            this.pnlMain2.Controls.Add(this.textBox2);
            this.pnlMain2.Controls.Add(this.lbTim);
            this.pnlMain2.Controls.Add(this.pnlDatMon);
            this.pnlMain2.Controls.Add(this.flpSanPham);
            this.pnlMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain2.Location = new System.Drawing.Point(3, 3);
            this.pnlMain2.Name = "pnlMain2";
            this.pnlMain2.Size = new System.Drawing.Size(780, 674);
            this.pnlMain2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 30);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 24);
            this.textBox2.TabIndex = 7;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(5, 36);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(106, 18);
            this.lbTim.TabIndex = 6;
            this.lbTim.Text = "Tìm sản phẩm:";
            // 
            // pnlDatMon
            // 
            this.pnlDatMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatMon.Controls.Add(this.nbrSoLuong);
            this.pnlDatMon.Controls.Add(this.label2);
            this.pnlDatMon.Controls.Add(this.label3);
            this.pnlDatMon.Controls.Add(this.label1);
            this.pnlDatMon.Controls.Add(this.txtTenMon);
            this.pnlDatMon.Controls.Add(this.txtKH);
            this.pnlDatMon.Controls.Add(this.btnChonKhach);
            this.pnlDatMon.Controls.Add(this.btnThem);
            this.pnlDatMon.Controls.Add(this.btnXoa);
            this.pnlDatMon.Controls.Add(this.lbBan);
            this.pnlDatMon.Controls.Add(this.dgvMonAn);
            this.pnlDatMon.Location = new System.Drawing.Point(448, 3);
            this.pnlDatMon.Name = "pnlDatMon";
            this.pnlDatMon.Size = new System.Drawing.Size(326, 671);
            this.pnlDatMon.TabIndex = 5;
            // 
            // nbrSoLuong
            // 
            this.nbrSoLuong.Location = new System.Drawing.Point(102, 188);
            this.nbrSoLuong.Name = "nbrSoLuong";
            this.nbrSoLuong.Size = new System.Drawing.Size(135, 24);
            this.nbrSoLuong.TabIndex = 7;
            this.nbrSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khách hàng:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(102, 153);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(212, 24);
            this.txtTenMon.TabIndex = 5;
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(102, 79);
            this.txtKH.Name = "txtKH";
            this.txtKH.ReadOnly = true;
            this.txtKH.Size = new System.Drawing.Size(212, 24);
            this.txtKH.TabIndex = 5;
            // 
            // btnChonKhach
            // 
            this.btnChonKhach.Location = new System.Drawing.Point(7, 111);
            this.btnChonKhach.Name = "btnChonKhach";
            this.btnChonKhach.Size = new System.Drawing.Size(136, 36);
            this.btnChonKhach.TabIndex = 4;
            this.btnChonKhach.Text = "Chọn khách hàng";
            this.btnChonKhach.UseVisualStyleBackColor = true;
            this.btnChonKhach.Click += new System.EventHandler(this.btnChonKhach_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(3, 597);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 69);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(192, 597);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 69);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.Location = new System.Drawing.Point(8, 9);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(94, 31);
            this.lbBan.TabIndex = 1;
            this.lbBan.Text = "Bàn....";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(0, 223);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(323, 368);
            this.dgvMonAn.TabIndex = 0;
            // 
            // flpSanPham
            // 
            this.flpSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSanPham.AutoScroll = true;
            this.flpSanPham.Location = new System.Drawing.Point(3, 57);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(439, 617);
            this.flpSanPham.TabIndex = 4;
            // 
            // imlSanPham
            // 
            this.imlSanPham.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSanPham.ImageStream")));
            this.imlSanPham.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSanPham.Images.SetKeyName(0, "noImage.png");
            // 
            // frmDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 711);
            this.Controls.Add(this.tabBanAn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatMon";
            this.Text = "frmDatMon";
            this.Load += new System.EventHandler(this.frmDatMon_Load);
            this.tabBanAn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabDatMon.ResumeLayout(false);
            this.pnlMain2.ResumeLayout(false);
            this.pnlMain2.PerformLayout();
            this.pnlDatMon.ResumeLayout(false);
            this.pnlDatMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBanAn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabDatMon;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Panel pnlMain2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Panel pnlDatMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.ImageList imlSanPham;
        private System.Windows.Forms.Button btnChonKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbrSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
    }
}