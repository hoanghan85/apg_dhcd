using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Elections_result : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elections_result));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MaskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Candidatecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentvote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip2 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.StatusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.MaskedTextBox6);
            this.GroupBox1.Controls.Add(this.MaskedTextBox3);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(1, 2);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1039, 165);
            this.GroupBox1.TabIndex = 57;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vấn đề bầu cử";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown1.Location = new System.Drawing.Point(217, 16);
            this.NumericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(81, 29);
            this.NumericUpDown1.TabIndex = 0;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // MaskedTextBox6
            // 
            this.MaskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox6.Location = new System.Drawing.Point(217, 108);
            this.MaskedTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox6.Name = "MaskedTextBox6";
            this.MaskedTextBox6.ReadOnly = true;
            this.MaskedTextBox6.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox6.TabIndex = 23;
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(217, 64);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.ReadOnly = true;
            this.MaskedTextBox3.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox3.TabIndex = 23;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(13, 116);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(169, 20);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Số ứng viên được bầu";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(15, 64);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(92, 20);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Tên bầu cử";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 22);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 20);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Mã bầu cử";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DataGridView1);
            this.GroupBox2.Location = new System.Drawing.Point(1, 176);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(1039, 460);
            this.GroupBox2.TabIndex = 58;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Kết quả";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Candidatecode,
            this.CandidateName,
            this.Votes,
            this.percentvote});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(4, 19);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1031, 437);
            this.DataGridView1.TabIndex = 14;
            // 
            // Candidatecode
            // 
            this.Candidatecode.DataPropertyName = "Candidatecode";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Candidatecode.DefaultCellStyle = dataGridViewCellStyle2;
            this.Candidatecode.FillWeight = 59.08628F;
            this.Candidatecode.HeaderText = "Mã ứng viên";
            this.Candidatecode.MinimumWidth = 6;
            this.Candidatecode.Name = "Candidatecode";
            this.Candidatecode.ReadOnly = true;
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "CandidateName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CandidateName.FillWeight = 59.08628F;
            this.CandidateName.HeaderText = "Tên ứng viên";
            this.CandidateName.MinimumWidth = 6;
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Votes
            // 
            this.Votes.DataPropertyName = "sumVotes";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            this.Votes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Votes.HeaderText = "Số phiếu bầu";
            this.Votes.MinimumWidth = 6;
            this.Votes.Name = "Votes";
            this.Votes.ReadOnly = true;
            // 
            // percentvote
            // 
            this.percentvote.DataPropertyName = "percentvote";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "n2";
            this.percentvote.DefaultCellStyle = dataGridViewCellStyle5;
            this.percentvote.HeaderText = "Tỷ lệ (%)";
            this.percentvote.MinimumWidth = 6;
            this.percentvote.Name = "percentvote";
            this.percentvote.ReadOnly = true;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripSplitButton1,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel6,
            this.ToolStripSplitButton2,
            this.ToolStripStatusLabel3,
            this.ToolStripStatusLabel4});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 669);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1056, 26);
            this.StatusStrip1.TabIndex = 59;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(131, 20);
            this.ToolStripStatusLabel1.Text = "Số lượng bản ghi : ";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(124, 20);
            this.ToolStripStatusLabel5.Text = "Số phiếu hợp lệ : ";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(153, 20);
            this.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6";
            // 
            // ToolStripSplitButton2
            // 
            this.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripSplitButton2.Name = "ToolStripSplitButton2";
            this.ToolStripSplitButton2.Size = new System.Drawing.Size(19, 24);
            this.ToolStripSplitButton2.Text = "ToolStripSplitButton2";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(145, 20);
            this.ToolStripStatusLabel3.Text = "Tổng số phiếu bầu : ";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(146, 20);
            this.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4";
            // 
            // StatusStrip2
            // 
            this.StatusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel7,
            this.ToolStripStatusLabel8,
            this.ToolStripStatusLabel9,
            this.ToolStripSplitButton3,
            this.ToolStripStatusLabel10,
            this.ToolStripStatusLabel11,
            this.ToolStripStatusLabel12});
            this.StatusStrip2.Location = new System.Drawing.Point(0, 643);
            this.StatusStrip2.Name = "StatusStrip2";
            this.StatusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip2.Size = new System.Drawing.Size(1056, 26);
            this.StatusStrip2.TabIndex = 60;
            this.StatusStrip2.Text = "StatusStrip2";
            // 
            // ToolStripStatusLabel7
            // 
            this.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7";
            this.ToolStripStatusLabel7.Size = new System.Drawing.Size(124, 20);
            this.ToolStripStatusLabel7.Text = "Số phiếu hợp lệ : ";
            // 
            // ToolStripStatusLabel8
            // 
            this.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8";
            this.ToolStripStatusLabel8.Size = new System.Drawing.Size(153, 20);
            this.ToolStripStatusLabel8.Text = "ToolStripStatusLabel8";
            // 
            // ToolStripStatusLabel9
            // 
            this.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9";
            this.ToolStripStatusLabel9.Size = new System.Drawing.Size(153, 20);
            this.ToolStripStatusLabel9.Text = "ToolStripStatusLabel9";
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
            // ToolStripStatusLabel10
            // 
            this.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10";
            this.ToolStripStatusLabel10.Size = new System.Drawing.Size(169, 20);
            this.ToolStripStatusLabel10.Text = "Số phiếu không hợp lệ : ";
            // 
            // ToolStripStatusLabel11
            // 
            this.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11";
            this.ToolStripStatusLabel11.Size = new System.Drawing.Size(161, 20);
            this.ToolStripStatusLabel11.Text = "ToolStripStatusLabel11";
            // 
            // ToolStripStatusLabel12
            // 
            this.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12";
            this.ToolStripStatusLabel12.Size = new System.Drawing.Size(161, 20);
            this.ToolStripStatusLabel12.Text = "ToolStripStatusLabel12";
            // 
            // Elections_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 695);
            this.Controls.Add(this.StatusStrip2);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Elections_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả bầu cử";
            this.Load += new System.EventHandler(this.Elections_result_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ElectionResult_KeyUp);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.StatusStrip2.ResumeLayout(false);
            this.StatusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox6;
        internal MaskedTextBox MaskedTextBox3;
        internal Label Label8;
        internal Label Label7;
        internal Label Label2;
        internal GroupBox GroupBox2;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        internal ToolStripStatusLabel ToolStripStatusLabel4;
        internal ToolStripSplitButton ToolStripSplitButton1;
        internal ToolStripStatusLabel ToolStripStatusLabel5;
        internal ToolStripStatusLabel ToolStripStatusLabel6;
        internal ToolStripSplitButton ToolStripSplitButton2;
        internal StatusStrip StatusStrip2;
        internal ToolStripStatusLabel ToolStripStatusLabel7;
        internal ToolStripStatusLabel ToolStripStatusLabel8;
        internal ToolStripStatusLabel ToolStripStatusLabel9;
        internal ToolStripSplitButton ToolStripSplitButton3;
        internal ToolStripStatusLabel ToolStripStatusLabel10;
        internal ToolStripStatusLabel ToolStripStatusLabel11;
        internal ToolStripStatusLabel ToolStripStatusLabel12;
        internal DataGridViewTextBoxColumn Candidatecode;
        internal DataGridViewTextBoxColumn CandidateName;
        internal DataGridViewTextBoxColumn Votes;
        internal DataGridViewTextBoxColumn percentvote;
    }
}