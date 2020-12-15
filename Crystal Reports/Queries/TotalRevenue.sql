

SELECT 
	
	-- Represents the total sales from all products sold
	(dbo.tblProductItem.price*(Count(soldQuantity))) AS totalSales,
	
	-- Represents the total products sold
	COUNT(soldQuantity) AS totalSoldProducts,

	-- Represents the total existing customers
	(SELECT 
		COUNT(dbo.tblCustomer.CustomerID) 
		FROM dbo.tblCustomer
		WHERE CustomerID!=0) AS existingCustomers,

	-- Total Customers ever
	(SELECT COUNT(CustomerID) 
		FROM dbo.tblSale) AS totalCustomers,

	-- Total Events
	(SELECT COUNT(dbo.tblEvent.EventID) FROM dbo.tblEvent) AS totalEvents,

	-- Total Locations
	(SELECT COUNT(LocationID)
		FROM dbo.tblEventLocation) AS totalLocations,

	-- Total Revenue - Expenses
	((dbo.tblProductItem.price*(Count(soldQuantity))) - ExpenseValue) AS FinalRevenue

FROM dbo.tblProduct
JOIN dbo.tblProductItem
	ON tblProductItem.ProductID = tblProduct.ProductID
JOIN dbo.tblProduction	
	ON tblProduction.ProductItemID = tblProductItem.ProductItemID
JOIN dbo.tblEventProduct	
	ON tblEventProduct.ProductionID = tblProduction.ProductionID
JOIN dbo.tblSaleProducts
	ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID
JOIN dbo.tblEventExpenses
	ON tblEventExpenses.EventID = tblEventProduct.EventID
JOIN dbo.tblMiscellaneousExpense
	ON tblMiscellaneousExpense.ExpenseID = tblEventExpenses.ExpenseID
GROUP BY ProductType, Price, ExpenseValue