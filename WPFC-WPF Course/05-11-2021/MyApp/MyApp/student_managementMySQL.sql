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

CREATE TABLE `tblclass` (
  `MaLop` int(11) NOT NULL,
  `TenLop` varchar(30) DEFAULT NULL,
  `SiSo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `tblclass`
--

INSERT INTO `tblclass` (`MaLop`, `TenLop`, `SiSo`) VALUES
(1, 'Class C1011GV', 0),
(2, 'Class C1009M', 2),
(3, 'Class C1010KV', 0),
(4, 'Class C1011L', 0),
(5, NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tblstudent`
--

CREATE TABLE `tblstudent` (
  `MaSV` int(11) NOT NULL,
  `TenSV` varchar(30) DEFAULT NULL,
  `GioiTinh` varchar(10) DEFAULT NULL,
  `NSinh` datetime DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `MaLop` int(11) DEFAULT NULL,
  `UserNm` varchar(20) DEFAULT NULL,
  `Password` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `tblstudent`
--

INSERT INTO `tblstudent` (`MaSV`, `TenSV`, `GioiTinh`, `NSinh`, `DiaChi`, `MaLop`, `UserNm`, `Password`) VALUES
(1, 'Nguyen Van Hung', 'True', '1990-09-08 00:00:00', 'Doi Can', 1, 'hungnv', '123456'),
(2, 'Tran Van Hieu', 'True', '1990-03-15 00:00:00', 'Ba Dinh', 2, 'hieutv', '123456'),
(3, 'Le Thi Hong', 'False', '1990-05-11 00:00:00', 'Hai Ba Trung', 2, 'honglt', '123456'),
(4, 'Nguyen Van Tien', 'True', '1990-08-28 00:00:00', 'Hoan Kiem', 1, 'tiennv', '123456'),
(5, 'Hoang Mai Huong', 'False', '1990-08-28 00:00:00', 'Xuan Dinh', 2, 'huonghm', '123456');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tblclass`
--
ALTER TABLE `tblclass`
  ADD PRIMARY KEY (`MaLop`);

--
-- Chỉ mục cho bảng `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD PRIMARY KEY (`MaSV`),
  ADD KEY `MaLop` (`MaLop`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `tblclass`
--
ALTER TABLE `tblclass`
  MODIFY `MaLop` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT cho bảng `tblstudent`
--
ALTER TABLE `tblstudent`
  MODIFY `MaSV` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD CONSTRAINT `tblstudent_ibfk_1` FOREIGN KEY (`MaLop`) REFERENCES `tblclass` (`MaLop`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
