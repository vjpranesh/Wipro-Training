CREATE
CREATE TABLE Students (
     StudentID INT PRIMARY KEY,
	 FirstName VARCHAR(50),
	 Marks INT,
	 DOB DATE
);

INSERT
INSERT INTO Students (StudentID, FirstName, Marks, DOB)
VALUES
(1, 'Amit', 92, '2003-05-10'),
(2, 'Neha', 78, '2002-11-15'),
(3, 'Rahul', 61, '2004-01-20'),
(4, 'Sneha', 49, '2003-09-01');

SCALAR FUNCTION - UPPER 
SELECT FirstName, UPPER(FirstName) AS UpperName FROM Students;


SCALAR FUNCTION - DATEDIFF
SELECT FirstName, DATEDIFF(YEAR, DOB, GETDATE()) AS Age FROM Students;

AGGREGATE FUNCTION - COUNT
SELECT COUNT(*) AS TotalStudents FROM Students;


AGGREGATE FUNCTION - AVG
SELECT AVG(Marks) AS AverageMarks FROM Students;

CASE EXPRESSION
SELECT Name, Salary,
  CASE
      WHEN Salary >= 70000 THEN 'High'
	  WHEN Marks >= 75 THEN 'B'
	  WHEN Marks>= 60 THEN 'C'
	  ELSE 'D'
	END AS Grade
FROM Students;





