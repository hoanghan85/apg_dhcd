using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Mainform : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuộcHọpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchCuộcHọpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchCổĐôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchĐạiBiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchỦyQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThôngTinCuộcHọpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BiểuQuyếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KếtQuảBiểuQuyếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BầuCửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchVấnĐềBầuCửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchỨngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchPhiếuBầuCửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KếtQuảBầuCửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BáoCáoToolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuStrip1.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HệThốngToolStripMenuItem,
            this.CuộcHọpToolStripMenuItem,
            this.BiểuQuyếtToolStripMenuItem,
            this.BầuCửToolStripMenuItem,
            this.BáoCáoToolStripMenuItem,
            this.HiểnThịToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1164, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // HệThốngToolStripMenuItem
            // 
            this.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem";
            this.HệThốngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.HệThốngToolStripMenuItem.Text = "&1.Hệ thống";
            // 
            // CuộcHọpToolStripMenuItem
            // 
            this.CuộcHọpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSáchCuộcHọpToolStripMenuItem,
            this.DanhSáchCổĐôngToolStripMenuItem,
            this.DanhSáchĐạiBiểuToolStripMenuItem,
            this.DanhSáchỦyQuyềnToolStripMenuItem,
            this.ThôngTinCuộcHọpToolStripMenuItem});
            this.CuộcHọpToolStripMenuItem.Name = "CuộcHọpToolStripMenuItem";
            this.CuộcHọpToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.CuộcHọpToolStripMenuItem.Text = "&2.Cuộc họp ";
            // 
            // DanhSáchCuộcHọpToolStripMenuItem
            // 
            this.DanhSáchCuộcHọpToolStripMenuItem.Name = "DanhSáchCuộcHọpToolStripMenuItem";
            this.DanhSáchCuộcHọpToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.DanhSáchCuộcHọpToolStripMenuItem.Text = "1. Danh sách cuộc họp";
            this.DanhSáchCuộcHọpToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchCuộcHọpToolStripMenuItem_Click);
            // 
            // DanhSáchCổĐôngToolStripMenuItem
            // 
            this.DanhSáchCổĐôngToolStripMenuItem.Name = "DanhSáchCổĐôngToolStripMenuItem";
            this.DanhSáchCổĐôngToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.DanhSáchCổĐôngToolStripMenuItem.Text = "2. Danh sách cổ đông";
            this.DanhSáchCổĐôngToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchCổĐôngToolStripMenuItem_Click);
            // 
            // DanhSáchĐạiBiểuToolStripMenuItem
            // 
            this.DanhSáchĐạiBiểuToolStripMenuItem.Name = "DanhSáchĐạiBiểuToolStripMenuItem";
            this.DanhSáchĐạiBiểuToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.DanhSáchĐạiBiểuToolStripMenuItem.Text = "3. Danh sách đại biểu";
            this.DanhSáchĐạiBiểuToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchĐạiBiểuToolStripMenuItem_Click);
            // 
            // DanhSáchỦyQuyềnToolStripMenuItem
            // 
            this.DanhSáchỦyQuyềnToolStripMenuItem.Name = "DanhSáchỦyQuyềnToolStripMenuItem";
            this.DanhSáchỦyQuyềnToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.DanhSáchỦyQuyềnToolStripMenuItem.Text = "4. Danh sách ủy quyền";
            this.DanhSáchỦyQuyềnToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchỦyQuyềnToolStripMenuItem_Click);
            // 
            // ThôngTinCuộcHọpToolStripMenuItem
            // 
            this.ThôngTinCuộcHọpToolStripMenuItem.Name = "ThôngTinCuộcHọpToolStripMenuItem";
            this.ThôngTinCuộcHọpToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ThôngTinCuộcHọpToolStripMenuItem.Text = "5. Thông tin cuộc họp";
            this.ThôngTinCuộcHọpToolStripMenuItem.Click += new System.EventHandler(this.ThôngTinCuộcHọpToolStripMenuItem_Click);
            // 
            // BiểuQuyếtToolStripMenuItem
            // 
            this.BiểuQuyếtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.KếtQuảBiểuQuyếtToolStripMenuItem});
            this.BiểuQuyếtToolStripMenuItem.Name = "BiểuQuyếtToolStripMenuItem";
            this.BiểuQuyếtToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.BiểuQuyếtToolStripMenuItem.Text = "&3.Biểu quyết";
            this.BiểuQuyếtToolStripMenuItem.Click += new System.EventHandler(this.BiểuQuyếtToolStripMenuItem_Click);
            // 
            // DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem
            // 
            this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Name = "DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem";
            this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Text = "1. Danh sách vấn đề biểu quyết";
            this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(297, 26);
            this.ToolStripMenuItem1.Text = "2. Danh sách phiếu biểu quyết";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // KếtQuảBiểuQuyếtToolStripMenuItem
            // 
            this.KếtQuảBiểuQuyếtToolStripMenuItem.Name = "KếtQuảBiểuQuyếtToolStripMenuItem";
            this.KếtQuảBiểuQuyếtToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.KếtQuảBiểuQuyếtToolStripMenuItem.Text = "3. Kết quả biểu quyết";
            this.KếtQuảBiểuQuyếtToolStripMenuItem.Click += new System.EventHandler(this.KếtQuảBiểuQuyếtToolStripMenuItem_Click);
            // 
            // BầuCửToolStripMenuItem
            // 
            this.BầuCửToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSáchVấnĐềBầuCửToolStripMenuItem,
            this.DanhSáchỨngViênToolStripMenuItem,
            this.DanhSáchPhiếuBầuCửToolStripMenuItem,
            this.KếtQuảBầuCửToolStripMenuItem,
            this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem});
            this.BầuCửToolStripMenuItem.Name = "BầuCửToolStripMenuItem";
            this.BầuCửToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.BầuCửToolStripMenuItem.Text = "&4.Bầu cử";
            // 
            // DanhSáchVấnĐềBầuCửToolStripMenuItem
            // 
            this.DanhSáchVấnĐềBầuCửToolStripMenuItem.Name = "DanhSáchVấnĐềBầuCửToolStripMenuItem";
            this.DanhSáchVấnĐềBầuCửToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.DanhSáchVấnĐềBầuCửToolStripMenuItem.Text = "1. Danh sách vấn đề bầu cử";
            this.DanhSáchVấnĐềBầuCửToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchVấnĐềBầuCửToolStripMenuItem_Click);
            // 
            // DanhSáchỨngViênToolStripMenuItem
            // 
            this.DanhSáchỨngViênToolStripMenuItem.Name = "DanhSáchỨngViênToolStripMenuItem";
            this.DanhSáchỨngViênToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.DanhSáchỨngViênToolStripMenuItem.Text = "2. Danh sách ứng viên";
            this.DanhSáchỨngViênToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchỨngViênToolStripMenuItem_Click);
            // 
            // DanhSáchPhiếuBầuCửToolStripMenuItem
            // 
            this.DanhSáchPhiếuBầuCửToolStripMenuItem.Name = "DanhSáchPhiếuBầuCửToolStripMenuItem";
            this.DanhSáchPhiếuBầuCửToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.DanhSáchPhiếuBầuCửToolStripMenuItem.Text = "3. Danh sách phiếu bầu cử";
            this.DanhSáchPhiếuBầuCửToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchPhiếuBầuCửToolStripMenuItem_Click);
            // 
            // KếtQuảBầuCửToolStripMenuItem
            // 
            this.KếtQuảBầuCửToolStripMenuItem.Name = "KếtQuảBầuCửToolStripMenuItem";
            this.KếtQuảBầuCửToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.KếtQuảBầuCửToolStripMenuItem.Text = "4. Kết quả bầu cử";
            this.KếtQuảBầuCửToolStripMenuItem.Click += new System.EventHandler(this.KếtQuảBầuCửToolStripMenuItem_Click);
            // 
            // DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem
            // 
            this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Name = "DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem";
            this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Text = "5. Danh sách phiếu bầu KHÔNG hợp lệ";
            this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem.Click += new System.EventHandler(this.DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem_Click);
            // 
            // BáoCáoToolStripMenuItem
            // 
            this.BáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BáoCáoToolStripMenuItem_1});
            this.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem";
            this.BáoCáoToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.BáoCáoToolStripMenuItem.Text = "&5.Báo cáo";
            // 
            // BáoCáoToolStripMenuItem_1
            // 
            this.BáoCáoToolStripMenuItem_1.Name = "BáoCáoToolStripMenuItem_1";
            this.BáoCáoToolStripMenuItem_1.Size = new System.Drawing.Size(161, 26);
            this.BáoCáoToolStripMenuItem_1.Text = "1. Báo cáo";
            this.BáoCáoToolStripMenuItem_1.Click += new System.EventHandler(this.BáoCáoToolStripMenuItem_1_Click);
            // 
            // HiểnThịToolStripMenuItem
            // 
            this.HiểnThịToolStripMenuItem.Name = "HiểnThịToolStripMenuItem";
            this.HiểnThịToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.HiểnThịToolStripMenuItem.Text = "&5.Hiển thị";
            this.HiểnThịToolStripMenuItem.Visible = false;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel3});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 826);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.MainStatusStrip.Size = new System.Drawing.Size(1456, 26);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(106, 20);
            this.ToolStripStatusLabel1.Text = "Mã cuộc họp : ";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(153, 20);
            this.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Location = new System.Drawing.Point(0, 28);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1456, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1456, 852);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm họp đại hội cổ đông";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem HệThốngToolStripMenuItem;
        internal ToolStripMenuItem CuộcHọpToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchCuộcHọpToolStripMenuItem;
        internal ToolStripMenuItem BiểuQuyếtToolStripMenuItem;
        internal ToolStripMenuItem BầuCửToolStripMenuItem;
        internal ToolStripMenuItem BáoCáoToolStripMenuItem;
        internal ToolStripMenuItem BáoCáoToolStripMenuItem_1;
        internal ToolStripMenuItem DanhSáchCổĐôngToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchĐạiBiểuToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchỦyQuyềnToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchVấnĐềBiểuQuyếtToolStripMenuItem;
        internal ToolStripMenuItem KếtQuảBiểuQuyếtToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchVấnĐềBầuCửToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchỨngViênToolStripMenuItem;
        internal ToolStripMenuItem KếtQuảBầuCửToolStripMenuItem;
        internal ToolStripMenuItem HiểnThịToolStripMenuItem;
        public StatusStrip MainStatusStrip;
        internal ToolStrip ToolStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripMenuItem ToolStripMenuItem1;
        internal ToolStripMenuItem DanhSáchPhiếuBầuCửToolStripMenuItem;
        internal ToolStripMenuItem ThôngTinCuộcHọpToolStripMenuItem;
        internal ToolStripMenuItem DanhSáchPhiếuBầuKhôngHợpLệToolStripMenuItem;
        public ToolStripStatusLabel ToolStripStatusLabel3;

    }
}