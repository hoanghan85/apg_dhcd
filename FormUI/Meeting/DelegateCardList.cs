using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pmDHCD.Meeting
{
    public partial class DelegateCardList : Form
    {
        public DelegateCardList()
        {
            InitializeComponent();
            // wire event to handle edits
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            this.Load += DelegateCardList_Load; // ensure Load is wired for runtime
        }

        private void DelegateCardList_Load(object sender, EventArgs e)
        {
            // keep behavior consistent with other lists
            MdiParent = My.MyProject.Forms.Mainform;
            filldgv();
        }

        public void filldgv()
        {
            var dt = new DataTable();

            try
            {
                dt = My.MyProject.Forms.Mainform.BenlyDal.VoteCards_getlist(My.MyProject.Forms.Mainform.workingmeeting, null);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi : " + ex.Message);
                return;
            }

            if (!dt.Columns.Contains("AgreePercent"))
                dt.Columns.Add("AgreePercent", typeof(decimal));

            if (!dt.Columns.Contains("DisAgreePercent"))
                dt.Columns.Add("DisAgreePercent", typeof(decimal));

            if (!dt.Columns.Contains("NoIdeaPercent"))
                dt.Columns.Add("NoIdeaPercent", typeof(decimal));

            foreach (DataRow dr in dt.Rows)
            {
                decimal total = ToDecimal(dr["TotalVoteRights"]);
                decimal agree = ToDecimal(dr["Agree"]);
                decimal disAgree = ToDecimal(dr["DisAgree"]);
                decimal noIdea = ToDecimal(dr["NoIdea"]);

                dr["AgreePercent"] = total == 0 ? 0 : Math.Round(agree / total * 100, 2);
                dr["DisAgreePercent"] = total == 0 ? 0 : Math.Round(disAgree / total * 100, 2);
                dr["NoIdeaPercent"] = total == 0 ? 0 : Math.Round(noIdea / total * 100, 2);
            }

            dataGridView1.DataSource = dt;


            // Format số có phân cách hàng nghìn theo culture vi-VN: 1.234.567
            dataGridView1.Columns["Agree"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["DisAgree"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["NoIdea"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["TotalVoteRights"].DefaultCellStyle.Format = "N0";

            dataGridView1.Columns["AgreePercent"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["DisAgreePercent"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["NoIdeaPercent"].DefaultCellStyle.Format = "N2";
            // Nên để Agree tự tính, không cho sửa tay
            //dataGridView1.Columns["Agree"].ReadOnly = true;
            dataGridView1.Columns["TotalVoteRights"].ReadOnly = true;
            dataGridView1.Columns["AgreePercent"].ReadOnly = true;
            dataGridView1.Columns["DisAgreePercent"].ReadOnly = true;
            dataGridView1.Columns["NoIdeaPercent"].ReadOnly = true;

            // update status label if present in designer
            try
            {
                toolStripStatusLabel1.Text = "Số lượng bản ghi : " + dataGridView1.RowCount.ToString();
            }
            catch
            {
                // ignore if label not present
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var row = dataGridView1.Rows[e.RowIndex];
            var col = dataGridView1.Columns[e.ColumnIndex];

            string meetingCode = row.Cells["MeetingCode"]?.Value?.ToString();
            string matterCode = row.Cells["MatterCode"]?.Value?.ToString();
            string matterDescription = row.Cells["MatterDescription"]?.Value?.ToString();

            string columnName = col.Name;
            object newValue = row.Cells[e.ColumnIndex]?.Value;

            // Validate các cột nhập số
            if (columnName == "Agree"
                || columnName == "DisAgree"
                || columnName == "NoIdea")
            {
                if (newValue == null || !int.TryParse(newValue.ToString(), out _))
                {
                    MessageBox.Show(
                        "Vui lòng nhập số biểu quyết",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // Tự tính lại Agree khi sửa DisAgree hoặc NoIdea
            if (columnName == "DisAgree" || columnName == "NoIdea")
            {
                int totalVoteRights = ParseInt(row, "TotalVoteRights");
                int disAgree = ParseInt(row, "DisAgree");
                int noIdea = ParseInt(row, "NoIdea");

                int agree = totalVoteRights - disAgree - noIdea;

                if (agree < 0)
                {
                    MessageBox.Show(
                        "Tổng số phiếu Không tán thành và Không có ý kiến vượt quá số quyền biểu quyết.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    agree = 0;
                }

                row.Cells["Agree"].Value = agree;

                row.Cells["AgreePercent"].Value = totalVoteRights == 0 ? 0 : Math.Round(agree * 100m / totalVoteRights, 2);
                row.Cells["DisAgreePercent"].Value = totalVoteRights == 0 ? 0 : Math.Round(disAgree * 100m / totalVoteRights, 2);
                row.Cells["NoIdeaPercent"].Value = totalVoteRights == 0 ? 0 : Math.Round(noIdea * 100m / totalVoteRights, 2);

            }

            try
            {
                // TODO: Save DB
                /*
                My.MyProject.Forms.Mainform.BenlyDal.VoteCards_Upsert(
                    meetingCode,
                    Convert.ToInt32(matterCode),
                    matterDescription,
                    ParseInt(row, "Agree"),
                    ParseInt(row, "DisAgree"),
                    ParseInt(row, "NoIdea"));
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Save failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static int ParseInt(DataGridViewRow r, string col)
        {
            var v = r.Cells[col]?.Value;

            if (v == null || v == DBNull.Value)
                return 0;

            string text = v.ToString().Replace(".", "").Replace(",", "");

            return int.TryParse(text, out var n) ? n : 0;
        }

        private static decimal ToDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
                return 0;

            decimal.TryParse(value.ToString(), out decimal result);
            return result;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var dal = My.MyProject.Forms.Mainform.BenlyDal;
            var meeting = My.MyProject.Forms.Mainform.workingmeeting;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (!int.TryParse(Convert.ToString(row.Cells["MatterCode"].Value), out int matterCode)) continue;
                string matterDescription = Convert.ToString(row.Cells["MatterDescription"].Value);
                int agree = ParseInt(row, "Agree");
                int disagree = ParseInt(row, "DisAgree");
                int noIdea = ParseInt(row, "NoIdea");
                dal.VoteCards_Upsert(meeting, matterCode, matterDescription, agree, disagree, noIdea);
            }
        }

        private void DeleteSelectedRow()
        {
            DataGridViewRow row = null;

            // prefer SelectedRows if present
            if (dataGridView1.SelectedRows.Count > 0)
            {
                row = dataGridView1.SelectedRows[0];
            }
            else if (dataGridView1.CurrentCell != null)
            {
                // use current cell's row when SelectionMode is CellSelect
                row = dataGridView1.CurrentCell.OwningRow;
            }

            if (row == null)
            {
                Interaction.MsgBox("Bạn phải chọn ít nhất một bản ghi");
                return;
            }

            if (!int.TryParse(Convert.ToString(row.Cells["MatterCode"].Value), out int matterCode))
            {
                Interaction.MsgBox("Mã vấn đề không hợp lệ");
                return;
            }

            if (Interaction.MsgBox($"Bạn có chắc chắn XÓA vấn đề: {matterCode} ?", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.ApplicationModal, "XÓA") != MsgBoxResult.Ok)
                return;

            try
            {
                var meeting = My.MyProject.Forms.Mainform.workingmeeting;
                My.MyProject.Forms.Mainform.BenlyDal.VoteCards_delete(meeting, matterCode);
                filldgv();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void DelegateCardList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                toolStripButton1.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                toolStripButton3.PerformClick();
            }
        }
    }
}