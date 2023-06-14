--Create a database
CREATE DATABASE DBPenerbit;

--Tabel Pengarang
CREATE TABLE tblPengarang(
ID INT PRIMARY KEY IDENTITY(1,1),
Kd_Pengarang VARCHAR(7) NOT NULL,
Nama VARCHAR(30) NOT NULL,
Alamat VARCHAR(80) NOT NULL,
Kota VARCHAR(15) NOT NULL,
Kelamin VARCHAR(1) NOT NULL
);

INSERT INTO tblPengarang(Kd_Pengarang, Nama, Alamat, Kota, Kelamin)
VALUES
('P0001','Ashadi','Jl.Beo 25','Yogya','P'),
('P0002','Rian','Jl.Solo 123','Yogya','P'),
('P0003','Suwadi','Jl.Semangka 13','Bandung','P'),
('P0004','Siti','Jl.Durian 15','Solo','W'),
('P0005','Amir','Jl.Gajah 33','Kudus','P'),
('P0006','Suparman','Jl.Harimau 25','Jakarta','P'),
('P0007','Jaja','Jl.Singa 7','Bandung','P'),
('P0008','Saman','Jl.Naga 12','Yogya','P'),
('P0009','Anwar','Jl.Tidar 6A','Magelang','P'),
('P0010','Fatmawati','Jl.Renjana 4','Bogor','W')

--Tabel Gaji
CREATE TABLE tblGaji(
ID INT PRIMARY KEY IDENTITY(1,1),
Kd_Pengarang VARCHAR(7) NOT NULL,
Nama VARCHAR(30) NOT NULL,
Gaji DECIMAL(18,4) NOT NULL
);

SELECT * FROM tblGaji;

INSERT INTO tblGaji(Kd_Pengarang, Nama, Gaji)
VALUES
('P0002','Rian',600000),
('P0005','Amir',700000),
('P0004','Siti',500000),
('P0003','Suwadi',1000000),
('P0010','Fatmawati',600000),
('P0008','Saman',750000)


--No 1
--Cara 1
SELECT Nama FROM tblPengarang;
SELECT COUNT(Nama) as Jml_Pengarang FROM tblPengarang;

--Cara 2
SELECT Nama, COUNT(Nama) as Jumlah
FROM tblPengarang
GROUP BY Nama

--No 2
--Cara 1
SELECT COUNT(Kelamin) as Jml_Pengarang_Pria
FROM tblPengarang
WHERE Kelamin = 'P';
SELECT COUNT(Kelamin) as Jml_Pengarang_Wanita
FROM tblPengarang
WHERE Kelamin = 'W';

--Cara2
SELECT Kelamin, COUNT(Kelamin) as Jumlah
FROM tblPengarang
GROUP BY Kelamin

--No 3
SELECT Kota FROM tblPengarang;
SELECT COUNT(DISTINCT  Kota) as Jml_Kota FROM tblPengarang;

--No 4
--cara 1
SELECT Kota
FROM tblPengarang
WHERE ID > 1;

--cara 2
SELECT Kota, COUNT(Kota) as Jumlah
FROM tblPengarang
GROUP BY Kota
HAVING COUNT(Kota) > 1


--No 5
--Cara 1
SELECT MIN(Kd_Pengarang) as Terkecil
FROM tblPengarang;
SELECT MAX(Kd_Pengarang) as Terbesar
FROM tblPengarang;

--Cara 2
SELECT MIN(Kd_Pengarang) as Terkecil, MAX(Kd_Pengarang) as Terbesar
FROM tblPengarang
 

--No 6
--Cara 1
SELECT MIN(Gaji) as Gaji_Terendah
FROM tblGaji;
SELECT MAX(Gaji) as Gaji_Tertinggi
FROM tblGaji;

--Cara 2
SELECT MIN(Gaji) as Gaji_Terendah, MAX(Gaji) as Terbesar
FROM tblGaji;

--No 7
SELECT Pgr.Kota, Gj.Gaji
FROM tblPengarang as Pgr
JOIN tblGaji as Gj
ON Pgr.Kd_Pengarang = Gj.Kd_Pengarang
WHERE Gaji > 600000;

--No 8
SELECT SUM(Gaji) as jml_Gaji
FROM tblGaji;

--No 9
SELECT Pgr.Kota as Kota, Gj.Gaji as Gaji
FROM tblPengarang as Pgr
JOIN tblGaji as Gj
ON Pgr.Kd_Pengarang = Gj.Kd_Pengarang 
ORDER BY Kota;

--No 10
SELECT *
FROM tblPengarang
WHERE Kd_Pengarang BETWEEN 'P0003' AND 'P0006';


--No 11
--Cara 1
SELECT *
FROM tblPengarang
WHERE Kota = 'Yogya' OR Kota = 'Solo' OR Kota = 'Magelang';

--Cara 2
SELECT *
FROM tblPengarang
WHERE Kota IN ('Yogya', 'Solo', 'Magelang'); 

--No 12
SELECT *
FROM tblPengarang
WHERE NOT Kota = 'Yogya';

SELECT *
FROM tblPengarang
WHERE  Kota != 'Yogya';

--No 13
--13a
SELECT *
FROM tblPengarang
WHERE Nama LIKE 'A%';
--13b
SELECT *
FROM tblPengarang
WHERE Nama LIKE '%i';
--13c
SELECT *
FROM tblPengarang
WHERE Nama LIKE '__a%';
--13d
SELECT *
FROM tblPengarang
WHERE Nama NOT LIKE '%n';	

--No 14
SELECT *
FROM tblPengarang as Pgr
JOIN tblGaji as Gj
ON Pgr.Kd_Pengarang = Gj.Kd_Pengarang;

--No 15
SELECT Pgr.Kota, Gj.Gaji
FROM tblPengarang as Pgr
JOIN tblGaji as Gj
ON Pgr.Kd_Pengarang = Gj.Kd_Pengarang
WHERE Gj.Gaji < 1000000;

--No16
ALTER TABLE tblPengarang
ALTER COLUMN Kelamin VARCHAR(10);

--No 17
ALTER TABLE tblPengarang
ADD Gelar VARCHAR(12);
 
ALTER TABLE tblPengarang
DROP COLUMN Gelar;

SELECT * FROM tblPengarang;

--No 18
UPDATE tblPengarang
SET Alamat = 'Jl.Cendrawasih 65', Kota = 'Pekanbaru'
WHERE Nama = 'Rian';

/*SELECT * FROM tblPengarang
WHERE Nama = 'Rian'*/

--No 19
CREATE VIEW vwPengarang AS
SELECT Pgr.Kd_Pengarang, Pgr.Nama, Pgr.Kota, Gj.Gaji
FROM tblPengarang as Pgr
LEFT JOIN tblGaji as Gj
ON Pgr.Kd_Pengarang = Gj.Kd_Pengarang

SELECT * FROM vwPengarang; 
DROP VIEW vwPengarang;