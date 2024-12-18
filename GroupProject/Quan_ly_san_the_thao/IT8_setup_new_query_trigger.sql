CREATE DATABASE IT8_DATABASE_PROJECT

USE IT8_DATABASE_PROJECT
GO

CREATE TABLE KHACHHANG
(
    USERNAME VARCHAR(20) NOT NULL,
    PASSWRD VARCHAR(20) NOT NULL,
    TENKH NVARCHAR(60) NOT NULL,
    EMAIL VARCHAR(60) NOT NULL,
    SDT VARCHAR(15) NOT NULL,
    GTINH BIT NOT NULL, -- 0: female, 1: male
    CONSTRAINT CS_PK_KHACHHANG PRIMARY KEY(USERNAME)
)
CREATE TABLE SANTHETHAO
(
    MASANTT VARCHAR(10) NOT NULL,
    MONTHETHAO VARCHAR(40) NOT NULL,
    TENSANTT VARCHAR(50) NOT NULL,
    GTSANG MONEY NOT NULL,
    GTTRUA MONEY NOT NULL,
    GTTOI MONEY NOT NULL,
    CONSTRAINT CS_PK_SANTHETHAO PRIMARY KEY(MASANTT)
)
CREATE TABLE HOADON
(
    MAHD VARCHAR(10) NOT NULL,
    USERNAME VARCHAR(20) NOT NULL,
    NGTTOAN DATE NOT NULL,
    TRIGIA MONEY NOT NULL,
    CONSTRAINT CS_PK_HOADON PRIMARY KEY(MAHD)
)
CREATE TABLE CTHD
(
    MAHD VARCHAR(10) NOT NULL,
    MASANTT VARCHAR(10) NOT NULL,
    NGHDHLUC DATE NOT NULL,
    TTGTSANG BINARY(4) NOT NULL,
    TTGTTRUA BINARY(4) NOT NULL,
    TTGTTOI BINARY(4) NOT NULL,
    CONSTRAINT CS_PK_CTHD PRIMARY KEY(MAHD, MASANTT)
)
GO

ALTER TABLE HOADON
ADD CONSTRAINT PK_KHACHHANG_TO_FK_HOADON
FOREIGN KEY(USERNAME) REFERENCES KHACHHANG(USERNAME)

ALTER TABLE CTHD
ADD CONSTRAINT PK_HOADON_TO_FK_CTHD
FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)

ALTER TABLE CTHD
ADD CONSTRAINT PK_SANTHETHAO_TO_FK_CTHD
FOREIGN KEY(MASANTT) REFERENCES SANTHETHAO(MASANTT)

ALTER TABLE CTHD
ALTER COLUMN KHUNGGIO TINYINT NOT NULL