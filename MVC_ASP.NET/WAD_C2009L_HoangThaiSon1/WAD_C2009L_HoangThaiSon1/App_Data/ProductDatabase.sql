IF OBJECT_ID ('dbo.Category','U') IS NOT NULL
	DROP TABLE dbo.Category;
Create table Category(
	CategoryId INT PRIMARY KEY IDENTITY(1,1), --định danh cục bộ --
	CategoryName Nvarchar(50) NOT NULL --Loại sản phẩm-- 
)
ON [PRIMARY];
GO

/*Bảng sản phẩm*/
IF OBJECT_ID ('dbo.Product','U') IS NOT NULL
	DROP TABLE dbo.Product;
Create Table Product(
	ProductId INT PRIMARY KEY Identity(1,1),
	ProductName Nvarchar(50),
	Price DECIMAL(19,4),
	Quantity INT,
	ReleaseDate DATE DEFAULT('1999-04-28') NOT NULL,
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Category(CategoryId) 
	/*Khóa ngoại tham chiếu sang bảng loại sản phẩm*/
);
GO

INSERT INTO Category(CategoryName) VALUES
('Electric Kettle'),('TV'),('Graphic Card');
GO
INSERT INTO Product(ProductName, Price, Quantity, ReleaseDate, CategoryId) VALUES
 ('Delites',       109.8999,  3,  '2007-06-29', 1),
 ('Romanic',       129.99,  3,  '2011-10-14', 1),
 ('Delicop',       99.9,  3,  '2015-09-01', 1),
 ('SamsungOLEDTV', 999.89,  10, '2010-07-01', 2),
 ('LGOLEDTV',      955.98,  7,  '2013-07-07', 2),
 ('TCLOLEDTV',     819.8999,  3,  '2013-10-03', 2),
 ('Roveno',        109.8999, 3,  '2016-09-10', 1),
 ('NIVIDARTX1650', 1055.8999, 5,  '2011-03-04', 3),
 ('NIVIDARTX1050', 1019.8999, 5,  '2002-12-14', 3),
 ('NIVIDARTX3050', 315.8999,  5,  '2012-04-14', 3),
 ('NIVIDARTX3080', 415.8999,  5,  '2015-12-14', 3),
 ('NIVIDARTX3090', 125.8999,  5,  '2015-12-14', 3),
 ('SonySurfaceTv', 751.8999,  5,  '2015-12-14', 2),
 ('Donal',		   832.8999,  5,  '2015-12-14', 1),
 ('Meredic',	   1790,  5,  '2015-12-14', 1);
GO
SELECT * FROM Category;
SELECT * FROM Product;