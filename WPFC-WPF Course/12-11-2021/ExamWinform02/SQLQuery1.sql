create database employeeManagement;
use employeeManagement;

create table Department(
DeptID INT identity(1,1) PRIMARY KEY,
DeptName  NVARCHAR(200) NOT NULL
);
create table Employees(
EmployeeID INT identity(1,1) PRIMARY KEY,
EmployeeName NVARCHAR(200) NOT NULL,
DeptID INT,
Gender SMALLINT DEFAULT 0,
BirthDate DATETIME,
Tel NVARCHAR(20) DEFAULT '',
);
ALTER TABLE Employees
ADD CONSTRAINT FK_DepartmentEmployee
FOREIGN KEY (DeptID) REFERENCES Department(DeptID);

INSERT INTO Department(DeptName)
VALUES('Sales'),
('IT'),
('Purchasing');

INSERT INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)
VALUES('Nguyen Van A', 1, 1, '1996/12/29', '01234566');
