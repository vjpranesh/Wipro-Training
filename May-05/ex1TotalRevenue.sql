CREATE 
CREATE PROCEDURE GetProductRevenue
       @ProductID INT
AS
BEGIN 
     SELECT
         @ProductID AS ProductID,
         SUM(o.Quantity * p.Price) AS TotalRevenue
	 FROM Orders o
	 INNER JOIN Products p ON o.ProductID = p.ProductID
	 WHERE o.ProductID = @ProductID
END;

EXEC 
EXEC GetProductRevenue @ProductID = 1;