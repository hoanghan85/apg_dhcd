# Hướng dẫn: Thiết lập DataSource cho VoteCountingMinute.rpt

## 📋 Tổng quan Report

Report "Biên bản kiểm phiếu biểu quyết" lấy dữ liệu từ **5 Stored Procedure**:
1. `PRP_Meeting_Summary` - Thông tin cuộc họp
2. `PRP_Matters` - Danh sách các vấn đề biểu quyết
3. `PRP_Matter_Vote_Summary` - Kết quả biểu quyết cho từng vấn đề
4. `PRP_Election_Candidate_Summary` - Danh sách ứng cử viên & kết quả bầu cử
5. `PRP_Election_Ballot_Summary` - Thống kê phiếu bầu cử

---

## 🔧 Các bước thiết lập trong Crystal Report Editor

### **Bước 1: Mở file .rpt**
- Đường dẫn: `FormUI\Report\VoteCountingMinute.rpt`
- Mở bằng Crystal Report Editor (ngoài Visual Studio)

### **Bước 2: Thêm Database Connection**
1. **Menu: Database → New Connection**
2. **Chọn SQL Server Native Client**
3. **Input thông tin:**
   - Server: Tên server của bạn
   - Database: Tên database của bạn
   - Username: username
   - Password: password

---

## 📊 Bước 3: Thêm Database Objects

### **3.1: Thêm PRP_Meeting_Summary (Main Dataset)**

1. **Database → Database Expert** (F5)
2. **Available Data Sources → Command (SQL)**
3. Nhập Command:
```sql
PRP_Meeting_Summary
```
4. **Parameter:** `@Meetingcode` (string)
5. **Fields trả về:**
   - MeetingCode (varchar)
   - MeetingName (nvarchar)
   - CompanyName (nvarchar)
   - YearMeeting (int)
   - HolderNumber (int)
   - ShareNumber (int)
   - DelegateNumber (int)
   - DelegateShare (int)
   - HolderSharePercent (decimal)
   - DelegateSharePercent (decimal)

### **3.2: Thêm PRP_Matters**

1. **Add another Command:**
```sql
PRP_Matters
```
2. **Parameter:** `@Meetingcode` (string)
3. **Fields trả về:**
   - MatterCode (int)
   - MatterName (nvarchar)
   - MatterDescription (nvarchar)

### **3.3: Thêm PRP_Matter_Vote_Summary**

1. **Add another Command:**
```sql
PRP_Matter_Vote_Summary
```
2. **Parameter:** `@Meetingcode` (string)
3. **Fields trả về:**
   - MatterCode (int)
   - VoteType (nvarchar) - "Tán thành", "Không tán thành", "Không có ý kiến", "Không hợp lệ"
   - VoteLabel (nvarchar)
   - VoteShares (decimal)
   - VotePercent (decimal)

### **3.4: Thêm PRP_Election_Candidate_Summary**

1. **Add another Command:**
```sql
PRP_Election_Candidate_Summary
```
2. **No Parameter** (hoặc tự động lấy @Meetingcode từ context)
3. **Fields trả về:**
   - MeetingCode (varchar)
   - ElectionCode (int)
   - CandidateCode (int)
   - RowNum (int)
   - CandidateName (nvarchar)
   - PositionName (nvarchar)
   - VoteCount (decimal)
   - VotePercent (decimal)
   - ElectionResult (nvarchar)

### **3.5: Thêm PRP_Election_Ballot_Summary**

1. **Add another Command:**
```sql
PRP_Election_Ballot_Summary
```
2. **No Parameter** (hoặc tự động lấy @Meetingcode từ context)
3. **Fields trả về:**
   - MeetingCode (varchar)
   - ElectionCode (int)
   - IssuedBallotCount (int)
   - IssuedVoteShares (decimal)
   - SubmittedBallotCount (int)
   - SubmittedVoteShares (decimal)
   - ValidBallotCount (int)
   - ValidVoteShares (decimal)
   - IllegalBallotCount (int)
   - IllegalVoteShares (decimal)
   - NoVoteBallotCount (int)
   - NoVoteShares (decimal)

---

## 🔗 Bước 4: Thiết lập Data Link (Relationship)

### **4.1: Link PRP_Matters với PRP_Matter_Vote_Summary**

1. **Database Expert → Links tab**
2. **New Link:**
   - **Left Table:** `PRP_Matters`
   - **Left Field:** `MatterCode`
   - **Right Table:** `PRP_Matter_Vote_Summary`
   - **Right Field:** `MatterCode`
   - **Type:** Left Outer Join

**Kết quả:** Sẽ tạo grouped data, mỗi matter có nhiều vote type

### **4.2: Link PRP_Meeting_Summary với PRP_Matters** (Optional - cho report structure)

Nếu muốn hiển thị summary info ở header:
- **Left Table:** `PRP_Meeting_Summary`
- **Left Field:** `MeetingCode`
- **Right Table:** `PRP_Matters`
- **Right Field:** `MeetingCode` (có thể không có - nên xử lý bằng code)

---

## 📐 Bước 5: Thiết kế Layout Report

### **5.1: Phần Header (Meeting Info)**

Thêm các fields từ `PRP_Meeting_Summary`:
```
Cuộc họp: {MeetingName} - Năm {YearMeeting}
Công ty: {CompanyName}
Ngày biểu quyết: [Current Date]
Tổng số cổ đông tham dự: {HolderNumber}
Tổng số phiếu biểu quyết: {ShareNumber}
Tổng số đại biểu: {DelegateNumber}
Tổng số phiếu của đại biểu: {DelegateShare}
Tỷ lệ cổ đông: {HolderSharePercent}%
Tỷ lệ đại biểu: {DelegateSharePercent}%
```

### **5.2: Phần Main Report (Matters & Votes)**

**Group by MatterCode:**

```
Vấn đề 01: {MatterName}
{MatterDescription}

Kết quả biểu quyết:
  - {VoteLabel}: {VoteShares} phiếu biểu quyết, đạt tỷ lệ {VotePercent}%
  - [Repeat for each VoteType]
```

**Details:**
- Thêm detail row cho mỗi vote type
- Group header hiển thị matter info
- Group footer hiển thị tổng cộng (nếu cần)

### **5.3: Phần Election Results (Bầu cử)**

**Tiêu đề:**
```
KẾT QUẢ BẦU CỬ
```

**Thống kê phiếu:**
```
Tổng số phiếu bầu phát ra: {IssuedBallotCount} phiếu, đại diện cho {IssuedVoteShares} phiếu bầu ({IssuedPercent}%)
Tổng số phiếu bầu thu về: {SubmittedBallotCount} phiếu, đại diện cho {SubmittedVoteShares} phiếu bầu ({SubmittedPercent}%)

Trong đó:
- Phiếu hợp lệ: {ValidBallotCount} phiếu, {ValidVoteShares} phiếu bầu ({ValidPercent}%)
- Phiếu không hợp lệ: {IllegalBallotCount} phiếu, {IllegalVoteShares} phiếu bầu ({IllegalPercent}%)
- Phiếu không biểu quyết: {NoVoteBallotCount} phiếu, {NoVoteShares} phiếu bầu ({NoVotePercent}%)
```

**Danh sách ứng cử viên:**
```
| Thứ tự | Tên ứng cử viên | Chức vụ | Số phiếu bầu | Tỷ lệ | Kết quả |
|--------|----------------|--------|--------------|-------|---------|
| {RowNum} | {CandidateName} | {PositionName} | {VoteCount} | {VotePercent}% | {ElectionResult} |
```

### **5.4: Các Formula cần tính**

Tạo formulas cho các tỷ lệ phần trăm tính toán:

```crystal
// IssuedPercent
NumberVar IssuedTotal := {PRP_Meeting_Summary.ShareNumber};
({PRP_Election_Ballot_Summary.IssuedVoteShares} / IssuedTotal) * 100

// SubmittedPercent
({PRP_Election_Ballot_Summary.SubmittedVoteShares} / IssuedTotal) * 100

// ValidPercent
({PRP_Election_Ballot_Summary.ValidVoteShares} / IssuedTotal) * 100

// Tương tự cho Illegal, NoVote
```

---

## 💾 Bước 6: Lưu và Integrate vào C#

### **6.1: Lưu file**
- Ctrl+S → Lưu `VoteCountingMinute.rpt`

### **6.2: Tạo Code Class (Auto-generated)**
- Visual Studio sẽ tự động tạo `VoteCountingMinute.cs` từ `.rpt`

### **6.3: Cập nhật .csproj**

Đảm bảo trong `FormUI.csproj`:

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

---

## 📝 Bước 7: Cập nhật DSReportSouce.xsd (Optional - nếu muốn dùng typed dataset)

### **Lưu ý:**
- Nếu bạn muốn dùng **typed dataset** (DSReportSouce) thay vì generic DataSet, hãy thêm các table definitions
- Nếu muốn nhanh chóng, bạn có thể skip bước này và dùng generic DataSet + DataTable (đã làm sẵn trong DAL.cs)

### **7.1: Thêm VoteCountingMinute tables vào DSReportSouce.xsd (Optional)**

Thêm các table definitions:

```xml
<!-- VoteMatterSummary Table -->
<xs:element name="VoteMatterSummary" msprop:Generator_UserTableName="VoteMatterSummary">
  <xs:complexType>
    <xs:sequence>
      <xs:element name="MatterCode" type="xs:int" minOccurs="0" />
      <xs:element name="MatterName" type="xs:string" minOccurs="0" />
      <xs:element name="MatterDescription" type="xs:string" minOccurs="0" />
      <xs:element name="VoteType" type="xs:string" minOccurs="0" />
      <xs:element name="VoteLabel" type="xs:string" minOccurs="0" />
      <xs:element name="VoteShares" type="xs:decimal" minOccurs="0" />
      <xs:element name="VotePercent" type="xs:decimal" minOccurs="0" />
    </xs:sequence>
  </xs:complexType>
</xs:element>

<!-- ElectionCandidateSummary Table -->
<xs:element name="ElectionCandidateSummary" msprop:Generator_UserTableName="ElectionCandidateSummary">
  <xs:complexType>
    <xs:sequence>
      <xs:element name="MeetingCode" type="xs:string" minOccurs="0" />
      <xs:element name="ElectionCode" type="xs:int" minOccurs="0" />
      <xs:element name="CandidateCode" type="xs:int" minOccurs="0" />
      <xs:element name="RowNum" type="xs:int" minOccurs="0" />
      <xs:element name="CandidateName" type="xs:string" minOccurs="0" />
      <xs:element name="PositionName" type="xs:string" minOccurs="0" />
      <xs:element name="VoteCount" type="xs:decimal" minOccurs="0" />
      <xs:element name="VotePercent" type="xs:decimal" minOccurs="0" />
      <xs:element name="ElectionResult" type="xs:string" minOccurs="0" />
    </xs:sequence>
  </xs:complexType>
</xs:element>

<!-- ElectionBallotSummary Table -->
<xs:element name="ElectionBallotSummary" msprop:Generator_UserTableName="ElectionBallotSummary">
  <xs:complexType>
    <xs:sequence>
      <xs:element name="MeetingCode" type="xs:string" minOccurs="0" />
      <xs:element name="ElectionCode" type="xs:int" minOccurs="0" />
      <xs:element name="IssuedBallotCount" type="xs:int" minOccurs="0" />
      <xs:element name="IssuedVoteShares" type="xs:decimal" minOccurs="0" />
      <xs:element name="SubmittedBallotCount" type="xs:int" minOccurs="0" />
      <xs:element name="SubmittedVoteShares" type="xs:decimal" minOccurs="0" />
      <xs:element name="ValidBallotCount" type="xs:int" minOccurs="0" />
      <xs:element name="ValidVoteShares" type="xs:decimal" minOccurs="0" />
      <xs:element name="IllegalBallotCount" type="xs:int" minOccurs="0" />
      <xs:element name="IllegalVoteShares" type="xs:decimal" minOccurs="0" />
      <xs:element name="NoVoteBallotCount" type="xs:int" minOccurs="0" />
      <xs:element name="NoVoteShares" type="xs:decimal" minOccurs="0" />
    </xs:sequence>
  </xs:complexType>
</xs:element>
```

### **7.2: Regenerate Designer**
- Chuột phải `DSReportSouce.xsd` → **Run Custom Tool**

---

## 💻 Bước 8: Tạo Method Load Report trong DAL.cs

Thêm method trong `DAL.cs`:

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

## 🎯 Bước 9: Load Report trong Code

Tạo method hiển thị report:

```csharp
public void ShowVoteCountingMinute(string meetingcode)
{
    try
    {
        // Lấy dữ liệu từ database
        var dsReport = BenlyDal.GetVoteCountingMinuteData(meetingcode);

        // Tạo instance report
        var report = new VoteCountingMinute();

        // Set data source cho từng table
        report.SetDataSource(dsReport.Tables["MeetingSummary"]);

        // Nếu cần set riêng cho VoteMatterSummary (nếu report structure phức tạp)
        // report.Database.Tables["VoteMatterSummary"].SetDataSource(dsReport.Tables["VoteMatterSummary"]);

        // Hiển thị report
        ReportViewer.LoadReport(report, this);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

---

## 📊 Bước 10: Format & Display

### **Format Numbers:**
- ShareNumber, VoteShares: **#,##0** (1000 separator, no decimals)
- VotePercent, DelegateSharePercent: **#,##0.00%** (2 decimals)
- Decimal values: **#,##0.00** (2 decimals)

### **Format Currency (Nếu cần):**
```crystal
// Thêm formatting function
StringVar formattedShares := 
  If({field} >= 1000000, 
    ToText({field}/1000000, "#.##") + "M",
    ToText({field}, "#,##0")
  );
formattedShares
```

---

## ⚠️ Troubleshooting

**Nếu gặp lỗi:**

1. **"Unable to cast object..."** 
   - Kiểm tra data type trong .xsd có match với database không
   - Regenerate Designer file

2. **Report hiển thị blank**
   - Kiểm tra parameter @Meetingcode có được pass đúng không
   - Verify SP trả về data đúng

3. **Grouped data không hiển thị đúng**
   - Đảm bảo link/join đúng trong Database Expert
   - Check ORDER BY clause trong query

4. **Formatting không apply**
   - Right-click field → Format Field → Number/Currency tab
   - Đảm bảo data type match (int/decimal)

---

## ✅ Checklist

- [ ] Tạo file VoteCountingMinute.rpt
- [ ] Thêm 5 SP vào Database Expert
- [ ] Link PRP_Matters với PRP_Matter_Vote_Summary
- [ ] Thiết kế layout report
- [ ] Tạo formulas tính toán %
- [ ] Regenerate VoteCountingMinute.cs
- [ ] Cập nhật .csproj file
- [ ] Thêm tables vào DSReportSouce.xsd
- [ ] Tạo method GetVoteCountingMinuteData trong DAL.cs
- [ ] Tạo method ShowVoteCountingMinute
- [ ] Test load report với sample data
- [ ] Format numbers & currencies
- [ ] Verify output với sample ở trên

