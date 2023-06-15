--SQLQuizDay03

--Create Database
CREATE DATABASE DB_Sales;

--Table sales person
CREATE TABLE salesPerson(
ID int PRIMARY KEY IDENTITY(1,1),
name varchar(55),
bod date,
salary decimal(18,2)
);

INSERT INTO salesPerson(name, bod, salary)
VALUES
('Abe','9/11/1988',140000),
('Bob','9/11/1978',44000),
('Chris','9/11/1983',40000),
('Dan','9/11/1980',52000),
('Ken','9/11/1977',115000),
('Joe','9/11/1990',38000)

select * from salesPerson;

CREATE TABLE orders(
ID int PRIMARY KEY IDENTITY(1,1),
order_date date,
cust_id int,
salesperson_id int,
amount decimal(18,2)
);

SELECT * FROM orders;

INSERT INTO orders(order_date, cust_id, salesperson_id, amount)
VALUES
('8/2/2020', 4, 2, 540),
('1/22/2021', 4, 5, 1800),
('7/14/2019', 9, 1, 460),
('1/29/2018', 7, 2, 2400),
('2/3/2021', 6, 4, 600),
('3/2/2020', 6, 4, 720),
('5/6/2021', 9, 4, 150)

--DROP TABLE orders;

--Soal a
SELECT s.name, COUNT(o.salesperson_id) AS person_order
FROM salesPerson AS s
JOIN orders AS o ON s.ID = o.salesperson_id
GROUP BY s.name
HAVING COUNT(o.salesperson_id) > 1;

--soal b
SELECT s.name, SUM(o.amount) AS order_amount
FROM salesPerson AS s
JOIN orders AS o ON s.ID = o.salesperson_id
GROUP BY s.name
HAVING SUM(o.amount) > 1000;

--soal c (belum selesai)
SELECT s.name, s.bod, s.salary, SUM(o.amount) AS order_amount
FROM salesPerson AS s
JOIN orders AS o ON s.ID = o.salesperson_id
GROUP BY s.name, s.bod, s.salary
HAVING o.order_date > '2020'

--order >= 2020
--ORDER BY salesPerson.bod

--soal d
SELECT s.name, AVG(o.amount) AS rata2_amount
FROM salesPerson AS s
JOIN orders AS o ON s.ID = o.salesperson_id
GROUP BY s.name
ORDER BY AVG(o.amount) DESC

--soal e
SELECT s.name, COUNT(o.salesperson_id) AS person_order, SUM(o.amount) AS amount, (s.salary * 30 / 100) AS bonus
FROM salesPerson AS s
RIGHT JOIN orders AS o ON s.ID = o.salesperson_id
GROUP BY s.name, (s.salary * 30 / 100)
HAVING COUNT(o.salesperson_id) > 2 AND SUM(o.amount) > 1000;	

--soal f
SELECT s.ID, s.name, s.bod, s.salary
FROM salesPerson AS s
LEFT JOIN orders AS o ON s.ID = o.salesperson_id
WHERE o.salesperson_id IS NULL;

--soal g
SELECT s.ID, s.name, s.bod, s.salary, (s.salary * 2 / 100) AS potongan_gaji, (s.salary - (s.salary * 2 / 100)) AS gaji_sekarang
FROM salesPerson AS s
LEFT JOIN orders AS o ON s.ID = o.salesperson_id
WHERE o.salesperson_id IS NULL;

