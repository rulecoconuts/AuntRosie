
SELECT EventName,
		EventDate,
		LocationName,
		LocationCity,
		LocationStreet,
		ExpenseValue,
		ProductName,
		price,
		(CAST(ExpenseValue / price AS INTEGER)) AS RequiredProducts

FROM dbo.tblEvent
JOIN dbo.tblEventLocation
	ON tblEventLocation.LocationID = tblEvent.LocationID
JOIN dbo.tblEventExpenses
	ON tblEventExpenses.EventID = tblEvent.EventID
JOIN dbo.tblMiscellaneousExpense
	ON tblMiscellaneousExpense.ExpenseID = tblEventExpenses.ExpenseID
LEFT JOIN dbo.tblEventProduct
	ON tblEventProduct.EventID = tblEvent.EventID
LEFT JOIN dbo.tblProduction
	ON tblProduction.ProductionID = tblEventProduct.ProductionID
LEFT JOIN dbo.tblProductItem
	ON tblProductItem.ProductItemID = tblProduction.ProductItemID
LEFT JOIN dbo.tblProduct
	ON tblProduct.ProductID = tblProductItem.ProductID
GROUP BY EventName,
		EventDate,
		LocationName,
		LocationCity,
		LocationStreet,
		ExpenseValue,
		ProductName,
		Price
