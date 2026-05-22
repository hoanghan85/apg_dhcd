using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MatterVotes_ins_remain_batch : Form
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(16, 15);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(480, 74);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Chọn vấn đề";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBox1.Location = new System.Drawing.Point(347, 31);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(105, 26);
            this.TextBox1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 31);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(231, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Mã vấn đề (để trống = tất cả):";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.RadioButton3);
            this.GroupBox2.Controls.Add(this.RadioButton2);
            this.GroupBox2.Controls.Add(this.RadioButton1);
            this.GroupBox2.Location = new System.Drawing.Point(16, 96);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(480, 123);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Chọn loại biểu quyết";
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RadioButton3.Location = new System.Drawing.Point(27, 92);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(125, 24);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "Không ý kiến";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RadioButton2.Location = new System.Drawing.Point(27, 62);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(131, 24);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "Không đồng ý";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RadioButton1.Location = new System.Drawing.Point(27, 31);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(82, 24);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.Text = "Đồng ý";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Button1.Location = new System.Drawing.Point(149, 234);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(107, 37);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Button2.Location = new System.Drawing.Point(267, 234);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 37);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Hủy";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MatterVotes_ins_remain_batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 283);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatterVotes_ins_remain_batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập phần còn lại - Hàng loạt";
            this.Load += new System.EventHandler(this.MatterVotes_ins_remain_batch_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(MattervoteInsBatch_KeyUp);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
    }
}
