USE NORTHWND
SELECT country FROM [dbo].[Customers]
SELECT DISTINCT country from[dbo].[Customers]
SELECT DISTINCT city from[dbo].[Customers]
SELECT * FROM dbo.Customers ORDER BY Country DESC
SELECT * FROM dbo.Customers WHERE[CompanyName] LIKE 'a%' 
SELECT * FROM dbo.Customers WHERE CompanyName LIKE '_r%'
USE NORTHWND
Go
--SELECT * FROM dbo.Customers WHERE	city='London'
UPDATE dbo.Customers SET CompanyName='Markham Cosco' WHERE CustomerID='AROUT'
USE NORTHWND
GO	
--DELETE FROM	dbo.Customers WHERE CustomerID='AROUT'
SELECT * from[dbo].[Orders]WHERE CustomerID='AROUT'

USE Market
GO
SELECT * FROM dbo.customers 
DELETE FROM dbo.customers WHERE	customerID=11
