--SQL Assignment 4

--4. Write a query to get most expense and least expensive Product list (name and unit price).
Select ProductName,UnitPrice
from tblProduct
where UnitPrice = (Select Max(UnitPrice) from tblProduct)
OR UnitPrice = (Select Min(UnitPrice) from tblProduct)
Order By UnitPrice Desc

--5. Display the list of products that are out of stock
Select Productname From tblProduct 
where IsDiscontinued=1

--8. Display complete list of customers, the OrderID and date of any orders they have made
Select tblcustomer.*,O.id,O.OrderDate From tblcustomer join tblorder as O
on tblcustomer.id = O.CustomerId
order by tblcustomer.Id

--9. Write  query that determines the customer who has placed the maximum number of orders
Select top 1 Customerid ,FirstName+ ' ' +LastName as Name, Count(*) as MaxOrders 
From tblOrder as O
join tblCustomer as C
on O.CustomerId =C.Id
group by CustomerId , FirstName+ ' ' +LastName
order by MaxOrders Desc

--10. Display the customerid whose name has substring ‘RA’
Select Id From Customer
Where FirstName+' '+LastName like '%RA%'

/* Data insufficient for answering questions 1,2,3,6,7,11 */