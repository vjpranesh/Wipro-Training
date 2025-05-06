CRUD OPERATIONS

CREATE TABLE Books (
     BookID INT PRIMARY KEY,
	 Title VARCHAR(100),
	 Author VARCHAR(100),
	 Genre VARCHAR(50),
	 Price DECIMAL(8,2),
	 PublisherYear INT
);

INSERT
INSERT INTO Books (BookID, Title, Author, Genre, Price, PublisherYear)
VALUES
(1, 'Atomic Habits', 'James Clear', 'Self-help', 499.0, 2018),
(2, 'The Alchemist', 'Paulo Coelho', 'Fiction', 299.0, 1993),
(3, 'Clean Code', 'Robert C.Martin', 'Programming', 799.0, 2008),
(4, 'Sapiens', 'Yuval Noah Harari', 'History', 599.0, 2015);


SELECT
SELECT * FROM Books


UPDATE
UPDATE Books
SET Price = 699.0
WHERE BookID = 2;

DELETE
DELETE FROM Books WHERE BookID = 1;

