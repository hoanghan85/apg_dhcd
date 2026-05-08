# 📋 SETUP_VOTE_COUNTING_MINUTE - CHECKLIST & QUICK GUIDE

## ✅ Checklist - Các bước thực hiện

### **Phase 1: Thiết kế Report (Crystal Report Designer)**
- [ ] **Tạo file VoteCountingMinute.rpt**
  - Đường dẫn: `FormUI\Report\VoteCountingMinute.rpt`
  - Mở bằng Crystal Report Editor

- [ ] **Thêm Database Connection**
  - Menu: Database → New Connection
  - Chọn SQL Server Native Client
  - Input server, database, username, password

- [ ] **Thêm 5 Stored Procedures vào Database Expert**
  1. PRP_Meeting_Summary (@Meetingcode)
  2. PRP_Matters (@Meetingcode)
  3. PRP_Matter_Vote_Summary (@Meetingcode)
  4. PRP_Election_Candidate_Summary (no param)
  5. PRP_Election_Ballot_Summary (no param)

- [ ] **Thiết lập Data Link**
  - Link: PRP_Matters (MatterCode) ← LEFT JOIN → PRP_Matter_Vote_Summary (MatterCode)

- [ ] **Thiết kế Layout Report**
  - Header: Meeting info (MeetingName, YearMeeting, HolderNumber, etc.)
  - Main: Grouped by MatterCode với Vote results
  - Election section: Candidate list & ballot statistics
  - Apply formatting: Numbers (#,##0), Percentages (#0.00%), Decimals (#,##0.00)

- [ ] **Lưu file VoteCountingMinute.rpt**

---

### **Phase 2: C# Code - Cấu trúc Project (2 cách)**

#### **Cách A: Dùng Generic DataSet (Đơn giản, khuyến khích)**
✅ **ĐÃ THỰC HIỆN:**
- [x] Đã thêm method `GetVoteCountingMinuteData()` vào `DAL.cs`
- [x] Method trả về DataSet với 4 tables:
  - MeetingSummary
  - VoteMatterSummary
  - ElectionCandidateSummary
  - ElectionBallotSummary

**Các bước còn lại:**
- [ ] Tạo file `VoteCountingMinute.cs` (auto-generated từ .rpt)
- [ ] Tạo method hiển thị report trong Form
- [ ] Rebuild solution

#### **Cách B: Dùng Typed DataSet - DSReportSouce (Tùy chọn)**
- [ ] Thêm table definitions vào `DSReportSouce.xsd`
  - VoteMatterSummary
  - ElectionCandidateSummary
  - ElectionBallotSummary
- [ ] Run Custom Tool để regenerate `DSReportSouce.Designer.cs`
- [ ] Update DAL.cs method để dùng DSReportSouce thay vì generic DataSet

---

### **Phase 3: Integration vào Solution**

- [ ] **Tạo VoteCountingMinute.cs từ .rpt**
  - Visual Studio sẽ auto-generate khi lưu .rpt
  - Hoặc rebuild solution

- [ ] **Cập nhật FormUI.csproj**
  ```xml
  <Compile Include="Report\VoteCountingMinute.cs">
    <DependentUpon>VoteCountingMinute.rpt</DependentUpon>
    <AutoGen>True</AutoGen>
    <DesignTime>True</DesignTime>
    <SubType>Component</SubType>
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>
  </Compile>

  <EmbeddedResource Include="Report\VoteCountingMinute.rpt">
    <Generator>CrystalDecisions.VSDesigner.CodeGen.ReportCodeGenerator</Generator>
    <LastGenOutput>VoteCountingMinute.cs</LastGenOutput>
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>
  </EmbeddedResource>
  ```

- [ ] **Tạo method hiển thị Report**
  ```csharp
  public void ShowVoteCountingMinute(string meetingcode)
  {
      try
      {
          var dsReport = BenlyDal.GetVoteCountingMinuteData(meetingcode);
          var report = new VoteCountingMinute();

          // Set data source cho report
          // report.SetDataSource(dsReport); hoặc set từng table

          ReportViewer.LoadReport(report, this);
      }
      catch (Exception ex)
      {
          MessageBox.Show("Lỗi: " + ex.Message);
      }
  }
  ```

- [ ] **Rebuild Solution**
  - Menu: Build → Rebuild Solution (Ctrl+Alt+B)

- [ ] **Test Load Report**
  - Chạy app, gọi ShowVoteCountingMinute("APG2026")
  - Verify dữ liệu hiển thị đúng

---

## 📊 Dữ liệu Mapping Reference

### **Meeting Info (từ PRP_Meeting_Summary)**
```
MeetingCode        → Mã cuộc họp
MeetingName        → Tên cuộc họp
CompanyName        → Tên công ty
YearMeeting        → Năm
HolderNumber       → Số cổ đông tham dự
ShareNumber        → Tổng số phiếu (cổ đông)
DelegateNumber     → Số đại biểu tham dự
DelegateShare      → Tổng số phiếu đại biểu
HolderSharePercent → Tỷ lệ phiếu cổ đông (%)
DelegateSharePercent → Tỷ lệ phiếu đại biểu (%)
```

### **Matters & Votes (PRP_Matters + PRP_Matter_Vote_Summary)**
```
MatterCode         → Mã vấn đề (1, 2, 3, ...)
MatterName         → Tên vấn đề
MatterDescription  → Chi tiết vấn đề
VoteType           → Loại biểu quyết (Tán thành, Không tán thành, Không có ý kiến, Không hợp lệ)
VoteLabel          → Nhãn hiển thị
VoteShares         → Số phiếu
VotePercent        → Tỷ lệ (%)
```

### **Election Candidates (PRP_Election_Candidate_Summary)**
```
MeetingCode        → Mã cuộc họp
ElectionCode       → Mã bầu cử
CandidateCode      → Mã ứng cử viên
RowNum             → Số thứ tự
CandidateName      → Tên ứng cử viên
PositionName       → Chức vụ
VoteCount          → Số phiếu bầu
VotePercent        → Tỷ lệ (%)
ElectionResult     → Kết quả (Trúng cử / Không trúng cử)
```

### **Election Ballots (PRP_Election_Ballot_Summary)**
```
MeetingCode           → Mã cuộc họp
ElectionCode          → Mã bầu cử
IssuedBallotCount     → Số phiếu phát ra
IssuedVoteShares      → Tổng phiếu bầu phát ra
SubmittedBallotCount  → Số phiếu thu về
SubmittedVoteShares   → Tổng phiếu bầu thu về
ValidBallotCount      → Số phiếu hợp lệ
ValidVoteShares       → Tổng phiếu bầu hợp lệ
IllegalBallotCount    → Số phiếu không hợp lệ
IllegalVoteShares     → Tổng phiếu bầu không hợp lệ
NoVoteBallotCount     → Số phiếu không tham gia
NoVoteShares          → Tổng phiếu bầu không tham gia
```

---

## 🎯 DAL.cs Method - Đã tạo sẵn

```csharp
// Lấy dữ liệu cho VoteCountingMinute Report
public DataSet GetVoteCountingMinuteData(string meetingcode)
{
    var dsReport = new DataSet();

    try
    {
        // 1. Lấy Meeting Summary
        string qryMeeting = "PRP_Meeting_Summary";
        var cmdMeeting = new SqlCommand(qryMeeting, conn);
        cmdMeeting.CommandType = CommandType.StoredProcedure;
        cmdMeeting.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
        var daMeeting = new SqlDataAdapter(cmdMeeting);
        daMeeting.Fill(dsReport, "MeetingSummary");

        // 2. Lấy Vote Matter Summary (Matters + Votes Join)
        string qryVoteMatter = @"
            SELECT m.MatterCode, m.MatterName, m.MatterDescription,
                   v.VoteType, v.VoteLabel, v.VoteShares, v.VotePercent
            FROM PRP_Matters m
            LEFT JOIN PRP_Matter_Vote_Summary v ON m.MatterCode = v.MatterCode
            WHERE m.MeetingCode = @Meetingcode
            ORDER BY m.MatterCode, v.VoteType
        ";
        var cmdVoteMatter = new SqlCommand(qryVoteMatter, conn);
        cmdVoteMatter.CommandType = CommandType.Text;
        cmdVoteMatter.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
        var daVoteMatter = new SqlDataAdapter(cmdVoteMatter);
        daVoteMatter.Fill(dsReport, "VoteMatterSummary");

        // 3. Lấy Election Candidate Summary
        string qryCandidate = "PRP_Election_Candidate_Summary";
        var cmdCandidate = new SqlCommand(qryCandidate, conn);
        cmdCandidate.CommandType = CommandType.StoredProcedure;
        var daCandidate = new SqlDataAdapter(cmdCandidate);
        daCandidate.Fill(dsReport, "ElectionCandidateSummary");

        // 4. Lấy Election Ballot Summary
        string qryBallot = "PRP_Election_Ballot_Summary";
        var cmdBallot = new SqlCommand(qryBallot, conn);
        cmdBallot.CommandType = CommandType.StoredProcedure;
        var daBallot = new SqlDataAdapter(cmdBallot);
        daBallot.Fill(dsReport, "ElectionBallotSummary");

        return dsReport;
    }
    catch (Exception ex)
    {
        throw new Exception("Lỗi lấy dữ liệu VoteCountingMinute: " + ex.Message, ex);
    }
}
```

---

## 💡 Tips & Troubleshooting

### **Format Fields trong Report**
- **Integer (ShareNumber, VoteCount):** `#,##0`
- **Decimal (Votes, Shares):** `#,##0.00`
- **Percentage:** `#0.00\%`
- **Currency:** `$#,##0.00`

### **Lỗi thường gặp**

| Lỗi | Nguyên nhân | Giải pháp |
|-----|-----------|----------|
| "Unable to cast object..." | Data type mismatch | Kiểm tra .xsd, regenerate Designer |
| Report hiển thị blank | Parameter không được pass | Verify @Meetingcode |
| "Stored Procedure not found" | SP name sai | Check tên SP trong SP query |
| Data không group đúng | Link/join sai | Verify Database Expert links |
| Số lượng không match | Query Filter sai | Check WHERE clause |

### **Query Test**
Để test query trước khi thêm vào report:
```sql
-- Test 1: Meeting Summary
EXEC PRP_Meeting_Summary 'APG2026'

-- Test 2: Matters & Votes
SELECT m.MatterCode, m.MatterName, v.VoteType, v.VoteShares, v.VotePercent
FROM PRP_Matters m
LEFT JOIN PRP_Matter_Vote_Summary v ON m.MatterCode = v.MatterCode
WHERE m.MeetingCode = 'APG2026'
ORDER BY m.MatterCode, v.VoteType

-- Test 3: Election Candidates
EXEC PRP_Election_Candidate_Summary

-- Test 4: Election Ballots
EXEC PRP_Election_Ballot_Summary
```

---

## 📚 Tài liệu tham khảo

- **SETUP_VOTE_COUNTING_MINUTE.md** - Hướng dẫn chi tiết thiết lập
- **SETUP_REPORT_RPT.md** - Hướng dẫn chung cho reports
- **DAL.cs** - Method `GetVoteCountingMinuteData()` đã thêm

---

## ✨ Next Steps

1. **Mở Crystal Report Designer** → Tạo VoteCountingMinute.rpt
2. **Thêm SPs** vào Database Expert
3. **Thiết kế layout** theo ví dụ mẫu
4. **Lưu .rpt file**
5. **Rebuild Visual Studio**
6. **Test load report** với sample data

Good luck! 🚀
