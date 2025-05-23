CREATE
CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
	Name VARCHAR(50),
	Department VARCHAR(50),
	Salary DECIMAL(10,2),
	JoinDate DATE
);

INSERT
INSERT INTO Employees (EmpID, Name, Department, Salary, JoinDate)
VALUES
(1, 'John', 'HR', 50000, '2021-06-01'),
(2, 'Priya', 'Finance', 60000, '2020-09-15'),
(3, 'Amit', 'IT', 75000, '2019-01-10'),
(4, 'Sara', 'IT', 72000, '2023-02-25');

SCALAR FUNCTION - ROUND
SELECT Name, ROUND(Salary, -3) AS RoundedSalary FROM Employees;

AGGREGATE FUNCTION - MAX
SELECT Department, MAX(Salary) AS HighestSalary
FROM Employees
GROUP BY Department;

CASE EXPRESSION
SELECT Name, Salary,
  CASE
      WHEN Salary >= 70000 THEN 'High'
	  WHEN Salary >= 50000 THEN 'Medium'
	  ELSE 'Low'
	END AS SalaryBand
FROM Employees;


WINDOW FUNCTION - OVER()
SELECT
     Name,
	 Department,
	 Salary,
	 AVG(Salary) OVER() AS AvgSalary
FROM Employees;

WINDOW FUNCTION - PARTITION BY
SELECT
     Name,
	 Department,
	 Salary,
	 AVG(Salary) OVER(PARTITION BY Department) AS DeptAvgSalary
FROM Employees;

RANKING FUNCTION - ROW_NUMBER()
SELECT
     Name,
	 Department,
	 Salary,
	 ROW_NUMBER() OVER(PARTITION BY Department ORDER BY Salary DESC) AS RowNum
FROM Employees;

RANKING FUNCTION - RANK()
SELECT
     Name,
	 Department,
	 Salary,
	 RANK() OVER(ORDER BY Salary DESC) AS RankBySalary
FROM Employees;









