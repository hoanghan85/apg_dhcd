using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AuthorizationUpdate : Form
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.StockTextBox2 = new Lapas.Controls.StockTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.StockTextBox1 = new Lapas.Controls.StockTextBox();
            this.MaskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.MaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(541, 540);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(193, 58);
            this.Button2.TabIndex = 68;
            this.Button2.Text = "Thoát";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(189, 540);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(193, 58);
            this.Button1.TabIndex = 67;
            this.Button1.Text = "Cập nhật";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.StockTextBox2);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Location = new System.Drawing.Point(8, 423);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Size = new System.Drawing.Size(880, 90);
            this.GroupBox3.TabIndex = 71;
            this.GroupBox3.TabStop = false;
            // 
            // StockTextBox2
            // 
            this.StockTextBox2.Alarm = false;
            this.StockTextBox2.AllowNegativeNumeric = true;
            this.StockTextBox2.CustomCulture = false;
            this.StockTextBox2.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTextBox2.Location = new System.Drawing.Point(220, 28);
            this.StockTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox2.MaxLength = 25;
            this.StockTextBox2.Name = "StockTextBox2";
            this.StockTextBox2.Precision = 0;
            this.StockTextBox2.Size = new System.Drawing.Size(265, 26);
            this.StockTextBox2.TabIndex = 4;
            this.StockTextBox2.Text = "0";
            this.StockTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox2.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 36);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(179, 20);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "Số quyền BQ ủy quyền";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.StockTextBox1);
            this.GroupBox2.Controls.Add(this.MaskedTextBox6);
            this.GroupBox2.Controls.Add(this.MaskedTextBox7);
            this.GroupBox2.Controls.Add(this.MaskedTextBox8);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(8, 191);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(880, 225);
            this.GroupBox2.TabIndex = 69;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Cổ đông";
            // 
            // StockTextBox1
            // 
            this.StockTextBox1.Alarm = false;
            this.StockTextBox1.AllowNegativeNumeric = true;
            this.StockTextBox1.CustomCulture = false;
            this.StockTextBox1.CustomCultureInfo = new System.Globalization.CultureInfo("en-GB");
            this.StockTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTextBox1.Location = new System.Drawing.Point(220, 166);
            this.StockTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.StockTextBox1.MaxLength = 25;
            this.StockTextBox1.Name = "StockTextBox1";
            this.StockTextBox1.Precision = 0;
            this.StockTextBox1.ReadOnly = true;
            this.StockTextBox1.Size = new System.Drawing.Size(265, 26);
            this.StockTextBox1.TabIndex = 36;
            this.StockTextBox1.Text = "0";
            this.StockTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StockTextBox1.ValueAlarm = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // MaskedTextBox6
            // 
            this.MaskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox6.Location = new System.Drawing.Point(220, 116);
            this.MaskedTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox6.Name = "MaskedTextBox6";
            this.MaskedTextBox6.ReadOnly = true;
            this.MaskedTextBox6.Size = new System.Drawing.Size(505, 26);
            this.MaskedTextBox6.TabIndex = 32;
            // 
            // MaskedTextBox7
            // 
            this.MaskedTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox7.Location = new System.Drawing.Point(220, 65);
            this.MaskedTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox7.Name = "MaskedTextBox7";
            this.MaskedTextBox7.ReadOnly = true;
            this.MaskedTextBox7.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox7.TabIndex = 33;
            this.MaskedTextBox7.TabStop = false;
            // 
            // MaskedTextBox8
            // 
            this.MaskedTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox8.Location = new System.Drawing.Point(220, 12);
            this.MaskedTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox8.Name = "MaskedTextBox8";
            this.MaskedTextBox8.ReadOnly = true;
            this.MaskedTextBox8.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox8.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(17, 170);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(159, 20);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Số quyền biểu quyết";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 116);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 20);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Tên cổ đông";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(17, 65);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(146, 20);
            this.Label6.TabIndex = 37;
            this.Label6.Text = "Số đăng ký sở hữu";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(17, 20);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 20);
            this.Label8.TabIndex = 36;
            this.Label8.Text = "Mã cổ đông";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.MaskedTextBox4);
            this.GroupBox1.Controls.Add(this.MaskedTextBox3);
            this.GroupBox1.Controls.Add(this.MaskedTextBox2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(8, 14);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(880, 170);
            this.GroupBox1.TabIndex = 70;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Đại biểu";
            // 
            // MaskedTextBox4
            // 
            this.MaskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox4.Location = new System.Drawing.Point(220, 116);
            this.MaskedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox4.Name = "MaskedTextBox4";
            this.MaskedTextBox4.ReadOnly = true;
            this.MaskedTextBox4.Size = new System.Drawing.Size(505, 26);
            this.MaskedTextBox4.TabIndex = 32;
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(220, 65);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.ReadOnly = true;
            this.MaskedTextBox3.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox3.TabIndex = 1;
            // 
            // MaskedTextBox2
            // 
            this.MaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox2.Location = new System.Drawing.Point(220, 12);
            this.MaskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox2.Name = "MaskedTextBox2";
            this.MaskedTextBox2.ReadOnly = true;
            this.MaskedTextBox2.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox2.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 116);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 20);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "Tên đại biểu";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(17, 65);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 20);
            this.Label7.TabIndex = 37;
            this.Label7.Text = "CCCD/HC";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(17, 20);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 20);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "Mã đại biểu";
            // 
            // AuthorizationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 612);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorizationUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin Ủy quyền";
            this.Load += new System.EventHandler(this.AuthorizationUpdate_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AuthorizationsUpdate_KeyUp);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        internal Button Button2;
        internal Button Button1;
        internal GroupBox GroupBox3;
        internal Lapas.Controls.StockTextBox StockTextBox2;
        internal Label Label4;
        internal GroupBox GroupBox2;
        internal Lapas.Controls.StockTextBox StockTextBox1;
        internal MaskedTextBox MaskedTextBox6;
        internal MaskedTextBox MaskedTextBox7;
        internal MaskedTextBox MaskedTextBox8;
        internal Label Label1;
        internal Label Label5;
        internal Label Label6;
        internal Label Label8;
        internal GroupBox GroupBox1;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox2;
        internal Label Label3;
        internal Label Label7;
        internal Label Label2;
    }
}