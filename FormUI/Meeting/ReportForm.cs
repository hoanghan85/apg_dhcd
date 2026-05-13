using CrystalDecisions.CrystalReports.Engine;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using DocBorder = Xceed.Document.NET.Border;
using DocBorderStyle = Xceed.Document.NET.BorderStyle;
using DocColor = Xceed.Drawing.Color;

namespace pmDHCD
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.MdiParent = My.MyProject.Forms.Mainform;
        }

        // Thông tin tham dự
        private void Button1_Click(object sender, EventArgs e)
        {
            // Xuất danh sách cổ đông (Excel)
            ExportHoldersList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Xuất danh sách đại biểu/ủy quyền (Excel)
            ExportAuthorizationsList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Xuất báo cáo kiểm tra tư cách (Excel)
            ExportParticipationReport();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // In biên bản kiểm tra tư cách (Crystal Report)
            PrintDelegateConfirmationMinute();
        }

        // Thông tin biểu quyết
        private void Button5_Click(object sender, EventArgs e)
        {
            // Xuất thống kê biểu quyết (Excel)
            ExportVoteReport();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Xuất biên bản biểu quyết (Word)
            PrintVoteCountingMinute();
        }

        // Thông tin bầu cử
        private void Button7_Click(object sender, EventArgs e)
        {
            // Xuất thống kê bầu cử (Excel)
            ExportELectionReport();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // Xuất biên bản bầu cử (Word)
            PrintMeetingMinute();
        }

        private void ExportHoldersList()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.DefaultExt = "xlsx";
                saveDialog.FileName = "DanhSachCoDong_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ SP Holders_getlist
                    var dt = new DataTable();
                    try
                    {
                        dt = My.MyProject.Forms.Mainform.BenlyDal.Holder_getlist(
                            My.MyProject.Forms.Mainform.workingmeeting,
                            "",
                            "");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo Excel từ DataTable
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("holder_list");

                    // Tạo header từ DataTable columns
                    IRow headerRow = sheet.CreateRow(0);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ICell cell = headerRow.CreateCell(i);
                        cell.SetCellValue(dt.Columns[i].ColumnName);

                        // Format header - bold
                        ICellStyle headerStyle = workbook.CreateCellStyle();
                        IFont headerFont = workbook.CreateFont();
                        headerFont.IsBold = true;
                        headerStyle.SetFont(headerFont);
                        cell.CellStyle = headerStyle;
                    }

                    // Thêm dữ liệu từ DataTable
                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                    {
                        IRow row = sheet.CreateRow(rowIndex + 1);
                        for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                        {
                            ICell cell = row.CreateCell(colIndex);
                            var cellValue = dt.Rows[rowIndex][colIndex];
                            if (cellValue != null && cellValue != DBNull.Value)
                            {
                                cell.SetCellValue(cellValue.ToString());
                            }
                        }
                    }

                    // Auto fit columns
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }

                    // Lưu file
                    using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fileStream);
                    }

                    MessageBox.Show("Xuất danh sách cổ đông thành công!\nĐường dẫn: " + saveDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportAuthorizationsList()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.DefaultExt = "xlsx";
                saveDialog.FileName = "DanhSachDaibieuUyquyen_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ SP RP_Authorizations_List
                    var dt = new DataTable();
                    try
                    {
                        dt = My.MyProject.Forms.Mainform.BenlyDal.RP_Authorizations_List(
                            My.MyProject.Forms.Mainform.workingmeeting,
                            My.MyProject.Forms.Mainform.stockCode);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo Excel từ DataTable
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("authorization_list");

                    // Tạo header từ DataTable columns
                    IRow headerRow = sheet.CreateRow(0);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ICell cell = headerRow.CreateCell(i);
                        cell.SetCellValue(dt.Columns[i].ColumnName);

                        // Format header - bold
                        ICellStyle headerStyle = workbook.CreateCellStyle();
                        IFont headerFont = workbook.CreateFont();
                        headerFont.IsBold = true;
                        headerStyle.SetFont(headerFont);
                        cell.CellStyle = headerStyle;
                    }

                    // Thêm dữ liệu từ DataTable
                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                    {
                        IRow row = sheet.CreateRow(rowIndex + 1);
                        for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                        {
                            ICell cell = row.CreateCell(colIndex);
                            var cellValue = dt.Rows[rowIndex][colIndex];
                            if (cellValue != null && cellValue != DBNull.Value)
                            {
                                cell.SetCellValue(cellValue.ToString());
                            }
                        }
                    }

                    // Auto fit columns
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }

                    // Lưu file
                    using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fileStream);
                    }

                    MessageBox.Show("Xuất danh sách đại biểu/ủy quyền thành công!\nĐường dẫn: " + saveDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportParticipationReport()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.DefaultExt = "xlsx";
                saveDialog.FileName = "DanhSachKiemTraTuCach_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ SP RP_Participation_Summary
                    var dt = new DataTable();
                    try
                    {
                        dt = My.MyProject.Forms.Mainform.BenlyDal.RP_Participation_Summary(
                            My.MyProject.Forms.Mainform.workingmeeting);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo Excel từ DataTable
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("participation_summary");

                    // Tạo header từ DataTable columns
                    IRow headerRow = sheet.CreateRow(0);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ICell cell = headerRow.CreateCell(i);
                        cell.SetCellValue(dt.Columns[i].ColumnName);

                        // Format header - bold
                        ICellStyle headerStyle = workbook.CreateCellStyle();
                        IFont headerFont = workbook.CreateFont();
                        headerFont.IsBold = true;
                        headerStyle.SetFont(headerFont);
                        cell.CellStyle = headerStyle;
                    }

                    // Thêm dữ liệu từ DataTable
                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                    {
                        IRow row = sheet.CreateRow(rowIndex + 1);
                        for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                        {
                            ICell cell = row.CreateCell(colIndex);
                            var cellValue = dt.Rows[rowIndex][colIndex];
                            if (cellValue != null && cellValue != DBNull.Value)
                            {
                                cell.SetCellValue(cellValue.ToString());
                            }
                        }
                    }

                    // Auto fit columns
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }

                    // Lưu file
                    using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fileStream);
                    }

                    MessageBox.Show("Xuất báo cáo kiểm tra tư cách thành công!\nĐường dẫn: " + saveDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportVoteReport()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.DefaultExt = "xlsx";
                saveDialog.FileName = "ThongKeBieuQuyet_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ SP RP_Participation_Summary
                    var dt = new DataTable();
                    try
                    {
                        dt = My.MyProject.Forms.Mainform.BenlyDal.RP_Vote_Report(
                            My.MyProject.Forms.Mainform.workingmeeting);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo Excel từ DataTable
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("vote_summary");

                    // Tạo header từ DataTable columns
                    IRow headerRow = sheet.CreateRow(0);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ICell cell = headerRow.CreateCell(i);
                        cell.SetCellValue(dt.Columns[i].ColumnName);

                        // Format header - bold
                        ICellStyle headerStyle = workbook.CreateCellStyle();
                        IFont headerFont = workbook.CreateFont();
                        headerFont.IsBold = true;
                        headerStyle.SetFont(headerFont);
                        cell.CellStyle = headerStyle;
                    }

                    // Thêm dữ liệu từ DataTable
                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                    {
                        IRow row = sheet.CreateRow(rowIndex + 1);
                        for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                        {
                            ICell cell = row.CreateCell(colIndex);
                            var cellValue = dt.Rows[rowIndex][colIndex];
                            if (cellValue != null && cellValue != DBNull.Value)
                            {
                                cell.SetCellValue(cellValue.ToString());
                            }
                        }
                    }

                    // Auto fit columns
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }

                    // Lưu file
                    using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fileStream);
                    }

                    MessageBox.Show("Xuất báo cáo thống kê biểu quyết thành công!\nĐường dẫn: " + saveDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportELectionReport()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.DefaultExt = "xlsx";
                saveDialog.FileName = "ThongKeBauCu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ SP RP_Participation_Summary
                    var dt = new DataTable();
                    try
                    {
                        dt = My.MyProject.Forms.Mainform.BenlyDal.RP_Election_Report(
                            My.MyProject.Forms.Mainform.workingmeeting);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo Excel từ DataTable
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("election_summary");

                    // Tạo header từ DataTable columns
                    IRow headerRow = sheet.CreateRow(0);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ICell cell = headerRow.CreateCell(i);
                        cell.SetCellValue(dt.Columns[i].ColumnName);

                        // Format header - bold
                        ICellStyle headerStyle = workbook.CreateCellStyle();
                        IFont headerFont = workbook.CreateFont();
                        headerFont.IsBold = true;
                        headerStyle.SetFont(headerFont);
                        cell.CellStyle = headerStyle;
                    }

                    // Thêm dữ liệu từ DataTable
                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                    {
                        IRow row = sheet.CreateRow(rowIndex + 1);
                        for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                        {
                            ICell cell = row.CreateCell(colIndex);
                            var cellValue = dt.Rows[rowIndex][colIndex];
                            if (cellValue != null && cellValue != DBNull.Value)
                            {
                                cell.SetCellValue(cellValue.ToString());
                            }
                        }
                    }

                    // Auto fit columns
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }

                    // Lưu file
                    using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fileStream);
                    }

                    MessageBox.Show("Xuất báo cáo thống kê bầu cử thành công!\nĐường dẫn: " + saveDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void PrintDelegateConfirmationMinute()
        //{
        //    try
        //    {
        //        // Lấy dữ liệu báo cáo từ DB
        //        var dt = new DataTable();
        //        try
        //        {
        //            dt = My.MyProject.Forms.Mainform.BenlyDal.GetMeetingSummary(
        //                My.MyProject.Forms.Mainform.workingmeeting);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        if (dt.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Không có dữ liệu để hiển thị báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Load báo cáo từ file path
        //        string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\DelegateConfirmationMinute.rpt");
        //        if (!System.IO.File.Exists(reportPath))
        //        {
        //            MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Tạo DataSet và fill dữ liệu
        //        var dsReport = new DSReportSouce();

        //        // Copy dữ liệu từ DataTable sang DataSet table
        //        foreach (DataRow sourceRow in dt.Rows)
        //        {
        //            dsReport.MeetingSummary.Rows.Add(
        //                sourceRow["MeetingCode"] ?? DBNull.Value,
        //                sourceRow["MeetingName"] ?? DBNull.Value,
        //                sourceRow["CompanyName"] ?? DBNull.Value,
        //                sourceRow["YearMeeting"] ?? DBNull.Value,
        //                sourceRow["HolderNumber"] ?? DBNull.Value,
        //                sourceRow["ShareNumber"] ?? DBNull.Value,
        //                sourceRow["DelegateNumber"] ?? DBNull.Value,
        //                sourceRow["DelegateShare"] ?? DBNull.Value,
        //                sourceRow["HolderSharePercent"] ?? DBNull.Value,
        //                sourceRow["DelegateSharePercent"] ?? DBNull.Value,
        //                sourceRow["StockCode"] ?? DBNull.Value,
        //                sourceRow["Period"] ?? DBNull.Value,
        //                sourceRow["Meetingtime"] ?? DBNull.Value,
        //                sourceRow["Mettingtype"] ?? DBNull.Value,
        //                sourceRow["CompanyAddress"] ?? DBNull.Value,
        //                sourceRow["MeetingAddress"] ?? DBNull.Value
        //            );
        //        }

        //        // Load báo cáo từ file
        //        var report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //        report.Load(reportPath);
        //        report.SetDataSource(dsReport);
        //        ReportViewer.LoadReport(report, this);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi in biên bản xác nhận: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void PrintDelegateConfirmationMinute()
        {
            try
            {
                // Lấy dữ liệu báo cáo từ DB
                string workingmeeting = My.MyProject.Forms.Mainform.workingmeeting;
                var dsReport = My.MyProject.Forms.Mainform.BenlyDal.GetVoteCountingMinuteData(workingmeeting);

                if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo báo cáo từ auto-generated class
                //var report = new VoteCountingMinute();

                // Set parameters if needed
                //report.SetParameterValue("MeetingCode", workingmeeting);

                ReportDocument rpt = new ReportDocument();

                string rptPath = Path.Combine(
                    Application.StartupPath,
                    "Report",
                    "DelegateConfirmationMinute.rpt"
                );


                if (!File.Exists(rptPath))
                {
                    MessageBox.Show(rptPath);
                    return;
                }

                rpt.Load(rptPath);
                rpt.Refresh();

                // ✅ Set data source từ DataSet (không connect DB từ .rpt)
                rpt.SetDataSource(dsReport);
                // Hiển thị báo cáo
                ReportViewer.LoadReport(rpt, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo biểu quyết/bầu cử: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintVoteCountingMinute()
        {
            try
            {
                // Lấy dữ liệu báo cáo từ DB
                string workingmeeting = My.MyProject.Forms.Mainform.workingmeeting;
                var dsReport = My.MyProject.Forms.Mainform.BenlyDal.GetVoteCountingMinuteData(workingmeeting);

                if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo báo cáo từ auto-generated class
                //var report = new VoteCountingMinute();

                // Set parameters if needed
                //report.SetParameterValue("MeetingCode", workingmeeting);

                ReportDocument rpt = new ReportDocument();

                string rptPath = Path.Combine(
                    Application.StartupPath,
                    "Report",
                    "VoteCountingMinute.rpt"
                );

                rpt.Load(rptPath);
                rpt.Refresh();


                // ✅ Set data source từ DataSet (không connect DB từ .rpt)
                rpt.SetDataSource(dsReport);
                // Hiển thị báo cáo
                ReportViewer.LoadReport(rpt, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo biểu quyết/bầu cử: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintMeetingMinute()
        {
            try
            {
                // Lấy dữ liệu báo cáo từ DB
                string workingmeeting = My.MyProject.Forms.Mainform.workingmeeting;
                var dsReport = My.MyProject.Forms.Mainform.BenlyDal.GetVoteCountingMinuteData(workingmeeting);

                if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo báo cáo từ auto-generated class
                //var report = new VoteCountingMinute();

                // Set parameters if needed
                //report.SetParameterValue("MeetingCode", workingmeeting);

                ReportDocument rpt = new ReportDocument();

                string rptPath = Path.Combine(
                    Application.StartupPath,
                    "Report",
                    "MeetingMinute.rpt"
                );

                rpt.Load(rptPath);
                //rpt.Refresh();
                // DEBUG: xem DataSet có gì
                foreach (DataTable t in dsReport.Tables)
                {
                    System.Diagnostics.Debug.WriteLine("==========");
                    System.Diagnostics.Debug.WriteLine("TABLE: " + t.TableName);

                    foreach (DataColumn c in t.Columns)
                    {
                        System.Diagnostics.Debug.WriteLine("   " + c.ColumnName);
                    }
                }


                // ✅ Set data source từ DataSet (không connect DB từ .rpt)
                rpt.SetDataSource(dsReport);
                // Hiển thị báo cáo
                ReportViewer.LoadReport(rpt, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in biên bản họp: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //[Obsolete]
        //private void PrintMeetingMinute()
        //{
        //    try
        //    {
        //        // Get dat from database
        //        string workingmeeting = My.MyProject.Forms.Mainform.workingmeeting; // Pass current working meeting as parameter to get data
        //        var dsReport = My.MyProject.Forms.Mainform.BenlyDal.GetVoteCountingMinuteData(workingmeeting); // Call BenlyDal method to get data for report, this should return a DataSet with all necessary tables and data for the report

        //        // Check if dataset has data for avoiding errors when generating report with empty data
        //        if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
        //        {
        //            MessageBox.Show("Không có dữ liệu để tạo biên bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Get data tables from dataset, these tables should match the ones used in the report template, and contain all necessary data for generating the report
        //        var meetingsummary = dsReport.Tables["Meeting_Summary"].Rows[0];
        //        var matterlist = dsReport.Tables["Matters_List"];
        //        var votesummary = dsReport.Tables["Vote_Summary"];
        //        var candidate = dsReport.Tables["Election_Candidate_Summary"];
        //        var ballot = dsReport.Tables["Election_Ballot_Summary"].Rows[0];
        //        var aggredmatter = dsReport.Tables["Matter_Result_Summary"];

        //        // Load Word template
        //        string templatePath = Path.Combine(
        //            Application.StartupPath,
        //            "Report",
        //            "Minute",
        //            "MeetingMinuteTemplate.docx"
        //            );
        //        var doc = DocX.Load(templatePath);

        //        // Declaring and formatting values to use to replace in minutes
        //        // Create custom formatted values
        //        DateTime dt = Convert.ToDateTime(meetingsummary["MeetingTime"]);
        //        string MeetingDate = $"ngày {dt.Day:00} tháng {dt.Month:00} năm {dt.Year}";
        //        string MeetingDateTime = $"{dt.Hour:00} giờ {dt.Minute:00} phút, ngày {dt.Day:00} tháng {dt.Month:00} năm {dt.Year}";
        //        StringBuilder sb = new StringBuilder();
        //        foreach (DataRow row in matterlist.Rows)
        //        {
        //            sb.AppendLine(
        //                $"Vấn đề {Convert.ToInt32(row["MatterCode"]):00}: " +
        //                $"{row["MatterDescription"]};"
        //            );

        //            sb.AppendLine();
        //        }

        //        // tìm marker
        //        var marker = doc.Paragraphs.FirstOrDefault(
        //            p => p.Text.Contains("{{VoteResultSection}}")
        //        );

        //        if (marker == null)
        //        {
        //            throw new Exception(
        //                "Không tìm thấy {{VoteResultSection}} trong template."
        //            );
        //        }


        //        // lưu style của marker để clone
        //        string markerStyle = marker.StyleName;


        //        // format VN
        //        var vi = new CultureInfo("vi-VN");


        //        // group data
        //        var groupedMatters = votesummary.AsEnumerable()
        //            .GroupBy(r => new
        //            {
        //                MatterCode = Convert.ToInt32(r["MatterCode"]),
        //                MatterName = r["MatterName"].ToString()
        //            });


        //        foreach (var matter in groupedMatters)
        //        {
        //            //-----------------------------------
        //            // 1. Tiêu đề vấn đề
        //            //-----------------------------------
        //            var p1 = marker.InsertParagraphAfterSelf("");

        //            p1.StyleName = markerStyle;

        //            p1.Append(
        //                $"Vấn đề {matter.Key.MatterCode:00}: " +
        //                $"{matter.Key.MatterName};"
        //            );

        //            marker = p1;


        //            //-----------------------------------
        //            // 2. "Kết quả biểu quyết"
        //            //-----------------------------------
        //            var p2 = marker.InsertParagraphAfterSelf("");

        //            p2.StyleName = markerStyle;

        //            p2.Append("Kết quả biểu quyết:");

        //            marker = p2;


        //            //-----------------------------------
        //            // 3. tạo table
        //            //-----------------------------------
        //            var votes = matter.ToList();

        //            var voteTable = doc.AddTable(
        //                votes.Count,
        //                4
        //            );

        //            voteTable.Design = TableDesign.None;


        //            voteTable.SetWidths(
        //                new float[]
        //                {
        //    140f,
        //    50f,
        //    70f,
        //    200f
        //                }
        //            );


        //            //-----------------------------------
        //            // 4. ẩn border
        //            //-----------------------------------
        //            var noBorder = new DocBorder(
        //                DocBorderStyle.Tcbs_none,
        //                0,
        //                0,
        //                DocColor.White
        //            );

        //            voteTable.SetBorder(
        //                TableBorderType.Left,
        //                noBorder
        //            );

        //            voteTable.SetBorder(
        //                TableBorderType.Right,
        //                noBorder
        //            );

        //            voteTable.SetBorder(
        //                TableBorderType.Top,
        //                noBorder
        //            );

        //            voteTable.SetBorder(
        //                TableBorderType.Bottom,
        //                noBorder
        //            );

        //            voteTable.SetBorder(
        //                TableBorderType.InsideH,
        //                noBorder
        //            );

        //            voteTable.SetBorder(
        //                TableBorderType.InsideV,
        //                noBorder
        //            );


        //            //-----------------------------------
        //            // 5. fill rows
        //            //-----------------------------------
        //            for (int i = 0; i < votes.Count; i++)
        //            {
        //                var vote = votes[i];

        //                decimal shares =
        //                    Convert.ToDecimal(
        //                        vote["VoteShares"]
        //                    );

        //                decimal percent =
        //                    Convert.ToDecimal(
        //                        vote["VotePercent"]
        //                    );

        //                string label =
        //                    vote["VoteLabel"]
        //                        .ToString();


        //                string c1 =
        //                    label ;

        //                string c2 =
        //                    shares.ToString("N0", vi);

        //                string c3 =
        //                    "phiếu biểu quyết, đạt tỷ lệ";

        //                string c4 =
        //                    percent.ToString("N2", vi)
        //                    + "% tổng số phiếu biểu quyết của đại biểu tham dự tại thời điểm biểu quyết nội dung này.";


        //                voteTable.Rows[i]
        //                    .Cells[0]
        //                    .Paragraphs[0]
        //                    .Append(c1);

        //                voteTable.Rows[i]
        //                    .Cells[1]
        //                    .Paragraphs[0]
        //                    .Append(c2);

        //                voteTable.Rows[i]
        //                    .Cells[2]
        //                    .Paragraphs[0]
        //                    .Append(c3);

        //                voteTable.Rows[i]
        //                    .Cells[3]
        //                    .Paragraphs[0]
        //                    .Append(c4);


        //                // clone style từ marker
        //                foreach (var cell in voteTable.Rows[i].Cells)
        //                {
        //                    cell.Paragraphs[0]
        //                        .StyleName = markerStyle;
        //                }
        //            }


        //            //-----------------------------------
        //            // 6. insert table
        //            //-----------------------------------
        //            // tạo 1 paragraph "neo" cho table
        //            var tableAnchor = marker.InsertParagraphAfterSelf("");
        //            tableAnchor.StyleName = markerStyle;

        //            // insert table ngay sau paragraph neo
        //            tableAnchor.InsertTableAfterSelf(voteTable);


        //            // tạo paragraph tiếp theo
        //            var p3 = tableAnchor.InsertParagraphAfterSelf("");
        //            p3.StyleName = markerStyle;

        //            //-----------------------------------
        //            // 7. kết quả thông qua
        //            //-----------------------------------
        //            var approveRow =
        //                matter.FirstOrDefault(
        //                    x =>
        //                        x["VoteType"]
        //                            .ToString()
        //                            == "tán thành"
        //                );

        //            decimal approvePercent = 0;

        //            if (approveRow != null)
        //            {
        //                approvePercent =
        //                    Convert.ToDecimal(
        //                        approveRow["VotePercent"]
        //                    );
        //            }

        //            string result =
        //                approvePercent > 50
        //                    ? "Thông qua"
        //                    : "Không thông qua";

        //            p3.Append(
        //                "Kết quả: "
        //                + result
        //                + "."
        //            );

        //            marker = p3;


        //            //-----------------------------------
        //            // 8. dòng trắng
        //            //-----------------------------------
        //            var blank = marker.InsertParagraphAfterSelf("");

        //            blank.StyleName = markerStyle;

        //            marker = blank;
        //        }


        //        // xóa marker
        //        doc.ReplaceText(
        //            "{{VoteResultSection}}",
        //            ""
        //        ); ;

        //        // Replace values from database
        //        doc.ReplaceText("{{MeetingCode}}", meetingsummary["MeetingCode"].ToString());
        //        doc.ReplaceText("{{MeetingName}}", meetingsummary["MeetingName"].ToString());
        //        doc.ReplaceText("{{YearMeeting}}", meetingsummary["YearMeeting"].ToString());
        //        doc.ReplaceText("{{HolderNumber}}", meetingsummary["HolderNumber"].ToString());
        //        doc.ReplaceText("{{ShareNumber}}", meetingsummary["ShareNumber"].ToString());
        //        doc.ReplaceText("{{DelegateNumber}}", meetingsummary["DelegateNumber"].ToString());
        //        doc.ReplaceText("{{DelegateShare}}", meetingsummary["DelegateShare"].ToString());
        //        doc.ReplaceText("{{HolderSharePercent}}", meetingsummary["HolderSharePercent"].ToString());
        //        doc.ReplaceText("{{DelegateSharePercent}}", meetingsummary["DelegateSharePercent"].ToString());
        //        doc.ReplaceText("{{StockCode}}", meetingsummary["StockCode"].ToString());
        //        doc.ReplaceText("{{Period}}", meetingsummary["Period"].ToString());
        //        doc.ReplaceText("{{MeetingTime}}", meetingsummary["MeetingTime"].ToString());
        //        doc.ReplaceText("{{MeetingType}}", meetingsummary["MeetingType"].ToString());
        //        doc.ReplaceText("{{CompanyAddress}}", meetingsummary["CompanyAddress"].ToString());
        //        doc.ReplaceText("{{MeetingAddress}}", meetingsummary["MeetingAddress"].ToString());
        //        doc.ReplaceText("{{UpperMeetingName}}", meetingsummary["MeetingName"].ToString().ToUpper()); // Upper for title uses
        //        doc.ReplaceText("{{UpperCompanyName}}", meetingsummary["CompanyName"].ToString().ToUpper()); // Upper for tittle uses
        //        doc.ReplaceText("{{CompanyName}}", meetingsummary["CompanyName"].ToString());
        //        doc.ReplaceText("{{StockCode}}", meetingsummary["StockCode"].ToString());
        //        doc.ReplaceText("{{IssuedBallotCount}}", ballot["SubmittedBallotCount"].ToString());
        //        doc.ReplaceText("{{IssuedVoteShares}}", ballot["SubmittedVoteShares"].ToString());
        //        doc.ReplaceText("{{IssuedPercent}}", ballot["SubmittedPercent"].ToString());
        //        doc.ReplaceText("{{SubmittedBallotCount}}", ballot["SubmittedBallotCount"].ToString());
        //        doc.ReplaceText("{{SubmittedVoteShares}}", ballot["SubmittedVoteShares"].ToString());
        //        doc.ReplaceText("{{SubmittedPercent}}", ballot["SubmittedPercent"].ToString());

        //        // Replace custom values
        //        doc.ReplaceText("{{MeetingDate}}", MeetingDate);
        //        doc.ReplaceText("{{MeetingDateTime}}", MeetingDateTime);

        //        string output = Path.Combine(
        //            Application.StartupPath,
        //            "Report",
        //            "Minute",
        //            "MeetingMinute.docx"
        //            );

        //        doc.SaveAs(output);
        //        Process.Start(output);

        //        MessageBox.Show("Tạo biên bản họp thành công");


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tạo biên bản họp: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
