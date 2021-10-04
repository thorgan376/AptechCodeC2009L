CREATE DATABASE IF NOT EXISTS abc12;
USE abc12;
CREATE TABLE IF NOT EXISTS abc12users (
    USERNAME VARCHAR(200) NOT NULL UNIQUE,
    PASSWORD_HASH CHAR(100) NOT NULL,
    PHONE VARCHAR(10)
);
INSERT INTO abc12users(USERNAME, PASSWORD_HASH, PHONE)
VALUES("hoang13", "123456", "001122");
--password hash : ma hoa mat khau
--vd: 123456 => jruiwhthsh4349343nuwhr54
--nhung thong tin gi phai ma hoa: password, the tin dung