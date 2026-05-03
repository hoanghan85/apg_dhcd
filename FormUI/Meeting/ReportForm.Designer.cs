using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ReportForm : Form
    {
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

        private System.ComponentModel.IContainer components;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();

            // GroupBox1 - Thông tin tham dự
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(20, 20);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(700, 200);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin tham dự";
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Label1 - Xuất danh sách cổ đông
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(300, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Xuất danh sách cổ đông (Excel)";
            this.Label1.Font = new System.Drawing.Font("Arial", 9);

            // Button1 - Export danh sách cổ đông
            this.Button1.Location = new System.Drawing.Point(580, 25);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 30);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Export";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);

            // Label2 - Xuất danh sách đại biểu/ủy quyền
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(20, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(300, 18);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Xuất danh sách đại biểu/ủy quyền (Excel)";
            this.Label2.Font = new System.Drawing.Font("Arial", 9);

            // Button2 - Export danh sách đại biểu
            this.Button2.Location = new System.Drawing.Point(580, 65);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 30);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Export";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);

            // Label3 - Xuất báo cáo kiểm tra tư cách
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(20, 110);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(300, 18);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Xuất báo cáo kiểm tra tư cách (Excel)";
            this.Label3.Font = new System.Drawing.Font("Arial", 9);

            // Button3 - Export báo cáo kiểm tra
            this.Button3.Location = new System.Drawing.Point(580, 105);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 30);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "Export";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);

            // Label4 - Xuất biên bản kiểm tra tư cách
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(20, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(300, 18);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Xuất biên bản kiểm tra tư cách (Word)";
            this.Label4.Font = new System.Drawing.Font("Arial", 9);
            this.Label4.Visible = false;

            // Button4 - Export biên bản kiểm tra
            this.Button4.Location = new System.Drawing.Point(580, 145);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 30);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "Export";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            this.Button4.Visible = false;

            // GroupBox2 - Thông tin biểu quyết
            this.GroupBox2.Controls.Add(this.Button5);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Button6);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(20, 240);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(700, 110);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Thông tin biểu quyết";
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Label5 - Xuất thống kê biểu quyết
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(20, 30);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(300, 18);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Xuất thống kê biểu quyết (Excel)";
            this.Label5.Font = new System.Drawing.Font("Arial", 9);

            // Button5 - Export thống kê biểu quyết
            this.Button5.Location = new System.Drawing.Point(580, 25);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(100, 30);
            this.Button5.TabIndex = 1;
            this.Button5.Text = "Export";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);

            // Label6 - Xuất biên bản biểu quyết
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(20, 70);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(300, 18);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Xuất biên bản biểu quyết (Word)";
            this.Label6.Font = new System.Drawing.Font("Arial", 9);
            this.Label6.Visible = false;

            // Button6 - Export biên bản biểu quyết
            this.Button6.Location = new System.Drawing.Point(580, 65);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 30);
            this.Button6.TabIndex = 3;
            this.Button6.Text = "Export";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            this.Button6.Visible = false;

            // GroupBox3 - Thông tin bầu cử
            this.GroupBox3.Controls.Add(this.Button7);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.Button8);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Location = new System.Drawing.Point(20, 370);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(700, 110);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Thông tin bầu cử";
            this.GroupBox3.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Label7 - Xuất thống kê bầu cử
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(20, 30);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(300, 18);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Xuất thống kê bầu cử (Excel)";
            this.Label7.Font = new System.Drawing.Font("Arial", 9);

            // Button7 - Export thống kê bầu cử
            this.Button7.Location = new System.Drawing.Point(580, 25);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(100, 30);
            this.Button7.TabIndex = 1;
            this.Button7.Text = "Export";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);

            // Label8 - Xuất biên bản bầu cử
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(20, 70);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(300, 18);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Xuất biên bản bầu cử (Word)";
            this.Label8.Font = new System.Drawing.Font("Arial", 9);
            this.Label8.Visible = false;

            // Button8 - Export biên bản bầu cử
            this.Button8.Location = new System.Drawing.Point(580, 65);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(100, 30);
            this.Button8.TabIndex = 3;
            this.Button8.Text = "Export";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            this.Label8.Visible = false;

            // ReportForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Label Label8;
    }
}
