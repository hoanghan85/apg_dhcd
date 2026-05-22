using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{
    public partial class Electionvote_ins_update
    {
        private int updateelectioncode = 0;
        private int updatedelegatecode = 0;
        private object controlcode = "Add";

        public Electionvote_ins_update(string controlcode, int updateelectioncode, int updatedelegationcode)
        {
            InitializeComponent();
            this.updateelectioncode = updateelectioncode;
            updatedelegatecode = updatedelegationcode;
            this.controlcode = controlcode;
        }
        private void Electionvote_ins_update_Load(object sender, EventArgs e)
        {
            MaskedTextBox1.Text = My.MyProject.Forms.Mainform.workingmeeting;
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(controlcode, "Update", false)))
            {
                NumericUpDown1.Value = updateelectioncode;

                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.Election_getlist(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                    return;
                }
                if (dt.Rows.Count == 1)
                {
                    MaskedTextBox3.Text = Conversions.ToString(dt.Rows[0]["Electionname"]);
                    MaskedTextBox6.Text = Conversions.ToString(dt.Rows[0]["Numofcandidates"]);

                    // ================ cho danh sach ung cu vien vao datagridview 

                    var dt2 = new DataTable();
                    try
                    {
                        dt2 = My.MyProject.Forms.Mainform.BenlyDal.Candidates_getlist_4voteupdate(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, 0m, updatedelegatecode);
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Lỗi :" + ex.Message);
                        return;
                    }
                    // dt2.Columns.Remove("electioncode")
                    // dt2.Columns.Remove("electionname")
                    // dt2.Columns.Remove("CandidateAddress")
                    DataGridView1.DataSource = dt2;
                }
                else
                {
                    MaskedTextBox3.Text = "";
                    MaskedTextBox6.Text = "";
                    DataGridView1.DataSource = Constants.vbNull;
                }


                // ===========================================
                MaskedTextBox5.Text = updatedelegatecode.ToString();

                var dt3 = new DataTable();
                int delecode = 0;
                try
                {
                    delecode = Conversions.ToInteger(MaskedTextBox5.Text);
                }
                catch (Exception ex)
                {
                    delecode = 0;
                }
                try
                {
                    dt3 = My.MyProject.Forms.Mainform.BenlyDal.Delegate_getlist(My.MyProject.Forms.Mainform.workingmeeting, updatedelegatecode, "");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                    return;
                }
                if (dt3.Rows.Count == 1)
                {
                    MaskedTextBox5.Text = Conversions.ToString(dt3.Rows[0]["Delegatecode"]);
                    MaskedTextBox2.Text = Conversions.ToString(dt3.Rows[0]["IdentityCard"]);
                    MaskedTextBox4.Text = Conversions.ToString(dt3.Rows[0]["DelegateName"]);
                    StockTextBox1.Text = Conversions.ToString(dt3.Rows[0]["voterights"]);
                    StockTextBox2.Text = Conversions.ToString(Operators.MultiplyObject(dt3.Rows[0]["voterights"], MaskedTextBox6.Text));
                }
                else
                {
                    MaskedTextBox5.Text = "";
                    MaskedTextBox2.Text = "";
                    MaskedTextBox4.Text = "";
                    StockTextBox1.Text = "";
                    StockTextBox2.Text = "";
                }


                NumericUpDown1.ReadOnly = true;
                MaskedTextBox5.ReadOnly = true;
                MaskedTextBox2.ReadOnly = true;

                Button1.Text = "Cập nhật";
                Text = "Cập nhật phiếu bầu cử";
                Button2.Enabled = false;
            }
            else
            {
                // ✅ Add mode - Load dữ liệu ngay lập tức
                LoadElectionData();
            }
        }

        // ✅ Thêm method này
        private void LoadElectionData()
        {
            var dt = new DataTable();
            try
            {
                dt = My.MyProject.Forms.Mainform.BenlyDal.Election_getlist(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi: " + ex.Message);
                return;
            }

            if (dt.Rows.Count == 1)
            {
                MaskedTextBox3.Text = Conversions.ToString(dt.Rows[0]["Electionname"]);
                MaskedTextBox6.Text = Conversions.ToString(dt.Rows[0]["Numofcandidates"]);

                var dt2 = new DataTable();
                try
                {
                    dt2 = My.MyProject.Forms.Mainform.BenlyDal.Candidates_getlist(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, 0m);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi: " + ex.Message);
                    return;
                }
                dt2.Columns.Remove("electioncode");
                dt2.Columns.Remove("electionname");
                dt2.Columns.Remove("CandidateAddress");
                DataGridView1.DataSource = dt2;
            }
            else
            {
                // ✅ Không có dữ liệu bầu cử
                Interaction.MsgBox("Không có dữ liệu Bầu cử", MsgBoxStyle.Exclamation);
                MaskedTextBox3.Text = "";
                MaskedTextBox6.Text = "";
                DataGridView1.DataSource = Constants.vbNull;
                Close();
            }
        }

        // Sửa NumericUpDown1_ValueChanged để gọi method chung
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LoadElectionData();
        }

        private void MaskedTextBox5_Leave(object sender, EventArgs e)
        {
            var dt = new DataTable();
            int delecode = 0;
            if (!int.TryParse(MaskedTextBox5.Text, out delecode))
            {
                delecode = 0;
            }

            try
            {
                dt = My.MyProject.Forms.Mainform.BenlyDal.Delegate_getlist(My.MyProject.Forms.Mainform.workingmeeting, delecode, "");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
                return;
            }

            if (dt.Rows.Count == 1)
            {

                MaskedTextBox5.Text = Conversions.ToString(dt.Rows[0]["Delegatecode"]);
                MaskedTextBox2.Text = Conversions.ToString(dt.Rows[0]["IdentityCard"]);
                //MaskedTextBox2.Enabled = false;
                MaskedTextBox4.Text = Conversions.ToString(dt.Rows[0]["DelegateName"]);
                StockTextBox1.Text = Conversions.ToString(dt.Rows[0]["voterights"]);
                StockTextBox2.Text = Conversions.ToString(Operators.MultiplyObject(dt.Rows[0]["voterights"], MaskedTextBox6.Text));
                DataGridView1.Select();
            }

            else
            {
                MessageBox.Show("Không tìm thấy đại biểu với mã đại biểu: " + delecode + "!");
                //MaskedTextBox5.Text = "";
                MaskedTextBox2.Text = "";
                MaskedTextBox4.Text = "";
                StockTextBox1.Text = "";
                StockTextBox2.Text = "";
                MaskedTextBox5.Focus();
                MaskedTextBox5.SelectAll();
            }
        }

        private void MaskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MaskedTextBox2_Leave(object sender, EventArgs e)
        {
            var dt = new DataTable();
            string identityCard = MaskedTextBox2.Text.Trim(); // Loại bỏ khoảng trắng

            try
            {
                dt = My.MyProject.Forms.Mainform.BenlyDal.Delegate_getlist(My.MyProject.Forms.Mainform.workingmeeting, 0m, identityCard);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
                return;
            }
            if (dt.Rows.Count == 1)
            {
                MaskedTextBox5.Text = Conversions.ToString(dt.Rows[0]["Delegatecode"]);
                MaskedTextBox2.Text = Conversions.ToString(dt.Rows[0]["IdentityCard"]);
                MaskedTextBox4.Text = Conversions.ToString(dt.Rows[0]["DelegateName"]);
                StockTextBox1.Text = Conversions.ToString(dt.Rows[0]["voterights"]);
                StockTextBox2.Text = Conversions.ToString(Operators.MultiplyObject(dt.Rows[0]["voterights"], MaskedTextBox6.Text));
            }
            else if (dt.Rows.Count > 1)
            {
                var objDelegateListForSelect = new DelegateListForSelect();
                objDelegateListForSelect.IdentifyCard = identityCard;
                objDelegateListForSelect.ShowDialog();
                if (objDelegateListForSelect.DataGridView1.CurrentRow != null)
                {
                    MaskedTextBox5.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["Delegatecode"].Value.ToString();
                    MaskedTextBox2.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["IdentityCard"].Value.ToString();
                    MaskedTextBox4.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["DelegateName"].Value.ToString();
                    StockTextBox1.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["voterights"].Value.ToString();
                    StockTextBox2.Text = Conversions.ToString(Operators.MultiplyObject(objDelegateListForSelect.DataGridView1.CurrentRow.Cells["voterights"].Value.ToString(), MaskedTextBox6.Text));
                }
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đại biểu với CCCD/HC: " + identityCard + "!");
                MaskedTextBox5.Text = "";
                //MaskedTextBox2.Text = "";
                MaskedTextBox4.Text = "";
                StockTextBox1.Text = "";
                StockTextBox2.Text = "";
                MaskedTextBox2.Focus();
                MaskedTextBox2.SelectAll();
            }
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Đếm số ứng viên được chọn TRƯỚC khi xóa Votes
                int candidatechoosen = 0;
                foreach (DataGridViewRow gr in DataGridView1.Rows)
                {
                    if (Convert.ToBoolean(gr.Cells["Choosen"].Value) == true)
                    {
                        candidatechoosen = candidatechoosen + 1;
                    }
                }

                // Nếu không có ứng viên nào được chọn, thoát
                if (candidatechoosen == 0)
                {
                    Interaction.MsgBox("Vui lòng chọn ít nhất một ứng viên");
                    return;
                }

                // Lúc này mới chia đều phiếu
                int totalVotes = Convert.ToInt32(
                    StockTextBox2.Text.Replace(".", "")
                );
                int votesPerCandidate = totalVotes / candidatechoosen;

                foreach (DataGridViewRow gr in DataGridView1.Rows)
                {
                    if (Convert.ToBoolean(gr.Cells["Choosen"].Value) == true)
                    {
                        gr.Cells["Votes"].Value = votesPerCandidate.ToString();
                    }
                    else
                    {
                        gr.Cells["Votes"].Value = "";
                    }
                }

                // Cập nhật cảnh báo sau khi chia đều
                CheckVoteWarning();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi: " + ex.Message);
            }

            // End If
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ElectionVoteUpsert_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            MaskedTextBox5.Text = "";
            MaskedTextBox2.Text = "";
            MaskedTextBox4.Text = "";
            StockTextBox1.Text = "";
            StockTextBox2.Text = "";
            var dt2 = new DataTable();
            try
            {
                dt2 = My.MyProject.Forms.Mainform.BenlyDal.Candidates_getlist(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, 0m);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
                return;
            }
            dt2.Columns.Remove("electioncode");
            dt2.Columns.Remove("electionname");
            dt2.Columns.Remove("CandidateAddress");
            DataGridView1.DataSource = dt2;
            Button1.Enabled = true;
            RadioButton1.Checked = true;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow gr in DataGridView1.Rows)
            {

                gr.Cells["Votes"].Value = 0;
                gr.Cells["Choosen"].Value = true;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (RadioButton1.Checked == true)
            {
                int totalvoteingrid = 0;
                int totalCandidateingrid = 0;

                foreach (DataGridViewRow dgvr in DataGridView1.Rows)
                {
                    if (Convert.ToBoolean(dgvr.Cells["choosen"].Value) == true)
                    {
                        try
                        {
                            totalvoteingrid = Conversions.ToInteger(Operators.AddObject(totalvoteingrid, dgvr.Cells["Votes"].Value));
                            totalCandidateingrid = totalCandidateingrid + 1;
                        }
                        catch (Exception ex)
                        {
                            Interaction.MsgBox("Lỗi :" + ex.Message);
                            return;
                        }
                    }
                }

                // If totalCandidateingrid > MaskedTextBox6.Text Then
                // MsgBox("Lỗi : Số ứng viên đã chọn lớn hơn số ứng viên được bầu")
                // Exit Sub
                // End If
                if (totalvoteingrid > Conversions.ToDouble(StockTextBox2.Text))
                {
                    Interaction.MsgBox("Lỗi : Số phiếu bầu không hợp lệ");
                    return;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(controlcode, "Add", false)))
                {
                    if (DataGridView1.CurrentRow == null)
                    {
                        Interaction.MsgBox("Thiếu thông tin Bầu cử hoặc Ứng viên, vui lòng kiểm tra lại");
                        return;
                    }
                    foreach (DataGridViewRow dgvr in DataGridView1.Rows)
                    {

                        // Fixed in case the Votes is empty or null
                        // If dgvr.Cells("choosen").Value = True And dgvr.Cells("Votes").Value.ToString <> "" Then
                        if (Conversions.ToBoolean(dgvr.Cells["choosen"].Value) == true)
                        {
                            string ValueFetchOut;
                            {
                                var withBlock = DataGridView1;
                                ValueFetchOut = Conversions.ToString(dgvr.Cells["Votes"].Value);
                                ValueFetchOut = ValueFetchOut.Replace(".", "");
                                if (string.IsNullOrEmpty(ValueFetchOut))
                                {
                                    ValueFetchOut = "0";
                                }
                                Convert.ToInt32(ValueFetchOut);
                            }

                            try
                            {
                                MessageBox.Show("Hellowword3");

                                // Mainform.BenlyDal.ElectionVotes_insert(Mainform.workingmeeting, NumericUpDown1.Value, MaskedTextBox5.Text, dgvr.Cells("Candidatecode").Value, dgvr.Cells("Votes").Value)
                                My.MyProject.Forms.Mainform.BenlyDal.ElectionVotes_insert(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, Conversions.ToDecimal(MaskedTextBox5.Text), Conversions.ToDecimal(dgvr.Cells["Candidatecode"].Value), Convert.ToInt32(ValueFetchOut));
                            }
                            catch (Exception ex)
                            {
                                Interaction.MsgBox("Lỗi :" + ex.Message);
                                return;
                            }
                        }
                        else
                        {
                            try
                            {
                                My.MyProject.Forms.Mainform.BenlyDal.ElectionVotes_insert(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, Conversions.ToDecimal(MaskedTextBox5.Text), Conversions.ToDecimal(dgvr.Cells["Candidatecode"].Value), 0m);
                            }
                            catch (Exception ex)
                            {
                                Interaction.MsgBox("Lỗi :" + ex.Message);
                                return;
                            }
                        }

                    }
                    Button1.Enabled = false;
                    Button2.Focus();
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(controlcode, "Update", false)))
                {
                    foreach (DataGridViewRow dgvr in DataGridView1.Rows)
                        My.MyProject.Forms.Mainform.BenlyDal.ElectionVotes_delete(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, Conversions.ToDecimal(MaskedTextBox5.Text), Conversions.ToDecimal(dgvr.Cells["Candidatecode"].Value));
                    foreach (DataGridViewRow dgvr in DataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(dgvr.Cells["choosen"].Value) == true & Convert.ToInt32(dgvr.Cells["Votes"].Value) != 0)
                        {
                            My.MyProject.Forms.Mainform.BenlyDal.ElectionVotes_insert(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, Conversions.ToDecimal(MaskedTextBox5.Text), Conversions.ToDecimal(dgvr.Cells["Candidatecode"].Value), Conversions.ToDecimal(dgvr.Cells["Votes"].Value));
                        }
                    }
                    Close();
                }
            }


            else
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.IllegalElectionVotes_insert(My.MyProject.Forms.Mainform.workingmeeting, NumericUpDown1.Value, Conversions.ToDecimal(MaskedTextBox5.Text));
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                    return;
                }
                Button1.Enabled = false;
                Button2.Focus();
            }

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                DataGridView1.ReadOnly = true;
                Button4.Enabled = false;
                Button5.Enabled = false;
            }
            else
            {
                DataGridView1.ReadOnly = false;
                Button4.Enabled = true;
                Button5.Enabled = true;
            }
        }

        // Kiểm tra và cập nhật warning khi nhập phiếu bầu
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ kiểm tra khi chỉnh sửa cột "Votes"
            if (e.ColumnIndex >= 0 && DataGridView1.Columns[e.ColumnIndex].Name == "Votes")
            {
                try
                {
                    // Lấy giá trị phiếu bầu được nhập
                    var votesValue = DataGridView1.Rows[e.RowIndex].Cells["Votes"].Value;
                    string votesStr = votesValue != null ? votesValue.ToString().Trim() : "";

                    // Tự động tick "Chọn" nếu nhập giá trị (bao gồm cả 0)
                    // Bỏ tick chỉ khi ô trống (rỗng)
                    if (!string.IsNullOrEmpty(votesStr))
                    {
                        DataGridView1.Rows[e.RowIndex].Cells["Choosen"].Value = true;
                    }
                    else
                    {
                        DataGridView1.Rows[e.RowIndex].Cells["Choosen"].Value = false;
                    }
                }
                catch (Exception ex)
                {
                    // Bỏ qua lỗi nếu không convert được
                }

                // Cập nhật cảnh báo
                CheckVoteWarning();
            }
        }

        private void CheckVoteWarning()
        {
            try
            {
                int totalvoteingrid = 0;
                int maxvotes = Conversions.ToInteger(StockTextBox2.Text);

                foreach (DataGridViewRow dgvr in DataGridView1.Rows)
                {
                    if (Convert.ToBoolean(dgvr.Cells["choosen"].Value) == true)
                    {
                        try
                        {
                            int votes = Conversions.ToInteger(dgvr.Cells["Votes"].Value ?? 0);
                            totalvoteingrid += votes;
                        }
                        catch
                        {
                            // Bỏ qua nếu không convert được
                        }
                    }
                }

                // Hiển thị cảnh báo nếu vượt quá
                if (totalvoteingrid > maxvotes)
                {
                    LabelWarning.Text = "⚠️ Cảnh báo: Tổng phiếu bầu (" + totalvoteingrid + ") vượt quá (" + maxvotes + ")";
                    LabelWarning.ForeColor = Color.Red;
                    LabelWarning.Visible = true;
                }
                else if (totalvoteingrid > 0)
                {
                    LabelWarning.Text = "✓ Phiếu hợp lệ";
                    LabelWarning.ForeColor = Color.Green;
                    LabelWarning.Visible = true;
                }
                else
                {
                    LabelWarning.Text = "";
                    LabelWarning.Visible = false;
                }
            }
            catch (Exception ex)
            {
                LabelWarning.Text = "";
                LabelWarning.Visible = false;
            }
        }
    }
}