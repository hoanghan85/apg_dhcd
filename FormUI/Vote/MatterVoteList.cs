using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace pmDHCD
{
    public partial class MatterVoteList
    {
        public MatterVoteList()
        {
            InitializeComponent();
        }


        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            filldgv();
        }

        private void MatterVoteList_Load(object sender, EventArgs e)
        {
            MdiParent = My.MyProject.Forms.Mainform;
            filldgv();
        }
        private void filldgv()
        {
            var t = new DataTable();
            try
            {
                string HolderIdentify;
                int mattcode = 0;
                try
                {
                    mattcode = Conversions.ToInteger(ToolStripTextBox1.Text);
                }
                catch (Exception ex)
                {
                    mattcode = 0;
                }
                try
                {
                    HolderIdentify = ToolStripTextBox2.Text;
                }
                catch (Exception ex)
                {
                    HolderIdentify = "";
                }

                t = My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_getlist(My.MyProject.Forms.Mainform.workingmeeting, mattcode, HolderIdentify);
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }

            int totalright = 0;
            int agreecount = 0;
            int agreeright = 0;
            int disagreecount = 0;
            int disagreeright = 0;
            int noideacount = 0;
            int noidearight = 0;

            foreach (DataRow dr in t.Rows)
            {
                totalright = Conversions.ToInteger(Operators.AddObject(totalright, dr["Voterights"]));
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["Agree"], true, false)))
                {
                    agreecount = agreecount + 1;
                    agreeright = Conversions.ToInteger(Operators.AddObject(agreeright, dr["Voterights"]));
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["DisAgree"], true, false)))
                {
                    disagreecount = disagreecount + 1;
                    disagreeright = Conversions.ToInteger(Operators.AddObject(disagreeright, dr["Voterights"]));
                }
                else
                {
                    noideacount = noideacount + 1;
                    noidearight = Conversions.ToInteger(Operators.AddObject(noidearight, dr["Voterights"]));
                }
            }
            DataGridView1.DataSource = t;
            ToolStripStatusLabel2.Text = DataGridView1.RowCount.ToString();
            ToolStripStatusLabel16.Text = My.MyProject.Forms.Mainform.addthousandseperator(totalright.ToString());
            // --------
            ToolStripStatusLabel4.Text = My.MyProject.Forms.Mainform.addthousandseperator(agreecount.ToString()) + " -- ";
            ToolStripStatusLabel5.Text = My.MyProject.Forms.Mainform.addthousandseperator(agreeright.ToString()) + " -- ";
            ToolStripStatusLabel8.Text = My.MyProject.Forms.Mainform.addthousandseperator(disagreecount.ToString()) + " -- ";
            ToolStripStatusLabel9.Text = My.MyProject.Forms.Mainform.addthousandseperator(disagreeright.ToString()) + " -- ";

            ToolStripStatusLabel12.Text = My.MyProject.Forms.Mainform.addthousandseperator(noideacount.ToString()) + " -- ";
            ToolStripStatusLabel13.Text = My.MyProject.Forms.Mainform.addthousandseperator(noidearight.ToString()) + " -- ";
            if (totalright > 0)
            {
                ToolStripStatusLabel6.Text = Math.Round(agreeright / (double)totalright * 100d, 2).ToString() + "% ";
                ToolStripStatusLabel10.Text = Math.Round(disagreeright / (double)totalright * 100d, 2).ToString() + "% ";
                ToolStripStatusLabel14.Text = Math.Round(noidearight / (double)totalright * 100d, 2).ToString() + "% ";
            }
            else
            {
                ToolStripStatusLabel6.Text = "";
                ToolStripStatusLabel10.Text = "";
                ToolStripStatusLabel14.Text = "";
            }

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            int matcode = 0;
            int delecode = 0;
            try
            {
                matcode = Conversions.ToInteger(ToolStripTextBox1.Text);
            }
            catch (Exception ex)
            {
                matcode = 0;
            }
            try
            {
                delecode = Conversions.ToInteger(ToolStripTextBox2.Text);
            }
            catch (Exception ex)
            {
                delecode = 0;
            }
            var f = new Mattervote_ins_update("Add", matcode, delecode);
            f.ShowDialog();
            filldgv();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                Interaction.MsgBox("Bạn phải chọn ít nhất một bản ghi");
                return;
            }
            else
            {
                var f = new Mattervote_ins_update("Update", Conversions.ToInteger(DataGridView1.CurrentRow.Cells["Mattercode"].Value), Conversions.ToInteger(DataGridView1.CurrentRow.Cells["delegatecode"].Value));
                f.ShowDialog();
            }
            filldgv();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                Interaction.MsgBox("Bạn phải chọn ít nhất một bản ghi");
                return;
            }
            if (Interaction.MsgBox(Operators.AddObject(Operators.AddObject(Operators.AddObject("Bạn có chắc chắn XÓA Phiếu biểu quyết vấn đề :", DataGridView1.CurrentRow.Cells["mattername"].Value), " của đb "), DataGridView1.CurrentRow.Cells["Delegatename"].Value), (MsgBoxStyle)((int)MsgBoxStyle.OkCancel + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.ApplicationModal + (int)MsgBoxStyle.DefaultButton2), "XÓA PHIẾU BIỂU QUYẾT") == MsgBoxResult.Ok)
            {
                try
                {
                    My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_delete(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["Mattercode"].Value), Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["delegatecode"].Value), Conversions.ToDecimal(DataGridView1.CurrentRow.Cells["HolderCode"].Value));
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Lỗi :" + ex.Message);
                }
            }
            filldgv();
        }

        private void MatterVoteList_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(ToolStripTextBox1.Focused | ToolStripTextBox2.Focused))
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        {
                            ToolStripButton1_Click(sender, e);
                            break;
                        }
                    case Keys.E:
                        {
                            ToolStripButton2_Click(sender, e);
                            break;
                        }
                    case Keys.D:
                        {
                            ToolStripButton3_Click(sender, e);
                            break;
                        }
                    case Keys.Z:
                        {
                            ToolStripButton5_Click(sender, e);
                            break;
                        }
                    case Keys.Escape:
                        {
                            Close();
                            break;
                        }
                }
            }

        }

        private void ToolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filldgv();
            }
        }

        private void ToolStripTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filldgv();
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = DataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "Agree" || colName == "Disagree" || colName == "Noidea" || colName == "Illegal")
                {
                    try
                    {
                        // mattercode As Decimal, ByVal delegatecode As Decimal, ByVal Agree As Boolean, ByVal disAgree As Boolean, ByVal noidea As Boolean)
                        var row = DataGridView1.Rows[e.RowIndex];
                        var mattercode = row.Cells["Mattercode"].Value;
                        var delegatecode = row.Cells["DelegateCode"].Value;
                        bool agree = false;
                        bool disagree = false;
                        bool noidea = false;
                        bool illegal = false;
                        // Nếu chọn Agree
                        if (colName == "Agree" && Conversions.ToBoolean(row.Cells["Agree"].Value) == true)
                        {
                            row.Cells["Disagree"].Value = false;
                            row.Cells["Noidea"].Value = false;
                            row.Cells["Illegal"].Value = false;
                            agree = true;
                            noidea = false;
                            disagree = false;
                            illegal = false;

                        }
                        else if (colName == "Disagree" && Conversions.ToBoolean(row.Cells["Disagree"].Value) == true)
                        {
                            row.Cells["Agree"].Value = false;
                            row.Cells["Noidea"].Value = false;
                            row.Cells["Illegal"].Value = false;
                            disagree = true;
                            noidea = false;
                            agree = false;
                            illegal = false;
                        }
                        else if (colName == "Noidea" && Conversions.ToBoolean(row.Cells["Noidea"].Value) == true)
                        {
                            row.Cells["Agree"].Value = false;
                            row.Cells["Disagree"].Value = false;
                            row.Cells["Illegal"].Value = false;
                            noidea = true;
                            disagree = false;
                            agree = false;
                            illegal = false;
                        }
                        else if (colName == "Illegal" && Conversions.ToBoolean(row.Cells["Illegal"].Value) == true)
                        {
                            row.Cells["Agree"].Value = false;
                            row.Cells["Disagree"].Value = false;
                            row.Cells["Noidea"].Value = false;
                            illegal = true;
                            noidea = false;
                            disagree = false;
                            agree = false;
                        }

                        My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_update(My.MyProject.Forms.Mainform.workingmeeting, Conversions.ToDecimal(mattercode), Conversions.ToDecimal(delegatecode), agree, disagree, noidea, illegal);
                        filldgv();
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Lỗi :" + ex.Message);
                    }

                }
            }
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            var f = new MatterVotes_ins_remain_batch();
            f.ShowDialog();

            if (f.IsConfirmed)
            {
                string actionMessage = "";
                if (f.SelectedMatterCode == 0)
                {
                    actionMessage = "Thao tác này sẽ nhập TẤT CẢ phiếu biểu quyết còn lại cho TẤT CẢ vấn đề hiện tại, Bạn đã kiểm tra CHẮC CHẮN???";
                }
                else
                {
                    actionMessage = "Thao tác này sẽ nhập TẤT CẢ phiếu biểu quyết còn lại cho vấn đề \"" + f.SelectedMatterCode + "\", Bạn đã kiểm tra CHẮC CHẮN???";
                }

                if (Interaction.MsgBox(actionMessage, (MsgBoxStyle)((int)MsgBoxStyle.OkCancel + (int)MsgBoxStyle.Critical + (int)MsgBoxStyle.ApplicationModal + (int)MsgBoxStyle.DefaultButton2), "NHẬP HÀNG LOẠT PHIẾU BIỂU QUYẾT") == MsgBoxResult.Ok)
                {
                    try
                    {
                        if (f.SelectedMatterCode == 0)
                        {
                            // Lấy tất cả vấn đề hiện tại
                            var allMatters = My.MyProject.Forms.Mainform.BenlyDal.Matter_getlist(My.MyProject.Forms.Mainform.workingmeeting, 0m);

                            // ✅ Kiểm tra nếu không có data hoặc data rỗng
                            if (allMatters == null || allMatters.Rows.Count == 0)
                            {
                                Interaction.MsgBox("Không có dữ liệu vấn đề để xử lý!", MsgBoxStyle.Exclamation);
                                filldgv();
                                return;
                            }

                            foreach (DataRow dr in allMatters.Rows)
                            {
                                // ✅ Kiểm tra Mattercode không rỗng/null
                                if (dr["Mattercode"] == null || dr["Mattercode"] == DBNull.Value)
                                {
                                    Interaction.MsgBox("Dữ liệu Mattercode bị rỗng, không thể xử lý!", MsgBoxStyle.Exclamation);
                                    filldgv();
                                    return;
                                }
                                int currentMatterCode = Conversions.ToInteger(dr["Mattercode"]);
                                My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_insert_remain(My.MyProject.Forms.Mainform.workingmeeting, currentMatterCode, 0m, f.AgreeValue, f.DisagreeValue, f.NoideaValue, f.IllegalValue);
                            }
                        }
                        else
                        {
                            // ✅ Kiểm tra Mattercode có hợp lệ không
                            var allMatters2 = My.MyProject.Forms.Mainform.BenlyDal.Matter_getlist(My.MyProject.Forms.Mainform.workingmeeting, 0m);

                            // ✅ Kiểm tra nếu không có data hoặc data rỗng
                            if (allMatters2 == null || allMatters2.Rows.Count == 0)
                            {
                                Interaction.MsgBox("Không có dữ liệu vấn đề để xử lý!", MsgBoxStyle.Exclamation);
                                filldgv();
                                return;
                            }
                            if (f.SelectedMatterCode <= 0)
                            {
                                Interaction.MsgBox("Mã vấn đề không hợp lệ!", MsgBoxStyle.Exclamation);
                                filldgv();
                                return;
                            }
                            // Nhập cho vấn đề cụ thể
                            My.MyProject.Forms.Mainform.BenlyDal.MatterVotes_insert_remain(My.MyProject.Forms.Mainform.workingmeeting, f.SelectedMatterCode, 0m, f.AgreeValue, f.DisagreeValue, f.NoideaValue, f.IllegalValue);
                        }

                        Interaction.MsgBox("Đã nhập xong");
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Lỗi : " + ex.Message);
                        return;
                    }
                }
            }
            filldgv();
        }
    }
}