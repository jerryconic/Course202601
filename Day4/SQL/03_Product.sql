USE db01;

DROP TABLE IF EXISTS dbo.Product;

CREATE TABLE dbo.Product
(
prdt_id int PRIMARY KEY,
prdt_name nvarchar(20),
price int
);

INSERT INTO dbo.Product(prdt_id, prdt_name, price)
VALUES(1, 'A-Product', 99999);

UPDATE dbo.Product
SET prdt_name = 'XXX', price = 0
WHERE prdt_id = 1;

DELETE FROM dbo.Product
WHERE prdt_id = 1;

SELECT * FROM dbo.Product
