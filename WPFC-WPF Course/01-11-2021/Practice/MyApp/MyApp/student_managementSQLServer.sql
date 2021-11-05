-- Create a new database called 'Student_Management'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'Student_Management'
)
--Trường hợp nếu dùng docker thì có thể ko cần tạo database dưới
--Vì docker có thể tạo nhiều container SQL sever từ 1 images mà ko cần thêm dung lượng
--Và nếu dùng nhiều database trong một container thì sẽ có thể rơi vào trường hợp bị lỗi và mất cả chì lẫn chài 
--Thay vì chỉ mất 1 database

CREATE DATABASE Student_Management;
GO

-- --------------------------------------------------------
CREATE TABLE tblclass (
  MaLop int NOT NULL PRIMARY KEY IDENTITY(1, 1),
  TenLop varchar(30) DEFAULT '',
  SiSo int DEFAULT 1
);
GO
-- Select rows from a Table or View '[TableOrViewName]' in schema '[dbo]'
--SELECT * FROM [dbo].[tblclass];
--GO

--
-- Đang đổ dữ liệu cho bảng `tblclass`
--

INSERT INTO tblclass (TenLop, SiSo) 
VALUES 
('Class C1011GV', 0),
('Class C1009M', 2),
('Class C1010KV', 0),
('Class C1011L', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tblstudent`
--

CREATE TABLE tblstudent (
  MaSV int PRIMARY KEY IDENTITY(1, 1),
  TenSV varchar(100) DEFAULT '',
  GioiTinh varchar(10) DEFAULT '',
  NSinh datetime DEFAULT NULL,
  DiaChi varchar(255) DEFAULT '',
  MaLop int,
  UserNm varchar(100) UNIQUE,
  Password varchar(100) DEFAULT ''
);
GO

-- Select rows from a Table or View '[TableOrViewName]' in schema '[dbo]'
--SELECT * FROM tblstudent;
--GO

ALTER TABLE tblstudent
ADD CONSTRAINT FK_StudentClass
FOREIGN KEY (MaLop) REFERENCES tblclass(MaLop);

--
-- Đang đổ dữ liệu cho bảng `tblstudent`
--

INSERT INTO tblstudent (TenSV, GioiTinh, NSinh, DiaChi, MaLop,UserNm, Password) 
VALUES('Nguyen Van Hung', 'male', '1990-09-08 00:00:00', 'Doi Can', 1, 'hungnv', '123456'),
('Tran Van Hieu', 'male', '1990-03-15 00:00:00', 'Ba Dinh', 2, 'hieutv', '123456'),
('Le Thi Hong', 'female', '1990-05-11 00:00:00', 'Hai Ba Trung', 2, 'honglt', '123456'),
('Nguyen Van Tien','male', '1990-08-28 00:00:00', 'Hoan Kiem', 1, 'tiennv', '123456'),
('Hoang Mai Huong', 'male', '1990-08-28 00:00:00', 'Xuan Dinh', 2, 'huonghm', '123456');
GO

