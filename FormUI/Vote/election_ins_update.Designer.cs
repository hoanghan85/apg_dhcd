using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace pmDHCD
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class election_ins_update : Form
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
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(497, 433);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(180, 43);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "Đóng";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(123, 433);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(161, 43);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(232, 219);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(635, 170);
            this.TextBox1.TabIndex = 3;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown1.Location = new System.Drawing.Point(232, 74);
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
            // MaskedTextBox3
            // 
            this.MaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox3.Location = new System.Drawing.Point(232, 129);
            this.MaskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox3.Name = "MaskedTextBox3";
            this.MaskedTextBox3.Size = new System.Drawing.Size(635, 26);
            this.MaskedTextBox3.TabIndex = 1;
            // 
            // MaskedTextBox1
            // 
            this.MaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTextBox1.Location = new System.Drawing.Point(232, 33);
            this.MaskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextBox1.Name = "MaskedTextBox1";
            this.MaskedTextBox1.ReadOnly = true;
            this.MaskedTextBox1.Size = new System.Drawing.Size(265, 26);
            this.MaskedTextBox1.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(28, 225);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 20);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "Diễn giải";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(29, 129);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(92, 20);
            this.Label7.TabIndex = 31;
            this.Label7.Text = "Tên bầu cử";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(29, 84);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 20);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Mã bầu cử";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(29, 33);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 20);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Mã cuộc họp";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(29, 176);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(165, 20);
            this.Label4.TabIndex = 31;
            this.Label4.Text = "Số đại biểu được bầu";
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown2.Location = new System.Drawing.Point(232, 171);
            this.NumericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(81, 29);
            this.NumericUpDown2.TabIndex = 2;
            this.NumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // election_ins_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 539);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.NumericUpDown2);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.MaskedTextBox3);
            this.Controls.Add(this.MaskedTextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "election_ins_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm vấn đề bầu cử";
            this.Load += new System.EventHandler(this.election_ins_update_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ElectionUpsert_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Button Button3;
        internal Button Button1;
        internal TextBox TextBox1;
        internal NumericUpDown NumericUpDown1;
        internal MaskedTextBox MaskedTextBox3;
        internal MaskedTextBox MaskedTextBox1;
        internal Label Label3;
        internal Label Label7;
        internal Label Label2;
        internal Label Label1;
        internal Label Label4;
        internal NumericUpDown NumericUpDown2;
    }
}