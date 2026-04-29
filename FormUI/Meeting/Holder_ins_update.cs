using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{
    public partial class Holder_ins_update
    {
        private string controlcode = "Add";
        private string updateholdercode;
        public Holder_ins_update(string controlcode, string holdercode)
        {
            this.controlcode = controlcode;
            updateholdercode = holdercode;
            InitializeComponent();

        }
        private void Holder_ins_update_Load(object sender, EventArgs e)
        {
            MaskedTextBox1.Text = My.MyProject.Forms.Mainform.workingmeeting;
            if (controlcode == "Update")
            {
                MaskedTextBox2.Text = updateholdercode;
                MaskedTextBox2.ReadOnly = true;
                Button1.Text = "Cập nhật";
                Text = "Cập nhật cổ đông";
                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.Holder_getlist(My.MyProject.Forms.Mainform.workingmeeting, updateholdercode, "");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("lỗi" + ex.Message);
                    return;
                }
                MaskedTextBox2.Text = Conversions.ToString(dt.Rows[0]["Holdercode"]);
                MaskedTextBox3.Text = Conversions.ToString(dt.Rows[0]["HolderIdentity"]);
                MaskedTextBox4.Text = Conversions.ToString(dt.Rows[0]["Holdername"]);
                MaskedTextBox5.Text = Conversions.ToString(dt.Rows[0]["HolderAddress"]);
                StockTextBox1.Text = Conversions.ToString(dt.Rows[0]["Shares"]);
                StockTextBox2.Text = Conversions.ToString(dt.Rows[0]["Voterights"]);
                DateTime dateValue = Conversions.ToDate(dt.Rows[0]["IdentityDate"]);
                identityDate.Text = dateValue.ToString("dd/MM/yyyy");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime identityDateValue;
            decimal shares = 0;
            decimal voteRights = 0;

            // Parse the date from MaskedTextBox format (dd/MM/yyyy)
            if (!DateTime.TryParseExact(identityDate.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out identityDateValue))
            {
                Interaction.MsgBox("Ngày cấp không hợp lệ. Vui lòng nhập theo định dạng DD/MM/YYYY");
                identityDate.Focus();
                return;
            }

            // Validate and parse Shares (Số cổ phần)
            if (!string.IsNullOrWhiteSpace(StockTextBox1.Text))
            {
                if (!decimal.TryParse(StockTextBox1.Text, out shares) || shares < 0)
                {
                    Interaction.MsgBox("Số cổ phần phải là số không âm");
                    StockTextBox1.Focus();
                    StockTextBox1.SelectAll();
                    return;
                }
            }

            // Validate and parse VoteRights (Số quyền biểu quyết)
            if (!string.IsNullOrWhiteSpace(StockTextBox2.Text))
            {
                if (!decimal.TryParse(StockTextBox2.Text, out voteRights) || voteRights < 0)
                {
                    Interaction.MsgBox("Số quyền biểu quyết phải là số không âm");
                    StockTextBox2.Focus();
                    StockTextBox2.SelectAll();
                    return;
                }
            }

            if (controlcode == "Add")
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.holder_insert(MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, shares, voteRights, identityDateValue);
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
                    My.MyProject.Forms.Mainform.BenlyDal.holder_update(MaskedTextBox1.Text, MaskedTextBox2.Text, MaskedTextBox3.Text, MaskedTextBox4.Text, MaskedTextBox5.Text, shares, voteRights, identityDateValue);
                    Close();
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi : " + ex.Message);
                }

            }
        }

        private void Holder_ins_update_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}