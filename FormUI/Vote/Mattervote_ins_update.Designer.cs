using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Mattervote_ins_update : Form
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.StockTextBox1 = new Lapas.Controls.StockTextBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.MaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.HolderIdentifyMaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.HolderCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.delegateNameTextbox = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.delegateIdentityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.delegateCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.MaskedTextBox3);
            this.GroupBox1.Controls.Add(this.MaskedTextBox1);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(1, 1);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(932, 188);
            this.GroupBox1.TabIndex = 55;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vấn đề biểu quyết";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown1.Location = new System.Drawing.Point(217, 78);
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
            this.NumericUpDown1.TabIndex = 2;
            this.NumericUpDown1.TabStop = false;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(217, 133);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.ReadOnly = true;
            this.MaskedTextBox3.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox3.TabIndex = 23;
            this.MaskedTextBox3.TabStop = false;
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox1.Location = new System.Drawing.Point(217, 37);
            this.MaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.ReadOnly = true;
            this.MaskedTextBox1.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox1.TabIndex = 24;
            this.MaskedTextBox1.TabStop = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(15, 133);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(91, 20);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Tên vấn đề";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 87);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 20);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Mã vấn đề";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 20);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Mã cuộc họp";
            // 
            // StockTextBox1
            // 
            this.StockTextBox1.Alarm = false;
            this.StockTextBox1.AllowNegativeNumeric = true;
            this.StockTextBox1.CustomCulture = false;
            this.StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox1.Location = new System.Drawing.Point(237, 425);
            this.StockTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox1.MaxLength = 25;
            this.StockTextBox1.Name = "StockTextBox1";
            this.StockTextBox1.Precision = 0;
            this.StockTextBox1.ReadOnly = true;
            this.StockTextBox1.Size = new System.Drawing.Size(265, 22);
            this.StockTextBox1.TabIndex = 3;
            this.StockTextBox1.TabStop = false;
            this.StockTextBox1.Text = "0";
            this.StockTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox1.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(605, 220);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(144, 20);
            this.CheckBox1.TabIndex = 37;
            this.CheckBox1.TabStop = false;
            this.CheckBox1.Text = "Chế độ nhập nhanh";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            // 
            // MaskedTextBox4
            // 
            this.MaskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox4.Location = new System.Drawing.Point(237, 338);
            this.MaskedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox4.Name = "MaskedTextBox4";
            this.MaskedTextBox4.ReadOnly = true;
            this.MaskedTextBox4.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox4.TabIndex = 2;
            this.MaskedTextBox4.TabStop = false;
            // 
            // HolderIdentifyMaskedTextBox2
            // 
            this.HolderIdentifyMaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolderIdentifyMaskedTextBox2.Location = new System.Drawing.Point(237, 301);
            this.HolderIdentifyMaskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.HolderIdentifyMaskedTextBox2.Name = "HolderIdentifyMaskedTextBox2";
            this.HolderIdentifyMaskedTextBox2.Size = new System.Drawing.Size(265, 26);
            this.HolderIdentifyMaskedTextBox2.TabIndex = 1;
            this.HolderIdentifyMaskedTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaskedTextBox2_KeyDown);
            this.HolderIdentifyMaskedTextBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HolderIdentifyMaskedTextBox2_PreviewKeyDown);
            // 
            // HolderCodeMaskedTextBox
            // 
            this.HolderCodeMaskedTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HolderCodeMaskedTextBox.Enabled = false;
            this.HolderCodeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolderCodeMaskedTextBox.Location = new System.Drawing.Point(237, 220);
            this.HolderCodeMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HolderCodeMaskedTextBox.Name = "HolderCodeMaskedTextBox";
            this.HolderCodeMaskedTextBox.Size = new System.Drawing.Size(265, 26);
            this.HolderCodeMaskedTextBox.TabIndex = 0;
            this.HolderCodeMaskedTextBox.TabStop = false;
            this.HolderCodeMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox5_MaskInputRejected);
            this.HolderCodeMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaskedTextBox5_KeyDown);
            this.HolderCodeMaskedTextBox.Leave += new System.EventHandler(this.MaskedTextBox5_Leave);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(35, 425);
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
            this.Label3.Location = new System.Drawing.Point(33, 343);
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
            this.Label4.Location = new System.Drawing.Point(35, 308);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 20);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "CMT/HC";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(35, 228);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 20);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Mã cổ đông";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.RadioButton3);
            this.GroupBox3.Controls.Add(this.RadioButton2);
            this.GroupBox3.Controls.Add(this.RadioButton1);
            this.GroupBox3.Location = new System.Drawing.Point(17, 479);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(916, 92);
            this.GroupBox3.TabIndex = 57;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Biểu quyết";
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(663, 41);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(104, 20);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "Không ý kiến";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(348, 41);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(110, 20);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "Không đồng ý";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(39, 41);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(70, 20);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Đồng ý";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Blue;
            this.Button3.Location = new System.Drawing.Point(467, 586);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(188, 43);
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Nhập phần còn lại";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(36, 586);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(153, 43);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(256, 586);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(161, 43);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Tiếp tục";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(780, 586);
            this.Button4.Margin = new System.Windows.Forms.Padding(4);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(153, 43);
            this.Button4.TabIndex = 6;
            this.Button4.TabStop = false;
            this.Button4.Text = "Đóng";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // delegateNameTextbox
            // 
            this.delegateNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delegateNameTextbox.Location = new System.Drawing.Point(237, 379);
            this.delegateNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.delegateNameTextbox.Name = "delegateNameTextbox";
            this.delegateNameTextbox.ReadOnly = true;
            this.delegateNameTextbox.Size = new System.Drawing.Size(635, 26);
            this.delegateNameTextbox.TabIndex = 58;
            this.delegateNameTextbox.TabStop = false;
            this.delegateNameTextbox.Visible = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(33, 384);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(115, 20);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Người đại diện";
            this.Label8.Visible = false;
            // 
            // delegateIdentityTextBox
            // 
            this.delegateIdentityTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.delegateIdentityTextBox.Enabled = false;
            this.delegateIdentityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delegateIdentityTextBox.Location = new System.Drawing.Point(733, 421);
            this.delegateIdentityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.delegateIdentityTextBox.Name = "delegateIdentityTextBox";
            this.delegateIdentityTextBox.Size = new System.Drawing.Size(139, 26);
            this.delegateIdentityTextBox.TabIndex = 60;
            this.delegateIdentityTextBox.TabStop = false;
            this.delegateIdentityTextBox.Visible = false;
            // 
            // delegateCodeMaskedTextBox
            // 
            this.delegateCodeMaskedTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.delegateCodeMaskedTextBox.Enabled = false;
            this.delegateCodeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delegateCodeMaskedTextBox.Location = new System.Drawing.Point(237, 262);
            this.delegateCodeMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.delegateCodeMaskedTextBox.Name = "delegateCodeMaskedTextBox";
            this.delegateCodeMaskedTextBox.Size = new System.Drawing.Size(265, 26);
            this.delegateCodeMaskedTextBox.TabIndex = 61;
            this.delegateCodeMaskedTextBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Mã đại biểu";
            // 
            // Mattervote_ins_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 660);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.delegateCodeMaskedTextBox);
            this.Controls.Add(this.delegateIdentityTextBox);
            this.Controls.Add(this.delegateNameTextbox);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.StockTextBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.MaskedTextBox4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.HolderIdentifyMaskedTextBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.HolderCodeMaskedTextBox);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mattervote_ins_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phiếu biểu quyết";
            this.Load += new System.EventHandler(this.Mattervote_ins_update_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Mattervote_ins_update_KeyUp);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox HolderIdentifyMaskedTextBox2;
        internal MaskedTextBox HolderCodeMaskedTextBox;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal GroupBox GroupBox3;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
        internal Button Button3;
        internal Button Button1;
        internal Button Button2;
        internal CheckBox CheckBox1;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal Label Label6;
        internal Button Button4;
        internal MaskedTextBox delegateNameTextbox;
        internal Label Label8;
        internal MaskedTextBox delegateIdentityTextBox;
        internal MaskedTextBox delegateCodeMaskedTextBox;
        internal Label label9;
    }
}