Select * from Employees;
Select * from Department;
ALTER TABLE Employees
ALTER COLUMN Gender nvarchar;
Insert INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)
VALUES ('John','2','Male','11/20/2001','0999111234');
Insert INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)
VALUES ('Hairo','2','Female','11/20/2002','0999125525');
Insert INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)
VALUES ('Jane','2','Female','11/20/2003','0991253313');
Insert INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)
VALUES ('Java','2','Female','11/20/2004','0999124124');
Insert INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel)
VALUES ('Jake','2','Female','11/20/2005','0999117679');

ALTER TABLE Employees
DROP CONSTRAINT FK_DepartmentEmployee;

ALTER TABLE Employees
ADD CONSTRAINT FK_DepartmentEmployee
FOREIGN KEY (DeptID) REFERENCES Department(DeptID);

drop table Employees;

create table Employees(
EmployeeID INT identity(1,1) PRIMARY KEY,
EmployeeName NVARCHAR(200) NOT NULL,
DeptID INT,
Gender NVARCHAR(10) NOT NULL,
BirthDate DATETIME,
Tel NVARCHAR(20) DEFAULT '',
);