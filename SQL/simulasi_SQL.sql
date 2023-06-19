--Simulasi SQL

CREATE DATABASE DB_PTXA;

--tabel biodata
CREATE TABLE tb_biodata(
id bigint NOT NULL PRIMARY KEY IDENTITY(1,1),
first_name varchar(20),
last_name varchar(30),
dob datetime,
pob varchar(50),
address varchar(255),
gender varchar(1)
);

INSERT INTO tb_biodata(first_name,last_name,dob,pob,address,gender)
VALUES
('soraya','rahayu','1990-12-22','Bali','Jl.Raya Kuta, Bali','P'),
('hanum','danuary','1990-01-02','Bandung','Jl.Berkah Ramadhan, Bandung','P'),
('melati','marcelia','1991-03-03','Jakarta','Jl.Mawar 3, Brebes','P'),
('farhan','Djokrowidodo','1989-10-11','Jakarta','Jl.Bahari Raya, Solo','L')

--tabel employee
CREATE TABLE tb_employee(
id bigint NOT NULL PRIMARY KEY IDENTITY(1,1),
biodata_id bigint,
nip varchar(5),
status varchar(10),
join_date datetime,
salary decimal(10,0)
);

INSERT INTO tb_employee(biodata_id,nip,status,join_date,salary)
VALUES
(1,'XA001','Permanen','2015-11-01 00:00:00.000',12000000),
(2,'XA002','Kontrak','2017-01-02 00:00:00.000',10000000),
(3,'XA003','Kontrak','2018-08-19 00:00:00.000',10000000)

--tabel contact person
CREATE TABLE tb_contact_person(
id bigint PRIMARY KEY IDENTITY(1,1),
biodata_id bigint,
type varchar(5),
contact varchar(100)
);

INSERT INTO tb_contact_person(biodata_id,type,contact)
VALUES
(1,'MAIL','soraya.rahayu@gmail.com'),
(1,'PHONE','085612345678'),
(2,'MAIL','hanum.danuary@gmail.com'),
(2,'PHONE','081312345678'),
(2,'PHONE','087812345678'),
(3,'MAIL','melati.marcelia@gmail.com')


--table leave
CREATE TABLE tb_leave(
id bigint PRIMARY KEY IDENTITY(1,1),
type varchar(10),
name varchar(100)
);

INSERT INTO tb_leave(type,name)
VALUES
('Reguler','Cuti Tahunan'),
('Khusus','Cuti Menikah'),
('Khusus','Cuti Haji & Umrah'),
('Khusus','Cuti Melahirkan')

--tabel employee leave
CREATE TABLE tb_employee_leave(
id int PRIMARY KEY IDENTITY(1,1),
employee_id int,
period varchar(4),
regular_quota int
);

INSERT INTO tb_employee_leave(employee_id,period,regular_quota)
VALUES
(1,'2021',16),
(2,'2021',12),
(3,'2021',12)

--table leave request
CREATE TABLE tb_leave_request(
id bigint PRIMARY KEY IDENTITY(1,1),
employee_id bigint,
leave_id bigint,
start_date date,
end_date date,
reason varchar(255)
);

INSERT INTO tb_leave_request(employee_id,leave_id,start_date,end_date,reason)
VALUES
(1,1,'2021-10-10','2021-10-12','Liburan'),
(1,1,'2021-11-12','2021-11-15','Acara Keluarga'),
(2,2,'2021-05-05','2021-05-07','Menikah'),
(2,1,'2021-09-09','2021-09-13','Touring'),
(2,1,'2021-12-20','2021-12-23','Acara Keluarga')


select * from tb_biodata;
SELECT * FROM tb_employee;
SELECT * FROM tb_contact_person;
SELECT * FROM tb_leave;
SELECT * FROM tb_employee_leave;
SELECT * FROM tb_leave_request;

--Soal 1
SELECT TOP 1 (e.join_date), b.first_name
FROM tb_biodata AS b
JOIN tb_employee AS e ON b.id = e.biodata_id
ORDER BY e.join_date

--Soal 2 (Menampilkan daftar karyawan yang saat ini sedang cuti. Daftar berisi nomor_induk, nama, tanggal_mulai, lama_cuti dan keterangan)
SELECT e.nip, b.first_name, e.join_date, DATEDIFF(day,ler.start_date,ler.end_date) AS lama_cuti,ler.reason AS keterangan
FROM tb_biodata AS b
JOIN tb_employee AS e ON b.id = e.biodata_id
JOIN tb_leave_request AS ler ON e.id = ler.employee_id

