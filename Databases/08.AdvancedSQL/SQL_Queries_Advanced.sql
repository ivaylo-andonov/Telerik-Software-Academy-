USE TelerikAcademy

/*Task 01 Write a SQL query to find the names and salaries of the employees that take 
	the minimal salary in the company.Use a nested SELECT statement.*/
SELECT FirstName + ' ' + LastName AS FullName, Salary
	FROM Employees
	WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

/*Task 02 Write a SQL query to find the names and salaries of the employees that have a salary 
	that is up to 10% higher than the minimal salary for the company.*/
SELECT FirstName + ' ' + LastName AS FullName, Salary
	FROM Employees
	WHERE Salary <= 1.1 *
	(SELECT MIN(Salary) FROM Employees)
	ORDER BY Salary

/* Task 03 Write a SQL query to find the full name, salary and department of the employees
	 that take the minimal salary in their department. Use a nested SELECT statement.*/
SELECT e.FirstName + ' ' + e.LastName AS FullName, e.Salary, d.Name AS Department
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID
	 AND Salary =
	(SELECT MIN(Salary) FROM Employees em
	WHERE em.DepartmentID = e.DepartmentID)

--SECOND WAY
--SELECT e.FirstName + ' ' + e.LastName AS FullName, e.Salary, d.Name AS Department
--	FROM Employees e
--	JOIN Departments d
--	ON e.DepartmentID = d.DepartmentID
--	WHERE Salary = 
--	(SELECT MIN(Salary) FROM Employees em
--    WHERE em.DepartmentID = e.DepartmentID)

/* Tasks 04 Write a SQL query to find the average salary in the department #1.*/
SELECT AVG(e.Salary) AS [Average Salary], d.Name AS [Department]
	FROM Employees e, Departments d
	WHERE d.DepartmentID = 1
	GROUP BY d.Name

--SECOND WAY
--SELECT AVG(e.Salary) AS Average Salary, MIN(d.Name) AS Department
--	FROM Employees e, Departments d
--	WHERE d.DepartmentID = 1

/* Task 05 Write a SQL query to find the average salary in the "Sales" department. */
SELECT AVG(e.Salary) AS AverageSalary, d.Name AS Department
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'
	GROUP BY d.Name

/* Task 06 Write a SQL query to find the number of employees in the "Sales" department.*/
SELECT COUNT(*) AS NumberEmployees, MIN(d.Name) AS Department
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID AND d.Name = 'Sales'

/* Task 07 Write a SQL query to find the number of all employees that have manager.*/ 
SELECT COUNT(ManagerID) AS EmployeeWithManager
	FROM Employees

/* Task 08 Write a SQL query to find the number of all employees that have no manager. */
SELECT COUNT(*) AS [Employee with NO Manager]
	FROM Employees
	WHERE ManagerID IS NULL

/* Task 09 Write a SQL query to find all departments and the average salary for each of them.*/
SELECT AVG(e.Salary) AS [Average Salary], d.Name AS Department
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID 
	GROUP BY d.Name

/* Task 10 Write a SQL query to find the count of all employees in each department and for each town.*/
SELECT COUNT(*) AS [E count], d.Name AS [Department], t.Name AS [Town]
	FROM Employees e
	JOIN Departments d
	  ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
	  ON e.AddressID = a.AddressID
	JOIN Towns t
	  ON a.TownID = t.TownID
	GROUP BY t.Name, d.Name

/* Task 11 Write a SQL query to find all managers that have exactly 5 employees. 
	Display their first name and last name.*/  
SELECT m.FirstName + ' ' +  m.LastName AS FullName, COUNT(e.ManagerID) AS EmployeesCount
	FROM Employees e, Employees m
	WHERE e.ManagerID = m.EmployeeID	
	GROUP BY m.FirstName, m.LastName
	HAVING COUNT(e.ManagerID) = 5

/* Task 12 Write a SQL query to find all employees along with their managers. 
	For employees that do not have manager display the value "(no manager)".*/
SELECT e.FirstName + ' ' + e.LastName AS Employee, 
	ISNULL(m.FirstName + ' ' + m.LastName, '(no manager)') AS Manager
	FROM Employees e
	LEFT JOIN Employees m
	ON e.ManagerID = m.EmployeeID

/* Task 13 Write a SQL query to find the names of all employees whose last name 
	is exactly 5 characters long. Use the built-in LEN(str) function.*/
SELECT LastName
	FROM Employees
	WHERE LEN(LastName) = 5

/* Task 14 Write a SQL query to display the current date and time in the following format 
	"day.month.year hour:minutes:seconds:milliseconds".*/
SELECT CONVERT(varchar, GETDATE(), 113) AS [Current Date And Time]

/* Task 15 Write a SQL statement to create a table Users. Users should have username, password,
	full name and last login time.
	-Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
	-Define the primary key column as identity to facilitate inserting records.
	-Define unique constraint to avoid repeating usernames.
	-Define a check constraint to ensure the password is at least 5 characters long.*/
CREATE TABLE Users (
	UserId int IDENTITY,
	Username nvarchar(50) NOT NULL,
	Password nvarchar(50) NOT NULL,
	FullName nvarchar(150) NOT NULL,
	LastLogin datetime DEFAULT(GETDATE()), 
 	CONSTRAINT PK_Users PRIMARY KEY(UserId),
	UNIQUE (Username),
	CHECK (LEN(Password) >= 5)
)
GO

/*  Task 16 Write a SQL statement to create a view that displays the users from the Users table that 
	have been in the system today.*/
CREATE VIEW [All Users From Today] AS
SELECT *
FROM Users
	WHERE CONVERT(varchar, GETDATE(), 112) = CONVERT(varchar, LastLogin, 112)
GO

/* Task 17 Write a SQL statement to create a table Groups. Groups should have unique name 
	(use unique constraint).
	Define primary key and identity column.*/
CREATE TABLE Groups (
	GroupId int IDENTITY,
	Name nvarchar(50) NOT NULL,
 	CONSTRAINT PK_Groups PRIMARY KEY(GroupId),
	UNIQUE (Name)
)
GO

/* Task 18 Write a SQL statement to add a column GroupID to the table Users.
	Fill some data in this new column and as well in the `Groups table.
	Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.*/
ALTER TABLE Users
	ADD 
	GroupId int NOT NULL
GO

ALTER TABLE Users
	ADD
	CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupId)
	REFERENCES Groups(GroupId)
GO

/* Task 19 Write SQL statements to insert several records in the Users and Groups tables.*/
INSERT INTO Groups (Name) VALUES
	('Noobs'),
	('Rugby players'),
	('Javascript Ninjas'),
	('Negrite')
GO

INSERT INTO Users (Username, Password, FullName, LastLogin, GroupId) VALUES
	('Johnny5', 'trickyone','Jonny', GETDATE(),2),
	('John Hon', 'japan1234','Gogo', GETDATE(),1),
	('Lise', 'ilikepink','Lisaa', GETDATE(),1),
	('Natasha', 'catslover','Babyy', GETDATE(),3),
	('John Snow', 'ilikethenorth','Ivvs', GETDATE(),4),
	('Penelope Cruz', 'sexylatina','SUzi', GETDATE(),1)
GO

/* Task 20 Write SQL statements to update some of the records in the Users and Groups tables.*/

UPDATE Groups
	SET Name = 'JS Applications'
	WHERE Name LIKE 'JS%'

UPDATE Users
	SET UserName = 'Fernando Fragolini'
	WHERE Username = 'Lise'

UPDATE Users
SET LastLogin = '2015.05.05'
WHERE Username = 'Natasha'

UPDATE Users
	SET FullName = 'Snowyyy'
	WHERE Username LIKE '%Snow'

/* Task 21 Write SQL statements to delete some of the records from the Users and Groups tables.*/
DELETE FROM Users
	WHERE Username = 'John Snow'
GO

DELETE FROM Users
	WHERE Password LIKE '%sexy%'
GO

/*Task 22: Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--	Combine the first and last names as a full name.
--	For username use the first letter of the first name + the last name (in lowercase).
--	Use the same for the password, and NULL for last login time.
	(There are duplicating usernames when we get only the first letter of FirstName so we get the first 3).*/
INSERT INTO Users(Username, Password, FullName, LastLogIn, GroupId)
SELECT  LEFT(FirstName, 3) + LOWER(LastName),
		LEFT(FirstName, 3) + LOWER(LastName),
		FirstName + ' ' + LastName,
		NULL,3
FROM Employees

/* Task 23 Write a SQL statement that changes the password to NULL for all users that have 
	not been in the system since 10.03.2010. */
UPDATE Users
	SET Password = NULL
	WHERE LastLogin <= CONVERT(DATE, '10.03.2010', 104)

/* Task 24 Write a SQL statement that deletes all users without passwords (NULL password). */

DELETE FROM Users
	WHERE Password IS NULL

/* Task 25 Write a SQL query to display the average employee salary by department and job title.*/
SELECT d.Name AS [Department], e.JobTitle, AVG(Salary) AS [Average Salary]
	FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name, e.JobTitle
	ORDER BY [Average Salary] DESC

--Task 26: Write a SQL query to display the minimal employee salary by department and 
--job title along with the name of some of the employees that take it.
SELECT d.Name AS [Department], e.JobTitle, MIN(Salary) AS [Average Salary], MIN(e.FirstName + ' ' + e.LastName) AS [Employee Name on that job]
	FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name, e.JobTitle
	ORDER BY [Average Salary] DESC

/* Task 27 Write a SQL query to display the town where maximal number of employees work. */
SELECT TOP 1 t.Name AS [Town], COUNT(e.EmployeeID) as [EmployeesCount]
    FROM Employees e 
    JOIN Addresses a
        ON e.AddressID = a.AddressID
    JOIN Towns t
        ON t.TownID = a.TownID
    GROUP BY t.Name
    ORDER BY EmployeesCount DESC

/* Task 28 Write a SQL query to display the number of managers from each town.*/
SELECT t.Name, COUNT(DISTINCT e.EmployeeID) AS [Number of Managers]
	FROM Employees e
		JOIN Addresses a
		ON e.AddressID = a.AddressID
		JOIN Towns t
		ON a.TownID = t.TownID
		JOIN Employees m
		ON e.EmployeeID = m.ManagerID
	GROUP BY t.Name
	ORDER BY [Number of Managers] DESC

-- SECOND WAY
/*
SELECT t.Name AS [Town], COUNT(DISTINCT e.ManagerID) AS [Number of Managers]
FROM Employees e, Employees m, Addresses a, Towns t
WHERE 
	e.ManagerID = m.EmployeeID AND
	m.AddressID = a.AddressID AND
	a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Number of Managers] DESC
*/

/* Task 29 Write a SQL to create table WorkHours to store work reports for each employee 
	(employee id, date, task, hours, comments).
	- Don't forget to define identity, primary key and appropriate foreign key.	*/
CREATE TABLE WorkHours (
	WorkHourID int IDENTITY,
	EmployeeID int NOT NULL,
	[Date] datetime,
	Task nvarchar(100),
	[Hours] int,
	Comments nvarchar(500),
	CONSTRAINT PK_WorkHours PRIMARY KEY(WorkHourID),
	CONSTRAINT FK_WorkHourss_Employees FOREIGN KEY(EmployeeID)
	REFERENCES Employees(EmployeeID)
)
GO

INSERT INTO WorkHours(EmployeeID, [Date], Task, [Hours], Comments)
VALUES
(2, GETDATE(),'Read SQL', 8, 'Database homework'),
(3, GETDATE(),'Learn AppHarbour', 12, 'JS aplication'),
(4, GETDATE(),'Learn1 AppHarbour1', 10, 'JS aplication1')

UPDATE WorkHours
SET [Hours] = 5
WHERE EmployeeID = 2

DELETE FROM WorkHours
WHERE Task='Read SQL'

CREATE TABLE WorkHoursLogs (
	WorkHoursLogID int IDENTITY,
	WorkHourID int,
	EmployeeID int NOT NULL,
	[Date] datetime,
	Task nvarchar(100),
	[Hours] int,
	Comments nvarchar(500),
	Command nvarchar(30) NOT NULL,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(WorkHoursLogID),
	CONSTRAINT FK_WorkHoursLogs_Employees FOREIGN KEY(EmployeeID)
	REFERENCES Employees(EmployeeID)
)
GO

CREATE TRIGGER TR_WorhoursInsert ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkHourID, EmployeeID, [Date], Task, [Hours], Comments, Command)
SELECT  WorkHourID, EmployeeID, [Date], Task, [Hours], Comments, 'INSERT'
FROM inserted
GO

CREATE TRIGGER TR_WorhoursUpdate ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkHourID, EmployeeID, [Date], Task, [Hours], Comments, Command)
SELECT WorkHourID, EmployeeID, [Date], Task, [Hours], Comments, 'UPDATE'
FROM inserted
GO

CREATE TRIGGER TR_WorhoursDelete ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkHourID, EmployeeID, [Date], Task, [Hours], Comments, Command)
SELECT WorkHourID, EmployeeID, [Date], Task, [Hours], Comments, 'DELETE'
FROM deleted
GO

DELETE FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeID, [Date], Task, [Hours], Comments)
VALUES
(10, GETDATE(),'Test 1', 2, 'Test insert'),
(11, GETDATE(),'Test 2', 4, 'Test insert')

UPDATE WorkHours
SET Task = 'Almost finished'
WHERE EmployeeID = 11

DELETE FROM WorkHours
WHERE Task= 'Test 1'

/* Task 30 Start a database transaction, delete all employees from the 'Sales' department along with all dependent 
records from the pother tables. At the end rollback the transaction. */
BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees

DELETE FROM Employees
WHERE DepartmentID =
	(SELECT DepartmentID FROM Departments
	WHERE Name = 'Sales')

ROLLBACK TRAN


/* Task 31 tart a database transaction and drop the table EmployeesProjects.
	Now how you could restore back the lost table data?*/
BEGIN TRAN 
	DROP TABLE EmployeeProjects
ROLLBACK TRAN 

/* Task 32 Find how to use temporary tables in SQL Server.
	Using temporary tables backup all records from EmployeesProjects 
	and restore them back after dropping and re-creating the table. */
SELECT * 
	INTO #Temp FROM EmployeeProjects
	DROP TABLE EmployeeProjects
		SELECT * INTO EmployeeProjects FROM #Temp
		DROP TABLE #Temp