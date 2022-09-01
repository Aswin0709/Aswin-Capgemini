--SQL Assignment 3

--1. Write a query to display the orders placed by customer with phone number 030-0074321
Select * from tblOrder 
where CustomerId = 
(select Id from tblCustomer 
where Phone = '030-0074321')

--3. Display the orders placed by customers not in London
Select * from tblOrder as O 
join tblCustomer as C on O.CustomerId = C.id Where C.City != 'London'

--4. Selects all the order which are placed for the product Chai.
Select * from tblOrder O where  O.id in (
    Select OI.Orderid from tblOrderItem as OI 
    join tblProduct as P on P.id = OI.ProductId
    where P.ProductName ='Chai')
     
/* Data insufficient for answering question 2,5 */
