--SQL Day 2

--COUNT()
SELECT COUNT(id) AS Jumlah_Mahasiswa
FROM mahasiswa;

--MIN() MAX()
SELECT MIN(id) AS ID_Terkecil
FROM mahasiswa;

ALTER TABLE mahasiswa
ADD nilai INT;

UPDATE mahasiswa
SET nilai = 80 
WHERE id IN (7,9)

SELECT id, nilai
FROM mahasiswa;

--JOINS

--INNER JOIN

--LEFT JOIN

--RIGHT JOIN

--distinct

--Group by

--Substring
SELECT SUBSTRING('SQL Tutorial', 1, 3);

--charindex
SELECT CHARINDEX('c', 'Customer');

--DATALENGTH
SELECT DATALENGTH('W3Schools.com');

--CASE WHEN
SELECT name, address,
CASE
	WHEN nilai >= 80 then 'A'
	WHEN nilai >= 60 then 'B'
	ELSE 'C'
END AS hasil_nilai
FROM mahasiswa

--CONCAT
SELECT CONCAT('SQL ','is ','Fun!');

--Operator Aritmatika
CREATE TABLE tbPenjualan(
id BIGINT PRIMARY KEY IDENTITY(1,1),
nama VARCHAR(32),
harga INT
);

SELECT nama, harga, (harga * 100) AS jml_belanja
FROM tbPenjualan;

INSERT INTO tbPenjualan(nama, harga)
VALUES
('Indomie', 1500),
('Close-up', 3500),
('Pepsoden', 3000),
('Brush Formula', 2500),
('Roti Manis', 1000),
('Gula', 3500),
('Sarden', 4500),
('Rokok Sampurna', 1100),
('Rokok 234', 1100) 

--DATETIME

--DAY-MONTH-YEAR

--DATEADD()

--DATEDIFF() - different
SELECT DATEDIFF(year, '2015/05/05', '2018/05/05') AS DiffYear;
SELECT DATEDIFF(month, '2015/05/05', '2018/09/05') AS DiffMonth;
SELECT DATEDIFF(day, '2015/05/05', '2018/05/21') AS DiffDay;

/* GETDATE(); --waktu sekarang */

--subquery
--SELECT *
--FROM mahasiswa AS mhs
--LEFT JOIN biodata AS bio
--ON mhs.nilai 

--view

--database index

--unique index

--foreign key, primary key, unique key

--primary key constrains

--unique constrains