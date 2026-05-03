using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class HolderList : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolderList));
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
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.holdercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolderIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voterights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoteRemains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotVSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.ToolStripButton6,
            this.ToolStripButton5});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1160, 31);
            this.ToolStrip1.TabIndex = 2;
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
            this.ToolStripLabel1.Size = new System.Drawing.Size(89, 28);
            this.ToolStripLabel1.Text = "Mã cổ đông";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(132, 31);
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
            // ToolStripButton6
            // 
            this.ToolStripButton6.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(118, 28);
            this.ToolStripButton6.Text = "In tài liệu..(P)";
            this.ToolStripButton6.Visible = false;
            this.ToolStripButton6.Click += new System.EventHandler(this.ToolStripButton6_Click);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Image = global::pmDHCD.My.Resources.Resources.Printer;
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(109, 28);
            this.ToolStripButton5.Text = "In nhiều CĐ";
            this.ToolStripButton5.Visible = false;
            this.ToolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.holdercode,
            this.HolderName,
            this.HolderIdentity,
            this.IdentityDate,
            this.nationality,
            this.Phone,
            this.email,
            this.HolderAddress,
            this.Shares,
            this.Voterights,
            this.VoteRemains,
            this.NotVSD});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 31);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1160, 541);
            this.DataGridView1.TabIndex = 5;
            // 
            // holdercode
            // 
            this.holdercode.DataPropertyName = "holdercode";
            this.holdercode.FillWeight = 59.08628F;
            this.holdercode.HeaderText = "Mã cổ đông";
            this.holdercode.MinimumWidth = 6;
            this.holdercode.Name = "holdercode";
            this.holdercode.ReadOnly = true;
            this.holdercode.Width = 90;
            // 
            // HolderName
            // 
            this.HolderName.DataPropertyName = "HolderName";
            this.HolderName.FillWeight = 59.08628F;
            this.HolderName.HeaderText = "Tên cổ đông";
            this.HolderName.MinimumWidth = 6;
            this.HolderName.Name = "HolderName";
            this.HolderName.ReadOnly = true;
            this.HolderName.Width = 120;
            // 
            // HolderIdentity
            // 
            this.HolderIdentity.DataPropertyName = "HolderIdentity";
            this.HolderIdentity.FillWeight = 59.08628F;
            this.HolderIdentity.HeaderText = "Số đăng ký sở hữu";
            this.HolderIdentity.MinimumWidth = 6;
            this.HolderIdentity.Name = "HolderIdentity";
            this.HolderIdentity.ReadOnly = true;
            this.HolderIdentity.Width = 94;
            // 
            // IdentityDate
            // 
            this.IdentityDate.DataPropertyName = "IdentityDate";
            this.IdentityDate.HeaderText = "Ngày cấp";
            this.IdentityDate.MinimumWidth = 6;
            this.IdentityDate.Name = "IdentityDate";
            this.IdentityDate.ReadOnly = true;
            this.IdentityDate.Width = 125;
            // 
            // nationality
            // 
            this.nationality.DataPropertyName = "nationality";
            this.nationality.FillWeight = 59.08628F;
            this.nationality.HeaderText = "Quốc tịch";
            this.nationality.MinimumWidth = 6;
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            this.nationality.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // HolderAddress
            // 
            this.HolderAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HolderAddress.DataPropertyName = "HolderAddress";
            this.HolderAddress.FillWeight = 200F;
            this.HolderAddress.HeaderText = "Địa chỉ";
            this.HolderAddress.MinimumWidth = 6;
            this.HolderAddress.Name = "HolderAddress";
            this.HolderAddress.ReadOnly = true;
            this.HolderAddress.Width = 56;
            // 
            // Shares
            // 
            this.Shares.DataPropertyName = "Shares";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.Shares.DefaultCellStyle = dataGridViewCellStyle2;
            this.Shares.FillWeight = 59.08628F;
            this.Shares.HeaderText = "Số cổ phần";
            this.Shares.MinimumWidth = 6;
            this.Shares.Name = "Shares";
            this.Shares.ReadOnly = true;
            this.Shares.Width = 94;
            // 
            // Voterights
            // 
            this.Voterights.DataPropertyName = "Voterights";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.Voterights.DefaultCellStyle = dataGridViewCellStyle3;
            this.Voterights.FillWeight = 59.08628F;
            this.Voterights.HeaderText = "Số quyền biểu quyết";
            this.Voterights.MinimumWidth = 6;
            this.Voterights.Name = "Voterights";
            this.Voterights.ReadOnly = true;
            this.Voterights.Width = 94;
            // 
            // VoteRemains
            // 
            this.VoteRemains.DataPropertyName = "VoteRemains";
            this.VoteRemains.FillWeight = 59.08628F;
            this.VoteRemains.HeaderText = "Quyền biểu quyết còn lại";
            this.VoteRemains.MinimumWidth = 6;
            this.VoteRemains.Name = "VoteRemains";
            this.VoteRemains.ReadOnly = true;
            this.VoteRemains.Width = 125;
            // 
            // NotVSD
            // 
            this.NotVSD.DataPropertyName = "NotVSD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.NotVSD.DefaultCellStyle = dataGridViewCellStyle4;
            this.NotVSD.HeaderText = "Chưa lưu ký";
            this.NotVSD.MinimumWidth = 6;
            this.NotVSD.Name = "NotVSD";
            this.NotVSD.ReadOnly = true;
            this.NotVSD.Width = 125;
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
            this.StatusStrip1.Location = new System.Drawing.Point(0, 546);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1160, 26);
            this.StatusStrip1.TabIndex = 6;
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
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new System.Drawing.Size(19, 24);
            this.ToolStripSplitButton1.Text = "ToolStripSplitButton1";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(130, 20);
            this.ToolStripStatusLabel3.Text = "Tổng số cổ phần : ";
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
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(191, 20);
            this.ToolStripStatusLabel5.Text = "Tổng số quyền biểu quyết : ";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(0, 20);
            // 
            // HolderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 572);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.ToolStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HolderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách cổ đông";
            this.Load += new System.EventHandler(this.HolderList_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HolderList_KeyUp);
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
        internal ToolStripButton ToolStripButton4;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton2;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        private DataGridViewTextBoxColumn holdercode;
        private DataGridViewTextBoxColumn HolderName;
        private DataGridViewTextBoxColumn HolderIdentity;
        private DataGridViewTextBoxColumn IdentityDate;
        private DataGridViewTextBoxColumn nationality;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn HolderAddress;
        private DataGridViewTextBoxColumn Shares;
        private DataGridViewTextBoxColumn Voterights;
        private DataGridViewTextBoxColumn VoteRemains;
        private DataGridViewTextBoxColumn NotVSD;
    }
}