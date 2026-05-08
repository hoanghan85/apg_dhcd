using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

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
            MessageBox.Show("Chức năng sẽ được thêm - Xuất biên bản bầu cử");
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

        private void PrintDelegateConfirmationMinute()
        {
            try
            {
                // Lấy dữ liệu báo cáo từ DB
                var dt = new DataTable();
                try
                {
                    dt = My.MyProject.Forms.Mainform.BenlyDal.GetMeetingSummary(
                        My.MyProject.Forms.Mainform.workingmeeting);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu từ DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Load báo cáo từ file path
                string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\DelegateConfirmationMinute.rpt");
                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo DataSet và fill dữ liệu
                var dsReport = new DSReportSouce();

                // Copy dữ liệu từ DataTable sang DataSet table
                foreach (DataRow sourceRow in dt.Rows)
                {
                    dsReport.MeetingSummary.Rows.Add(
                        sourceRow["MeetingCode"] ?? DBNull.Value,
                        sourceRow["MeetingName"] ?? DBNull.Value,
                        sourceRow["CompanyName"] ?? DBNull.Value,
                        sourceRow["YearMeeting"] ?? DBNull.Value,
                        sourceRow["HolderNumber"] ?? DBNull.Value,
                        sourceRow["ShareNumber"] ?? DBNull.Value,
                        sourceRow["DelegateNumber"] ?? DBNull.Value,
                        sourceRow["DelegateShare"] ?? DBNull.Value,
                        sourceRow["HolderSharePercent"] ?? DBNull.Value,
                        sourceRow["DelegateSharePercent"] ?? DBNull.Value
                    );
                }

                // Load báo cáo từ file
                var report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.Load(reportPath);
                report.SetDataSource(dsReport);
                ReportViewer.LoadReport(report, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintVoteCountingMinute()
        {
            try
            {
                // Lấy dữ liệu báo cáo từ DB
                string meetingcode = My.MyProject.Forms.Mainform.workingmeeting;
                var dsReport = My.MyProject.Forms.Mainform.BenlyDal.GetVoteCountingMinuteData(meetingcode);

                if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo báo cáo từ auto-generated class
                var report = new VoteCountingMinute();

                // Set parameters if needed
                report.SetParameterValue("MeetingCode", meetingcode);

                // ✅ Set data source từ DataSet (không connect DB từ .rpt)
                report.SetDataSource(dsReport);

                // Hiển thị báo cáo
                ReportViewer.LoadReport(report, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo biểu quyết: " + ex.Message + "\n\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
