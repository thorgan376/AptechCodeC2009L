CREATE DATABASE HumanResources;

USE HumanResources;

CREATE TABLE Employee(
EmployeeID int PRIMARY KEY identity(1,1),
EmployeeName VARCHAR(500) NOT NULL,
DeptID int,
Gender VARCHAR(100) NOT NULL,
BirthDate  DATE NOT NULL,
Tel VARCHAR(200),
Address TEXT
);

INSERT INTO Employee(EmployeeName, DeptID, Gender, BirthDate, Tel, Address)
VALUES('Tom', 1, 'Female', '1993/12/30', '002-9887887', 'Road A, Street B'),
('Tomi', 2, 'Male', '1993/11/30', '002-9887878', 'Road A, Street B'),
('Toma', 3, 'Female', '1993/10/30', '002-8878787', 'Road A, Street B'),
('Tomb', 4, 'Male', '1993/09/30', '02-98878787', 'Road A, Street B'),
('Tomc', 5, 'Male', '1993/08/30', '002-9878787', 'Road A, Street B'),
('Tomd', 6, 'Female', '1993/07/30', '002-98878787', 'Road A, Street B'),
('Tomg', 6, 'Female', '1993/07/31', '002-918878787', 'Road A, Street B'),
('Tomf', 7, 'Male', '1993/06/30', '002-9878787', 'Road A, Street B');

CREATE TABLE Department(
DeptID int PRIMARY KEY identity(1,1),
DeptName VARCHAR(500) NOT NULL
);

INSERT INTO Department(DeptName) VALUES
('Accounting'),('Administration'),('DTY'),('Engineering'),('F & A'),('Marketing');

ALTER TABLE  Employee
ADD CONSTRAINT FK_Department
FOREIGN KEY (DeptID) REFERENCES Department(DeptID);

Select * from Department;
Select * from Employee;
