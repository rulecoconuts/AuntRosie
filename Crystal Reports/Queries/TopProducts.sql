
SELECT	TOP 1
		ProductName, 
		ProductType,
		SizeValue,
		Unit,
		Price, 

		'Weekly' AS Sort
FROM dbo.tblProduct
LEFT JOIN dbo.tblProductItem
	ON tblProductItem.ProductID = tblProduct.ProductID
LEFT JOIN dbo.tblProduction
	ON tblProduction.ProductItemID = tblProductItem.ProductItemID
LEFT JOIN dbo.tblEventProduct
	ON tblEventProduct.ProductionID = tblProduction.ProductionID
LEFT JOIN dbo.tblSaleProducts
	ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID
LEFT JOIN dbo.tblSale
	ON tblSale.SaleID = tblSaleProducts.SaleID
LEFT JOIN dbo.tblProductSize
	ON tblProductSize.SizeID = tblProductItem.SizeID
WHERE SaleDateTime >= DATEPART(WEEK, GETDATE())


UNION 

SELECT	TOP 1
		ProductName, 
		ProductType,
		SizeValue,
		Unit,
		Price,  
		'Monthly' AS Sort
FROM dbo.tblProduct
LEFT JOIN dbo.tblProductItem
	ON tblProductItem.ProductID = tblProduct.ProductID
LEFT JOIN dbo.tblProduction
	ON tblProduction.ProductItemID = tblProductItem.ProductItemID
LEFT JOIN dbo.tblEventProduct
	ON tblEventProduct.ProductionID = tblProduction.ProductionID
LEFT JOIN dbo.tblSaleProducts
	ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID
LEFT JOIN dbo.tblSale
	ON tblSale.SaleID = tblSaleProducts.SaleID
LEFT JOIN dbo.tblProductSize
	ON tblProductSize.SizeID = tblProductItem.SizeID
WHERE SaleDateTime >= DATEPART(MONTH, GETDATE())

UNION

SELECT	TOP 1
		ProductName, 
		ProductType,
		SizeValue,
		Unit,
		Price, 
		'Yearly' AS Sort
FROM dbo.tblProduct
LEFT JOIN dbo.tblProductItem
	ON tblProductItem.ProductID = tblProduct.ProductID
LEFT JOIN dbo.tblProduction
	ON tblProduction.ProductItemID = tblProductItem.ProductItemID
LEFT JOIN dbo.tblEventProduct
	ON tblEventProduct.ProductionID = tblProduction.ProductionID
LEFT JOIN dbo.tblSaleProducts
	ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID
LEFT JOIN dbo.tblSale
	ON tblSale.SaleID = tblSaleProducts.SaleID
LEFT JOIN dbo.tblProductSize
	ON tblProductSize.SizeID = tblProductItem.SizeID
WHERE SaleDateTime >= DATEPART(YEAR, GETDATE())

GROUP BY dbo.tblProduct.ProductID, ProductName, ProductType, SizeValue, Unit, Price
