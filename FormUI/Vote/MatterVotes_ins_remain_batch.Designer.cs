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
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
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
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(360, 60);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Chọn vấn đề";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(11, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(130, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Mã vấn đề (để trống = tất cả):";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            this.TextBox1.Location = new System.Drawing.Point(260, 25);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(80, 22);
            this.TextBox1.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.RadioButton3);
            this.GroupBox2.Controls.Add(this.RadioButton2);
            this.GroupBox2.Controls.Add(this.RadioButton1);
            this.GroupBox2.Location = new System.Drawing.Point(12, 78);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(360, 100);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Chọn loại biểu quyết";
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            this.RadioButton1.Location = new System.Drawing.Point(20, 25);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(76, 20);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.Text = "Đồng ý";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            this.RadioButton2.Location = new System.Drawing.Point(20, 50);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(115, 20);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "Không đồng ý";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            this.RadioButton3.Location = new System.Drawing.Point(20, 75);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(107, 20);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "Không ý kiến";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            this.Button1.Location = new System.Drawing.Point(112, 190);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(80, 30);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            this.Button2.Location = new System.Drawing.Point(200, 190);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(80, 30);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Hủy";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MatterVotes_ins_remain_batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 230);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatterVotes_ins_remain_batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập phần còn lại - Hàng loạt";
            this.Load += new System.EventHandler(this.MatterVotes_ins_remain_batch_Load);
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
