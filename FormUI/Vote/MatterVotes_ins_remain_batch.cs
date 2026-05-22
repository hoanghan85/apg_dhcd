using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Windows.Forms;

namespace pmDHCD
{
    public partial class MatterVotes_ins_remain_batch
    {
        public bool IsConfirmed { get; set; }
        public int SelectedMatterCode { get; set; }
        public bool AgreeValue { get; set; }
        public bool DisagreeValue { get; set; }
        public bool NoideaValue { get; set; }

        public MatterVotes_ins_remain_batch()
        {
            InitializeComponent();
            IsConfirmed = false;
            SelectedMatterCode = 0;
            AgreeValue = true;
            DisagreeValue = false;
            NoideaValue = false;
        }

        private void MatterVotes_ins_remain_batch_Load(object sender, EventArgs e)
        {
            // Set default to "Đồng ý"
            RadioButton1.Checked = true;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Confirm button
            try
            {
                SelectedMatterCode = Conversions.ToInteger(TextBox1.Text);
            }
            catch (Exception ex)
            {
                SelectedMatterCode = 0;
            }

            AgreeValue = RadioButton1.Checked;
            DisagreeValue = RadioButton2.Checked;
            NoideaValue = RadioButton3.Checked;

            IsConfirmed = true;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Cancel button
            IsConfirmed = false;
            Close();
        }

        private void MattervoteInsBatch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
