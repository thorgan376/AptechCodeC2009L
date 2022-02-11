/*Use master;
GO

IF DB_ID('CustomerManagement') IS NOT NULL
	DROP DATABASE CustomerManagement;
GO

CREATE database CustomerManagement;
GO

USE CustomerManagement;
GO
*/
/* CƠ SỞ DỮ LIỆU CHO ỨNG DỤNG WEB ASP.NET MVC QUẢN LÝ KHÁCH HÀNG (CUSTOMER MANAGEMENT) */

/* tạo bảng LOẠI KHÁCH HÀNG */
/*'U' = user table*/
IF OBJECT_ID('dbo.Class', 'U') IS NOT NULL
  DROP TABLE dbo.Class
GO
-- pass table name and object type to OBJECT_ID - a NULL is returned if there is no object id and DROP TABLE is ignored 
CREATE TABLE Class
(
	ClassId INT PRIMARY KEY IDENTITY (1,1),	/* định danh cục bộ */
	ClassName NVARCHAR(50) NOT NULL
)
ON [PRIMARY]
GO

INSERT INTO	Class(ClassName) VALUES
 (N'VIP Member'),	/* 1 */
 (N'Newsletter Discount Group'), /* 2 */
 (N'Educational Institutions'),	 /* 3 */
 (N'Promotional Emails'),		 /* 4 */
 (N'USA Shipping'),				/* 5 */
 (N'Shipping Discount Group'),	/* 6 */
 (N'Quantity Discount Group'),	/* 7 */
 (N'Monthly Membership'),	/* 8 */
 (N'Active Paypal Profiles')	/* 9 */
GO

/* tạo bảng KHÁCH HÀNG */
IF OBJECT_ID('dbo.Customer', 'U') IS NOT NULL
  DROP TABLE dbo.Customer;
GO

Create table Customer(
	CustomerId INT PRIMARY KEY IDENTITY (1,1),
	Fullname VARCHAR(25) NOT NULL,
	Birthday DATE DEFAULT('1975-04-30') NOT NULL,
	Address VARCHAR(255) DEFAULT(N'One Infinite Loop Cupertino, Newyork 15024'),
	Email Varchar(100),
	Username Varchar(30) UNIQUE NOT NULL,
	Password Varchar(50) NOT NULL,
	ConfirmPassword Varchar(50) NOT NULL,
	ClassId INT NOT NULL, -- FOREIGN KEY REFERENCES Class(ClassId), cách 1
)
ON [PRIMARY];
GO
/* khóa ngoại tham chiếu sang bảng loại khách hàng Class */

ALTER TABLE Customer
ADD FOREIGN KEY (ClassId) REFERENCES Class(ClassId); 
GO

INSERT INTO Customer(Fullname, Birthday, Email, Username, Password, ConfirmPassword, ClassId, Address) VALUES
 (N'Steve Jobs',      '1955-02-24', 'stevejobs@apple.com',         'stevejobs',      'Abcd@1234', 'Abcd@1234', 1, N'One Infinite Loop Cupertino, California 95014.'),
 (N'Bill Gates',      '1955-10-28', 'billgates@microsoft.com',     'billgates',      'Abcd@1234', 'Abcd@1234', 2, N'One Microsoft Way Redmond, WA 98052-7329.'),
 (N'Larry Ellison',   '1944-08-17', 'larryellison@oracle.com',     'larryellison',   'Abcd@1234', 'Abcd@1234', 3, N'Oracle Parkway Redwood Shores, CA 94065.'), 
 (N'Steve Ballmer',   '1956-03-24', 'steveballmer@microsoft.com',  'steveballmer',   'Abcd@1234', 'Abcd@1234', 4, N'One Microsoft Way Redmond, WA 98052-7329.'),
 (N'Mark Zuckerberg', '1984-05-14', 'markzuckerberg@facebook.com', 'markzuckerberg', 'Abcd@1234', 'Abcd@1234', 5, N'1 Hacker Way 94025 Menlo Park'),	
 (N'Tim Cook',        '1960-11-01', 'timcook@apple.com',           'timcook',        'Abcd@1234', 'Abcd@1234', 6, N'One Infinite Loop Cupertino, California 95014.'),
 (N'Larry Page',      '1973-03-26', 'larrypage@google.com',        'larrypage',      'Abcd@1234', 'Abcd@1234', 7, N'1600 Amphitheatre Parkway Mountain View, CA 94043'),
 (N'Sergei Brin',     '1954-01-01', 'sergeibrin@google.com',       'sergeibrin',     'Abcd@1234', 'Abcd@1234', 8, N'1600 Amphitheatre Parkway Mountain View, CA 94043.'),
 (N'Eric Schmidt',    '1955-04-27', 'ericschmidt@google.com',      'ericschmidt',    'Abcd@1234', 'Abcd@1234', 9, N'1600 Amphitheatre Parkway Mountain View, CA 94043.'),
 (N'Jack Ma',         '1964-09-10', 'jackma@alibaba.com',          'jackma',         'Abcd@1234', 'Abcd@1234', 1, N'699 Wang Shang Road Binjiang District Hangzhou 310052.'),
 (N'Jerry Jang',      '1968-11-06', 'jerryjang@yahoo.com',		   'jerryjang',      'Abcd@1234', 'Abcd@1234', 2, N'Yahoo! Inc. 701 First Ave Sunnyvale, CA 94089.'),
 (N'Jeff Bezos',      '1964-01-12', 'jeffbezos@amazon.com',		   'jeffbezos',		 'Abcd@1234', 'Abcd@1234', 3, N'345 Boren Ave N Seattle, Washington 98109.'),
 (N'Elon Musk',       '1971-06-28', 'elonmusk@tesla.com',          'elonmusk',	     'Abcd@1234', 'Abcd@1234', 4, N'3500 Deer Creek Road Palo Alto, CA 94304.'),
 (N'Warren Buffet',   '1930-08-30', 'warrenbuffet@hathaway.com',   'warrenbuffet',   'Abcd@1234', 'Abcd@1234', 5, N'3555 Farnam Street Omaha, NE 68131.')
GO

SELECT * FROM Class;
SELECT * FROM Customer;
GO