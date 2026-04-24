# DHCD-NewAPG Solution Architecture & Functionality Documentation

**Project Name**: DHCD-NewAPG (Shareholder Meeting Management System)  
**Company**: Công ty Cổ phần Chứng khoán APG  
**Technology Stack**: .NET Framework 4.8  
**Database**: SQL Server 2008+  
**UI Framework**: Windows Forms  
**Reporting**: Crystal Reports 13.0

---

## 📑 Table of Contents

1. [Solution Overview](#solution-overview)
2. [Architecture Diagram](#architecture-diagram)
3. [Project Structure](#project-structure)
4. [Technology Stack](#technology-stack)
5. [Database Configuration](#database-configuration)
6. [Module Functionality](#module-functionality)
7. [Data Flow](#data-flow)
8. [File Structure](#file-structure)
9. [Key Components](#key-components)
10. [Dependencies](#dependencies)

---

## 🏗️ Solution Overview

The **DHCD-NewAPG** system is a comprehensive Windows Forms application designed to manage shareholder meetings for APG Securities. It handles:

- **Meeting Management**: Create, schedule, and track shareholder meetings
- **Participant Management**: Manage shareholders, delegates, and representatives
- **Voting System**: Execute voting on various matters and elections
- **Reporting**: Generate professional reports using Crystal Reports
- **Data Management**: Full CRUD operations via SQL Server backend

---

## 🔧 Architecture Diagram

```
┌─────────────────────────────────────────────────────────────────┐
│                    DHCD-NewAPG Solution                         │
│                  (ShareHolder Meeting System)                   │
│                    .NET Framework 4.8                           │
└─────────────────────────────────────────────────────────────────┘
                              │
                  ┌───────────┴───────────┐
                  ▼                       ▼
        ┌──────────────────┐    ┌──────────────────┐
        │   FormUI.csproj  │    │   DAL.csproj     │
        │  (Presentation)  │    │  (Data Access)   │
        └──────────────────┘    └──────────────────┘
              │                         │
              │                         │
    ┌─────────┴─────────┬──────┐       │
    ▼                   ▼      ▼       │
┌──────────┐      ┌─────────┐  │       │
│Mainform  │      │Meeting  │  │       │
│(Main UI) │      │Forms    │  │       │
└──────────┘      └─────────┘  │       │
    │              │    │      │       │
    └──┬──┬────┬───┘    │      │       │
       │  │    │        ▼      ▼       │
       │  │    │    ┌────────────┐     │
       │  │    │    │Vote Forms  │     │
       │  │    │    │(Election)  │     │
       │  │    │    └────────────┘     │
       │  │    │         │             │
       │  │    └─────────┼─────────────┼───────┐
       │  │              │             │       │
       │  │    ┌─────────┴────────┐    │       │
       │  │    ▼                  ▼    │       │
       │  │  ┌──────────────┐  ┌──────────────┐
       │  │  │ Reports      │  │Crystal      │
       │  │  │ (.rpt files) │  │Reports      │
       │  │  └──────────────┘  │Engine       │
       │  │                    └──────────────┘
       │  └────────────┐
       │               ▼
       │    ┌─────────────────────┐
       │    │   DAL Class         │
       │    │ (BenlyDAL.BenlyDAL) │
       │    └─────────────────────┘
       │               │
       └───────────────┼────────────────────┐
                       │                    │
                       ▼                    ▼
            ┌──────────────────┐  ┌──────────────────┐
            │  SQL Procedures  │  │  SQL Database    │
            │  (Stored Procs)  │  │  (DHCD)          │
            │  - Meetings_*    │  │  Server:         │
            │  - Holders_*     │  │  10.68.10.101    │
            │  - Delegates_*   │  │  User: sa        │
            │  - Elections_*   │  │  Port: 1433      │
            │  - Candidates_*  │  └──────────────────┘
            │  - Votes_*       │
            └──────────────────┘
```

---

## 📁 Project Structure

### **Solution: DHCD-NewAPG**

```
DHCD-NewAPG/
├── FormUI/
│   ├── FormUI.csproj              (Main UI Project)
│   ├── app.config                 (Configuration)
│   ├── packages.config            (NuGet Packages)
│   │
│   ├── Mainform.cs                (Main Application Window)
│   ├── Mainform.Designer.cs
│   ├── Mainform.resx
│   │
│   ├── Meeting/                   (Meeting Management)
│   │   ├── MeetingList.cs
│   │   ├── MeetingInfoshow.cs
│   │   ├── Meeting_ins_update.cs
│   │   ├── HolderList.cs
│   │   ├── HolderListForSelect.cs
│   │   ├── Holder_ins_update.cs
│   │   ├── DelegateList.cs
│   │   ├── DelegateListForSelect.cs
│   │   ├── Delegate_ins.cs
│   │   ├── DelegateUpdate.cs
│   │   ├── AuthorizationList.cs
│   │   ├── AuthorizationListForSelect.cs
│   │   ├── AuthorizationsInsert.cs
│   │   ├── AuthorizationUpdate.cs
│   │   ├── CandidateList.cs
│   │   ├── Candidates_ins_update.cs
│   │   └── PrintHolders.cs
│   │
│   ├── Vote/                      (Voting & Elections)
│   │   ├── MatterList.cs
│   │   ├── Matter_ins_update.cs
│   │   ├── MatterVoteList.cs
│   │   ├── Mattervote_ins_update.cs
│   │   ├── MatterVoteResult.cs
│   │   ├── MatterVotes_ins_remain.cs
│   │   ├── ElectionList.cs
│   │   ├── election_ins_update.cs
│   │   ├── CandidateList.cs
│   │   ├── Elections_result.cs
│   │   ├── ElectionVoteList.cs
│   │   ├── Electionvote_ins_update.cs
│   │   ├── IllegalElectionList.cs
│   │   └── Sentate.cs
│   │
│   ├── Report/                    (Reporting)
│   │   ├── frmReport.cs
│   │   ├── ReportViewer.cs
│   │   ├── ThongTinCuocHop.cs
│   │   ├── thebieuquyet.cs
│   │   ├── thebieuquyet_2.cs
│   │   ├── phieubauBKS.cs
│   │   ├── phieubauHDQT.cs
│   │   ├── phieubieuquyet1.cs
│   │   └── PhieuXacNhan.cs
│   │
│   ├── Report/                    (Crystal Reports)
│   │   ├── phieubauBKS.rpt
│   │   ├── phieubauHDQT.rpt
│   │   ├── phieubieuquyet1.rpt
│   │   ├── PhieuXacNhan.rpt
│   │   ├── thebieuquyet.rpt
│   │   ├── thebieuquyet_2.rpt
│   │   └── ThongTinCuocHop.rpt
│   │
│   ├── My Project/
│   │   ├── AssemblyInfo.cs
│   │   ├── Application.Designer.cs
│   │   ├── Settings.Designer.cs
│   │   ├── MyNamespace.Dynamic.Designer.cs
│   │   └── MyNamespace.Static.1.Designer.cs
│   │
│   ├── Resources.Designer.cs
│   ├── clsCommon.cs              (Common Utilities)
│   ├── DSReportSouce.cs          (Data Source for Reports)
│   ├── obj/                      (Build Output)
│   ├── bin/                      (Compiled Output)
│   └── lib/                      (Local Dependencies)
│
├── DAL/                           (Data Access Layer)
│   ├── DAL.csproj
│   ├── DAL.cs                    (Main Data Access Class)
│   ├── My Project/
│   ├── obj/
│   └── bin/
│
└── packages.config               (Solution-level NuGet)
```

---

## 🛠️ Technology Stack

| Component | Technology | Version |
|-----------|-----------|---------|
| **Framework** | .NET Framework | 4.8 |
| **Language** | C# & VB.NET | Latest |
| **UI Framework** | Windows Forms | Built-in |
| **Database** | SQL Server | 2008+ |
| **Reporting** | Crystal Reports | 13.0 |
| **ORM** | ADO.NET (Direct) | - |
| **Package Manager** | NuGet | - |

### **Key NuGet Packages**
- `Crystal.Reports.Essentials` v13.0.2000.0
- `CrystalDecisions.Windows.Forms` v1.0.0

---

## 🗄️ Database Configuration

### **Connection String**
```
Server: 10.68.10.101
Database: DHCD
Authentication: SQL Server (User/Pass)
User: sa
Password: Phap@1234
Application: dhcd
Port: 1433 (Default)
```

### **Configuration Location**
File: `FormUI\app.config`

```xml
<connectionStrings>
    <add name="connDBstr" 
         connectionString="server=10.68.10.101;Database=DHCD;Trusted_Connection=false;uid=sa;pwd=Phap@1234;application name=dhcd"/>
</connectionStrings>
```

---

## 📊 Module Functionality

### **1. MEETING MODULE** 📋
**Location**: `FormUI\Meeting\`

| Form | Purpose |
|------|---------|
| **MeetingList** | View all shareholder meetings |
| **MeetingInfoshow** | Display meeting details |
| **Meeting_ins_update** | Create/Update meeting information |

**Database Procedures**:
- `Meetings_getlist` - Retrieve meetings
- `Meetings_insert` - Create new meeting
- `Meetings_update` - Update meeting details

---

### **2. SHAREHOLDER MODULE** 👥
**Location**: `FormUI\Meeting\`

| Form | Purpose |
|------|---------|
| **HolderList** | Display all shareholders |
| **HolderListForSelect** | Select shareholders for operations |
| **Holder_ins_update** | Add/Edit shareholder information |

**Database Procedures**:
- `Holders_getlist` - Get shareholder list
- `Holders_insert` - Add new shareholder
- `Holders_update` - Update shareholder

---

### **3. DELEGATE MODULE** 👔
**Location**: `FormUI\Meeting\`

| Form | Purpose |
|------|---------|
| **DelegateList** | List of meeting delegates |
| **DelegateListForSelect** | Select delegates |
| **Delegate_ins** | Add delegate information |
| **DelegateUpdate** | Update delegate details |

**Database Procedures**:
- `Delegates_getlist` - Get delegate list
- `Delegates_insert` - Add delegate
- `Delegates_update` - Update delegate

---

### **4. AUTHORIZATION MODULE** 🔐
**Location**: `FormUI\Meeting\`

| Form | Purpose |
|------|---------|
| **AuthorizationList** | List proxy authorizations |
| **AuthorizationListForSelect** | Select authorizations |
| **AuthorizationsInsert** | Create new authorization |
| **AuthorizationUpdate** | Modify authorization |

**Database Procedures**:
- `Authorizations_*` - Authorization management

---

### **5. VOTING MODULE** 🗳️
**Location**: `FormUI\Vote\`

| Form | Purpose |
|------|---------|
| **MatterList** | List all voting matters |
| **Matter_ins_update** | Create/Edit voting matter |
| **MatterVoteList** | Record votes on matters |
| **Mattervote_ins_update** | Add/Update matter votes |
| **MatterVoteResult** | Display voting results |
| **MatterVotes_ins_remain** | Handle remaining votes |

**Database Procedures**:
- `Matters_*` - Matter management
- `MatterVotes_*` - Vote recording

---

### **6. ELECTION MODULE** 🏆
**Location**: `FormUI\Vote\`

| Form | Purpose |
|------|---------|
| **ElectionList** | List all elections |
| **election_ins_update** | Create/Edit election |
| **CandidateList** | Candidate listing |
| **Candidates_ins_update** | Add/Edit candidates |
| **Elections_result** | Election results |
| **ElectionVoteList** | Record election votes |
| **Electionvote_ins_update** | Update election votes |
| **IllegalElectionList** | Invalid/Spoiled ballots |

**Database Procedures**:
- `Elections_*` - Election management
- `Candidates_*` - Candidate management
- `ElectionVotes_*` - Vote management

---

### **7. REPORTING MODULE** 📄
**Location**: `FormUI\Report\`

| Form | Purpose |
|------|---------|
| **frmReport** | Report viewer & generator |
| **ReportViewer** | Crystal Reports viewer |

**Available Reports** (.rpt files):
1. **ThongTinCuocHop.rpt** - Meeting Information Report
2. **thebieuquyet.rpt** - Voting Results Report
3. **thebieuquyet_2.rpt** - Detailed Voting Report
4. **phieubauBKS.rpt** - Ballot - Supervisory Board
5. **phieubauHDQT.rpt** - Ballot - Management Board
6. **phieubieuquyet1.rpt** - Voting Ballot
7. **PhieuXacNhan.rpt** - Confirmation Slip

---

## 🔄 Data Flow

### **Typical Application Flow**

```
1. USER STARTS APPLICATION
   ↓
2. Mainform_Load()
   - Initialize UI
   - Set Vietnamese Culture
   ↓
3. Mainform_Shown()
   - Connect to Database
   - Load MeetingList Form
   ↓
4. USER SELECTS MENU ITEM
   - Meeting Management
   - Holder Management
   - Delegate Management
   - Voting/Elections
   - Reports
   ↓
5. FORM OPENS
   - Load data from DAL
   ↓
6. DAL.Method(parameters)
   - Execute SQL Stored Procedure
   - Fill DataTable
   - Return to Form
   ↓
7. FORM DISPLAYS DATA
   - Bind to DataGridView
   - Show in UI
   ↓
8. USER PERFORMS ACTION (Create/Read/Update/Delete)
   ↓
9. FORM CALLS DAL METHOD
   - DAL.insert_*()
   - DAL.update_*()
   - DAL.delete_*()
   ↓
10. DATABASE UPDATED
    ↓
11. REFRESH GRID/DISPLAY
```

---

## 📂 Key Components

### **DAL Class (BenlyDAL.BenlyDAL)**
**File**: `DAL\DAL.cs`

**Main Methods**:
```csharp
// Meeting Operations
public DataTable Meeting_getlist(string meetingcode)
public void meeting_insert(...)
public void meeting_update(...)

// Voting Operations
public DataTable GetVoteSenate(string senateName)

// Generic SQL Execution
SqlCommand cmd = new SqlCommand(storedProcName, conn);
cmd.CommandType = CommandType.StoredProcedure;
```

### **Mainform Class**
**File**: `FormUI\Mainform.cs`

**Key Properties**:
- `SqlConnection conn` - Database connection
- `DAL BenlyDal` - Data access layer instance
- `workingmeeting` - Current active meeting
- `period` - Meeting period (e.g., "2022 – 2026")
- `mettingType` - Type of meeting (e.g., "thường niên")
- `stockCode` - Stock code (e.g., "APG")
- `companyName` - Company name
- `dateMeeting` - Meeting date

**Key Methods**:
- `Mainform_Load()` - Initialize
- `Mainform_Shown()` - Show on startup
- `connect2db()` - Database connection
- `GetConnectionString()` - Get connection string
- Menu handlers for all modules

---

## 📦 Dependencies

### **Framework References**
- `System`
- `System.Data`
- `System.Configuration`
- `System.Windows.Forms`
- `System.Drawing`
- `System.Web`
- `System.Xml`
- `Microsoft.VisualBasic`

### **Crystal Reports References**
- `CrystalDecisions.CrystalReports.Engine` v13.0.4000.0
- `CrystalDecisions.CrystalReports.Design` v13.0.4000.0
- `CrystalDecisions.Windows.Forms` v13.0.4000.0
- `CrystalDecisions.Shared` v13.0.4000.0
- `CrystalDecisions.ReportSource` v13.0.4000.0
- `CrystalDecisions.Enterprise.*` v13.0.4000.0

### **Custom References**
- `Lapas.Common.dll` v1.1.1.0 (Common utilities)

---

## 🔌 SQL Stored Procedures Summary

| Procedure | Type | Purpose |
|-----------|------|---------|
| `Meetings_getlist` | SELECT | Get meeting list |
| `Meetings_insert` | INSERT | Create meeting |
| `Meetings_update` | UPDATE | Update meeting |
| `Meetings_delete` | DELETE | Remove meeting |
| `Holders_*` | CRUD | Shareholder management |
| `Delegates_*` | CRUD | Delegate management |
| `Elections_*` | CRUD | Election management |
| `Candidates_*` | CRUD | Candidate management |
| `Matters_*` | CRUD | Matter/Issue management |
| `Votes_*` | CRUD | Vote recording |
| `Authorizations_*` | CRUD | Proxy authorization |

---

## 🚀 Application Startup Sequence

1. **Program Start** → `My.MyApplication` initialization
2. **Mainform Constructor** → Initialize DAL with connection
3. **Mainform_Load** → Set Vietnamese culture
4. **Mainform_Shown** → Connect to DB, open MeetingList
5. **User Interaction** → Select menu items, open forms
6. **Form Operations** → CRUD via DAL → SQL Procedures

---

## 📝 Configuration & Settings

| Setting | Value |
|---------|-------|
| **Database Server** | 10.68.10.101 |
| **Database Name** | DHCD |
| **Language** | Vietnamese (vi-VN) |
| **Framework** | .NET Framework 4.8 |
| **Application Name** | pmDHCD |
| **Company** | APG (Chứng khoán APG) |
| **Report Format** | Crystal Reports (.rpt) |

---

## 🎯 Summary

**DHCD-NewAPG** is a professional **Shareholder Meeting Management System** built with:
- **3-Tier Architecture**: Presentation (FormUI) → Business Logic (Mainform) → Data Access (DAL)
- **Windows Forms** for rich desktop experience
- **SQL Server** for reliable data storage
- **Crystal Reports** for professional reporting
- **Vietnamese Localization** for local market

The system provides comprehensive functionality for managing all aspects of shareholder meetings including meeting planning, participant management, voting processes, election management, and professional reporting.

---

**Document Version**: 1.0  
**Last Updated**: 2024  
**Status**: Active Development
