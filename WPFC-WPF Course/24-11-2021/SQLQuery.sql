CREATE DATABASE EmployeeWPF;
USE EmployeeWPF
CREATE TABLE Employees(
	EmployeeID int PRIMARY KEY identity(1,1) ,
	EmployeeName VARCHAR(500) NOT NULL,
	DeptID int,
	Gender VARCHAR(100) NOT NULL,
	BirthDate Date NOT NULL,
	Tel VARCHAR(200),
	Address TEXT
)
INSERT INTO Employees(EmployeeName, DeptID, Gender, BirthDate, Tel, Address)
VALUES('Nguyen Van A', 1, 'Male', '1993/12/30', '002-98878787', 'Road A, Street B'),
('Jane nuee', 1, 'Male', '1993/12/30', '002-989843', 'Road A, Street B'),
('Tome', 2, 'Female', '1994/11/30', '002-8438758', 'Road A, Street B'),
('Jenny', 3, 'Female', '1992/06/15', '002-837548375', 'Road A, Street B');

CREATE TABLE Departments(
	DeptID int PRIMARY KEY identity(1,1),
	DeptName VARCHAR(500)NOT NULL,
);
ALTER TABLE Employees
ADD CONSTRAINT FK_Department
FOREIGN KEY (DeptID) REFERENCES Departments(DeptID); 

INSERT INTO Departments(DeptName) VALUES('Sales');
INSERT INTO Departments(DeptName) VALUES('IT');
INSERT INTO Departments(DeptName) VALUES('Accounts');
SELECT * FROM Departments;
SELECT * FROM Employees;