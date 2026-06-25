/*
CREATE DATABASE db01;
*/

USE db01;

DROP TABLE IF EXISTS dbo.Employee;
CREATE TABLE dbo.Employee
(
emp_id int PRIMARY KEY,
emp_name nvarchar(20),
salary decimal(10, 2),
birthdate date
);


INSERT INTO dbo.Employee(emp_id, emp_name, salary, birthdate)
VALUES(1, 'John', 48000, '1990-1-1'),
(2, 'Peter', 42000, '1991-1-1'),
(3, 'Linda', 46000, '1992-1-1'),
(4, 'Alice', 38000, '1993-1-1');

SELECT * FROM dbo.Employee;

