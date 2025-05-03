CREATE
CREATE TABLE Students (
      StudentID INT PRIMARY KEY,
	  FIRSTNAME VARCHAR(50),
	  LASTNAME VARCHAR(50),
	  Age INT,
	  Department VARCHAR(50),
	  Marks INT
);

INSERT INTO Students (StudentID, FirstName, LastName, Age, Department, Marks)
VALUES
(1, 'Amit', 'Sharma',21, 'Computer Science', 85),
(2, 'Neha', 'Kumar', 22,'Electronics', 78),
(3, 'Rahul', 'Verma', 20,'Mechanical', 66),
(4, 'Sneha', 'Singh',23 ,'Computer Science',91 );

SELECT * FROM Students
WHERE Department = 'Computer Science';

SELECT FirstName , Marks FROM Students
WHERE Marks > 80;

UPDATE Students
SET Marks = 95
WHERE StudentID = 2;

INSERT INTO Students (StudentID, FirstName, LastName, Age, Department, Marks)
VALUES
(5, 'Ram', 'Kumar',21, 'Computer Science', 77),
(6, 'Arun', 'Ram', 23,'Mechanical', 65);

DELETE FROM Students WHERE Marks < 50;

DELETE FROM Students WHERE StudentID = 3;

TRUNCATE TABLE Students; -- data is removed but table is present

DROP TABLE Students;