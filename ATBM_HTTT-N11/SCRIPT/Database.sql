--DROP TABLE
DECLARE
   TEMP_COUNT INT;
BEGIN
   SELECT COUNT(*) INTO TEMP_COUNT FROM USER_TABLES WHERE TABLE_NAME = 'PHANCONG';
   IF TEMP_COUNT = 1 THEN
      EXECUTE IMMEDIATE 'DROP TABLE PHANCONG';
   END IF;
   SELECT COUNT(*) INTO TEMP_COUNT FROM USER_TABLES WHERE TABLE_NAME = 'DEAN';
   IF TEMP_COUNT = 1 THEN
      EXECUTE IMMEDIATE 'DROP TABLE DEAN';
   END IF;
   SELECT COUNT(*) INTO TEMP_COUNT FROM USER_TABLES WHERE TABLE_NAME = 'NHANVIEN';
   IF TEMP_COUNT = 1 THEN
      EXECUTE IMMEDIATE 'DROP TABLE NHANVIEN';
   END IF;
   SELECT COUNT(*) INTO TEMP_COUNT FROM USER_TABLES WHERE TABLE_NAME = 'PHONGBAN';
   IF TEMP_COUNT = 1 THEN
      EXECUTE IMMEDIATE 'DROP TABLE PHONGBAN';
   END IF;
END;
/

--CREATE TABLE PHONGBAN
CREATE TABLE PHONGBAN(
    MAPB VARCHAR2(6),
    TENPB VARCHAR2(40),
    TRPHG VARCHAR2(6) NULL,
    CONSTRAINT PHONGBAN_PK PRIMARY KEY (MAPB)
);
--CREATE TABLE NHANVIEN
CREATE TABLE NHANVIEN(
    MANV VARCHAR2(6),
    TENNV NVARCHAR2(40),
    PHAI NVARCHAR2(10),
    NGAYSINH DATE,
    DIACHI NVARCHAR2(50),
    SODT VARCHAR(11),
    LUONG VARCHAR(10),
    PHUCAP VARCHAR(10),
    VAITRO NVARCHAR2(20),
    MANQL VARCHAR2(6),
    PHG VARCHAR2(6),
    CONSTRAINT NHANVIEN_PK PRIMARY KEY (MANV),
    CONSTRAINT NHANVIEN_NHANVIEN_FK FOREIGN KEY (MANQL) REFERENCES NHANVIEN (MANV),
    CONSTRAINT NHANVIEN_PHONGBAN_FK FOREIGN KEY (PHG) REFERENCES PHONGBAN (MAPB)
);
/
--CREATE TABLE DEAN
CREATE TABLE DEAN(
    MADA VARCHAR2(6),
    TENDA NVARCHAR2(40), 
    NGAYBD DATE,
    PHONG VARCHAR2(6),
    CONSTRAINT DEAN_PK PRIMARY KEY (MADA),
    CONSTRAINT DEAN_PHONGBAN_FK FOREIGN KEY (PHONG) REFERENCES PHONGBAN(MAPB)
);
/
--CREATE TABLE PHANCONG
CREATE TABLE PHANCONG(
    MANV VARCHAR2(6),
    MADA VARCHAR2(6),
    THOIGIAN DATE,
    CONSTRAINT PHANCONG_PK PRIMARY KEY (MANV, MADA),
    CONSTRAINT PHANCONG_DEAN_FK FOREIGN KEY (MADA) REFERENCES DEAN(MADA),
    CONSTRAINT PHANCONG_NHANVIEN_FK FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);
/