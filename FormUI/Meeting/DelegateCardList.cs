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

            dataGridView1.DataSource = dt;
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var col = dataGridView1.Columns[e.ColumnIndex];

            var meetingCode = row.Cells["MeetingCode"]?.Value?.ToString();
            var matterCode = row.Cells["MatterCode"]?.Value?.ToString();
            var matterDescription = row.Cells["MatterDescription"]?.Value?.ToString();
            var columnName = col.Name;
            var newValue = row.Cells[e.ColumnIndex]?.Value;

            // simple validation for numeric vote columns
            if (columnName == "Agree" || columnName == "DisAgree" || columnName == "NoIdea")
            {
                if (newValue == null || !int.TryParse(newValue.ToString(), out _))
                {
                    MessageBox.Show("Vui lòng nhập số biểu quyết", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // optionally revert cell value or focus cell
                    return;
                }
            }

            try
            {
                // TODO: Persist change via your DAL. Example (replace with real method):
                // My.MyProject.Forms.Mainform.BenlyDal.UpdateVoteCard(
                //     My.MyProject.Forms.Mainform.workingmeeting,
                //     meetingCode, matterCode, columnName, newValue);

                // Optionally refresh dependent UI:
                // My.MyProject.Forms.Mainform.UpdateAttendanceRate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static int ParseInt(DataGridViewRow r, string col)
        {
            var v = r.Cells[col]?.Value;
            return v != null && int.TryParse(v.ToString(), out var n) ? n : 0;
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
    }
}