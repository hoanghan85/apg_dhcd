using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ElectionVoteList : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectionVoteList));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel15 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel16 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Electioncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electionname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delegatecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delegatename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
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
            this.ToolStripSeparator2,
            this.ToolStripLabel1,
            this.ToolStripTextBox1,
            this.ToolStripSeparator1,
            this.ToolStripLabel2,
            this.ToolStripTextBox2,
            this.ToolStripSeparator3,
            this.ToolStripLabel3,
            this.ToolStripTextBox3,
            this.ToolStripSeparator4,
            this.ToolStripButton4});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(959, 26);
            this.ToolStrip1.TabIndex = 12;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(79, 23);
            this.ToolStripLabel1.Text = "Mã bầu cử";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(132, 26);
            this.ToolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyUp);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(88, 23);
            this.ToolStripLabel2.Text = "Mã đại biểu";
            // 
            // ToolStripTextBox2
            // 
            this.ToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox2.Name = "ToolStripTextBox2";
            this.ToolStripTextBox2.Size = new System.Drawing.Size(132, 26);
            this.ToolStripTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox2_KeyUp);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolStripLabel3
            // 
            this.ToolStripLabel3.Name = "ToolStripLabel3";
            this.ToolStripLabel3.Size = new System.Drawing.Size(102, 23);
            this.ToolStripLabel3.Text = "Mã ứng viên : ";
            // 
            // ToolStripTextBox3
            // 
            this.ToolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox3.Name = "ToolStripTextBox3";
            this.ToolStripTextBox3.Size = new System.Drawing.Size(132, 27);
            this.ToolStripTextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox3_KeyUp);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripSplitButton3,
            this.ToolStripStatusLabel15,
            this.ToolStripStatusLabel16});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 613);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1151, 26);
            this.StatusStrip1.TabIndex = 14;
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
            // ToolStripStatusLabel15
            // 
            this.ToolStripStatusLabel15.Name = "ToolStripStatusLabel15";
            this.ToolStripStatusLabel15.Size = new System.Drawing.Size(143, 20);
            this.ToolStripStatusLabel15.Text = "Tổng số phiếu bầu : ";
            // 
            // ToolStripStatusLabel16
            // 
            this.ToolStripStatusLabel16.Name = "ToolStripStatusLabel16";
            this.ToolStripStatusLabel16.Size = new System.Drawing.Size(161, 20);
            this.ToolStripStatusLabel16.Text = "ToolStripStatusLabel16";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Electioncode,
            this.electionname,
            this.delegatecode,
            this.Delegatename,
            this.candidatecode,
            this.candidatename,
            this.Votes});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 22);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(959, 489);
            this.DataGridView1.TabIndex = 15;
            // 
            // Electioncode
            // 
            this.Electioncode.DataPropertyName = "Electioncode";
            this.Electioncode.FillWeight = 59.08628F;
            this.Electioncode.HeaderText = "Mã bầu cử";
            this.Electioncode.MinimumWidth = 6;
            this.Electioncode.Name = "Electioncode";
            this.Electioncode.ReadOnly = true;
            // 
            // electionname
            // 
            this.electionname.DataPropertyName = "electionname";
            this.electionname.FillWeight = 59.08628F;
            this.electionname.HeaderText = "Tên bầu cử";
            this.electionname.MinimumWidth = 6;
            this.electionname.Name = "electionname";
            this.electionname.ReadOnly = true;
            // 
            // delegatecode
            // 
            this.delegatecode.DataPropertyName = "delegatecode";
            this.delegatecode.HeaderText = "Mã đại biểu";
            this.delegatecode.MinimumWidth = 6;
            this.delegatecode.Name = "delegatecode";
            this.delegatecode.ReadOnly = true;
            // 
            // Delegatename
            // 
            this.Delegatename.DataPropertyName = "Delegatename";
            this.Delegatename.HeaderText = "Tên đại biểu";
            this.Delegatename.MinimumWidth = 6;
            this.Delegatename.Name = "Delegatename";
            this.Delegatename.ReadOnly = true;
            // 
            // candidatecode
            // 
            this.candidatecode.DataPropertyName = "candidatecode";
            dataGridViewCellStyle3.Format = "N0";
            this.candidatecode.DefaultCellStyle = dataGridViewCellStyle3;
            this.candidatecode.HeaderText = "Mã ứng viên";
            this.candidatecode.MinimumWidth = 6;
            this.candidatecode.Name = "candidatecode";
            this.candidatecode.ReadOnly = true;
            // 
            // candidatename
            // 
            this.candidatename.DataPropertyName = "candidatename";
            this.candidatename.HeaderText = "Tên ứng viên";
            this.candidatename.MinimumWidth = 6;
            this.candidatename.Name = "candidatename";
            this.candidatename.ReadOnly = true;
            // 
            // Votes
            // 
            this.Votes.DataPropertyName = "Votes";
            dataGridViewCellStyle4.Format = "N0";
            this.Votes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Votes.HeaderText = "Số phiếu bầu";
            this.Votes.MinimumWidth = 6;
            this.Votes.Name = "Votes";
            this.Votes.ReadOnly = true;
            // 
            // ToolStripSplitButton3
            // 
            this.ToolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSplitButton3.Image")));
            this.ToolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSplitButton3.Name = "ToolStripSplitButton3";
            this.ToolStripSplitButton3.Size = new System.Drawing.Size(19, 24);
            this.ToolStripSplitButton3.Text = "ToolStripSplitButton3";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Image = global::pmDHCD.My.Resources.Resources.Add;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(94, 23);
            this.ToolStripButton1.Text = "Thêm (A)";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Enabled = false;
            this.ToolStripButton2.Image = global::pmDHCD.My.Resources.Resources.Document;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(80, 23);
            this.ToolStripButton2.Text = "Sửa (E)";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Image = global::pmDHCD.My.Resources.Resources.Delete;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(84, 23);
            this.ToolStripButton3.Text = "Xóa (D)";
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Image = global::pmDHCD.My.Resources.Resources.Search;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(58, 24);
            this.ToolStripButton4.Text = "Tìm";
            this.ToolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // ElectionVoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ToolStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ElectionVoteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu bầu cử";
            this.Load += new System.EventHandler(this.ElectionVoteList_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ElectionVoteList_KeyUp);
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
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStripTextBox ToolStripTextBox1;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripTextBox ToolStripTextBox2;
        internal ToolStripButton ToolStripButton4;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripSplitButton ToolStripSplitButton3;
        internal ToolStripStatusLabel ToolStripStatusLabel15;
        internal ToolStripStatusLabel ToolStripStatusLabel16;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripLabel ToolStripLabel3;
        internal ToolStripTextBox ToolStripTextBox3;
        internal ToolStripSeparator ToolStripSeparator4;
        internal DataGridView DataGridView1;
        internal DataGridViewTextBoxColumn Electioncode;
        internal DataGridViewTextBoxColumn electionname;
        internal DataGridViewTextBoxColumn delegatecode;
        internal DataGridViewTextBoxColumn Delegatename;
        internal DataGridViewTextBoxColumn candidatecode;
        internal DataGridViewTextBoxColumn candidatename;
        internal DataGridViewTextBoxColumn Votes;
    }
}