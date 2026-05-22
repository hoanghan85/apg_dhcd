using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MeetingList : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Meetingcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meetingname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meetingaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MettingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearMeeting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
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
            this.ToolStripLabel1,
            this.ToolStripTextBox1,
            this.ToolStripButton4,
            this.ToolStripSeparator2,
            this.ToolStripButton5});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(998, 26);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(95, 23);
            this.ToolStripLabel1.Text = "Mã cuộc họp";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(132, 26);
            this.ToolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyUp);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 512);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1197, 26);
            this.StatusStrip1.TabIndex = 3;
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
            this.Meetingcode,
            this.Meetingname,
            this.CompanyName,
            this.CompanyAddress,
            this.Meetingaddress,
            this.StockCode,
            this.meetingtime,
            this.Period,
            this.MettingType,
            this.YearMeeting});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 22);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(998, 405);
            this.DataGridView1.TabIndex = 4;
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // Meetingcode
            // 
            this.Meetingcode.DataPropertyName = "Meetingcode";
            this.Meetingcode.FillWeight = 59.37841F;
            this.Meetingcode.HeaderText = "Mã cuộc họp";
            this.Meetingcode.MinimumWidth = 6;
            this.Meetingcode.Name = "Meetingcode";
            this.Meetingcode.ReadOnly = true;
            // 
            // Meetingname
            // 
            this.Meetingname.DataPropertyName = "Meetingname";
            this.Meetingname.FillWeight = 65.68176F;
            this.Meetingname.HeaderText = "Tên cuộc họp";
            this.Meetingname.MinimumWidth = 100;
            this.Meetingname.Name = "Meetingname";
            this.Meetingname.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.FillWeight = 138.3765F;
            this.CompanyName.HeaderText = "Tên công ty";
            this.CompanyName.MinimumWidth = 8;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // CompanyAddress
            // 
            this.CompanyAddress.DataPropertyName = "CompanyAddress";
            this.CompanyAddress.FillWeight = 79.50503F;
            this.CompanyAddress.HeaderText = "Đ/C công ty";
            this.CompanyAddress.MinimumWidth = 6;
            this.CompanyAddress.Name = "CompanyAddress";
            this.CompanyAddress.ReadOnly = true;
            // 
            // Meetingaddress
            // 
            this.Meetingaddress.DataPropertyName = "Meetingaddress";
            this.Meetingaddress.FillWeight = 24.77251F;
            this.Meetingaddress.HeaderText = "Địa điểm tổ chức";
            this.Meetingaddress.MinimumWidth = 6;
            this.Meetingaddress.Name = "Meetingaddress";
            this.Meetingaddress.ReadOnly = true;
            this.Meetingaddress.Visible = false;
            // 
            // StockCode
            // 
            this.StockCode.DataPropertyName = "StockCode";
            this.StockCode.HeaderText = "Mã CK";
            this.StockCode.MinimumWidth = 6;
            this.StockCode.Name = "StockCode";
            this.StockCode.ReadOnly = true;
            // 
            // meetingtime
            // 
            this.meetingtime.DataPropertyName = "meetingtime";
            dataGridViewCellStyle3.NullValue = null;
            this.meetingtime.DefaultCellStyle = dataGridViewCellStyle3;
            this.meetingtime.FillWeight = 38.75047F;
            this.meetingtime.HeaderText = "Thời gian tổ chức";
            this.meetingtime.MinimumWidth = 6;
            this.meetingtime.Name = "meetingtime";
            this.meetingtime.ReadOnly = true;
            // 
            // Period
            // 
            this.Period.DataPropertyName = "Period";
            this.Period.HeaderText = "Nhiệm kỳ";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            // 
            // MettingType
            // 
            this.MettingType.DataPropertyName = "MettingType";
            this.MettingType.HeaderText = "Loại hình";
            this.MettingType.MinimumWidth = 6;
            this.MettingType.Name = "MettingType";
            this.MettingType.ReadOnly = true;
            // 
            // YearMeeting
            // 
            this.YearMeeting.DataPropertyName = "YearMeeting";
            this.YearMeeting.HeaderText = "Năm";
            this.YearMeeting.MinimumWidth = 6;
            this.YearMeeting.Name = "YearMeeting";
            this.YearMeeting.ReadOnly = true;
            this.YearMeeting.Visible = false;
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Image = global::pmDHCD.My.Resources.Resources.Add;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(90, 23);
            this.ToolStripButton1.Text = "Thêm(A)";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = global::pmDHCD.My.Resources.Resources.Document;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(76, 23);
            this.ToolStripButton2.Text = "Sửa(E)";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Image = global::pmDHCD.My.Resources.Resources.Delete;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(80, 23);
            this.ToolStripButton3.Text = "Xóa(D)";
            this.ToolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Image = global::pmDHCD.My.Resources.Resources.Search;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(58, 23);
            this.ToolStripButton4.Text = "Tìm";
            this.ToolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Image = global::pmDHCD.My.Resources.Resources.officemac01;
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(210, 23);
            this.ToolStripButton5.Text = "Chọn cuộc họp (S or Enter)";
            this.ToolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // MeetingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 538);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ToolStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeetingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách cuộc họp";
            this.Load += new System.EventHandler(this.MeetingList_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MeetingList_KeyUp);
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
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStripTextBox ToolStripTextBox1;
        internal ToolStripButton ToolStripButton4;
        internal StatusStrip StatusStrip1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal DataGridView DataGridView1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripButton ToolStripButton5;
        internal DataGridViewTextBoxColumn Meetingcode;
        internal DataGridViewTextBoxColumn Meetingname;
        internal DataGridViewTextBoxColumn CompanyName;
        internal DataGridViewTextBoxColumn CompanyAddress;
        internal DataGridViewTextBoxColumn Meetingaddress;
        internal DataGridViewTextBoxColumn StockCode;
        internal DataGridViewTextBoxColumn meetingtime;
        internal DataGridViewTextBoxColumn Period;
        internal DataGridViewTextBoxColumn MettingType;
        internal DataGridViewTextBoxColumn YearMeeting;
    }
}