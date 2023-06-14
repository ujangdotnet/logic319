--SQL Quiz Day 2

--Create Database
CREATE DATABASE DB_Entertainer;

--table artis
CREATE TABLE artis(
kd_artis varchar(100) PRIMARY KEY,
nm_artis varchar(100),
jk varchar(100),
bayaran int,
award int,
negara varchar(100)
);

ALTER TABLE artis
ALTER COLUMN bayaran bigint;

INSERT INTO artis(kd_artis, nm_artis, jk, bayaran, award, negara)
VALUES
('A001', 'ROBERT DOWNEY JR', 'PRIA', 3000000000, 2, 'AS'),
('A002', 'ANGELINA JOLIE', 'WANITA', 700000000, 1, 'AS'),
('A003', 'JACKIE CHAN', 'PRIA', 200000000, 7, 'HK'),
('A004', 'JOE TASLIM', 'PRIA', 350000000, 1, 'ID'),
('A005', 'CHELSEA ISLAN', 'WANITA', 300000000, 2, 'ID')

SELECT * FROM artis;

--tabel film
CREATE TABLE film(
kd_film varchar(10) PRIMARY KEY,
nm_film varchar(55),
genre varchar(55),
artis varchar(55),
produser varchar(55),
pendapatan int,
nominasi int
);

ALTER TABLE film
ALTER COLUMN pendapatan bigint;

INSERT INTO film(kd_film, nm_film, genre, artis, produser, pendapatan, nominasi)
VALUES
('F001', 'IRON MAN', 'G001', 'A001','PD01', 2000000000, 3),
('F002', 'IRON MAN 2', 'G001', 'A001','PD01', 1800000000, 2),
('F003', 'IRON MAN 3', 'G001', 'A001','PD01', 1200000000, 0),
('F004', 'AVENGER: CIVIL WAR', 'G001', 'A001','PD01', 2000000000, 1),
('F005', 'SPIDERMAN HOME COMING', 'G001', 'A001','PD01', 1300000000, 0),
('F006', 'THE RAID', 'G001', 'A004','PD03', 800000000, 5),
('F007', 'FAST & FURIOUS', 'G001', 'A004','PD05', 830000000, 2),
('F008', 'HABIBIE DAN AINUN', 'G004', 'A005','PD03', 670000000, 4),
('F009', 'POLICE STORY', 'G001', 'A003','PD02', 700000000, 3),
('F010', 'POLICE STORY 2', 'G001', 'A003','PD02', 710000000, 1),
('F011', 'POLICE STORY 3', 'G001', 'A003','PD02', 615000000, 0),
('F012', 'RUSH HOUR', 'G003', 'A003','PD05', 695000000, 2),
('F013', 'KUNGFU PANDA', 'G003', 'A003','PD05', 923000000, 5)

SELECT * FROM film;


--tabel produser
CREATE TABLE produser(
kd_produser varchar(50) PRIMARY KEY,
nm_produser varchar(50),
international varchar(50)
);

INSERT INTO produser(kd_produser, nm_produser, international)
VALUES
('PD01', 'MARVEL', 'YA'),
('PD02', 'HONGKONG CINEMA', 'YA'),
('PD03', 'RAPI FILM', 'TIDAK'),
('PD04', 'PARKIT', 'TIDAK'),
('PD05', 'PARAMOUNT PICTURE', 'YA')

SELECT * FROM produser;

--TABEL NEGARA
CREATE TABLE negara(
kd_negara varchar(100) PRIMARY KEY,
nm_negara varchar(100)
);

INSERT INTO negara(kd_negara, nm_negara)
VALUES
('AS', 'AMERIKA SERIKAT'),
('HK', 'HONGKONG'),
('ID', 'INDONESIA'),
('IN', 'INDIA')

SELECT * FROM negara;

--TABEL GENRE
CREATE TABLE genre(
kd_genre varchar(50) PRIMARY KEY,
nm_genre varchar(50)
);

INSERT INTO genre(kd_genre, nm_genre)
VALUES
('G001', 'ACTION'),
('G002', 'HORROR'),
('G003', 'COMEDY'),
('G004', 'DRAMA'),
('G005', 'THRILLER'),
('G006', 'FICTION')

SELECT * FROM genre;

--SOAL 1
SELECT nm_produser AS Nama, pendapatan
FROM produser AS prod
JOIN film
ON prod.kd_produser = film.produser;

--SOAL 2
SELECT nm_film, nominasi
FROM film
WHERE nominasi = 0;

--SOAL 3
SELECT nm_film
FROM film
WHERE nm_film LIKE 'p%';

--SOAL 4
SELECT nm_film
FROM film
WHERE nm_film LIKE '%y';

--SOAL 5
SELECT nm_film
FROM film
WHERE nm_film LIKE '%d%';

--SOAL 6
SELECT nm_film, nm_artis
FROM film
JOIN artis
ON film.artis = artis.kd_artis

--SOAL 7
SELECT nm_film, negara
FROM film
JOIN artis
ON film.artis = artis.kd_artis
WHERE negara LIKE 'HK';

--SOAL 8 (foreign key)
