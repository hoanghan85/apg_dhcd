# Hướng dẫn: Thiết lập DataSource cho DelegateConfirmationMinute.rpt

## 🔧 Các bước thiết lập trong Crystal Report Editor

### **Bước 1: Mở file .rpt**
- Đường dẫn: `FormUI\Report\DelegateConfirmationMinute.rpt`
- Mở bằng Crystal Report Editor (ngoài Visual Studio)

### **Bước 2: Thêm Database Connection**
1. **Menu: Database → New Connection**
2. **Chọn ODBC Data Source hoặc SQL Server Native Client**
3. **Input thông tin:**
   - Server: Tên server của bạn
   - Database: Tên database của bạn
   - Username: username
   - Password: password

### **Bước 3: Thêm Table vào Report**
1. **Database → Database Expert** (hoặc F5)
2. **Chọn table:** Chọn database → bảng cần query (hoặc query từ SP)
3. **Có 2 cách:**

#### **Cách 1: Query từ Stored Procedure (Recommended)**
- Chọn "Command" thay vì "Table"
- Nhập: `PRP_Meeting_Summary` + parameter @Meetingcode

#### **Cách 2: Query từ View**
- Tạo view `vw_MeetingSummary` trong database
- Select view này vào report

### **Bước 4: Map Fields**
1. **Insert → Field**
2. **Thêm các fields vào report:**
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

### **Bước 5: Thiết kế Layout**
- Add headers, footers
- Format các fields theo ý muốn
- Thêm calculations/summaries

### **Bước 6: Lưu file**
- Ctrl+S để lưu `DelegateConfirmationMinute.rpt`

---

## 🔌 Thông tin kết nối từ Database

**Stored Procedure:** `PRP_Meeting_Summary`
**Parameter:** @Meetingcode (varchar)

**Cấu trúc dữ liệu trả về:**
```
MeetingCode          varchar
MeetingName          nvarchar
CompanyName          nvarchar
YearMeeting          int
HolderNumber         int
ShareNumber          decimal
DelegateNumber       int
DelegateShare        decimal
HolderSharePercent   decimal
DelegateSharePercent decimal
```

---

## 🔧 Sửa cấu trúc Project File (.csproj)

Sau khi tạo hoặc chỉnh sửa file `.rpt`, cần cập nhật lại file **FormUI.csproj** để đảm bảo cấu trúc nested file đúng trong Solution Explorer.

### **Kiểm tra cấu trúc hiện tại:**

Mở `FormUI.csproj` và kiểm tra xem `DelegateConfirmationMinute` có đúng cấu trúc sau không:

#### **✅ Đúng - Compile Node:**
```xml
<Compile Include="Report\DelegateConfirmationMinute.cs">
  <DependentUpon>DelegateConfirmationMinute.rpt</DependentUpon>
  <AutoGen>True</AutoGen>
  <DesignTime>True</DesignTime>
  <SubType>Component</SubType>
  <CopyToOutputDirectory>Always</CopyToOutputDirectory>
</Compile>
```

#### **✅ Đúng - EmbeddedResource Node:**
```xml
<EmbeddedResource Include="Report\DelegateConfirmationMinute.rpt">
  <Generator>CrystalDecisions.VSDesigner.CodeGen.ReportCodeGenerator</Generator>
  <LastGenOutput>DelegateConfirmationMinute.cs</LastGenOutput>
  <CopyToOutputDirectory>Always</CopyToOutputDirectory>
</EmbeddedResource>
```

### **Nếu cấu trúc sai:**

#### ❌ Lỗi thường gặp:
1. `.cs` file không có `DependentUpon` → .cs sẽ không nested dưới .rpt
2. `.rpt` file có `DependentUpon` trỏ đến `.cs` (ngược lại) → Sai hướng
3. Thiếu `AutoGen`, `DesignTime`, `CopyToOutputDirectory` → Build sẽ không sinh code tự động

#### ✅ Cách sửa bằng PowerShell:

Chạy script dưới đây từ PowerShell:

```powershell
# Sửa Compile node cho DelegateConfirmationMinute.cs
$csprojPath = "C:\Users\hienpnp\source\repos\apg_dhcd1\FormUI\FormUI.csproj"
[xml]$xml = Get-Content $csprojPath
$ns = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
$ns.AddNamespace('default', 'http://schemas.microsoft.com/developer/msbuild/2003')

# Update Compile node
$compileNode = $xml.SelectSingleNode("//default:Compile[@Include='Report\DelegateConfirmationMinute.cs']", $ns)
if ($compileNode) {
  $compileNode.InnerXml = @"
      <DependentUpon>DelegateConfirmationMinute.rpt</DependentUpon>
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <SubType>Component</SubType>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
"@
  Write-Host "✓ Updated Compile node"
}

# Update EmbeddedResource node
$rptNode = $xml.SelectSingleNode("//default:EmbeddedResource[@Include='Report\DelegateConfirmationMinute.rpt']", $ns)
if ($rptNode) {
  $rptNode.InnerXml = @"
      <Generator>CrystalDecisions.VSDesigner.CodeGen.ReportCodeGenerator</Generator>
      <LastGenOutput>DelegateConfirmationMinute.cs</LastGenOutput>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
"@
  Write-Host "✓ Updated EmbeddedResource node"
}

$xml.Save($csprojPath)
Write-Host "✓ File saved successfully!"
```

#### ✅ Sau khi sửa:
1. **Đóng Visual Studio** hoàn toàn
2. **Reload FormUI.csproj** vào Visual Studio
3. **Kiểm tra Solution Explorer:** `DelegateConfirmationMinute.cs` giờ sẽ nested dưới `DelegateConfirmationMinute.rpt` ✓

---

## ⚠️ Nếu vẫn lỗi

Nếu vẫn gặp lỗi "Unable to cast object to type...", hãy:

1. **Kiểm tra .rpt file:**
   - Mở trong Crystal Report Designer
   - Xem Database Expert (F5)
   - Đảm bảo table/SP được thêm đúng

2. **Nếu chưa có datasource:**
   - **Cách nhanh:** Dùng View thay vì DataSet
   - Database → New View → query từ `vw_MeetingSummary`

3. **Rebuild code:**
   ```csharp
   // Cách đơn giản nhất - không dùng DataSet
   var dt = My.MyProject.Forms.Mainform.BenlyDal.GetMeetingSummary(
       My.MyProject.Forms.Mainform.workingmeeting);

   var report = new DelegateConfirmationMinute();
   report.SetDataSource(dt);  // Set trực tiếp DataTable
   ReportViewer.LoadReport(report, this);
   ```

---

## ✅ Kiểm tra lại

Sau khi setup:
1. Build project: `Ctrl+Shift+B`
2. Click Button4 trên ReportForm
3. Báo cáo sẽ hiển thị với dữ liệu từ database

Good luck! 🎉
