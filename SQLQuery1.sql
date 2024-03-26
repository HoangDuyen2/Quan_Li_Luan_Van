
GO
CREATE TABLE GiangVien (
    MaGV VARCHAR(8) PRIMARY KEY,
    TenGV NVARCHAR(255) NOT NULL,
    GioiTinh NVARCHAR(3),
    DiaChi NVARCHAR(255),
    CCCD VARCHAR(12) UNIQUE,
    NgaySinh DATE,
    SDT VARCHAR(11) UNIQUE,
    Email VARCHAR(255) UNIQUE
);

GO
CREATE TABLE SinhVien (
    MSSV VARCHAR(8) PRIMARY KEY,
    TenSV NVARCHAR(255) NOT NULL,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    CCCD VARCHAR(12) UNIQUE,
    NgaySinh DATE,
    SDT VARCHAR(11) UNIQUE,
    Email VARCHAR(255) UNIQUE,
);

GO
CREATE TABLE TaiKhoan (
    Username VARCHAR(8) PRIMARY KEY,
    Pass VARCHAR(100),
    ChucVu NVARCHAR(50)
);

GO
CREATE TABLE LuanVan (
    MaLV VARCHAR(5) PRIMARY KEY,
    TenLV NVARCHAR(255),
    MaGV VARCHAR(8),
    ChuyenNganh NVARCHAR(255),
    LinhVuc NVARCHAR(255),
    ChucNang NVARCHAR(MAX),
    CongNghe VARCHAR(255),
    NgonNgu VARCHAR(255),
    YeuCau NVARCHAR(MAX),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaGV) REFERENCES GiangVien(MaGV),
);

CREATE TABLE DSThanhVien (
	MaLV VARCHAR(5) PRIMARY KEY,
	MSSV1 VARCHAR(8) FOREIGN KEY REFERENCES SinhVien(MSSV),
	MSSV2 VARCHAR(8) FOREIGN KEY REFERENCES SinhVien(MSSV),
	MSSV3 VARCHAR(8) FOREIGN KEY REFERENCES SinhVien(MSSV),
	FOREIGN KEY (MaLV) REFERENCES LuanVan(MaLV)
)

create table DuyetDangKy(
	MaLV VARCHAR(5) PRIMARY KEY,
	MSSV1 VARCHAR(8) FOREIGN KEY REFERENCES SinhVien(MSSV),
	MSSV2 VARCHAR(8) FOREIGN KEY REFERENCES SinhVien(MSSV),
	MSSV3 VARCHAR(8) FOREIGN KEY REFERENCES SinhVien(MSSV),
	FOREIGN KEY (MaLV) REFERENCES LuanVan(MaLV)
)

GO
INSERT INTO GiangVien (MaGV, TenGV, GioiTinh, DiaChi, CCCD, NgaySinh, SDT, Email)
VALUES 
('GV001', N'Nguyễn Thủy An', N'Nữ', N'Hồ Chí Minh', '123456789012', '1978-03-15', '0901224567', 'nguyenthuyan@hcmute.edu.vn'),
('GV002', N'Nguyễn Minh Đạo', N'Nam', N'Hà Nội', '234567890123', '1982-06-20', '0987653321', 'nguyenminhdao@hcmute.edu.vn'),
('GV003', N'Nguyễn Thành Sơn', N'Nam', N'Đà Nẵng', '345678901234', '1975-12-10', '0123456789', 'nguyenthanhson@hcmute.edu.vn'),
('GV004', N'Nguyễn Quang Ngọc', N'Nam', N'Hồ Chí Minh', '456789012345', '1980-09-05', '0988654321', 'nguyenquangngoc@hcmute.edu.vn'),
('GV005', N'Đinh Công Đoan', N'Nam', N'Hồ Chí Minh', '567890123456', '1977-05-25', '0122456789', 'dinhcongdoan@hcmute.edu.vn'),
('GV006', N'Nguyễn Thị Thanh Vân', N'Nữ', N'Hồ Chí Minh', '678901234567', '1985-11-30', '0901238567', 'nguyenthithanhvan@hcmute.edu.vn');

GO
INSERT INTO SinhVien (MSSV, TenSV, GioiTinh, DiaChi, CCCD, NgaySinh, SDT, Email)
VALUES 
('22110271', N'Lê Đức Minh Vương', N'Nam', N'Bình Định', '123456709012', '2004-02-06', '0897679971', '22110271@student.hcmute.edu.vn'),
('22110217', N'Hàng Diễm Quỳnh', N'Nữ', N'Ninh Thuận', '234567800123', '2004-02-02', '0123456789', '22110217@student.hcmute.edu.vn'),
('22110260', N'Nguyễn Hà Hồng Tuấn', N'Nam', N'Bà Rịa Vũng Tàu', '345678901234', '2004-02-05', '0901234567', '22110260@student.hcmute.edu.vn'),
('22110121', N'Đỗ Thị Hoàng Duyên', N'Nữ', N'Hồ Chí Minh', '456789012345', '2004-01-10', '0987654311', '22110121@student.hcmute.edu.vn'),
('22110169', N'Lê Quốc Kiệt', N'Nam', N'Tây Ninh', '567890423456', '2004-03-18', '0909876593', '22110169@student.hcmute.edu.vn'),
('22110139', N'Trần Trung Hiếu', N'Nam', N'Bình Định', '678991234567', '2004-05-22', '0987654327', '22110139@student.hcmute.edu.vn'),
('22110247', N'Nguyễn Thanh Tính', N'Nam', N'Đồng Nai', '789012445678', '2004-06-28', '0901234587', '22110247@student.hcmute.edu.vn'),
('22110136', N'Nguyễn Thanh Hậu', N'Nam', N'Vĩnh Long', '890123656789', '2004-09-30', '0123456719', '22110136@student.hcmute.edu.vn'),
('22110107', N'Nguyễn Đình Bảo', N'Nam', N'Thanh Hóa', '901234597890', '2004-10-15', '0987654320', '22110107@student.hcmute.edu.vn'),
('22146367', N'Mai Công Phát', N'Nam', N'Hồ Chí Minh', '012345678901', '2003-11-20', '0901234507', '22146367@student.hcmute.edu.vn'),
('22110181', N'Nguyễn Đình Lợi', N'Nam', N'Bình Dương', '123656489012', '2004-08-05', '0123456769', '22110181@student.hcmute.edu.vn'),
('22110128', N'Cao Võ Tiến Đạt', N'Nam', N'Đồng Nai', '234567893123', '2004-12-12', '0987644321', '22110128@student.hcmute.edu.vn'),
('22110251', N'Nguyễn Nam Thùy Trinh', N'Nữ', N'Tây Ninh', '345478901234', '2004-01-01', '0901204567', '22110251@student.hcmute.edu.vn'),
('22110167', N'Đỗ Nguyễn Đăng Khoa', N'Nam', N'Gia Lai', '456749012345', '2004-04-23', '0123459789', '22110167@student.hcmute.edu.vn'),
('22110140', N'Hoàng Phi Hiệp', N'Nam', N'Lâm Đồng', '567890123456', '2004-09-07', '0987654621', '22110140@student.hcmute.edu.vn');

GO
INSERT INTO TaiKhoan (Username, Pass, ChucVu)
VALUES 
('GV001','123456',N'Giảng Viên'),
('22110271','123456',N'Sinh Viên'),
('22110121','123456',N'Sinh Viên'),
('22110217','123456',N'Sinh Viên'),
('22110260','123456',N'Sinh Viên');

GO
INSERT INTO LuanVan(MaLV, TenLV, MaGV, ChuyenNganh, LinhVuc, ChucNang, CongNghe, NgonNgu, YeuCau, TrangThai)
VALUES
('LV001',N'Thiết kế trình duyệt web','GV001',N'Phát triển phần mềm',N'Phát triển web',N'Các chức năng chính như trình duyệt web...vvv',N'Xamarin',N'Tùy chọn',
 N'Sinh viên hiểu và vận dụng được các CTDL thiết kế winform cơ bản',N'Chưa có nhóm'),
('LV002',N'Thiết kế ứng dụng di động','GV002',N'Phát triển phần mềm',N'Ứng dụng di động',N'Các chức năng chính của ứng dụng di động...vvv',N'React Native',N'Tùy chọn',
 N'Sinh viên hiểu và vận dụng được lập trình ứng dụng di động cơ bản',N'Chưa có nhóm'),
('LV003',N'Phân tích hệ thống thông tin','GV003',N'Hệ thống thông tin',N'Phân tích hệ thống',N'Các chức năng phân tích và thiết kế hệ thống thông tin...vvv',N'UML',N'Tùy chọn',
 N'Sinh viên hiểu và vận dụng được phân tích hệ thống thông tin cơ bản',N'Đã có nhóm'),
('LV004',N'Quản lý dự án phần mềm','GV004',N'Quản lý dự án',N'Phát triển phần mềm',N'Các chức năng quản lý dự án phần mềm...vvv',N'Agile',N'Tùy chọn',
 N'Sinh viên hiểu và vận dụng được quản lý dự án phần mềm cơ bản',N'Chưa có nhóm'),
('LV005',N'Phát triển ứng dụng AI','GV005',N'Khoa học máy tính',N'Ứng dụng trí tuệ nhân tạo',N'Các chức năng phát triển ứng dụng AI...vvv',N'Python',N'Tùy chọn',
 N'Sinh viên hiểu và vận dụng được phát triển ứng dụng trí tuệ nhân tạo cơ bản',N'Đã có nhóm')

GO
INSERT INTO DSThanhVien(MaLV, MSSV1, MSSV2, MSSV3)
VALUES
('LV003','22146367','22110167', NULL),
('LV005','22110136','22110140','22110107')

GO
INSERT INTO DuyetDangKy(MaLV, MSSV1, MSSV2, MSSV3)
VALUES
('LV001','22110271','22110217',null),
('LV004','22110260','22110128','22110139')