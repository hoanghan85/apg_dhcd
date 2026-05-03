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
            // Xuất biên bản kiểm tra tư cách (Word)
            MessageBox.Show("Chức năng sẽ được thêm - Xuất biên bản kiểm tra tư cách");
        }

        // Thông tin biểu quyết
        private void Button5_Click(object sender, EventArgs e)
        {
            // Xuất thống kê biểu quyết (Excel)
            MessageBox.Show("Chức năng sẽ được thêm - Xuất thống kê biểu quyết");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Xuất biên bản biểu quyết (Word)
            MessageBox.Show("Chức năng sẽ được thêm - Xuất biên bản biểu quyết");
        }

        // Thông tin bầu cử
        private void Button7_Click(object sender, EventArgs e)
        {
            // Xuất thống kê bầu cử (Excel)
            MessageBox.Show("Chức năng sẽ được thêm - Xuất thống kê bầu cử");
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
    }
}
