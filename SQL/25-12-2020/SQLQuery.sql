CREATE DATABASE C2009L;
USE C2009L;
CREATE TABLE tblEmployee(
	EmployeeID INT PRIMARY KEY IDENTITY(1, 1),
	EmployeeName NVARCHAR(500) NOT NULL,
	DateOfBirth Date DEFAULT '1999-12-12',
	DateOfJoin Date
);
SELECT 
	EmployeeID AS 'MaNhanVien', 
	DateOfBirth AS 'DOB', 
	EmployeeName AS 'tenNhanVien'
FROM tblEmployee
ORDER BY DateOfBirth DESC;


SELECT 5+2 as x;
--insert data
INSERT INTO tblEmployee(EmployeeName, DateOfBirth, DateOfJoin)
VALUES(N'Nguyen Van A', '1993-12-30', '2019-05-26');
INSERT INTO tblEmployee(EmployeeName, DateOfBirth, DateOfJoin)
VALUES(N'Nguyen Van B', '1994-12-30', '2020-06-26');

INSERT INTO tblEmployee(EmployeeName, DateOfBirth, DateOfJoin)
VALUES(N'John xx', '1995-12-30', '2018-06-26');
INSERT INTO tblEmployee(EmployeeName, DateOfBirth, DateOfJoin)
VALUES(N'Maxdd xx', '1996-12-30', '2016-06-26');

DELETE FROM tblEmployee WHERE tblEmployee.EmployeeID = 2;