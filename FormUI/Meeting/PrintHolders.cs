using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;

namespace pmDHCD
{

    public partial class PrintHolders
    {
        public PrintHolders()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            var dt = new DataTable();
            try
            {
                if (!int.TryParse(txtFromHolder.Text, out int fromValue))
                {
                    MessageBox.Show("'Từ mã cổ đông' phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFromHolder.Focus();
                    return;
                }

                if (!int.TryParse(txtToHolder.Text, out int toValue))
                {
                    MessageBox.Show("'Tới mã cổ đông' phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtToHolder.Focus();
                    return;
                }

                dt = My.MyProject.Forms.Mainform.BenlyDal.Holder_getListLimited(My.MyProject.Forms.Mainform.workingmeeting, fromValue, toValue);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy cổ đông trong phạm vi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Keep only columns that Crystal Report expects
                var dtFiltered = new DataTable();
                dtFiltered.Columns.Add("Holdercode");
                dtFiltered.Columns.Add("HolderName");
                dtFiltered.Columns.Add("HolderAddress");
                dtFiltered.Columns.Add("HolderIdentity");
                dtFiltered.Columns.Add("Shares");
                dtFiltered.Columns.Add("VoteRights");

                foreach (DataRow drSource in dt.Rows)
                {
                    DataRow drNew = dtFiltered.NewRow();
                    drNew["Holdercode"] = drSource["Holdercode"];
                    drNew["HolderName"] = drSource["HolderName"];
                    drNew["HolderAddress"] = drSource["HolderAddress"];
                    drNew["HolderIdentity"] = drSource["HolderIdentity"];
                    drNew["Shares"] = drSource["Shares"];

                    // Format VoteRights with thousand separator
                    if (drSource["VoteRights"] != DBNull.Value)
                    {
                        drNew["VoteRights"] = My.MyProject.Forms.Mainform.addthousandseperator(drSource["VoteRights"].ToString().Trim());
                    }
                    else
                    {
                        drNew["VoteRights"] = "0";
                    }

                    dtFiltered.Rows.Add(drNew);
                }

                dt = dtFiltered;

                var cr_thebieuquyet = new ReportDocument();
                string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\thebieuquyet.rpt");

                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                    return;
                }

                try
                {
                    cr_thebieuquyet.Load(reportPath);
                    cr_thebieuquyet.SetDataSource(dt);
                    string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                    cr_thebieuquyet.SetParameterValue("LogoPath", logoPath);
                    cr_thebieuquyet.SetParameterValue("DateMeeting", My.MyProject.Forms.Mainform.dateMeeting);
                    cr_thebieuquyet.SetParameterValue("MettingType", My.MyProject.Forms.Mainform.mettingType);

                    ReportViewer.LoadReport(cr_thebieuquyet, My.MyProject.Forms.HolderList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị báo cáo: " + ex.Message + "\n\nHãy cài SAP Crystal Reports hoặc sửa file report");
                    return;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
                return;
            }
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
