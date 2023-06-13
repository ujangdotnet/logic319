--SQL Day 01--

--//CREATE//
--create database
CREATE DATABASE db_kampus;

--create table
CREATE TABLE mahasiswa(
id BIGINT PRIMARY KEY IDENTITY(1,1),
name VARCHAR(50) NOT NULL,
address VARCHAR(50) NOT NULL,
email VARCHAR(255) NULL
);

CREATE TABLE biodata(
id BIGINT PRIMARY KEY IDENTITY(1,1),
mahasiswa_id BIGINT,
tgl_lahir DATETIME,
gender VARCHAR(10)
);

--create view
--CREATE VIEW vw_mahasiswa as SELECT * FROM mahasiswa;

--//ALTER//
--add column
ALTER TABLE mahasiswa add nomor_hp VARCHAR(100) NOT NULL;

--drop column
ALTER TABLE mahasiswa drop column nomor_hp;

--alter column
--ALTER TABLE mahasiswa

--//DROP
--drop database
--DROP DATABASE [nama-database];



--DML (Data Manipulation Language)

--Insert into
INSERT INTO mahasiswa(name,address,email) VALUES ('Banu','Ciamis','banu@gmail.com');

INSERT INTO biodata(mahasiswa_id,tgl_lahir,gender) VALUES (1,'2003-06-12','laki-laki');
INSERT INTO biodata(mahasiswa_id,tgl_lahir,gender) VALUES (2,'2005-06-12','laki-laki');
INSERT INTO biodata(mahasiswa_id,tgl_lahir,gender) VALUES (2,'2007-06-12','wanita');

--Select
SELECT id,name,address,email FROM mahasiswa;

SELECT * FROM biodata;

--Update
UPDATE mahasiswa SET name = 'Banu 2' WHERE id = 1;

UPDATE biodata
SET mahasiswa_id = 2

--Delete
DELETE FROM mahasiswa WHERE  id = 1;

--Join (AND, OR, NOT)
SELECT mhs.id as id_mahasiswa, mhs.name as nama_mahasiswa, mhs.address as alamat, mhs.email as email, bio.tgl_lahir as tgl_lahir, bio.gender as gender
FROM mahasiswa as mhs
JOIN biodata as bio
ON mhs.id = bio.mahasiswa_id 

--Order by
SELECT *
FROM biodata
ORDER BY tgl_lahir DESC

--Select Top
SELECT TOP 1 mahasiswa_id
FROM biodata
ORDER BY mahasiswa_id ASC

--Between
SELECT *
FROM biodata
WHERE id
BETWEEN 2 AND 3

--Like

--Group by

--having 