USE master;
CREATE TABLE Employees(
	EmployeeID int PRIMARY KEY identity(1,1) ,
	EmployeeName VARCHAR(500) NOT NULL,
	DeptID int,
	Gender VARCHAR(100) NOT NULL,
	BirthDate Date NOT NULL,
	Tel VARCHAR(200),
	Address TEXT
);
INSERT INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel, Address)
VALUES('Thomas', 1, 'Male', '1993/12/30', '002-98878787', 'Road A, Street B'),
('Frank', 1, 'Male', '1993/12/30', '002-989843', 'Road A, Street B'),
('Jane', 2, 'Female', '1994/11/30', '002-843858', 'Road A, Street B'),
('John', 4, 'Female', '1994/11/30', '002-8438758', 'Road A, Street B'),
('Jack', 5, 'Female', '1994/11/30', '002-838758', 'Road A, Street B'),
('Joe', 6, 'Female', '1994/11/30', '02-8438758', 'Road A, Street B'),
('Jenny', 3, 'Female', '1992/06/15', '002-837548375', 'Road A, Street B');

CREATE TABLE Departments(
	DeptID int PRIMARY KEY identity(1,1),
	DeptName VARCHAR(500)NOT NULL,
);
ALTER TABLE Employees
ADD CONSTRAINT FK_Department
FOREIGN KEY (DeptID) REFERENCES Departments(DeptID); 

INSERT INTO Departments(DeptName) VALUES('Accounting'),
('Administration'),('DTY'),('Engineering'),('F & A'),('Marketing');
SELECT * FROM Departments;
SELECT * FROM Employees;