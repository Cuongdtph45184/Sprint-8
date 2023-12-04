create database QLDiemSV;


--  Lệnh tạo bảng sinh viên: 

CREATE TABLE SinhVien (
    MaSv varchar(10) PRIMARY KEY,
    HoTen NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    Email NVARCHAR(255),
    Lop NVARCHAR(20),
    MaMh varchar(10) FOREIGN KEY REFERENCES MonHoc(MaMh),
	DiemTa FLOAT,
    DiemDuAn FLOAT,
    DiemIt FLOAT,
    DiemTb FLOAT
);

CREATE TABLE MonHoc (
    MaMh varchar(10) PRIMARY KEY,
    TenMh NVARCHAR(255),
);

-- Thêm dữ liệu vào bảng SinhVien
INSERT INTO SinhVien 
VALUES
    ('SV001', N'Đỗ Hồng Quân', '2004-02-01', 'Nam', 'hongquan@gmail.com', 'SD18401','Net103', 8.5, 7.5, 9.0, 9),
    ('SV002', N'Dương Trí Cường', '2004-05-15', 'Nam', 'duongcuong@gmail.com', 'SD18401','COM108', 7.0, 8.0, 9.5, 9),
    ('SV003', N'Phạm Công Phú', '2004-03-10', 'Nam', 'congphu@gmail.com', 'SD18401','ENT1126', 9.0, 8.5, 7.0, 9)
	
	delete from SinhVien
-- Thêm dữ liệu vào bảng MonHoc
INSERT INTO MonHoc (MaMh, TenMh)
VALUES
    ('ENT1126', N'Tiếng Anh 1.1'),
    ('Net103', N'Lập trình C# 3'),
    ('COM108', N'Nhập môn lập trình' ) ,
    ('COM2012', N'Cơ sở dữ liệu' ) ,
    ('ENT1225', N'Tiếng Anh 2.1' ) ,
    ('WEB1013', N'Xây dựng trang Web' ) 
	delete from MonHoc