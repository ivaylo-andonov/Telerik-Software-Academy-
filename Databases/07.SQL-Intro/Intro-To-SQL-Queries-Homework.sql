USE [TelerikAcademy]

/* Task04 Write a SQL query to find all information about all departments (use "TelerikAcademy" database).*/
SELECT *
	FROM Departments

/* Task 05 Write a SQL query to find all department names.*/
SELECT Name AS DepartmentName
	FROM Departments

/* Task 06 Write a SQL query to find the salary of each employee, ordered by salary asc.*/
SELECT Salary 
	FROM Employees
	ORDER BY Salary ASC

/* Task 07 Write a SQL to find the full name of each employee.*/
SELECT FirstName + ' ' + LastName AS FullName
	FROM Employees

/* Task 08 Write a SQL query to find the email addresses of each employee (by his first and last name). 
Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
The produced column should be named "Full Email Addresses". */
SELECT 
	FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS [Full name],
	FirstName + '.' + LastName + '@.telerik.com' AS Email 
FROM Employees

/* Task 09 Write a SQL query to find all different employee salaries.*/
SELECT DISTINCT Salary AS [Different Salaries]
	FROM Employees

/* Tasks 10 Write a SQL query to find all information about the employees whose job title is “Sales Representative“. */
SELECT *
	FROM Employees
	WHERE JobTitle = 'Sales Representative'

/* Task 11 Write a SQL query to find the names of all employees whose first name starts with "SA". */
SELECT FirstName + ' ' + LastName AS FullName
	FROM Employees
	WHERE FirstName LIKE 'SA%'

/* Task 12 Write a SQL query to find the names of all employees whose last name contains "ei"*/
SELECT LastName
	FROM Employees
	WHERE LastName LIKE '%ei%'

/* Task 13 Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].*/
SELECT FirstName + ' ' + LastName AS FullName, Salary
	FROM Employees
	WHERE Salary BETWEEN 20000 AND 30000
	ORDER BY Salary DESC

/* Tasks 14 Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.*/
SELECT FirstName + ' ' + LastName AS FullName, Salary
	FROM Employees
	WHERE Salary IN (14000, 12500, 23600, 25000)
	ORDER BY Salary DESC

/* Task 15 Write a SQL query to find all employees that do not have manager. */
SELECT FirstName + ' ' + LastName AS FullName, ManagerID
	FROM Employees
	WHERE ManagerID IS NULL

/*Task 16 Write a SQL query to find all employees that have salary more than 50000. 
Order them in decreasing order by salary.*/
SELECT FirstName + ' ' + LastName AS FullName, Salary
	FROM Employees
	WHERE Salary > 50000
	ORDER BY Salary DESC

/*Task 17 Write a SQL query to find the top 5 best paid employees.*/
SELECT TOP 5 FirstName, LastName, Salary
	FROM Employees
	ORDER BY Salary DESC

/* Tsk 18 Write a SQL query to find all employees along with their address. Use inner join with ON clause.*/
SELECT e.FirstName + e.LastName AS FullName, a.AddressText AS Adress
	FROM Employees e
	INNER JOIN Addresses a 
	ON e.AddressID = a.AddressID

/* Task 19 Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).*/
SELECT e.FirstName + e.LastName AS FullName, a.AddressText AS Adress
	FROM Employees e, Addresses a 
	WHERE e.AddressID = a.AddressID

/* Task 20 Write a SQL query to find all employees along with their manager.*/
SELECT 
	e1.FirstName + ' ' + e1.LastName AS Employee, 
	e2.FirstName + ' ' + e2.LastName AS Manager
	FROM Employees e1, Employees e2
	WHERE e1.ManagerID = e2.EmployeeID

/* Task 21 Write a SQL query to find all employees, along with their manager and their address. 
Join the 3 tables: Employees e, Employees m and Addresses a. */
SELECT	
	e.FirstName + ' ' + e.LastName AS Employee,
	m.FirstName + ' ' + m.LastName AS Manager,
	a.AddressText AS EmployeeAdress
	FROM Employees e
		JOIN Employees m 
	ON e.ManagerID = m.EmployeeID 
		JOIN Addresses a
	ON e.AddressID = a.AddressID 

/* Task 22 Write a SQL query to find all departments and all town names as a single list. Use UNION.*/
SELECT Name AS [Town/Department]
	FROM Departments
	UNION 
	SELECT Name AS [Town/Department]
	FROM Towns

/*Task 23 Write a SQL query to find all the employees and the manager for each of them along with the employees 
that do not have manager. Use right outer join. Rewrite the query to use left outer join.*/
SELECT 
	 ISNULL(e.FirstName + ' ' + e.LastName, 'Nobody to manage') AS Employee,
	 m.FirstName + ' ' + m.LastName AS Manager
	 FROM Employees e
	 RIGHT JOIN Employees m
	 ON e.ManagerID = m.EmployeeID

--Second way

SELECT 
	 e.FirstName + ' ' + e.LastName AS Employee,
	 ISNULL(m.FirstName + ' ' + m.LastName, 'Has No Manager') AS Manager
	 FROM Employees e
	 LEFT JOIN Employees m
	 ON e.ManagerID = m.EmployeeID

/*24. Write a SQL query to find the first and last name of all employees 
from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
 Order the results by first name, then by last name, both in ascending order. */

SELECT 
	e.FirstName AS FirstName, e.LastName AS LastName
	FROM Employees e, Departments d
	WHERE e.DepartmentID = d.DepartmentID 
	AND d.Name IN ('Sales', 'Finance')
	AND e.HireDate BETWEEN '1995-01-01' AND '2005-12-31'
	ORDER BY e.FirstName ASC, e.LastName ASC