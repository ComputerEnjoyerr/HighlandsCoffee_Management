namespace GUI
{
    partial class frmBaoCaoHangTonKho
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
            this.crvHangTon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BaoCaoHangTonKho1 = new GUI.BaoCaoHangTonKho();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTen = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvHangTon
            // 
            this.crvHangTon.ActiveViewIndex = 0;
            this.crvHangTon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvHangTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHangTon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHangTon.Location = new System.Drawing.Point(12, 80);
            this.crvHangTon.Name = "crvHangTon";
            this.crvHangTon.ReportSource = this.BaoCaoHangTonKho1;
            this.crvHangTon.Size = new System.Drawing.Size(875, 426);
            this.crvHangTon.TabIndex = 3;
            this.crvHangTon.ToolPanelWidth = 225;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTen);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 69);
            this.panel1.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(452, 14);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(86, 34);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên chi nhánh:";
            // 
            // cboTen
            // 
            this.cboTen.FormattingEnabled = true;
            this.cboTen.Location = new System.Drawing.Point(127, 19);
            this.cboTen.Margin = new System.Windows.Forms.Padding(2);
            this.cboTen.Name = "cboTen";
            this.cboTen.Size = new System.Drawing.Size(308, 26);
            this.cboTen.TabIndex = 3;
            // 
            // frmBaoCaoHangTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crvHangTon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBaoCaoHangTonKho";
            this.Text = "frmBaoCaoHangTonKho";
            this.Load += new System.EventHandler(this.frmBaoCaoHangTonKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHangTon;
        private BaoCaoHangTonKho BaoCaoHangTonKho1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTen;
    }
}