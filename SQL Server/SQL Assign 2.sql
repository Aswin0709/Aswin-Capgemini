-- SQL Server Assignment 2

--1. Display the details from Customer table who is from country Germany
SELECT * FROM tblCustomer 
WHERE Country = 'Germany'

--2. Display the  fullname of the employee 
SELECT Firstname +' '+Lastname AS Fullname FROM tblCustomer

/*3. Display the  customer details  who has Fax number
Fax number is not present in the table so Phone number is used */
SELECT * FROM tblCustomer 
WHERE Phone IS NOT NULL

--4. Display the customer details whoes name holds second letter as U
SELECT * FROM tblCustomer 
WHERE Firstname LIKE '_U%'

--5. Select order Details where unit price is greater than 10 and less than 20
SELECT  * FROM tblOrderItem 
WHERE UnitPrice > 10 and UnitPrice < 20

--6. Display order details which contains shipping date and arrange the order by date
SELECT * FROM tblOrder 
WHERE OrderDate IS NOT NULL ORDER BY OrderDate

--9. Print the average quantity ordered for every product
SELECT P.ProductName , AVG(OI.Quantity) AS AverageQuantity 
FROM tblProduct AS P INNER JOIN tblOrderItem AS OI 
ON OI.ProductId = P.Id
GROUP BY P.ProductName

/* Data insufficient for answering questions 7,8,10,11,12,13 */ 



