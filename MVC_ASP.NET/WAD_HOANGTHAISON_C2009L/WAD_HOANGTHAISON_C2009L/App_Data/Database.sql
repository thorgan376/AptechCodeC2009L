IF OBJECT_ID('dbo.Department', 'U') IS NOT NULL
  DROP TABLE dbo.Department;
GO

CREATE TABLE Department(
	DeptID INT PRIMARY KEY IDENTITY(1,1),
	DeptName NVARCHAR(50) NOT NULL
)
ON [PRIMARY]
GO

INSERT INTO Department(DeptName) VALUES 
('Marketing'),('Purchasing'),('Production');
GO

IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL
  DROP TABLE dbo.Employee;
GO

CREATE TABLE Employee(
	EmpID INT PRIMARY KEY IDENTITY(1,1),
	EmpName NVARCHAR(50) NOT NULL,
	DeptID INT NOT NULL FOREIGN KEY REFERENCES Department(DeptID),
	Address NVARCHAR(255) DEFAULT('122 One hundred and twenty two'),
	Email NVARCHAR(100), 
	DOJ NVARCHAR(100) NOT NULL,
	Gender Nvarchar (10) NOT NULL,
	YearOfBirth DATE DEFAULT('1945-04-30') NOT NULL,
)
ON [PRIMARY];
GO

INSERT INTO Employee (EmpName, DeptID, Address, Email, DOJ, Gender, YearOfBirth) VALUES
('Hahahaha',1,N'One Infinite Loop Cupertino, California 95014.', 'stevejobs@apple.com','Melon', 'Male', '1959-02-24'),
('Hohohoho',2,N'One Microsoft Way Redmond, WA 98052-7329.','billgates@microsoft.com', 'Rice', 'Female', '1958-02-24'),
('Hihihihi',2,N'Oracle Parkway Redwood Shores, CA 94065.', 'larryellison@oracle.com', 'Cupid', 'Male', '1957-02-24'),
('Hehehehe',2,N'One Microsoft Way Redmond, WA 98052-7329.', 'steveballmer@microsoft.com', 'Virgin', 'Male', '1956-02-24'),
('Kakakaka',1,N'1 Hacker Way 94025 Menlo Park', 'markzuckerberg@facebook.com','Minimum', 'Female', '1955-02-24'),
('Kokokoko',3,N'Two Infinite Loop Cupertino, California 95014.', 'timcook@apple.com','Maximum', 'Female', '1954-02-24'),
('Kekekeke',3,N'1632 Amphitheatre Parkway Mountain View, CA 94043', 'larrypage@google.com','Hologam', 'Female', '1953-02-24'),
('Bill Gates',1,N'1622 Amphitheatre Parkway Mountain View, CA 94043', 'sergeibrin@google.com','Nick Vujic', 'Male', '1952-02-24'),
('Donald Trump',1,N'1665 Amphitheatre Parkway Mountain View, CA 94043', 'ericschmidt@google.com','MetaVerse', 'Female', '1951-02-24'),
('Kikikiki',3,N'699 Wang Shang Road Binjiang District Hangzhou 310052.', 'jackma@alibaba.com', 'HarryPotter', 'Male', '1950-02-24');
GO

SELECT * FROM Department;
SELECT * FROM Employee;