CREATE
CREATE PROCEDURE GetAllProducts
AS
BEGIN
    SELECT * FROM Products;
END;

EXEC
EXEC GetAllProducts;

----
SELECT *, 'HigherEndProducts' AS ProductType
FROM Products
WHERE Price > 60000;

