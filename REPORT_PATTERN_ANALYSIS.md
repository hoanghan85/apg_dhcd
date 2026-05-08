# 📊 Analysis: Cách sử dụng Report trong Project APG_DHCD

## ✅ Kết luận: Project sử dụng **HYBRID APPROACH**

---

## 🎯 Hai mô hình chính đang áp dụng

### **Mô hình 1: Auto-Generated Report Class + SetDataSource() - ĐỦ THÔNG MINH**
**Status:** ✅ ĐANG DÙNG - Giải pháp hiện tại của project

#### Ví dụ: `phieubieuquyet1.rpt` → `phieubieuquyet1.cs`

**Cách hoạt động:**
1. Crystal Report Designer tạo `.rpt` file với **tùy chọn không lưu DB connection** (hoặc lưu temporary)
2. Visual Studio auto-generate `phieubieuquyet1.cs` khi save `.rpt`
3. Lúc runtime: `new phieubieuquyet1()` rồi `SetDataSource()` từ C# code

**Code in DelegateList.cs (Lines 182-221):**
```csharp
var cr = new phieubieuquyet1();
try
{
    // Set parameters
    cr.SetParameterValue("LogoPath", logoPath);

    // ✅ SET DATA SOURCE từ C# (không connect DB từ .rpt)
    cr.SetDataSource(My.MyProject.Forms.Mainform.BenlyDal.Matter_getlist(...));

    cr.SetParameterValue("Delegatecode", ...);
    cr.SetParameterValue("Delegatename", ...);
    // ... more parameters

    // Show report
    ReportViewer.LoadReport(cr, this);
}
catch (Exception ex)
{
    Interaction.MsgBox("Lỗi :" + ex.Message);
}
```

**Ưu điểm:**
- ✅ Không phụ thuộc vào DB connection trong `.rpt`
- ✅ Linh hoạt - có thể thay đổi data source dynamically
- ✅ Dễ test - pass mock data từ DAL
- ✅ Tương thích .NET Framework 4.8

---

### **Mô hình 2: Direct ReportDocument.Load() - CÓ THẬP HƠN**
**Status:** ⚠️ CŨNG ĐANG DÙNG - Cho các report legacy

#### Ví dụ: `PhieuXacNhan.rpt`, `thebieuquyet_2.rpt`

**Cách hoạt động:**
1. Load `.rpt` file từ disk bằng `new ReportDocument()` + `Load()`
2. Set parameters + in report
3. **Không sử dụng auto-generated CS file**

**Code in DelegateList.cs (Lines 357-415):**
```csharp
var cr = new ReportDocument();
string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\PhieuXacNhan.rpt");

cr.Load(reportPath);
cr.SetParameterValue("LogoPath", logoPath);
// Set other parameters...
ReportViewer.LoadReport(cr, this);
```

**Nhược điểm:**
- ⚠️ Phải lưu đường dẫn `.rpt` hardcoded
- ⚠️ Không auto-generate C# class - phải maintain thủ công
- ⚠️ Nếu `.rpt` có DB connection, sẽ connect trực tiếp DB

---

## 🔍 Phân tích từng Report

| Report | Tệp .rpt | Phương pháp | Auto-Generated CS? | Cách Connect DB | Ghi chú |
|--------|---------|-----------|-----------------|-----------------|--------|
| **phieubieuquyet1** | ✅ | Mô hình 1 | ✅ phieubieuquyet1.cs | SetDataSource() | ✨ Best Practice |
| **DelegateConfirmationMinute** | ✅ | Mô hình 1 | ✅ DelegateConfirmationMinute.cs | SetDataSource() hoặc Load() | ✨ Best Practice |
| **PhieuXacNhan** | ✅ | Mô hình 2 | ❌ | ReportDocument.Load() | Legacy approach |
| **thebieuquyet_2** | ✅ | Mô hình 2 | ❌ | ReportDocument.Load() | Legacy approach |
| **ThongTinCuocHop** | ✅ | Mô hình 1 | ✅ ThongTinCuocHop.cs | SetDataSource() | ✨ Best Practice |

---

## 🎓 Khuyến cáo cho `VoteCountingMinute.rpt`

### ✅ **OPTION A - Khuyến khích nhất (Giống phieubieuquyet1)**

```csharp
// 1. Tạo .rpt file KHÔNG lưu DB connection
// 2. Visual Studio tự generate VoteCountingMinute.cs

// 3. Lúc runtime:
var report = new VoteCountingMinute();

// Set parameters
report.SetParameterValue("MeetingCode", meetingcode);

// ✅ SET DATA SOURCE từ DAL
var dsReport = BenlyDal.GetVoteCountingMinuteData(meetingcode);
report.SetDataSource(dsReport);

// Show report
ReportViewer.LoadReport(report, this);
```

**Lý do chọn:**
- ✅ Không phụ thuộc DB connection trong .rpt
- ✅ Tuân theo pattern hiện tại của project
- ✅ Dữ liệu được lấy từ DAL (centralized)
- ✅ Dễ maintain và debug

---

### ⚠️ **OPTION B - Không khuyến khích (Giống PhieuXacNhan)**

```csharp
// ❌ Không recommended - nhưng vẫn có thể dùng
var report = new ReportDocument();
report.Load(@"Report\VoteCountingMinute.rpt");
// ...
```

**Tại sao không:**
- ⚠️ Phá vỡ pattern của project
- ⚠️ Phải maintain hardcoded path
- ⚠️ Nếu .rpt có DB connection, report sẽ connect trực tiếp

---

## 📋 Quy trình Setup cho VoteCountingMinute

### **Phase 1: Design .rpt (Crystal Report Designer)**
1. Mở Crystal Reports Designer
2. Tạo `VoteCountingMinute.rpt`
3. **QUAN TRỌNG:** 
   - ❌ **KHÔNG** thêm Database → New Connection
   - ✅ Để trống database fields lúc đầu
   - ✅ Chỉ tạo text fields cho parameters (@MeetingCode, etc.)

### **Phase 2: C# Code Setup**

```csharp
// DAL.cs - Lấy dữ liệu (Đã có)
public DataSet GetVoteCountingMinuteData(string meetingcode)
{
    // Fetch từ 4 SPs/queries
    return dsReport;
}

// Form.cs - Display Report
private void ShowVoteCountingMinute(string meetingcode)
{
    try
    {
        var report = new VoteCountingMinute();

        // Set parameters
        report.SetParameterValue("MeetingCode", meetingcode);

        // ✅ Set data source
        var ds = BenlyDal.GetVoteCountingMinuteData(meetingcode);
        report.SetDataSource(ds);

        // Show
        ReportViewer.LoadReport(report, this);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi: " + ex.Message);
    }
}
```

### **Phase 3: .csproj Configuration**
```xml
<EmbeddedResource Include="Report\VoteCountingMinute.rpt">
    <Generator>CrystalDecisions.VSDesigner.CodeGen.ReportCodeGenerator</Generator>
    <LastGenOutput>VoteCountingMinute.cs</LastGenOutput>
    <CopyToOutputDirectory>Always</CopyToOutputDirectory>
</EmbeddedResource>

<Compile Include="Report\VoteCountingMinute.cs">
    <DependentUpon>VoteCountingMinute.rpt</DependentUpon>
    <AutoGen>True</AutoGen>
    <DesignTime>True</DesignTime>
</Compile>
```

### **Phase 4: Rebuild Visual Studio**
```
Build → Rebuild Solution (Ctrl+Alt+B)
```

---

## 🎯 Summary: Cách không dùng Direct DB Connection

| Yêu cầu | Cách thực hiện |
|--------|--------------|
| Không connect DB từ .rpt | Không thêm Database Connection trong Crystal Designer |
| Truyền data vào report | Dùng `report.SetDataSource(dataSet)` hoặc `SetParameterValue()` |
| Lấy data từ DB | Dùng `BenlyDal.GetVoteCountingMinuteData()` → trả DataSet |
| Query DB | Thực hiện trong DAL.cs, không trong report |
| Maintain connection | Quản lý trong DAL, tách biệt khỏi report logic |

---

## 📚 Tài liệu tham khảo trong codebase

- **phieubieuquyet1.cs** (auto-generated)
- **DelegateConfirmationMinute.cs** (auto-generated)
- **DelegateList.cs** Lines 182-221 (usage example)
- **DAL.cs** (data source methods)
- **DSReportSouce.xsd** (typed dataset option)

