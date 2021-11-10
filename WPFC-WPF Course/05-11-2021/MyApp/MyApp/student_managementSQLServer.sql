-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 29, 2021 lúc 01:40 PM
-- Phiên bản máy phục vụ: 10.4.18-MariaDB
-- Phiên bản PHP: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `student_management`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tblclass`
--

CREATE TABLE tblclass (
  MaLop int NOT NULL PRIMARY KEY IDENTITY(1, 1),
  TenLop varchar(30) DEFAULT '',
  SiSo int DEFAULT 1
);

--
-- Đang đổ dữ liệu cho bảng `tblclass`
--

INSERT INTO tblclass (TenLop, SiSo) 
VALUES ('Class C1011GV', 30),
('Class C1009M', 20),
('Class C1010KV', 45),
('Class C1011L', 15);


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

ALTER TABLE tblstudent
ADD CONSTRAINT FK_StudentClass
FOREIGN KEY (MaLop) REFERENCES tblclass(MaLop);

--
-- Đang đổ dữ liệu cho bảng `tblstudent`

INSERT INTO tblstudent (TenSV, GioiTinh, NSinh, DiaChi, MaLop,UserNm, Password) 
VALUES('Nguyen Van Hung', 'male', '1990-09-08 00:00:00', 'Doi Can', 1, 'hungnv', '123456'),
('Tran Van Hieu', 'male', '1990-03-15 00:00:00', 'Ba Dinh', 2, 'hieutv', '123456'),
('Le Thi Hong', 'female', '1990-05-11 00:00:00', 'Hai Ba Trung', 2, 'honglt', '123456'),
('Nguyen Van Tien','male', '1990-08-28 00:00:00', 'Hoan Kiem', 1, 'tiennv', '123456'),
('Hoang Mai Huong', 'male', '1990-08-28 00:00:00', 'Xuan Dinh', 2, 'huonghm', '123456');


COMMIT;