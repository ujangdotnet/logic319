--SQLDay04

 CREATE DATABASE DB_HR;

 --tabel karyawan
 CREATE TABLE tb_karyawan(
 id bigint NOT NULL PRIMARY KEY IDENTITY(1,1),
 nip varchar(50) NOT NULL,
 nama_depan varchar(50) NOT NULL,
 nama_belakang varchar(50) NOT NULL,
 jenis_kelamin varchar(50) NOT NULL,
 agama varchar(50) NOT NULL,
 tempat_lahir varchar(50) NOT NULL,
 tgl_lahir date,
 alamat varchar(100) NOT NULL,
 pendidikan_terakhir varchar(50) NOT NULL,
 tgl_masuk date
 );

 INSERT INTO tb_karyawan(nip, nama_depan, nama_belakang, jenis_kelamin, agama, tempat_lahir, tgl_lahir, alamat, pendidikan_terakhir, tgl_masuk)
 VALUES
 ('001','Hamidi','Samsudin','Pria','Islam','Sukabumi','1977-04-21','Jl.Sudirman No.12','S1 Teknik Mesin','2015-12-07'),
 ('002','Ghandi','Wamida','Wanita','Islam','Palu','1992-01-12','Jl.Rambutan No.22','SMA Negeri 02 Palu','2014-12-01'),
 ('003','Paul','Christian','Pria','Kristen','Ambon','1980-05-27','Jl.Veteran No.4','S1 Pendidikan Geografi','2014-01-12')

 
 --tabel divisi
 CREATE TABLE tb_divisi(
 id bigint NOT NULL PRIMARY KEY IDENTITY(1,1),
 kd_divisi varchar(50) NOT NULL,
 nama_divisi varchar(50) NOT NULL
 );

 INSERT INTO tb_divisi(kd_divisi, nama_divisi)
 VALUES
 ('GD','Gudang'),
 ('HRD','HRD'),
 ('KU','Keuangan'),
 ('UM','Umum')


 --tabel jabatan
 CREATE TABLE tb_jabatan(
 id bigint NOT NULL PRIMARY KEY IDENTITY(1,1),
 kd_jabatan varchar(50) NOT NULL,
 nama_jabatan varchar(50) NOT NULL,
 gaji_pokok numeric,
 tunjangan_jabatan numeric
 );

 INSERT INTO tb_jabatan(kd_jabatan, nama_jabatan, gaji_pokok, tunjangan_jabatan)
 VALUES
 ('MGR','Manager',5500000,1500000),
 ('OB','Office Boy',1900000,200000),
 ('ST','Staff',3000000,750000),
 ('WMGR','Wakil Manager',4000000,1200000)

 --tabel pekerjaan
 CREATE TABLE tb_pekerjaan(
 id bigint NOT NULL PRIMARY KEY IDENTITY(1,1),
 nip varchar(50) NOT NULL,
 kode_jabatan varchar(50) NOT NULL,
 kode_divisi varchar(50) NOT NULL,
 tunjangan_kinerja numeric,
 kota_penempatan varchar(50)
 );

 INSERT INTO tb_pekerjaan(nip, kode_jabatan, kode_divisi, tunjangan_kinerja, kota_penempatan)
 VALUES
 ('001','ST','KU',750000,'Cianjur'),
 ('002','OB','UM',350000,'Sukabumi'),
 ('003','MGR','HRD',1500000,'Sukabumi')

 SELECT * FROM tb_karyawan;
 SELECT * FROM tb_divisi;
 SELECT * FROM tb_jabatan;
 SELECT * FROM tb_pekerjaan;

 --EXEC sp_rename 'tb_jabatan.tumjangan_jabatan', 'tunjangan_jabatan';

 --Soal 1
 SELECT k.nama_depan + ' ' + k.nama_belakang AS nama_lengkap, j.nama_jabatan, j.gaji_pokok + j.tunjangan_jabatan AS gaji_tunjangan
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 WHERE j.gaji_pokok + j.tunjangan_jabatan < 5000000;

 --Soal 2
 SELECT (k.nama_depan + ' ' + k.nama_belakang) AS nama_lengkap, j.nama_jabatan, d.nama_divisi,
 (j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja) AS total_gaji,
 (0.05 * (j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)) AS pajak,
 ((j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja) - (0.05 * (j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja))) AS gaji_bersih
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 JOIN tb_divisi AS d ON p.kode_divisi = d.kd_divisi
 WHERE p.kota_penempatan <> 'Sukabumi' AND k.jenis_kelamin = 'Pria'

 --Soal 3
 SELECT k.nip, (k.nama_depan + ' ' + k.nama_belakang) AS nama_lengkap,  j.nama_jabatan, d.nama_divisi,
 (0.25*((j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)*7)) AS bonus
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 JOIN tb_divisi AS d ON p.kode_divisi = d.kd_divisi

 --Soal 4
 SELECT k.nip, CONCAT(k.nama_depan,' ',k.nama_belakang) AS nama_lengkap, j.nama_jabatan, d.nama_divisi,
 (j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja) AS total_gaji,
 (0.05*(j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)) AS infaq
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 JOIN tb_divisi AS d ON p.kode_divisi = d.kd_divisi
 WHERE p.kode_jabatan = 'MGR'

  

 --Soal 5
 SELECT k.nip, (k.nama_depan + ' ' + k.nama_belakang) AS nama_lengkap, j.nama_jabatan, k.pendidikan_terakhir,
 (2000000) AS tunjangan_pendidikan,
 (j.gaji_pokok+j.tunjangan_jabatan+ 2000000) AS total_gaji
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 WHERE k.pendidikan_terakhir LIKE 'S1%'

 --Soal 6
 SELECT k.nip, (k.nama_depan + ' ' + k.nama_belakang) AS nama_lengkap,  j.nama_jabatan, d.nama_divisi, 
 CASE
	WHEN p.kode_jabatan = 'MGR' THEN 0.25*((j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)*7)
	WHEN p.kode_jabatan = 'ST' THEN 0.25*((j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)*5)
	ELSE 0.25*((j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)*2)
 END AS bonus
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 JOIN tb_divisi AS d ON p.kode_divisi = d.kd_divisi
 
 --Soal 7
 ALTER TABLE tb_karyawan
 ADD CONSTRAINT UNIQUE_nip UNIQUE (nip);

 ALTER TABLE tb_karyawan
 DROP CONSTRAINT UNIQUE_nip;

 --Soal 8
 CREATE INDEX idx_nip
 ON tb_karyawan(nip);

 DROP INDEX idx_nip ON tb_karyawan;

 --Soal 9
 SELECT k.nama_depan + ' ' + UPPER(k.nama_belakang) AS nama_lengkap
 FROM tb_karyawan AS k
 WHERE k.nama_belakang LIKE '%W%' 

 SELECT --k.nama_depan + ' ' + k.nama_belakang AS nama_lengkap,
 CASE
	WHEN k.nama_belakang LIKE '%W%' THEN k.nama_depan + ' ' + UPPER(k.nama_belakang)
	ELSE k.nama_depan + ' ' + k.nama_belakang
 END AS nama_lengkap
 FROM tb_karyawan AS k
 WHERE k.nama_belakang LIKE '%W%' 



 --Soal 10
 SELECT k.nip, (k.nama_depan + ' ' + k.nama_belakang) AS nama_lengkap, k.tgl_masuk, j.nama_jabatan, d.nama_divisi,
 (j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja) AS total_gaji,
 DATEDIFF(YEAR, k.tgl_masuk, GETDATE()) AS lama_bekerja,
 CASE
	WHEN DATEDIFF(YEAR, k.tgl_masuk, GETDATE()) >= 8 THEN 0.1 * (j.gaji_pokok+j.tunjangan_jabatan+p.tunjangan_kinerja)
 END AS bonus
 FROM tb_karyawan AS k
 JOIN tb_pekerjaan AS p ON k.nip = p.nip
 JOIN tb_jabatan AS j ON p.kode_jabatan = j.kd_jabatan
 JOIN tb_divisi AS d ON p.kode_divisi = d.kd_divisi
 WHERE DATEDIFF(YEAR, k.tgl_masuk, GETDATE()) >= 8;
