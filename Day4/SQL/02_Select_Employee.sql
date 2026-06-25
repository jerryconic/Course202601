USE db01;

--Ctrl + Shift + R
SELECT * FROM dbo.Employee
WHERE emp_id = 3;

SELECT * FROM dbo.Employee
WHERE salary < 40000;

SELECT * FROM dbo.Employee
WHERE birthdate >= '1992-1-1';

SELECT * FROM dbo.Employee
WHERE emp_name <> 'John';

SELECT * FROM dbo.Employee
WHERE emp_id IN (1, 3, 5);

SELECT * FROM dbo.Employee
WHERE salary BETWEEN 30000 AND 40000;

SELECT * FROM dbo.Employee
WHERE emp_name LIKE 'A%';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE '%A';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE '%A%';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE 'J___';

SELECT * FROM dbo.Employee
WHERE emp_name LIKE 'J____';

UPDATE dbo.Employee
SET emp_name = 'xxx', salary = 0
WHERE emp_id = 4;

DELETE FROM dbo.Employee
WHERE emp_id = 3;

SELECT * FROM dbo.Employee;