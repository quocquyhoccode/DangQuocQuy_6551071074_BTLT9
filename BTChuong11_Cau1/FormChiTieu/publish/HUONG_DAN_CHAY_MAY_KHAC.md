# HƯỚNG DẪN CHẠY ỨNG DỤNG "SỔ CHI TIÊU CÁ NHÂN" TRÊN MÁY KHÁC

Ứng dụng đã được đóng gói hoàn chỉnh dưới dạng **Framework-Dependent (win-x64)**. Khi sao chép sang laptop hoặc máy tính khác, bạn **hoàn toàn không cần cài đặt Visual Studio hay build lại code**.

---

### BƯỚC 1: YÊU CẦU MÔI TRƯỜNG TRÊN MÁY MỚI
1. **.NET Desktop Runtime**:
   - Cài đặt **.NET Desktop Runtime 10.0 (x64)** (hoặc runtime phù hợp với máy tính).
   - Tải chính thức từ Microsoft: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. **Cơ sở dữ liệu (SQL Server)**:
   - Máy cần có **SQL Server** (SQL Express, LocalDB hoặc SQL Server bản Standard/Developer).

---

### BƯỚC 2: KHỞI TẠO CƠ SỞ DỮ LIỆU
1. Mở **SQL Server Management Studio (SSMS)** hoặc **Azure Data Studio** trên máy mới.
2. Mở file [script_db.sql](script_db.sql) có sẵn trong thư mục này.
3. Bấm **Execute** để tự động tạo CSDL `QL_ChiTieu`, bảng `ChiTieu` và nạp sẵn 15 dòng dữ liệu mẫu (Ăn uống, Di chuyển, Học tập, Giải trí...).

---

### BƯỚC 3: CẤU HÌNH KẾT NỐI (appsettings.json)
Mở file [appsettings.json](appsettings.json) bằng Notepad và chỉnh sửa tên Server cho đúng với máy mới:

- **Nếu dùng Windows Authentication (SQL Express mặc định)**:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=QL_ChiTieu;Integrated Security=True;TrustServerCertificate=True"
  }
}
```
- **Nếu dùng tài khoản sa (SQL Server Authentication)** (tham khảo thêm tại [appsettings.example.json](appsettings.example.json)):
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=QL_ChiTieu;User Id=sa;Password=MatKhauCuaBan;TrustServerCertificate=True"
  }
}
```

---

### BƯỚC 4: CHẠY ỨNG DỤNG
1. Nháy đúp vào file `FormChiTieu.exe` để khởi chạy ứng dụng.
2. Kiểm tra các chức năng:
   - Xem danh sách chi tiêu và nhãn **Tổng chi** màu đỏ ở góc dưới.
   - Thêm khoản chi mới, sửa hoặc xóa khoản chi (có hộp thoại xác nhận).
   - Tra cứu / lọc theo nội dung, loại chi ("Ăn uống", "Học tập"...), hoặc theo khoảng "Từ ngày - Đến ngày".
   - Mở thư mục `Logs/` bên cạnh file `.exe` để xem file log hoạt động dạng `log-yyyyMMdd.txt`.
