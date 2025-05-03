CREATE 
CREATE TABLE Products (
     ProductID INT PRIMARY KEY,
	 ProductName VARCHAR(100),
	 Price DECIMAL(10,2)
);

CREATE TABLE Orders (
     OrderID INT PRIMARY KEY,
	 ProductID INT,
	 Quantity INT,
	 OrderDate DATE,
	 FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT
INSERT INTO Products (ProductID, ProductName, Price)
VALUES
(1, 'Laptop', 70000.00),
(2, 'Smartphone', 30000.00),
(3, 'Tablet', 20000.00),
(4, 'Monitor', 15000.00);

INSERT INTO Orders (OrderID, ProductID, Quantity, OrderDate)
VALUES
(101, 1, 2, '2024-12-10'),
(102, 2, 1, '2024-12-05'),
(103, 3, 3, '2024-12-10'),
(104, 1, 1, '2024-12-15'),
(105, 4, 2, '2024-12-20');


INNER JOIN
SELECT
      Orders.OrderID,
	  Products.ProductName,
	  Orders.Quantity,
	  Products.Price,
	  (Orders.Quantity * Products.Price) AS TotalAmount,
	  Orders.OrderDate
FROM Orders
INNER JOIN Products ON Orders.ProductID = Products.ProductID;

LEFT JOIN
SELECT
      Products.ProductID,
	  Products.ProductName,
	  Orders.OrderID,
	  Orders.Quantity,
	  Orders.OrderDate
FROM Products
LEFT JOIN Orders ON Products.ProductID = Orders.ProductID;

RIGHT JOIN
SELECT
      Products.ProductID,
	  Products.ProductName,
	  Orders.OrderID,
	  Orders.Quantity,
	  Orders.OrderDate
FROM Products
RIGHT JOIN Orders ON Products.ProductID = Orders.ProductID;

SUM AND GROUP BY
SELECT
     Products.ProductName,
	 SUM (Orders.Quantity) AS TotalUnitsSold
FROM Orders
INNER JOIN Products ON Orders.ProductID = Products.ProductID
GROUP BY Products.ProductName;
