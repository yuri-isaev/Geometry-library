-- Таблица для продуктов
CREATE TABLE Products
(
    ProductId   INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255) NOT NULL
);

-- Таблица для категорий
CREATE TABLE Categories
(
    CategoryId   INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(255) NOT NULL
);

-- Таблица для связи продуктов и категорий (многие ко многим)
CREATE TABLE ProductCategories
(
    ProductId  INT,
    CategoryId INT,
    FOREIGN KEY (ProductId)  REFERENCES Products (ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories (CategoryId),
    PRIMARY KEY (ProductId, CategoryId)
);


-- В этом случае SQL-запрос для получения всех пар «Имя продукта – Имя категории»,
-- включая продукты без категорий, будет выглядеть следующим образом:
SELECT p.ProductName,
       c.CategoryName
FROM Products p
         LEFT JOIN
     ProductCategories pc ON p.ProductId = pc.ProductId
         LEFT JOIN
     Categories c ON pc.CategoryId = c.CategoryId
GO