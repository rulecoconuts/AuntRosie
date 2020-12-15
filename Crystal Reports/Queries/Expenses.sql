
SELECT ExpensePayDate, ExpenseValue, ExpenseType,
	sum( case when ExpiryDate < GETDATE() then 1 else 0 end ) as TotalExpired,
	sum(Quantity*UnitPrice) AS TotalIngredientsCost
FROM dbo.tblMiscellaneousExpense
JOIN dbo.tblEventExpenses
	ON tblEventExpenses.ExpenseID = tblMiscellaneousExpense.ExpenseID
LEFT JOIN dbo.tblIngredientInventory
	ON tblIngredientInventory.PaymentMethod = tblMiscellaneousExpense.PaymentMethod
GROUP BY ExpensePayDate, ExpenseValue, ExpenseType