Select * from tblstudent;

Select * from tblclass;

DELETE FROM tblstudent WHERE UserNm = 'sonht';

INSERT INTO tblstudent(TenSV,GioiTinh,NSinh,DiaChi,MaLop,UserNm,Password)
VALUES ('Hoang Thai Son','male','2002-10-10 00:00:00.000','Doi Can','1','sonht','123456');

INSERT INTO tblstudent(TenSV,GioiTinh,NSinh,DiaChi,MaLop,UserNm)
VALUES ('Hoang Thai','male','2002-10-10','Doi Can','1','sonht');