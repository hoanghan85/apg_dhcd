# Khảo sát cơ sở dữ liệu legacy DHCD

**Ngày khảo sát:** 22/06/2026  
**Nguồn:** SQL Server local, database `DHCD`  
**Phạm vi:** Đọc metadata và định nghĩa SQL; không thay đổi dữ liệu  
**Trạng thái:** Khảo sát sơ bộ

## 1. Tổng quan

Database hiện có:

- 17 user table, trong đó có `sysdiagrams` và bốn bảng dữ liệu trung gian `APGHolder*`.
- 72 stored procedure, bao gồm các procedure hệ thống phục vụ database diagram.
- 8 view nghiệp vụ.
- Không có foreign key nghiệp vụ.
- Không có check constraint nghiệp vụ.
- Primary key chủ yếu là khóa ghép từ mã cuộc họp và mã nghiệp vụ.

Business logic hiện thực sự nằm ở cả ba nơi:

1. Windows Forms.
2. `DAL/DAL.cs`.
3. Stored procedure và view trong SQL Server.

Do đó, khi chuyển đổi không được chỉ thay stored procedure bằng CRUD repository. Quy tắc phải được nhận diện và chuyển sang application/domain service có test.

## 2. Bảng nghiệp vụ chính

| Bảng legacy | Số dòng hiện tại | Vai trò |
|---|---:|---|
| `Meetings` | 3 | Cuộc họp |
| `Holders` | 19 | Snapshot cổ đông theo cuộc họp |
| `Delegates` | 3 | Đại biểu |
| `Authorizations` | 6 | Phân bổ quyền từ cổ đông cho đại biểu |
| `Matters` | 32 | Vấn đề biểu quyết |
| `MatterVotes` | 41 | Phiếu biểu quyết theo đại biểu |
| `Elections` | 2 | Kỳ bầu cử |
| `Candidates` | 8 | Ứng viên |
| `ElectionVotes` | 1 | Phiếu phân bổ cho ứng viên |
| `IllegalElectionVotes` | 0 | Phiếu bầu không hợp lệ |
| `VoteCards` | 6 | Số liệu thẻ biểu quyết nhập bổ sung |
| `HoldersImport` | 5.671 | Bảng nhập cổ đông |
| `APGHolder` | 5.383 | Dữ liệu nguồn/trung gian |
| `APGHolder2` | 4.299 | Dữ liệu nguồn/trung gian |
| `APGHolder3` | 77 | Dữ liệu nguồn/trung gian |
| `APGHolder4` | 3.903 | Dữ liệu nguồn/trung gian |

## 3. Khóa hiện tại

Các khóa chính nghiệp vụ:

- `Meetings(Meetingcode)`.
- `Holders(Holdercode, Meetingcode)`.
- `Delegates(Meetingcode, Delegatecode)`.
- `Authorizations(Meetingcode, DelegateCode, Holdercode)`.
- `Matters(MeetingCode, Mattercode)`.
- `MatterVotes(Meetingcode, Mattercode, DelegateCode)`.
- `Elections(Meetingcode, Electioncode)`.
- `Candidates(Meetingcode, Electioncode, CandidateCode)`.
- `ElectionVotes(Meetingcode, ElectionCode, CandidateCode, DelegateCode)`.
- `IllegalElectionVotes(Meetingcode, ElectionCode, DelegateCode)`.
- `VoteCards(MeetingCode, MatterCode)`.

Database không khai báo foreign key giữa các bảng trên. Tính toàn vẹn quan hệ hiện dựa vào procedure và cách ứng dụng gọi.

## 4. Logic quan trọng đang nằm trong stored procedure

### 4.1. Ủy quyền

`Authorizations_Insert` và `Authorizations_update`:

- Lấy tổng quyền biểu quyết của cổ đông.
- Tính tổng quyền đã phân bổ cho các đại biểu.
- Không cho tổng quyền ủy quyền vượt quyền của cổ đông.
- Không cho tạo trùng cùng tổ hợp cổ đông/đại biểu/cuộc họp.

`Holders_GetRemainingVoterights`:

- Quyền còn lại = quyền cổ đông - tổng quyền đã ủy quyền.

Logic này phải chuyển sang `ProxyAuthorizationService`, thực hiện trong transaction và khóa record cổ đông để tránh hai request đồng thời cùng vượt quyền.

### 4.2. Tạo đại biểu

`Delegates_insert`:

- Không cho trùng số định danh trong cùng cuộc họp.
- Cảnh báo khi cổ đông đã ủy quyền một phần nhưng tiếp tục đăng ký tham dự.
- Sinh `DelegateCode` bằng `MAX(DelegateCode) + 1`.

`MAX + 1` không an toàn khi nhiều người tạo đại biểu đồng thời. PostgreSQL target nên dùng sequence/identity cho số thứ tự hoặc một bộ cấp mã có khóa.

### 4.3. Phiếu biểu quyết

`Mattervotes_Insert`:

- Không cho nhập trùng phiếu theo vấn đề/đại biểu.
- Kiểm tra vấn đề tồn tại.
- Lưu bốn cột boolean `Agree`, `DisAgree`, `NoIdea`, `Illegal`.

`Mattervotes_Insert_remain`:

- Tạo cùng một lựa chọn cho tất cả đại biểu chưa có phiếu.

`matters_VoteInfor_get`:

- Đếm tổng đại biểu, số phiếu đã nhập, số còn lại.
- Đếm số đại biểu theo từng lựa chọn.

Database hiện không có constraint buộc đúng một trong bốn boolean được chọn. Target nên dùng một enum `choice`.

### 4.4. Phiếu bầu cử

`Electionvotes_Insert`:

- Không cho một phiếu vừa hợp lệ vừa không hợp lệ.
- Kiểm tra election và candidate tồn tại.
- Tính số phiếu tối đa bằng:

```text
tổng quyền đại biểu từ Authorizations × số lượng ứng viên được bầu
```

- Không cho tổng phân bổ vượt số phiếu tối đa.

Quy tắc này phải chuyển vào `ElectionBallotService` và ghi toàn bộ allocation trong một transaction.

### 4.5. Tổng hợp tham dự

`Meetings_VoteInfor_get`:

- Tổng cổ đông.
- Tổng cổ phần gồm `Shares + NotVSD`.
- Tổng quyền biểu quyết.
- Tổng đại biểu.
- Số cổ đông trực tiếp tham dự.
- Số cổ đông ủy quyền nhưng không trực tiếp tham dự.
- Tổng quyền tham dự lấy từ `SUM(Authorizations.DelegateRight)`.

Cần xác nhận rõ mô hình hiện tại: quyền trực tiếp của đại biểu dường như cũng được biểu diễn bằng một authorization “tự ủy quyền”.

`SP_Delegates_CheckAttendanceType` phân loại:

- Tham dự trực tiếp nếu authorization trỏ từ chính holder của delegate.
- Tham dự theo ủy quyền nếu nhận quyền từ holder khác.

## 5. View và procedure báo cáo

Các view nghiệp vụ:

- `vw_MeetingSummary`.
- `vw_MatterVoteDetail`.
- `vw_MatterVoteSummary`.
- `vw_MatterResult`.
- `vw_MatterResultSummary`.
- `vw_ElectionBallotSummary`.
- `vw_ElectionCandidateSummary`.
- `vw_ElectedCandidates`.

Các procedure báo cáo nổi bật:

- `RP_Authorizations_List`.
- `RP_Participation_Summary`.
- `RP_Vote_Report`.
- `RP_Election_Report`.
- `PRP_Meeting_Summary`.
- `PRP_Matters_List`.
- `PRP_Matter_Result_Summary`.
- `PRP_Election_Ballot_Summary`.
- `PRP_Election_Candidate_Summary`.
- `PRP_Vote_Summary`.
- `PRP_VoteCards_Summary`.

Các object này cần được phân loại thành:

- Query service cho màn hình.
- Report query cho template.
- Công thức domain phải có test.
- Dữ liệu tổng hợp có thể tính lại, không nhất thiết tạo table.

## 6. Vấn đề chất lượng schema

### 6.1. Không có foreign key

Database có thể chứa record mồ côi, ví dụ:

- Vote trỏ tới delegate không tồn tại.
- Candidate trỏ tới election không tồn tại.
- Authorization trỏ tới holder không tồn tại.

Cần chạy data quality query trước migration.

### 6.2. Không có check constraint

Chưa có bảo vệ database cho:

- Quyền/cổ phần không âm.
- Vote allocation không âm.
- Chỉ một lựa chọn biểu quyết.
- Tỷ lệ thông qua nằm trong khoảng hợp lệ.
- Số ghế bầu cử lớn hơn 0.

### 6.3. Kiểu dữ liệu không nhất quán

- `Meetingcode` có độ dài 10, 20 hoặc 50 tùy bảng/procedure.
- `DelegateCode` là `int` ở bảng đại biểu nhưng `varchar(10)` tại `MatterVotes`.
- `Holdercode` là `varchar` ở bảng chính nhưng `bigint` tại `HoldersImport`.
- `IdentityDate` là chuỗi.
- Các bảng nguồn dùng `float` cho số cổ phần.
- Procedure insert/update cổ đông không thống nhất `bigint` và `int`.

### 6.4. Thiếu audit và trạng thái

Các bảng chưa có:

- `created_at`, `created_by`.
- `updated_at`, `updated_by`.
- Version concurrency.
- Trạng thái mở/đóng/khóa sổ.
- Lý do sửa/hủy.

### 6.5. Race condition

Các procedure hiện thực hiện “đọc tổng rồi ghi” nhưng không thấy transaction/locking rõ ràng:

- Phân bổ quyền ủy quyền.
- Sinh mã đại biểu bằng `MAX + 1`.
- Cộng dồn phiếu bầu.

Khi chuyển thành web nhiều người dùng, đây là rủi ro bắt buộc xử lý.

## 7. Mapping trách nhiệm sang backend mới

| Logic legacy | Thành phần mới |
|---|---|
| CRUD đơn giản | Repository |
| Kiểm tra quyền còn lại | `ProxyAuthorizationService` |
| Tạo và cấp mã đại biểu | `DelegateRegistrationService` |
| Nhập/chỉnh phiếu biểu quyết | `MatterBallotService` |
| Batch phiếu còn lại | `MatterBallotBatchService` |
| Nhập phiếu bầu cử | `ElectionBallotService` |
| Tính kết quả | Domain calculator/query service |
| Tổng hợp tham dự | Attendance query service |
| Query báo cáo | Reporting query service |
| Foreign key/unique/check | PostgreSQL constraints |
| Lịch sử thay đổi | Audit service/table |

## 8. Kết luận sơ bộ

Database local đã đọc được đầy đủ qua SQL authentication.

Kết quả khảo sát xác nhận quyết định kiến trúc:

- Chuyển business rule khỏi stored procedure.
- Không đặt business rule trong CRUD controller/repository.
- Đưa rule vào application/domain service.
- Giữ PostgreSQL constraint và transaction như hàng rào cuối.
- Viết regression test từ công thức của stored procedure trước khi thay thế.

Bước tiếp theo là trích xuất toàn bộ định nghĩa 72 procedure và 8 view, lập ma trận `legacy object -> use case/API/table target`, sau đó chạy data-quality query để phát hiện dữ liệu mồ côi và sai quy tắc trước migration.
