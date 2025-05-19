namespace GUI
{
    partial class frmAdXoaSuaCongThuc
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
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.cboNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.dgvCongThuc = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.btnSuaCT);
            this.pnlMain.Controls.Add(this.btnXoaCT);
            this.pnlMain.Controls.Add(this.cboNguyenLieu);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtDVT);
            this.pnlMain.Controls.Add(this.txtSoLuong);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtMaCT);
            this.pnlMain.Location = new System.Drawing.Point(20, 18);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(724, 144);
            this.pnlMain.TabIndex = 0;
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(550, 29);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(120, 55);
            this.btnSuaCT.TabIndex = 32;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(386, 28);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(120, 55);
            this.btnXoaCT.TabIndex = 33;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguyenLieu.FormattingEnabled = true;
            this.cboNguyenLieu.Location = new System.Drawing.Point(132, 28);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Size = new System.Drawing.Size(192, 26);
            this.cboNguyenLieu.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Đơn vị tính:";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(132, 90);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(158, 24);
            this.txtDVT.TabIndex = 30;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(132, 60);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 24);
            this.txtSoLuong.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nguyên liệu:";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(132, 30);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(10, 24);
            this.txtMaCT.TabIndex = 35;
            this.txtMaCT.Visible = false;
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCongThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongThuc.Location = new System.Drawing.Point(20, 170);
            this.dgvCongThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCongThuc.MultiSelect = false;
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.Size = new System.Drawing.Size(724, 436);
            this.dgvCongThuc.TabIndex = 1;
            this.dgvCongThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongThuc_CellClick);
            // 
            // frmAdXoaSuaCongThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 623);
            this.Controls.Add(this.dgvCongThuc);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdXoaSuaCongThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAdXoaSuaCongThuc_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvCongThuc;
        private System.Windows.Forms.ComboBox cboNguyenLieu;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtDVT;
    }
}