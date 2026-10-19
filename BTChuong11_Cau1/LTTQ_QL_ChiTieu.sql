CREATE DATABASE QL_ChiTieu;
GO

USE QL_ChiTieu;
GO

CREATE TABLE ChiTieu
(
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    NgayChi DATE NOT NULL,
    NoiDung NVARCHAR(100) NOT NULL,
    LoaiChi NVARCHAR(30) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    GhiChu NVARCHAR(200) NULL
);
GO

INSERT INTO ChiTieu (NgayChi, NoiDung, LoaiChi, SoTien, GhiChu)
VALUES
('2026-10-01', N'Tiền ăn sáng', N'Ăn uống', 30000, N'Ăn sáng'),
('2026-10-02', N'Mua cơm trưa', N'Ăn uống', 50000, N'Ăn trưa'),
('2026-10-03', N'Đổ xăng xe', N'Đi lại', 100000, N'Đổ xăng'),
('2026-10-04', N'Mua sách giáo trình', N'Học tập', 150000, N'Sách môn Cơ sở dữ liệu'),
('2026-10-05', N'Tiền điện thoại', N'Điện thoại', 70000, NULL),
('2026-10-06', N'Mua nước uống', N'Ăn uống', 20000, NULL),
('2026-10-07', N'Gửi xe', N'Đi lại', 10000, N'Gửi xe tại trường'),
('2026-10-08', N'Mua bút', N'Học tập', 15000, N'Bút bi'),
('2026-10-09', N'Ăn tối', N'Ăn uống', 60000, NULL),
('2026-10-10', N'Mua áo', N'Mua sắm', 250000, N'Áo thun'),
('2026-10-11', N'Tiền Internet', N'Sinh hoạt', 200000, N'Tiền Internet tháng 10'),
('2026-10-12', N'Mua vở', N'Học tập', 30000, N'Vở ghi bài'),
('2026-10-13', N'Đổ xăng xe', N'Đi lại', 80000, NULL),
('2026-10-14', N'Uống cà phê', N'Ăn uống', 40000, N'Đi cà phê với bạn'),
('2026-10-15', N'Mua thuốc', N'Sinh hoạt', 120000, NULL);
GO

SELECT * FROM ChiTieu;
GO