------------------------------------------- ADMIN -------------------------------------------
-- Tạo user
CREATE OR REPLACE PROCEDURE USP_CREATEUSER (
    p_username IN VARCHAR2,
    p_password IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY ' || p_password;
    EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || p_username;
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || p_username;
    EXECUTE IMMEDIATE 'GRANT CREATE TABLE TO ' || p_username;
    EXECUTE IMMEDIATE 'GRANT UNLIMITED TABLESPACE TO ' || p_username;
END;
/
 
-- Xóa user
CREATE OR REPLACE PROCEDURE USP_DROPUSER (p_username IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP USER ' || p_username;
END;
/

-- Chỉnh sửa user
CREATE OR REPLACE PROCEDURE USP_ALTERUSER 
(P_USERNAME IN VARCHAR2, P_USER_NEW_PASSWORD IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE 'ALTER USER ' || P_USERNAME || ' IDENTIFIED BY ' || P_USER_NEW_PASSWORD;
END;
/

-- Tạo role
CREATE OR REPLACE PROCEDURE USP_ADDROLE (p_role_name IN VARCHAR2)
AS
   v_role_name VARCHAR2(30);
BEGIN
    v_role_name := 'RL_' || p_role_name;
    EXECUTE IMMEDIATE 'CREATE ROLE ' || v_role_name;
END;
/

-- Xóa role
CREATE OR REPLACE PROCEDURE USP_DROPROLE (P_ROLENAME IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP ROLE ' || P_ROLENAME;
END;
/

--Chỉnh sửa role
CREATE OR REPLACE PROCEDURE USP_ALTERROLE
(P_ROLENAME IN VARCHAR2, P_ROLE_NEW_PASSWORD IN VARCHAR2)
AS
BEGIN
    EXECUTE IMMEDIATE 'ALTER ROLE ' || P_ROLENAME || ' IDENTIFIED BY ' || P_ROLE_NEW_PASSWORD;
END;
/

------------------------------------------- NHANVIEN -------------------------------------------
--1. xem tất cả các thuộc tính trên quan hệ NHANVIEN và PHANCONG liên quan đến chính nhân viên đó
