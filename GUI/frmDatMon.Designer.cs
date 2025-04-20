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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbBan = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.imlSanPham = new System.Windows.Forms.ImageList(this.components);
            this.tabBanAn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabDatMon.SuspendLayout();
            this.pnlMain2.SuspendLayout();
            this.pnlDatMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
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
            this.pnlDatMon.Controls.Add(this.button4);
            this.pnlDatMon.Controls.Add(this.button3);
            this.pnlDatMon.Controls.Add(this.button2);
            this.pnlDatMon.Controls.Add(this.button1);
            this.pnlDatMon.Controls.Add(this.lbBan);
            this.pnlDatMon.Controls.Add(this.dgvSanPham);
            this.pnlDatMon.Location = new System.Drawing.Point(448, 3);
            this.pnlDatMon.Name = "pnlDatMon";
            this.pnlDatMon.Size = new System.Drawing.Size(326, 671);
            this.pnlDatMon.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(9, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(192, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hủy bỏ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(7, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thêm món";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(125, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.Location = new System.Drawing.Point(10, 19);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(110, 37);
            this.lbBan.TabIndex = 1;
            this.lbBan.Text = "Bàn....";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 74);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(323, 338);
            this.dgvSanPham.TabIndex = 0;
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
            this.imlSanPham.Images.SetKeyName(0, "americano.jpg");
            this.imlSanPham.Images.SetKeyName(1, "bXiuDa.jpg");
            this.imlSanPham.Images.SetKeyName(2, "c&c.jpg");
            this.imlSanPham.Images.SetKeyName(3, "cappuccino.jpg");
            this.imlSanPham.Images.SetKeyName(4, "cappuccinoDa.jpg");
            this.imlSanPham.Images.SetKeyName(5, "chDaVien.jpg");
            this.imlSanPham.Images.SetKeyName(6, "chDaXay.jpg");
            this.imlSanPham.Images.SetKeyName(7, "cheeseCakes.jpg");
            this.imlSanPham.Images.SetKeyName(8, "espresso.jpg");
            this.imlSanPham.Images.SetKeyName(9, "kemDi.jpg");
            this.imlSanPham.Images.SetKeyName(10, "latte.jpg");
            this.imlSanPham.Images.SetKeyName(11, "mCaramel.jpg");
            this.imlSanPham.Images.SetKeyName(12, "mMocha.jpg");
            this.imlSanPham.Images.SetKeyName(13, "muffin.jpg");
            this.imlSanPham.Images.SetKeyName(14, "pastry.jpg");
            this.imlSanPham.Images.SetKeyName(15, "pCaramelFreeze.jpg");
            this.imlSanPham.Images.SetKeyName(16, "pCassia.jpg");
            this.imlSanPham.Images.SetKeyName(17, "pChoco.jpg");
            this.imlSanPham.Images.SetKeyName(18, "pDenDa.jpg");
            this.imlSanPham.Images.SetKeyName(19, "pDenNong.jpg");
            this.imlSanPham.Images.SetKeyName(20, "pHanhNhan.jpg");
            this.imlSanPham.Images.SetKeyName(21, "pKemSua.jpg");
            this.imlSanPham.Images.SetKeyName(22, "pSuaDa.jpg");
            this.imlSanPham.Images.SetKeyName(23, "pSuaNong.jpg");
            this.imlSanPham.Images.SetKeyName(24, "tcDaVien.jpg");
            this.imlSanPham.Images.SetKeyName(25, "trOiHong.jpg");
            this.imlSanPham.Images.SetKeyName(26, "trQuaMongAnhDao.jpg");
            this.imlSanPham.Images.SetKeyName(27, "trThachDao.jpg");
            this.imlSanPham.Images.SetKeyName(28, "trThanhDao.jpg");
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.ImageList imlSanPham;
    }
}