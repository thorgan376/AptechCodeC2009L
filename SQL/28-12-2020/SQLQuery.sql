CREATE DATABASE StudentManagementSystem;
USE StudentManagementSystem;
CREATE TABLE Class(
	ClassId INT NOT NULL,
	ClassCode NVARCHAR(50)
);
CREATE TABLE Student(
	StudentId INT NOT NULL,
	StudentName NVARCHAR(50),
	BirthDate DATETIME,
	ClassId INT
);
CREATE TABLE Subject(
	SubjectId INT NOT NULL,
	SubjectName NVARCHAR(100),
	SessionCount INT 
);

CREATE TABLE Result(
	StudentId INT NOT NULL,
	SubjectId INT NOT NULL,
	Mark INT 
);
CREATE NONCLUSTERED INDEX IX_StudentName   
ON Student (StudentName);   

DROP INDEX IX_StudentName ON Student;

ALTER TABLE Result
ALTER COLUMN Mark FLOAT;

ALTER TABLE Class
ADD CONSTRAINT PK_Class PRIMARY KEY (ClassId);

--ALTER TABLE Class DROP CONSTRAINT PK_Class; -- ko thi
ALTER TABLE Student
ADD CONSTRAINT PK_Student PRIMARY KEY (StudentId);
ALTER TABLE Subject
ADD CONSTRAINT PK_Subject PRIMARY KEY (SubjectId);

ALTER TABLE Result
ADD CONSTRAINT PK_Result PRIMARY KEY (StudentId, SubjectId);

ALTER TABLE Student
ADD CONSTRAINT FK_Student_Class
FOREIGN KEY (ClassId) REFERENCES Class(ClassId);
INSERT INTO Class(ClassId, ClassCode) VALUES
(1, 'C1106KV'),
(2, 'C1108GV'),
(3, 'C1108IV'),
(4, 'C1108HV'),
(5, 'C1109GV');
SELECT * FROM Class;

INSERT INTO Student(StudentId, StudentName, BirthDate,ClassId)
VALUES(1,N'PhạmTuấnAnh', '1993/08/05', 1);

INSERT INTO Student(StudentId, StudentName, BirthDate,ClassId)
VALUES(2, N'PhanVănHuy', '1996/06/10', 1);

