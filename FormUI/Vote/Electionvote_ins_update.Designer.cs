using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Electionvote_ins_update : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MaskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.StockTextBox2 = new Lapas.Controls.StockTextBox();
            this.StockTextBox1 = new Lapas.Controls.StockTextBox();
            this.MaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Candidatecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Choosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.MaskedTextBox6);
            this.GroupBox1.Controls.Add(this.MaskedTextBox3);
            this.GroupBox1.Controls.Add(this.MaskedTextBox1);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(1, 2);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(932, 178);
            this.GroupBox1.TabIndex = 56;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vấn đề bầu cử";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown1.Location = new System.Drawing.Point(217, 58);
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
            this.MaskedTextBox6.Location = new System.Drawing.Point(217, 140);
            this.MaskedTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox6.Name = "MaskedTextBox6";
            this.MaskedTextBox6.ReadOnly = true;
            this.MaskedTextBox6.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox6.TabIndex = 23;
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(217, 99);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.ReadOnly = true;
            this.MaskedTextBox3.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox3.TabIndex = 23;
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox1.Location = new System.Drawing.Point(217, 22);
            this.MaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.ReadOnly = true;
            this.MaskedTextBox1.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox1.TabIndex = 24;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(13, 147);
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
            this.Label7.Location = new System.Drawing.Point(15, 99);
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
            this.Label2.Location = new System.Drawing.Point(15, 68);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 20);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Mã bầu cử";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 20);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Mã cuộc họp";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.StockTextBox2);
            this.GroupBox2.Controls.Add(this.StockTextBox1);
            this.GroupBox2.Controls.Add(this.MaskedTextBox4);
            this.GroupBox2.Controls.Add(this.MaskedTextBox2);
            this.GroupBox2.Controls.Add(this.MaskedTextBox5);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.LabelWarning);
            this.GroupBox2.Location = new System.Drawing.Point(1, 187);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(687, 220);
            this.GroupBox2.TabIndex = 57;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Đại biểu";
            // 
            // StockTextBox2
            // 
            this.StockTextBox2.Alarm = false;
            this.StockTextBox2.AllowNegativeNumeric = true;
            this.StockTextBox2.CustomCulture = false;
            this.StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox2.Location = new System.Drawing.Point(217, 165);
            this.StockTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox2.MaxLength = 25;
            this.StockTextBox2.Name = "StockTextBox2";
            this.StockTextBox2.Precision = 0;
            this.StockTextBox2.ReadOnly = true;
            this.StockTextBox2.Size = new System.Drawing.Size(265, 22);
            this.StockTextBox2.TabIndex = 38;
            this.StockTextBox2.Text = "0";
            this.StockTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox2.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // StockTextBox1
            // 
            this.StockTextBox1.Alarm = false;
            this.StockTextBox1.AllowNegativeNumeric = true;
            this.StockTextBox1.CustomCulture = false;
            this.StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox1.Location = new System.Drawing.Point(217, 129);
            this.StockTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox1.MaxLength = 25;
            this.StockTextBox1.Name = "StockTextBox1";
            this.StockTextBox1.Precision = 0;
            this.StockTextBox1.ReadOnly = true;
            this.StockTextBox1.Size = new System.Drawing.Size(265, 22);
            this.StockTextBox1.TabIndex = 38;
            this.StockTextBox1.Text = "0";
            this.StockTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox1.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // MaskedTextBox4
            // 
            this.MaskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox4.Location = new System.Drawing.Point(217, 91);
            this.MaskedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox4.Name = "MaskedTextBox4";
            this.MaskedTextBox4.ReadOnly = true;
            this.MaskedTextBox4.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox4.TabIndex = 32;
            // 
            // MaskedTextBox2
            // 
            this.MaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox2.Location = new System.Drawing.Point(217, 53);
            this.MaskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox2.Name = "MaskedTextBox2";
            this.MaskedTextBox2.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox2.TabIndex = 2;
            this.MaskedTextBox2.Leave += new System.EventHandler(this.MaskedTextBox2_Leave);
            // 
            // MaskedTextBox5
            // 
            this.MaskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox5.Location = new System.Drawing.Point(217, 16);
            this.MaskedTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox5.Name = "MaskedTextBox5";
            this.MaskedTextBox5.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox5.TabIndex = 1;
            this.MaskedTextBox5.TabStop = false;
            this.MaskedTextBox5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox5_MaskInputRejected);
            this.MaskedTextBox5.Leave += new System.EventHandler(this.MaskedTextBox5_Leave);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(15, 165);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(106, 20);
            this.Label9.TabIndex = 36;
            this.Label9.Text = "Số phiếu bầu";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(15, 134);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(159, 20);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "Số quyền biểu quyết";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 91);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 20);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Tên đại biểu";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(15, 53);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 20);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "CCCD/HC";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(15, 23);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(95, 20);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Mã đại biểu";
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning.ForeColor = System.Drawing.Color.Red;
            this.LabelWarning.Location = new System.Drawing.Point(217, 193);
            this.LabelWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(0, 20);
            this.LabelWarning.TabIndex = 40;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.DataGridView1);
            this.GroupBox3.Location = new System.Drawing.Point(1, 411);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(932, 200);
            this.GroupBox3.TabIndex = 58;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Bầu chọn";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Candidatecode,
            this.CandidateName,
            this.Choosen,
            this.Votes});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(4, 19);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(924, 177);
            this.DataGridView1.TabIndex = 13;
            this.DataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Candidatecode
            // 
            this.Candidatecode.DataPropertyName = "Candidatecode";
            this.Candidatecode.FillWeight = 59.08628F;
            this.Candidatecode.HeaderText = "Mã ứng viên";
            this.Candidatecode.MinimumWidth = 6;
            this.Candidatecode.Name = "Candidatecode";
            this.Candidatecode.ReadOnly = true;
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "CandidateName";
            this.CandidateName.FillWeight = 59.08628F;
            this.CandidateName.HeaderText = "Tên ứng viên";
            this.CandidateName.MinimumWidth = 6;
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Choosen
            // 
            this.Choosen.DataPropertyName = "Choosen";
            this.Choosen.FillWeight = 59.08628F;
            this.Choosen.HeaderText = "Chọn";
            this.Choosen.MinimumWidth = 6;
            this.Choosen.Name = "Choosen";
            this.Choosen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Choosen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Votes
            // 
            this.Votes.DataPropertyName = "Votes";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Votes.DefaultCellStyle = dataGridViewCellStyle4;
            this.Votes.HeaderText = "Số phiếu bầu";
            this.Votes.MinimumWidth = 6;
            this.Votes.Name = "Votes";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(571, 615);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(168, 43);
            this.Button2.TabIndex = 60;
            this.Button2.Text = "Tiếp tục";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(776, 615);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(153, 43);
            this.Button3.TabIndex = 61;
            this.Button3.Text = "Đóng";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(5, 615);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(152, 43);
            this.Button1.TabIndex = 59;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(179, 615);
            this.Button4.Margin = new System.Windows.Forms.Padding(4);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(160, 43);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "Chia đều phiếu";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(363, 615);
            this.Button5.Margin = new System.Windows.Forms.Padding(4);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(168, 43);
            this.Button5.TabIndex = 60;
            this.Button5.Text = "Để trống phiếu";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.RadioButton2);
            this.GroupBox4.Controls.Add(this.RadioButton1);
            this.GroupBox4.Location = new System.Drawing.Point(696, 187);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Size = new System.Drawing.Size(233, 220);
            this.GroupBox4.TabIndex = 39;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "TRẠNG THÁI PHIẾU";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(39, 132);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(116, 20);
            this.RadioButton2.TabIndex = 0;
            this.RadioButton2.Text = "KHÔNG hợp lệ";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(39, 43);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(68, 20);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Hợp lệ";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Electionvote_ins_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 665);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Electionvote_ins_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phiếu bầu cử";
            this.Load += new System.EventHandler(this.Electionvote_ins_update_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ElectionVoteUpsert_KeyUp);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal GroupBox GroupBox2;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox5;
        internal Label Label6;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label LabelWarning;
        internal GroupBox GroupBox3;
        internal DataGridView DataGridView1;
        internal Button Button2;
        internal Button Button3;
        internal Button Button1;
        internal Button Button4;
        internal MaskedTextBox MaskedTextBox6;
        internal Label Label8;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Label Label9;
        internal DataGridViewTextBoxColumn Candidatecode;
        internal DataGridViewTextBoxColumn CandidateName;
        internal DataGridViewCheckBoxColumn Choosen;
        internal DataGridViewTextBoxColumn Votes;
        internal Button Button5;
        internal GroupBox GroupBox4;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
    }
}