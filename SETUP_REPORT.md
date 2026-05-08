# Setup báo cáo DelegateConfirmationMinute - Hướng dẫn

## ✅ Các bước đã hoàn thành

### 1. **DAL Layer** (Database → Report SP)
- ✅ Thêm method `GetMeetingSummary(string meetingcode)` trong `DAL.cs`
- Method này gọi SP `PRP_Meeting_Summary` để lấy dữ liệu báo cáo

### 2. **Typed DataSet** (Report SP → Typed DataSet)
- ✅ Cập nhật `DSReportSouce.xsd` - thêm table `MeetingSummary` với 10 cột:
  - MeetingCode (string)
  - MeetingName (string)
  - CompanyName (string)
  - YearMeeting (int)
  - HolderNumber (int)
  - ShareNumber (decimal)
  - DelegateNumber (int)
  - DelegateShare (decimal)
  - HolderSharePercent (decimal)
  - DelegateSharePercent (decimal)

- ✅ Cập nhật `DSReportSouce.Designer.cs`:
  - Thêm field `MeetingSummaryDataTable`
  - Thêm property `MeetingSummary`
  - Thêm class `MeetingSummaryDataTable` với đầy đủ các methods
  - Thêm class `MeetingSummaryRow` với properties cho từng cột
  - Thêm event handlers và delegates

### 3. **Crystal Report Wrapper** (Typed DataSet → Crystal Report)
- ✅ Tạo file `DelegateConfirmationMinute.cs` 
  - Class wrapper để connect .rpt file với code
  - Có thể thêm parameters khi cần

## 📝 Cách sử dụng báo cáo

### Bước 1: Lấy dữ liệu từ database
```csharp
var dal = new DAL(connection);
DataTable dt = dal.GetMeetingSummary(meetingCode);
```

### Bước 2: Fill vào DataSet
```csharp
var dsReport = new DSReportSouce();
foreach (DataRow row in dt.Rows)
{
    dsReport.MeetingSummary.AddMeetingSummaryRow(
        (string)row["MeetingCode"],
        (string)row["MeetingName"],
        (string)row["CompanyName"],
        (int)row["YearMeeting"],
        (int)row["HolderNumber"],
        (decimal)row["ShareNumber"],
        (int)row["DelegateNumber"],
        (decimal)row["DelegateShare"],
        (decimal)row["HolderSharePercent"],
        (decimal)row["DelegateSharePercent"]
    );
}
```

### Bước 3: Load báo cáo và hiển thị
```csharp
var report = new DelegateConfirmationMinute();
report.SetDataSource(dsReport);
ReportViewer.LoadReport(report, this);
```

## 📋 Các file đã được thay đổi

1. **DAL\DAL.cs**
   - Thêm method `GetMeetingSummary`

2. **FormUI\DSReportSouce.xsd**
   - Thêm element `MeetingSummary` với schema

3. **FormUI\DSReportSouce.Designer.cs**
   - Thêm tất cả classes và methods cho MeetingSummary

4. **FormUI\Report\DelegateConfirmationMinute.cs** (NEW)
   - Wrapper class cho Crystal Report

## 🔧 Tiếp theo - Bạn cần làm

1. **Trong Crystal Report Editor (bên ngoài):**
   - Mở file `DelegateConfirmationMinute.rpt`
   - Set datasource: Database → New Connection → trỏ vào table MeetingSummary
   - Thiết kế layout báo cáo theo ý muốn
   - Lưu file

2. **Thêm vào FormUI.csproj:**
   - Đảm bảo file `DelegateConfirmationMinute.rpt` được included trong project
   - Build action: **Embedded Resource**

3. **(Optional) Tạo form để hiển thị báo cáo:**
   - Gọi code ở phần "Cách sử dụng" để load và in báo cáo

## 🎯 Tóm tắt quy trình

```
Database (PRP_Meeting_Summary)
          ↓
DAL.GetMeetingSummary(meetingCode) 
          ↓
DataSet (MeetingSummary table)
          ↓
DelegateConfirmationMinute report
          ↓
CrystalReportsViewer
```

---

Mọi thứ đã sẵn sàng! Bạn chỉ cần thiết kế báo cáo trong Crystal Report Editor và save lại file .rpt 🎉
