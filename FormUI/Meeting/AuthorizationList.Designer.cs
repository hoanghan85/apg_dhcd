using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AuthorizationList : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Holdercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolderIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delegatecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delegatename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelegateAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voterights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelegateRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
            this.ToolStripLabel2,
            this.ToolStripTextBox2,
            this.ToolStripSeparator2,
            this.ToolStripLabel4,
            this.ToolStripTextBox4,
            this.ToolStripSeparator3,
            this.ToolStripButton5,
            this.ToolStripButton6,
            this.ToolStripButton4});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1253, 31);
            this.ToolStrip1.TabIndex = 4;
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
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(131, 28);
            this.ToolStripLabel2.Text = "CCCD/HC đại biểu";
            // 
            // ToolStripTextBox2
            // 
            this.ToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox2.Name = "ToolStripTextBox2";
            this.ToolStripTextBox2.Size = new System.Drawing.Size(132, 31);
            this.ToolStripTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox2_KeyUp);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripLabel4
            // 
            this.ToolStripLabel4.Name = "ToolStripLabel4";
            this.ToolStripLabel4.Size = new System.Drawing.Size(176, 28);
            this.ToolStripLabel4.Text = "CCCD/HC/GPKD cổ đông";
            // 
            // ToolStripTextBox4
            // 
            this.ToolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox4.Name = "ToolStripTextBox4";
            this.ToolStripTextBox4.Size = new System.Drawing.Size(132, 31);
            this.ToolStripTextBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox4_KeyUp);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Image = global::pmDHCD.My.Resources.Resources.Search;
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(58, 28);
            this.ToolStripButton5.Text = "Tìm";
            this.ToolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.Image = global::pmDHCD.My.Resources.Resources.Search;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(94, 24);
            this.ToolStripButton6.Text = "In thẻ BQ";
            this.ToolStripButton6.Visible = false;
            this.ToolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Image = global::pmDHCD.My.Resources.Resources.Search;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(153, 24);
            this.ToolStripButton4.Text = "In giấy x.nhận t.dự";
            this.ToolStripButton4.Visible = false;
            this.ToolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripSplitButton1,
            this.ToolStripStatusLabel3,
            this.ToolStripStatusLabel4,
            this.ToolStripSplitButton2,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel6});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 544);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1253, 26);
            this.StatusStrip1.TabIndex = 8;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(134, 20);
            this.ToolStripStatusLabel1.Text = "Số lượng bản ghi : ";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // ToolStripSplitButton1
            // 
            this.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSplitButton1.Image")));
            this.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(19, 24);
            this.ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(242, 20);
            this.ToolStripStatusLabel3.Text = "Tổng số quyền biểu quyết của CĐ : ";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(0, 20);
            // 
            // ToolStripSplitButton2
            // 
            this.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSplitButton2.Image")));
            this.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            this.ToolStripSplitButton2.Size = new System.Drawing.Size(19, 24);
            this.ToolStripSplitButton2.Text = "ToolStripSplitButton2";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(292, 20);
            this.ToolStripStatusLabel5.Text = "Tổng số quyền biểu quyết được ủy quyền : ";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(153, 20);
            this.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Holdercode,
            this.holdername,
            this.HolderIdentity,
            this.HolderAddress,
            this.Delegatecode,
            this.Delegatename,
            this.IdentityCard,
            this.DelegateAddress,
            this.voterights,
            this.DelegateRight});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 31);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1253, 513);
            this.DataGridView1.TabIndex = 9;
            // 
            // Holdercode
            // 
            this.Holdercode.DataPropertyName = "Holdercode";
            this.Holdercode.FillWeight = 11.21656F;
            this.Holdercode.HeaderText = "Mã cổ đông";
            this.Holdercode.MinimumWidth = 80;
            this.Holdercode.Name = "Holdercode";
            this.Holdercode.ReadOnly = true;
            // 
            // holdername
            // 
            this.holdername.DataPropertyName = "holdername";
            this.holdername.FillWeight = 196.5355F;
            this.holdername.HeaderText = "Tên cổ đông";
            this.holdername.MinimumWidth = 150;
            this.holdername.Name = "holdername";
            this.holdername.ReadOnly = true;
            // 
            // HolderIdentity
            // 
            this.HolderIdentity.DataPropertyName = "HolderIdentity";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.HolderIdentity.DefaultCellStyle = dataGridViewCellStyle2;
            this.HolderIdentity.FillWeight = 97.21734F;
            this.HolderIdentity.HeaderText = "CCCD/HC/GPKD CĐ";
            this.HolderIdentity.MinimumWidth = 100;
            this.HolderIdentity.Name = "HolderIdentity";
            this.HolderIdentity.ReadOnly = true;
            // 
            // HolderAddress
            // 
            this.HolderAddress.DataPropertyName = "HolderAddress";
            this.HolderAddress.HeaderText = "HolderAddress";
            this.HolderAddress.MinimumWidth = 6;
            this.HolderAddress.Name = "HolderAddress";
            this.HolderAddress.ReadOnly = true;
            this.HolderAddress.Visible = false;
            // 
            // Delegatecode
            // 
            this.Delegatecode.DataPropertyName = "Delegatecode";
            this.Delegatecode.FillWeight = 74.75592F;
            this.Delegatecode.HeaderText = "Mã đại biểu";
            this.Delegatecode.MinimumWidth = 80;
            this.Delegatecode.Name = "Delegatecode";
            this.Delegatecode.ReadOnly = true;
            // 
            // Delegatename
            // 
            this.Delegatename.DataPropertyName = "Delegatename";
            this.Delegatename.FillWeight = 6.621332F;
            this.Delegatename.HeaderText = "Tên đại biểu";
            this.Delegatename.MinimumWidth = 200;
            this.Delegatename.Name = "Delegatename";
            this.Delegatename.ReadOnly = true;
            // 
            // IdentityCard
            // 
            this.IdentityCard.DataPropertyName = "IdentityCard";
            this.IdentityCard.FillWeight = 52.32525F;
            this.IdentityCard.HeaderText = "CMT/HC ĐB";
            this.IdentityCard.MinimumWidth = 100;
            this.IdentityCard.Name = "IdentityCard";
            this.IdentityCard.ReadOnly = true;
            // 
            // DelegateAddress
            // 
            this.DelegateAddress.DataPropertyName = "DelegateAddress";
            this.DelegateAddress.HeaderText = "DelegateAddress";
            this.DelegateAddress.MinimumWidth = 6;
            this.DelegateAddress.Name = "DelegateAddress";
            this.DelegateAddress.ReadOnly = true;
            this.DelegateAddress.Visible = false;
            // 
            // voterights
            // 
            this.voterights.DataPropertyName = "voterights";
            dataGridViewCellStyle3.Format = "N0";
            this.voterights.DefaultCellStyle = dataGridViewCellStyle3;
            this.voterights.FillWeight = 128.2284F;
            this.voterights.HeaderText = "Số quyền BQ CĐ";
            this.voterights.MinimumWidth = 40;
            this.voterights.Name = "voterights";
            this.voterights.ReadOnly = true;
            // 
            // DelegateRight
            // 
            this.DelegateRight.DataPropertyName = "DelegateRight";
            dataGridViewCellStyle4.Format = "N0";
            this.DelegateRight.DefaultCellStyle = dataGridViewCellStyle4;
            this.DelegateRight.FillWeight = 169.4455F;
            this.DelegateRight.HeaderText = "Số quyền BQ ủy quyền";
            this.DelegateRight.MinimumWidth = 40;
            this.DelegateRight.Name = "DelegateRight";
            this.DelegateRight.ReadOnly = true;
            // 
            // AuthorizationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 570);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ToolStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorizationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách ủy quyền";
            this.Load += new System.EventHandler(this.AuthorizationList_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AuthorizationList_KeyUp);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal ToolStrip ToolStrip1;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel4;
        internal ToolStripTextBox ToolStripTextBox4;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripButton ToolStripButton4;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal DataGridView DataGridView1;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton2;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        internal DataGridViewTextBoxColumn Holdercode;
        internal DataGridViewTextBoxColumn holdername;
        internal DataGridViewTextBoxColumn HolderIdentity;
        internal DataGridViewTextBoxColumn HolderAddress;
        internal DataGridViewTextBoxColumn Delegatecode;
        internal DataGridViewTextBoxColumn Delegatename;
        internal DataGridViewTextBoxColumn IdentityCard;
        internal DataGridViewTextBoxColumn DelegateAddress;
        internal DataGridViewTextBoxColumn voterights;
        internal DataGridViewTextBoxColumn DelegateRight;
    }
}