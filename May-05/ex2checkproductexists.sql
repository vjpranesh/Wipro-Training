CREATE
CREATE PROCEDURE CheckProductExists
     @ProductID INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
	   PRINT 'Product Exists'
	ELSE
	   PRINT 'Product not found'
END;

EXEC
EXEC CheckProductExists @ProductID = 1;