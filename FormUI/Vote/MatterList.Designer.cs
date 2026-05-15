using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MatterList : Form
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mattercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatterDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatterApprovedPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ToolStripSeparator2});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(975, 27);
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Image = global::pmDHCD.My.Resources.Resources.Add;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(70, 24);
            this.ToolStripButton1.Text = "Thêm";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = global::pmDHCD.My.Resources.Resources.Document;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(58, 24);
            this.ToolStripButton2.Text = "Sửa";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Image = global::pmDHCD.My.Resources.Resources.Delete;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(59, 24);
            this.ToolStripButton3.Text = "Xóa";
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mattercode,
            this.MatterName,
            this.MatterDescription,
            this.MatterApprovedPercent});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 27);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(975, 485);
            this.DataGridView1.TabIndex = 6;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 486);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(975, 26);
            this.StatusStrip1.TabIndex = 7;
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
            // Mattercode
            // 
            this.Mattercode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Mattercode.DataPropertyName = "Mattercode";
            this.Mattercode.FillWeight = 59.08628F;
            this.Mattercode.HeaderText = "Mã vấn đề";
            this.Mattercode.MinimumWidth = 6;
            this.Mattercode.Name = "Mattercode";
            this.Mattercode.ReadOnly = true;
            this.Mattercode.Width = 99;
            // 
            // MatterName
            // 
            this.MatterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MatterName.DataPropertyName = "MatterName";
            this.MatterName.FillWeight = 59.08628F;
            this.MatterName.HeaderText = "Tên vấn đề";
            this.MatterName.MinimumWidth = 6;
            this.MatterName.Name = "MatterName";
            this.MatterName.ReadOnly = true;
            this.MatterName.Width = 104;
            // 
            // MatterDescription
            // 
            this.MatterDescription.DataPropertyName = "MatterDescription";
            this.MatterDescription.FillWeight = 59.08628F;
            this.MatterDescription.HeaderText = "Diễn giải";
            this.MatterDescription.MinimumWidth = 6;
            this.MatterDescription.Name = "MatterDescription";
            this.MatterDescription.ReadOnly = true;
            // 
            // MatterApprovedPercent
            // 
            this.MatterApprovedPercent.DataPropertyName = "MatterApprovedPercent";
            this.MatterApprovedPercent.FillWeight = 13F;
            this.MatterApprovedPercent.HeaderText = "Tỷ lệ thông qua (%)";
            this.MatterApprovedPercent.MinimumWidth = 6;
            this.MatterApprovedPercent.Name = "MatterApprovedPercent";
            this.MatterApprovedPercent.ReadOnly = true;
            // 
            // MatterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 512);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.ToolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatterList";
            this.Text = "Danh sách vấn đề biểu quyết";
            this.Load += new System.EventHandler(this.MatterList_Load);
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
        internal ToolStripSeparator ToolStripSeparator2;
        internal DataGridView DataGridView1;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        private DataGridViewTextBoxColumn Mattercode;
        private DataGridViewTextBoxColumn MatterName;
        private DataGridViewTextBoxColumn MatterDescription;
        private DataGridViewTextBoxColumn MatterApprovedPercent;
    }
}