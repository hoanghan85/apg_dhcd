using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MatterVoteResult : Form
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
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox13 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox14 = new System.Windows.Forms.MaskedTextBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.NumericUpDown1);
            this.GroupBox1.Controls.Add(this.MaskedTextBox3);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(63, 23);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1056, 117);
            this.GroupBox1.TabIndex = 58;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vấn đề biểu quyết";
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.NumericUpDown1.Size = new System.Drawing.Size(81, 34);
            this.NumericUpDown1.TabIndex = 0;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(217, 64);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.ReadOnly = true;
            this.MaskedTextBox3.Size = new System.Drawing.Size(812, 34);
            this.MaskedTextBox3.TabIndex = 23;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(15, 64);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(111, 25);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "Tên vấn đề";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 22);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 25);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Mã vấn đề";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(129, 279);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 29);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Số đại biểu";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(397, 217);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 29);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Đồng ý";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(602, 217);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(161, 29);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Không đồng ý";
            // 
            // Label5
            // 
            this.Label5.AutoEllipsis = true;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(830, 217);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(151, 29);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Không ý kiến";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(129, 425);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(155, 29);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Số quyền BQ";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(129, 556);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(66, 29);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Tỷ lệ";
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox1.Location = new System.Drawing.Point(355, 276);
            this.MaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.ReadOnly = true;
            this.MaskedTextBox1.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox1.TabIndex = 59;
            // 
            // MaskedTextBox2
            // 
            this.MaskedTextBox2.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox2.Location = new System.Drawing.Point(586, 278);
            this.MaskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox2.Name = "MaskedTextBox2";
            this.MaskedTextBox2.ReadOnly = true;
            this.MaskedTextBox2.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox2.TabIndex = 59;
            // 
            // MaskedTextBox4
            // 
            this.MaskedTextBox4.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox4.Location = new System.Drawing.Point(816, 278);
            this.MaskedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox4.Name = "MaskedTextBox4";
            this.MaskedTextBox4.ReadOnly = true;
            this.MaskedTextBox4.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox4.TabIndex = 59;
            // 
            // MaskedTextBox5
            // 
            this.MaskedTextBox5.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox5.Location = new System.Drawing.Point(355, 418);
            this.MaskedTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox5.Name = "MaskedTextBox5";
            this.MaskedTextBox5.ReadOnly = true;
            this.MaskedTextBox5.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox5.TabIndex = 59;
            // 
            // MaskedTextBox6
            // 
            this.MaskedTextBox6.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox6.Location = new System.Drawing.Point(586, 421);
            this.MaskedTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox6.Name = "MaskedTextBox6";
            this.MaskedTextBox6.ReadOnly = true;
            this.MaskedTextBox6.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox6.TabIndex = 59;
            // 
            // MaskedTextBox7
            // 
            this.MaskedTextBox7.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox7.Location = new System.Drawing.Point(816, 421);
            this.MaskedTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox7.Name = "MaskedTextBox7";
            this.MaskedTextBox7.ReadOnly = true;
            this.MaskedTextBox7.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox7.TabIndex = 59;
            // 
            // MaskedTextBox8
            // 
            this.MaskedTextBox8.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox8.Location = new System.Drawing.Point(355, 550);
            this.MaskedTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox8.Name = "MaskedTextBox8";
            this.MaskedTextBox8.ReadOnly = true;
            this.MaskedTextBox8.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox8.TabIndex = 59;
            // 
            // MaskedTextBox9
            // 
            this.MaskedTextBox9.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox9.Location = new System.Drawing.Point(586, 553);
            this.MaskedTextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox9.Name = "MaskedTextBox9";
            this.MaskedTextBox9.ReadOnly = true;
            this.MaskedTextBox9.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox9.TabIndex = 59;
            // 
            // MaskedTextBox10
            // 
            this.MaskedTextBox10.BackColor = System.Drawing.Color.LightYellow;
            this.MaskedTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox10.Location = new System.Drawing.Point(816, 553);
            this.MaskedTextBox10.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox10.Name = "MaskedTextBox10";
            this.MaskedTextBox10.ReadOnly = true;
            this.MaskedTextBox10.Size = new System.Drawing.Size(189, 34);
            this.MaskedTextBox10.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(1054, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Không hợp lệ";
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.BackColor = System.Drawing.Color.LightYellow;
            this.maskedTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.maskedTextBox11.Location = new System.Drawing.Point(1044, 276);
            this.maskedTextBox11.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(189, 34);
            this.maskedTextBox11.TabIndex = 61;
            // 
            // maskedTextBox13
            // 
            this.maskedTextBox13.BackColor = System.Drawing.Color.LightYellow;
            this.maskedTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.maskedTextBox13.Location = new System.Drawing.Point(1044, 421);
            this.maskedTextBox13.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox13.Name = "maskedTextBox13";
            this.maskedTextBox13.ReadOnly = true;
            this.maskedTextBox13.Size = new System.Drawing.Size(189, 34);
            this.maskedTextBox13.TabIndex = 63;
            // 
            // maskedTextBox14
            // 
            this.maskedTextBox14.BackColor = System.Drawing.Color.LightYellow;
            this.maskedTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.maskedTextBox14.Location = new System.Drawing.Point(1044, 553);
            this.maskedTextBox14.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox14.Name = "maskedTextBox14";
            this.maskedTextBox14.ReadOnly = true;
            this.maskedTextBox14.Size = new System.Drawing.Size(189, 34);
            this.maskedTextBox14.TabIndex = 64;
            // 
            // MatterVoteResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 745);
            this.Controls.Add(this.maskedTextBox14);
            this.Controls.Add(this.maskedTextBox13);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MaskedTextBox10);
            this.Controls.Add(this.MaskedTextBox9);
            this.Controls.Add(this.MaskedTextBox7);
            this.Controls.Add(this.MaskedTextBox6);
            this.Controls.Add(this.MaskedTextBox8);
            this.Controls.Add(this.MaskedTextBox4);
            this.Controls.Add(this.MaskedTextBox5);
            this.Controls.Add(this.MaskedTextBox2);
            this.Controls.Add(this.MaskedTextBox1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatterVoteResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả biểu quyết";
            this.Load += new System.EventHandler(this.MatterVoteResult_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MatterVoteResult_KeyUp);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal GroupBox GroupBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label8;
        internal MaskedTextBox MaskedTextBox1;
        internal MaskedTextBox MaskedTextBox2;
        internal MaskedTextBox MaskedTextBox4;
        internal MaskedTextBox MaskedTextBox5;
        internal MaskedTextBox MaskedTextBox6;
        internal MaskedTextBox MaskedTextBox7;
        internal MaskedTextBox MaskedTextBox8;
        internal MaskedTextBox MaskedTextBox9;
        internal MaskedTextBox MaskedTextBox10;
        internal Label label9;
        internal MaskedTextBox maskedTextBox11;
        internal MaskedTextBox maskedTextBox13;
        internal MaskedTextBox maskedTextBox14;
    }
}