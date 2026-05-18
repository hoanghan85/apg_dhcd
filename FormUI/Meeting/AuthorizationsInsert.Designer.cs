using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AuthorizationsInsert : Form
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
            this.components = new System.ComponentModel.Container();
            this.StockTextBox2 = new Lapas.Controls.StockTextBox();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.StockTextBox3 = new Lapas.Controls.StockTextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.MaskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.StockTextBox1 = new Lapas.Controls.StockTextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // StockTextBox2
            // 
            this.StockTextBox2.Alarm = false;
            this.StockTextBox2.AllowNegativeNumeric = true;
            this.StockTextBox2.CustomCulture = false;
            this.StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTextBox2.Location = new System.Drawing.Point(285, 430);
            this.StockTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox2.MaxLength = 25;
            this.StockTextBox2.Name = "StockTextBox2";
            this.StockTextBox2.Precision = 0;
            this.StockTextBox2.Size = new System.Drawing.Size(265, 26);
            this.StockTextBox2.TabIndex = 2;
            this.StockTextBox2.Text = "0";
            this.StockTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox2.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.StockTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockTextBox2_KeyDown);
            this.StockTextBox2.Leave += new System.EventHandler(this.StockTextBox2_Leave);
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(81, 437);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(179, 20);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Số quyền BQ ủy quyền";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(81, 468);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(162, 20);
            this.Label12.TabIndex = 21;
            this.Label12.Text = "Số quyền BQ còn lại";
            // 
            // StockTextBox3
            // 
            this.StockTextBox3.Alarm = false;
            this.StockTextBox3.AllowNegativeNumeric = false;
            this.StockTextBox3.CustomCulture = false;
            this.StockTextBox3.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTextBox3.Location = new System.Drawing.Point(285, 461);
            this.StockTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox3.MaxLength = 25;
            this.StockTextBox3.Name = "StockTextBox3";
            this.StockTextBox3.Precision = 0;
            this.StockTextBox3.ReadOnly = true;
            this.StockTextBox3.Size = new System.Drawing.Size(265, 26);
            this.StockTextBox3.TabIndex = 22;
            this.StockTextBox3.TabStop = false;
            this.StockTextBox3.Text = "0";
            this.StockTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox3.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(251, 500);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(193, 58);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(516, 500);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(193, 58);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "Thoát";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(84, 44);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Mã đại biểu";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(84, 90);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 20);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "CCCD/HC";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(83, 140);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Tên đại biểu";
            // 
            // MaskedTextBox2
            // 
            this.MaskedTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.MaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox2.Location = new System.Drawing.Point(287, 37);
            this.MaskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox2.Name = "MaskedTextBox2";
            this.MaskedTextBox2.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox2.TabIndex = 5;
            this.MaskedTextBox2.TabStop = false;
            this.MaskedTextBox2.Leave += new System.EventHandler(this.MaskedTextBox2_Leave);
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(287, 90);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox3.TabIndex = 0;
            this.MaskedTextBox3.Leave += new System.EventHandler(this.MaskedTextBox3_Leave);
            // 
            // MaskedTextBox4
            // 
            this.MaskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox4.Location = new System.Drawing.Point(287, 140);
            this.MaskedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox4.Name = "MaskedTextBox4";
            this.MaskedTextBox4.ReadOnly = true;
            this.MaskedTextBox4.Size = new System.Drawing.Size(505, 26);
            this.MaskedTextBox4.TabIndex = 6;
            this.MaskedTextBox4.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(81, 236);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 20);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Mã cổ đông";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(81, 267);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(146, 20);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "Số đăng ký sở hữu";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(80, 305);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 20);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Tên cổ đông";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(81, 391);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(159, 20);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Số quyền biểu quyết";
            // 
            // MaskedTextBox8
            // 
            this.MaskedTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.MaskedTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox8.Location = new System.Drawing.Point(284, 229);
            this.MaskedTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox8.Name = "MaskedTextBox8";
            this.MaskedTextBox8.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox8.TabIndex = 7;
            this.MaskedTextBox8.TabStop = false;
            this.MaskedTextBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaskedTextBox8_KeyDown);
            this.MaskedTextBox8.Leave += new System.EventHandler(this.MaskedTextBox8_Leave);
            // 
            // MaskedTextBox7
            // 
            this.MaskedTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox7.Location = new System.Drawing.Point(284, 267);
            this.MaskedTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox7.Name = "MaskedTextBox7";
            this.MaskedTextBox7.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox7.TabIndex = 1;
            this.MaskedTextBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaskedTextBox7_KeyDown);
            this.MaskedTextBox7.Leave += new System.EventHandler(this.MaskedTextBox7_Leave);
            // 
            // MaskedTextBox6
            // 
            this.MaskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox6.Location = new System.Drawing.Point(284, 305);
            this.MaskedTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox6.Name = "MaskedTextBox6";
            this.MaskedTextBox6.ReadOnly = true;
            this.MaskedTextBox6.Size = new System.Drawing.Size(505, 26);
            this.MaskedTextBox6.TabIndex = 8;
            this.MaskedTextBox6.TabStop = false;
            // 
            // StockTextBox1
            // 
            this.StockTextBox1.Alarm = false;
            this.StockTextBox1.AllowNegativeNumeric = true;
            this.StockTextBox1.CustomCulture = false;
            this.StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTextBox1.Location = new System.Drawing.Point(284, 388);
            this.StockTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox1.MaxLength = 25;
            this.StockTextBox1.Name = "StockTextBox1";
            this.StockTextBox1.Precision = 0;
            this.StockTextBox1.ReadOnly = true;
            this.StockTextBox1.Size = new System.Drawing.Size(265, 26);
            this.StockTextBox1.TabIndex = 9;
            this.StockTextBox1.TabStop = false;
            this.StockTextBox1.Text = "0";
            this.StockTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox1.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(56, 199);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(218, 20);
            this.Label9.TabIndex = 17;
            this.Label9.Text = "Thông tin người ủy quyền";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(56, 11);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(159, 20);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "Thông tin đại biểu";
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox1.Location = new System.Drawing.Point(284, 346);
            this.MaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.ReadOnly = true;
            this.MaskedTextBox1.Size = new System.Drawing.Size(505, 26);
            this.MaskedTextBox1.TabIndex = 19;
            this.MaskedTextBox1.TabStop = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(80, 346);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(61, 20);
            this.Label11.TabIndex = 20;
            this.Label11.Text = "Địa chỉ";
            // 
            // AuthorizationsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 615);
            this.Controls.Add(this.StockTextBox3);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.MaskedTextBox1);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.StockTextBox2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.StockTextBox1);
            this.Controls.Add(this.MaskedTextBox4);
            this.Controls.Add(this.MaskedTextBox6);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.MaskedTextBox7);
            this.Controls.Add(this.MaskedTextBox3);
            this.Controls.Add(this.MaskedTextBox8);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.MaskedTextBox2);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorizationsInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ủy quyền";
            this.Load += new System.EventHandler(this.AuthorizationsInsert_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AuthorizationsInsert_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Label Label4;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Button Button1;
        internal Button Button2;
        internal Label Label2;
        internal Label Label7;
        internal Label Label3;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox4;
        internal Label Label8;
        internal Label Label6;
        internal Label Label5;
        internal Label Label1;
        internal MaskedTextBox MaskedTextBox8;
        internal MaskedTextBox MaskedTextBox7;
        internal MaskedTextBox MaskedTextBox6;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal Label Label9;
        internal Label Label10;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label11;
        internal Label Label12;
        internal Lapas.Controls.StockTextBox StockTextBox3;
        internal ErrorProvider ErrorProvider1;
    }
}