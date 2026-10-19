-- Script khởi tạo CSDL QL_ChiTieu cho bài tập WinForms Sổ chi tiêu cá nhân
USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'QL_ChiTieu')
BEGIN
    CREATE DATABASE QL_ChiTieu;
END
GO

USE QL_ChiTieu;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ChiTieu')
BEGIN
    CREATE TABLE ChiTieu (
        MaCT INT IDENTITY(1,1) PRIMARY KEY,
        NgayChi DATE NOT NULL,
        NoiDung NVARCHAR(100) NOT NULL,
        LoaiChi NVARCHAR(30) NOT NULL,
        SoTien DECIMAL(18,0) NOT NULL,
        GhiChu NVARCHAR(200) NULL
    );
END
GO

-- Nhập dữ liệu mẫu (nếu bảng chưa có dữ liệu)
IF (SELECT COUNT(*) FROM ChiTieu) = 0
BEGIN
    INSERT INTO ChiTieu (NgayChi, NoiDung, LoaiChi, SoTien, GhiChu) VALUES
    ('2026-10-01', N'Cơm trưa', N'Ăn uống', 35000, N'Cơm văn phòng'),
    ('2026-10-02', N'Xăng xe', N'Di chuyển', 60000, N'Đổ xăng xe máy'),
    ('2026-10-03', N'Photo giáo trình', N'Học tập', 25000, N'Tài liệu C#'),
    ('2026-10-04', N'Xem phim', N'Giải trí', 90000, N'Vé xem phim rạp'),
    ('2026-10-05', N'Trà sữa', N'Ăn uống', 40000, N'Uống cùng đồng nghiệp'),
    ('2026-10-06', N'Mua sắm', N'Cá nhân', 150000, N'Đồ dùng sinh hoạt'),
    ('2026-10-07', N'Tiền điện', N'Hóa đơn', 500000, N'Tiền điện tháng 9'),
    ('2026-10-08', N'Ăn sáng', N'Ăn uống', 25000, N'Bánh mì chả'),
    ('2026-10-09', N'Mua sách tham khảo', N'Học tập', 120000, N'Sách lập trình .NET'),
    ('2026-10-10', N'Cà phê với bạn', N'Ăn uống', 45000, N'Gặp bạn đại học'),
    ('2026-10-11', N'Rửa xe', N'Di chuyển', 30000, N'Rửa xe máy'),
    ('2026-10-12', N'Cước internet', N'Hóa đơn', 220000, N'Internet FPT'),
    ('2026-10-13', N'Mua áo thun', N'Cá nhân', 180000, N'Mua online'),
    ('2026-10-14', N'Xem kịch', N'Giải trí', 150000, N'Vé kịch sân khấu'),
    ('2026-10-15', N'Bút và sổ tay', N'Học tập', 35000, N'Dụng cụ học tập');
END
GO
