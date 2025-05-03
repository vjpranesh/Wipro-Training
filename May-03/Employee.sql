CREATE
CREATE TABLE Employees (
     EmployeeID INT PRIMARY KEY,
	 FirstName VARCHAR(50),
	 LastName VARCHAR(50),
	 Department VARCHAR(50),
	 Salary DECIMAL(10,2),
	 HireDate DATE
);

INSERT
INSERT INTO EMPLOYEES (EmployeeID, FirstName, LastName, Department, Salary, HireDate)
VALUES
(1,'Ram', 'Kumar', 'Marketing', 10000.50,'2025-06-13'),
(2,'Anil', 'Varma', 'Finanace', 25000.50,'2024-08-15'),
(3,'Sneha', 'Singh', 'HR', 20000.50,'2023-06-11'),
(4,'Arjun', 'Raja', 'IT', 30000.50,'2022-08-13'),
(5,'Tilak', 'Kumar', 'Finance', 40000.50,'2021-06-25');

SELECT
select * from Employees

UPDATE
UPDATE Employees
SET Salary = 15000.75
WHERE EmployeeID = 1 ;

DELETE
DELETE FROM Employees WHERE FirstName ='Arjun';

