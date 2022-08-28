--5. Display all customer details
SELECT * FROM tblCustomer

--6. Write a query to display Country whose name starts with A or I
SELECT Country FROM tblCustomer WHERE Country LIKE 'a%' or Country LIKE 'i%'

--7 .Write a query to display whose name of customer whose third character is i
SELECT Firstname FROM tblCustomer WHERE Firstname LIKE '__i%'