
SELECT ProductName, ServingSize, ValueType, Value 

FROM dbo.tblProduct
LEFT JOIN dbo.tblProductNutrition
	ON tblProductNutrition.ProductID = tblProduct.ProductID