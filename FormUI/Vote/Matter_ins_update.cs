using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{
    public partial class Matter_ins_update
    {
        private string controlcode;
        private int updatemattercode;
        public Matter_ins_update(string controlcode, int mattercode)
        {
            this.controlcode = controlcode;
            updatemattercode = mattercode;
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call.

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Matter_ins_update_Load(object sender, EventArgs e)
        {
            MaskedTextBox1.Text = My.MyProject.Forms.Mainform.workingmeeting;

            // Set giá trị mặc định cho MaskedTextBox2 (Tỷ lệ)
            MaskedTextBox2.Text = "65";

            if (controlcode == "Update")
            {
                NumericUpDown1.Value = updatemattercode;
                NumericUpDown1.ReadOnly = true;
                Button1.Text = "Cập nhật";
                Text = "Cập nhật vấn đề biểu quyết";
                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.Matter_getlist(My.MyProject.Forms.Mainform.workingmeeting, updatemattercode);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("lỗi" + ex.Message);
                    return;
                }
                MaskedTextBox2.Text = Convert.ToString(dt.Rows[0]["MatterApprovedPercent"]);
                MaskedTextBox3.Text = Conversions.ToString(dt.Rows[0]["Mattername"]);
                TextBox1.Text = Conversions.ToString(dt.Rows[0]["MatterDescription"]);
            }

            // Add event handler để validate input cho MaskedTextBox2
            MaskedTextBox2.TextChanged += MaskedTextBox2_TextChanged;
            MaskedTextBox2.KeyPress += MaskedTextBox2_KeyPress;
        }

        // Validate input - chỉ nhận số 0-100
        private void MaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaskedTextBox2.Text))
                return;

            if (int.TryParse(MaskedTextBox2.Text.Trim(), out int value))
            {
                if (value < 0 || value > 100)
                {
                    MaskedTextBox2.Text = value > 100 ? "100" : "0";
                    MaskedTextBox2.SelectAll();
                }
            }
        }

        // Prevent non-numeric input
        private void MaskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (controlcode == "Add")
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.Matter_insert(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value.ToString(), MaskedTextBox3.Text, TextBox1.Text, int.Parse(MaskedTextBox2.Text));
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi : " + ex.Message);
                }
            }
            else if (controlcode == "Update")
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.Matter_update(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value.ToString(), MaskedTextBox3.Text, TextBox1.Text, int.Parse(MaskedTextBox2.Text));
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi : " + ex.Message);
                }

            }
        }
    }
}