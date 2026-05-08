# 📊 Quick Reference: Sử dụng VoteCountingMinute Report

## 🚀 Cách sử dụng trong Form

```csharp
// Gọi từ ReportForm Button6:
private void Button6_Click(object sender, EventArgs e)
{
    PrintVoteCountingMinute();
}

// Implementation:
private void PrintVoteCountingMinute()
{
    try
    {
        // 1️⃣ Lấy meeting code từ Mainform
        string meetingcode = My.MyProject.Forms.Mainform.workingmeeting;

        // 2️⃣ Gọi DAL method để lấy DataSet
        var dsReport = My.MyProject.Forms.Mainform.BenlyDal.GetVoteCountingMinuteData(meetingcode);

        // 3️⃣ Validate dữ liệu
        if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu để hiển thị báo cáo");
            return;
        }

        // 4️⃣ Tạo report instance từ auto-generated class
        var report = new VoteCountingMinute();

        // 5️⃣ (Optional) Set parameters
        report.SetParameterValue("MeetingCode", meetingcode);

        // 6️⃣ ⭐ SET DATA SOURCE - Không load từ DB trong .rpt
        report.SetDataSource(dsReport);

        // 7️⃣ Hiển thị báo cáo
        ReportViewer.LoadReport(report, this);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi: " + ex.Message);
    }
}
```

---

## 📦 DataSet Structure

**Method:** `DAL.GetVoteCountingMinuteData(string meetingcode)`

**Trả về DataSet với 4 tables:**

### 1. **MeetingSummary**
```
Columns:
- MeetingCode
- MeetingName
- CompanyName
- YearMeeting
- HolderNumber
- ShareNumber
- DelegateNumber
- DelegateShare
- HolderSharePercent
- DelegateSharePercent
```

### 2. **VoteMatterSummary**
```
Columns:
- MatterCode
- MatterName
- MatterDescription
- VoteType (Tán thành, Không tán thành, Không có ý kiến, Không hợp lệ)
- VoteLabel
- VoteShares
- VotePercent
```

### 3. **ElectionCandidateSummary**
```
Columns:
- MeetingCode
- ElectionCode
- CandidateCode
- RowNum
- CandidateName
- PositionName
- VoteCount
- VotePercent
- ElectionResult
```

### 4. **ElectionBallotSummary**
```
Columns:
- MeetingCode
- ElectionCode
- IssuedBallotCount
- IssuedVoteShares
- SubmittedBallotCount
- SubmittedVoteShares
- ValidBallotCount
- ValidVoteShares
- IllegalBallotCount
- IllegalVoteShares
- NoVoteBallotCount
- NoVoteShares
```

---

## 🎨 Crystal Report Designer Setup

### ❌ KHÔNG làm
```
- Thêm Database Connection (Database → New Connection)
- Lưu login credentials trong .rpt
- Viết SQL queries trong report
```

### ✅ PHẢI làm
```
- Thiết kế layout với Text Fields & Table objects
- Kéo từng column từ DataSet tables vào report
- Không kết nối trực tiếp với database
- Set Parameters để nhận giá trị từ C#
```

### Các bước trong Designer
1. Mở file: `FormUI\Report\VoteCountingMinute.rpt`
2. Tạo Header section với thông tin cuộc họp
3. Tạo Main section, grouped by MatterCode
4. Insert fields từ MeetingSummary & VoteMatterSummary
5. Tạo Election section cho candidates & ballots
6. Format: Numbers (#,##0), Percentages (#0.00\%)
7. Save file

---

## 🔌 Files liên quan

| File | Mục đích | Chỉnh sửa |
|------|---------|----------|
| `VoteCountingMinute.rpt` | Crystal Report design | Thiết kế layout |
| `VoteCountingMinute.cs` | Auto-generated class | Không chỉnh sửa |
| `FormUI.csproj` | Project config | ✅ Đã cấu hình |
| `DAL.GetVoteCountingMinuteData()` | Lấy data từ DB | ✅ Đã triển khai |
| `ReportForm.PrintVoteCountingMinute()` | Display report | ✅ Đã triển khai |

---

## 🐛 Debug Tips

### 1. Kiểm tra DataSet có dữ liệu
```csharp
var dsReport = BenlyDal.GetVoteCountingMinuteData(meetingcode);
foreach (DataTable dt in dsReport.Tables)
{
    Debug.WriteLine($"Table: {dt.TableName}, Rows: {dt.Rows.Count}");
    foreach (DataColumn col in dt.Columns)
        Debug.WriteLine($"  - {col.ColumnName}");
}
```

### 2. Kiểm tra report fields
```csharp
var report = new VoteCountingMinute();
report.SetDataSource(dsReport);
foreach (var field in report.DataDefinition.DatabaseFields)
{
    Debug.WriteLine(field.Name);
}
```

### 3. Verify SQL queries in SQL Server
```sql
-- Test queries trước khi run report:
EXEC PRP_Meeting_Summary 'APG2026'

SELECT m.MatterCode, m.MatterName, v.VoteType, v.VoteShares, v.VotePercent
FROM PRP_Matters m
LEFT JOIN PRP_Matter_Vote_Summary v ON m.MatterCode = v.MatterCode
WHERE m.MeetingCode = 'APG2026'

EXEC PRP_Election_Candidate_Summary

EXEC PRP_Election_Ballot_Summary
```

---

## 📝 Ghi chú quan trọng

1. **Database Connection:** ❌ KHÔNG lưu trong `.rpt`
   - Connection được quản lý bởi DAL
   - Report là stateless, chỉ nhận data

2. **Data Flow:** C# → DataSet → Report
   - DAL.cs (lấy dữ liệu)
   - ReportForm.cs (gọi method & display)
   - VoteCountingMinute.rpt (thiết kế layout)

3. **SetDataSource()** là KEY:
   ```csharp
   report.SetDataSource(dsReport);  // ← Quan trọng!
   ```

4. **Parameters tùy chọn:**
   ```csharp
   report.SetParameterValue("ParamName", value);
   ```

---

## ✅ Checklist trước khi sử dụng

- [ ] File `VoteCountingMinute.rpt` đã thiết kế layout
- [ ] File `VoteCountingMinute.cs` đã generate
- [ ] Build solution không có lỗi
- [ ] DAL method `GetVoteCountingMinuteData()` trả về đúng dữ liệu
- [ ] Button6 (PrintVoteCountingMinute) hoạt động
- [ ] Report hiển thị đúng dữ liệu
- [ ] Formatting (numbers, dates) đúng

---

**📞 Support:** Nếu gặp lỗi, check `IMPLEMENTATION_VOTE_COUNTING_MINUTE.md` hoặc `REPORT_PATTERN_ANALYSIS.md`

