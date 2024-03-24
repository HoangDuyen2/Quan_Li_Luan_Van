GO
CREATE TABLE GiangVien(
	MaGV VARCHAR(10) PRIMARY KEY,
	TenGV NVARCHAR(255) NOT NULL,
	GioiTinh VARCHAR(10),
	DiaChi NVARCHAR(255),
	CCCD VARCHAR(12) UNIQUE,
	NgaySinh Date,
	SDT VARCHAR(11) UNIQUE,
	Email VARCHAR(255) UNIQUE
)

GO
CREATE TABLE LuanVan(
	MaLV VARCHAR(10) PRIMARY KEY,
    MaGV VARCHAR(10) FOREIGN KEY REFERENCES GiangVien(MaGV),
	TenLV NVARCHAR(255) NOT NULL,
	ChuyenNganh VARCHAR(255),
    LinhVuc NVARCHAR(255),
    ChucNang NVARCHAR(255),
	TrangThai VARCHAR(100),
	MoTaChiTiet NVARCHAR(MAX),
    TienTrinh int,
	SoLuongConLai int,
)

drop table LuanVan

GO
CREATE TABLE Nhom(
	MaNhom VARCHAR(10) PRIMARY KEY
)

drop table Nhom

GO
CREATE TABLE SinhVien (
    MSSV VARCHAR(10) PRIMARY KEY,
    TenSV NVARCHAR(255) NOT NULL,
    GioiTinh VARCHAR(10),
    DiaChi NVARCHAR(255),
    CCCD VARCHAR(12) UNIQUE,
    NgaySinh DATE,
    SDT VARCHAR(11) UNIQUE,
    Email VARCHAR(255) UNIQUE,
    MaLV VARCHAR(10),
    MaNhom VARCHAR(10),
    FOREIGN KEY (MaLV) REFERENCES LuanVan(MaLV),
    FOREIGN KEY (MaNhom) REFERENCES Nhom(MaNhom)
);

DROP TABLE SinhVien

CREATE TABLE TaiKhoan(
    Username VARCHAR(10) PRIMARY KEY,
    Pass VARCHAR(50),
    ChucVu NVARCHAR(50)
)

drop table GiangVien

GO
INSERT INTO GiangVien (MaGV, TenGV, GioiTinh, DiaChi, CCCD, NgaySinh, SDT, Email)
VALUES 
('GV001', N'Nguyễn Thủy An', 'Nữ', N'Hồ Chí Minh', '123456789012', '1978-03-15', '0901234567', 'nguyenthuyan@example.com'),
('GV002', N'Nguyễn Minh Đạo', 'Nam', N'Hà Nội', '234567890123', '1982-06-20', '0987654321', 'nguyenminhdao@example.com'),
('GV003', N'Nguyễn Thành Sơn', 'Nam', N'Đà Nẵng', '345678901234', '1975-12-10', '0123456789', 'nguyenthanhson@example.com')


GO
INSERT INTO LuanVan (MaLV, TenLV, BatDau, KetThuc, ChuyenNganh, MoTaChiTiet, SoLuongConLai, MaGV)
VALUES 
('LV001', N'Thiết kế Trình Duyệt Web', '2024-01-01', '2024-06-30', N'Công nghệ thông tin', N'Đề tài tập trung vào việc thiết kế và phát triển một trình duyệt web hiệu quả và thân thiện với người dùng.', 3, 'GV001'),
('LV002', N'Nghiên cứu xử lý ảnh số trong bệnh viện', '2024-02-01', '2024-07-31', N'Trí tuệ nhân tạo', N'Đề tài tập trung vào việc áp dụng các phương pháp và thuật toán xử lý ảnh số để hỗ trợ trong việc chẩn đoán và điều trị bệnh tật trong bệnh viện.', 3, 'GV002'),
('LV003', N'Hệ quản trị cơ sở dữ liệu cho quán trà sữa', '2024-03-01', '2024-08-31', N'Hệ quản trị cơ sở dữ liệu', N'Đề tài tập trung vào việc thiết kế và triển khai một hệ thống quản trị cơ sở dữ liệu hiệu quả cho việc quản lí quán trà sữa, bao gồm các tính năng như đặt hàng, quản lí khách hàng và tồn kho.', 3, 'GV003')


GO
INSERT INTO SinhVien (MSSV, TenSV, GioiTinh, DiaChi, CCCD, NgaySinh, SDT, Email, MaLV, MaNhom)
VALUES 
('22110001', N'Lê Nhật Nam', 'Nam', N'Hà Nội', '123456789012', '2000-01-01', '0987654321', 'lenhatnam@example.com', NULL, NULL),
('22110002', N'Nguyễn Minh Quang', 'Nam', N'Thành phố Hồ Chí Minh', '234567890123', '1999-02-02', '0123456789', 'nguyenminhquang@example.com', NULL, NULL),
('22110003', N'Trần Thị Thắm', 'Nữ', N'Đà Nẵng', '345678901234', '1998-03-03', '0901234567', 'tranthitham@example.com', NULL, NULL);



GO
INSERT INTO TaiKhoan (Username, Pass, ChucVu)
VALUES 
('22110001','123456',N'Sinh vien'),
('GV001','123456',N'Giang vien')


go
CREATE TRIGGER Trig_TaiKhoan_GV_SV
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    DECLARE @Username VARCHAR(10);
    DECLARE @ChucVu NVARCHAR(50);

    SELECT @Username = Username, @ChucVu = ChucVu FROM inserted;

    IF @ChucVu = N'Giảng viên'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM GiangVien WHERE MaGV = @Username)
        BEGIN
            RAISERROR ('Không tồn tại mã giảng viên tương ứng', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
    END
    ELSE
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM SinhVien WHERE MSSV = @Username)
        BEGIN
            RAISERROR ('Không tồn tại mã sinh viên tương ứng', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
    END
END

SELECT MaGV, TenGV, GioiTinh, DiaChi, CCCD, NgaySinh, SDT, Email
FROM GiangVien
WHERE MaGV = 'GV001'

SELECT *
FROM SinhVien
WHERE MSSV = '22110001'