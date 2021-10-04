CREATE DATABASE C2009L;
USE C2009L;

CREATE TABLE tblBook(
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    bookName VARCHAR(300),
    year INTEGER DEFAULT 1980
);
INSERT INTO tblBook(bookName, year)
VALUES("lap trinh C trong 2h", 2019);
INSERT INTO tblBook(bookName, year)
VALUES("php cho nguoi moi", 2020);