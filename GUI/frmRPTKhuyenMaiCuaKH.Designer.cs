namespace GUI
{
    partial class frmRPTKhuyenMaiCuaKH
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptKhuyenMaiCuaKH1 = new GUI.rptKhuyenMaiCuaKH();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.rptKhuyenMaiCuaKH1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1010, 575);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmRPTKhuyenMaiCuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 575);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmRPTKhuyenMaiCuaKH";
            this.Text = "frmRPTKhuyenMaiCuaKH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRPTKhuyenMaiCuaKH_FormClosed);
            this.Load += new System.EventHandler(this.frmRPTKhuyenMaiCuaKH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rptKhuyenMaiCuaKH rptKhuyenMaiCuaKH1;
    }
}