using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Matter_ins_update : Form
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
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.MaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(219, 118);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox3.TabIndex = 1;
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox1.Location = new System.Drawing.Point(219, 22);
            this.MaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.ReadOnly = true;
            this.MaskedTextBox1.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox1.TabIndex = 18;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(15, 169);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 20);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Diễn giải";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 118);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(91, 20);
            this.Label7.TabIndex = 21;
            this.Label7.Text = "Tên vấn đề";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 73);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 20);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Mã vấn đề";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 20);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Mã cuộc họp";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(540, 73);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 20);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Tỷ lệ";
            // 
            // MaskedTextBox2
            // 
            this.MaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox2.Location = new System.Drawing.Point(640, 63);
            this.MaskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox2.Mask = "000";
            this.MaskedTextBox2.Name = "MaskedTextBox2";
            this.MaskedTextBox2.Size = new System.Drawing.Size(61, 26);
            this.MaskedTextBox2.TabIndex = 1;
            this.MaskedTextBox2.Text = "65";
            this.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown1.Location = new System.Drawing.Point(219, 63);
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
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(219, 162);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(635, 170);
            this.TextBox1.TabIndex = 2;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(484, 368);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(180, 43);
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Đóng";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(109, 368);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(161, 43);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Matter_ins_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 442);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.MaskedTextBox2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.MaskedTextBox3);
            this.Controls.Add(this.MaskedTextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Matter_ins_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm vấn đề biểu quyết";
            this.Load += new System.EventHandler(this.Matter_ins_update_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Matterupsert_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox1;
        internal MaskedTextBox MaskedTextBox2;
        internal Label Label3;
        internal Label Label7;
        internal Label Label2;
        internal Label Label4;
        internal Label Label1;
        internal NumericUpDown NumericUpDown1;
        internal TextBox TextBox1;
        internal Button Button3;
        internal Button Button1;
    }
}