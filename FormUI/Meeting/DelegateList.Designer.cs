using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DelegateList : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.InPhieuBauBKS = new System.Windows.Forms.ToolStripButton();
            this.InPhieuBauHDQT = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delegatecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delegatename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelegateAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voterights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.ToolStripButton2,
            this.ToolStripButton3,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.ToolStripTextBox1,
            this.ToolStripSeparator2,
            this.ToolStripLabel2,
            this.ToolStripTextBox2,
            this.ToolStripButton4,
            this.ToolStripButton10,
            this.ToolStripSeparator3,
            this.ToolStripButton5,
            this.ToolStripButton7,
            this.InPhieuBauBKS,
            this.InPhieuBauHDQT,
            this.ToolStripButton8,
            this.ToolStripButton6,
            this.ToolStripButton9});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1309, 31);
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Image = global::pmDHCD.My.Resources.Resources.Add;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(90, 28);
            this.ToolStripButton1.Text = "Thêm(A)";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = global::pmDHCD.My.Resources.Resources.Document;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(76, 28);
            this.ToolStripButton2.Text = "Sửa(E)";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Image = global::pmDHCD.My.Resources.Resources.Delete;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(80, 28);
            this.ToolStripButton3.Text = "Xóa(D)";
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(88, 28);
            this.ToolStripLabel1.Text = "Mã đại biểu";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(65, 31);
            this.ToolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyUp);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(91, 28);
            this.ToolStripLabel2.Text = "CCCD/GPKD";
            // 
            // ToolStripTextBox2
            // 
            this.ToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox2.Name = "ToolStripTextBox2";
            this.ToolStripTextBox2.Size = new System.Drawing.Size(132, 31);
            this.ToolStripTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox2_KeyUp);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Image = global::pmDHCD.My.Resources.Resources.Search;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(58, 28);
            this.ToolStripButton4.Text = "Tìm";
            this.ToolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // ToolStripButton10
            // 
            this.ToolStripButton10.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton10.Name = "ToolStripButton10";
            this.ToolStripButton10.Size = new System.Drawing.Size(124, 28);
            this.ToolStripButton10.Text = "P.XN tham dự";
            this.ToolStripButton10.Click += new System.EventHandler(this.ToolStripButton10_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(94, 28);
            this.ToolStripButton5.Text = "In thẻ BQ";
            this.ToolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // ToolStripButton7
            // 
            this.ToolStripButton7.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton7.Name = "ToolStripButton7";
            this.ToolStripButton7.Size = new System.Drawing.Size(93, 28);
            this.ToolStripButton7.Text = "Phiếu BQ";
            this.ToolStripButton7.Click += new System.EventHandler(this.ToolStripButton7_Click_1);
            // 
            // InPhieuBauBKS
            // 
            this.InPhieuBauBKS.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.InPhieuBauBKS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InPhieuBauBKS.Name = "InPhieuBauBKS";
            this.InPhieuBauBKS.Size = new System.Drawing.Size(103, 28);
            this.InPhieuBauBKS.Text = "P. Bầu BSK";
            this.InPhieuBauBKS.Click += new System.EventHandler(this.InPhieuBauBKS_Click);
            // 
            // InPhieuBauHDQT
            // 
            this.InPhieuBauHDQT.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.InPhieuBauHDQT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InPhieuBauHDQT.Name = "InPhieuBauHDQT";
            this.InPhieuBauHDQT.Size = new System.Drawing.Size(117, 28);
            this.InPhieuBauHDQT.Text = "P. Bầu HDQT";
            this.InPhieuBauHDQT.Click += new System.EventHandler(this.InPhieuBauHDQT_Click);
            // 
            // ToolStripButton8
            // 
            this.ToolStripButton8.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton8.Name = "ToolStripButton8";
            this.ToolStripButton8.Size = new System.Drawing.Size(105, 36);
            this.ToolStripButton8.Text = "Phiếu BQ 2";
            this.ToolStripButton8.Visible = false;
            this.ToolStripButton8.Click += new System.EventHandler(this.ToolStripButton8_Click);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(110, 36);
            this.ToolStripButton6.Text = "Phiếu bầu 1";
            this.ToolStripButton6.Visible = false;
            // 
            // ToolStripButton9
            // 
            this.ToolStripButton9.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton9.Name = "ToolStripButton9";
            this.ToolStripButton9.Size = new System.Drawing.Size(110, 36);
            this.ToolStripButton9.Text = "Phiếu bầu 2";
            this.ToolStripButton9.Visible = false;
            this.ToolStripButton9.Click += new System.EventHandler(this.ToolStripButton9_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delegatecode,
            this.Delegatename,
            this.IdentityCard,
            this.DelegateAddress,
            this.Voterights});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 31);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1309, 642);
            this.DataGridView1.TabIndex = 6;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Delegatecode
            // 
            this.Delegatecode.DataPropertyName = "Delegatecode";
            this.Delegatecode.FillWeight = 59.08628F;
            this.Delegatecode.HeaderText = "Mã đại biểu";
            this.Delegatecode.MinimumWidth = 6;
            this.Delegatecode.Name = "Delegatecode";
            this.Delegatecode.ReadOnly = true;
            // 
            // Delegatename
            // 
            this.Delegatename.DataPropertyName = "Delegatename";
            this.Delegatename.FillWeight = 59.08628F;
            this.Delegatename.HeaderText = "Tên đại biểu";
            this.Delegatename.MinimumWidth = 6;
            this.Delegatename.Name = "Delegatename";
            this.Delegatename.ReadOnly = true;
            // 
            // IdentityCard
            // 
            this.IdentityCard.DataPropertyName = "IdentityCard";
            this.IdentityCard.FillWeight = 59.08628F;
            this.IdentityCard.HeaderText = "CMT/GPKD";
            this.IdentityCard.MinimumWidth = 6;
            this.IdentityCard.Name = "IdentityCard";
            this.IdentityCard.ReadOnly = true;
            // 
            // DelegateAddress
            // 
            this.DelegateAddress.DataPropertyName = "DelegateAddress";
            this.DelegateAddress.FillWeight = 200F;
            this.DelegateAddress.HeaderText = "Địa chỉ";
            this.DelegateAddress.MinimumWidth = 6;
            this.DelegateAddress.Name = "DelegateAddress";
            this.DelegateAddress.ReadOnly = true;
            // 
            // Voterights
            // 
            this.Voterights.DataPropertyName = "Voterights";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Voterights.DefaultCellStyle = dataGridViewCellStyle2;
            this.Voterights.FillWeight = 59.08628F;
            this.Voterights.HeaderText = "Tổng  quyền b.quyết";
            this.Voterights.MinimumWidth = 6;
            this.Voterights.Name = "Voterights";
            this.Voterights.ReadOnly = true;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripSplitButton1,
            this.ToolStripStatusLabel3,
            this.ToolStripStatusLabel4});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 649);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1309, 24);
            this.StatusStrip1.TabIndex = 7;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(131, 18);
            this.ToolStripStatusLabel1.Text = "Số lượng bản ghi : ";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(0, 18);
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(19, 22);
            this.ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(180, 18);
            this.ToolStripStatusLabel3.Text = "Tổng số quyền biểu quyết";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(146, 18);
            this.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4";
            // 
            // DelegateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 673);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.ToolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DelegateList";
            this.Text = "Danh sách đại biểu";
            this.Load += new System.EventHandler(this.DelegateList_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DelegateList_KeyUp);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal ToolStrip ToolStrip1;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStripTextBox ToolStripTextBox1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal ToolStripButton ToolStripButton4;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripButton ToolStripButton8;
        internal ToolStripButton ToolStripButton9;
        internal ToolStripButton ToolStripButton10;
        internal DataGridViewTextBoxColumn Delegatecode;
        internal DataGridViewTextBoxColumn Delegatename;
        internal DataGridViewTextBoxColumn IdentityCard;
        internal DataGridViewTextBoxColumn DelegateAddress;
        internal DataGridViewTextBoxColumn Voterights;
        internal ToolStripButton InPhieuBauBKS;
        internal ToolStripButton InPhieuBauHDQT;
        internal ToolStripButton ToolStripButton7;
    }
}