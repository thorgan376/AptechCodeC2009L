Select * from Employees;
Select * from Department;

create table Department(
DeptID INT identity(1,1) PRIMARY KEY,
DeptName  NVARCHAR(200) NOT NULL
);
create table Employees(
EmployeeID INT identity(1,1) PRIMARY KEY,
EmployeeName NVARCHAR(200) NOT NULL,
DeptID INT,
Gender NVARCHAR(10) NOT NULL,
BirthDate DATETIME,
Tel NVARCHAR(20) DEFAULT '',
);
ALTER TABLE Employees
ADD CONSTRAINT FK_DepartmentEmployee
FOREIGN KEY (DeptID) REFERENCES Department(DeptID);
--connection string
INSERT INTO Department(DeptName)
VALUES('Sales'),
('IT'),
('Purchasing');
INSERT INTO Department(DeptName)
VALUES('Accounting'),
('Administration'),
('DTY'), ('Engineering'), ('F & A'), ('Marketing');

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


