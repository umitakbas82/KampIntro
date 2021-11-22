--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City= 'London'


select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc --ascending --descending

Select COUNT (*) from Products where CategoryID =2

Select CategoryID, COUNT (*) from Products where UnitPrice>20  group by CategoryID having COUNT (*) < 10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryId =Categories.CategoryID
where Products.UnitPrice>10

--DTO DATA TRANSFORMATION OBJECT

Select * from Products p left join [Order Details] od on p.ProductID=od.ProductID 

Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where  o.CustomerID is null