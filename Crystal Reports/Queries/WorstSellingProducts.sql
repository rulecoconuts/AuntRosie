
SELECT ProductName, 
		SUM(SaleQuantity) AS totalQuantity,
		(SUM(SaleQuantity) * SalePrice) AS TotalSales
FROM dbo.tblProduct
JOIN dbo.tblProductItem
	ON tblProductItem.ProductID = tblProduct.ProductID
JOIN dbo.tblProduction
	ON tblProduction.ProductItemID = tblProductItem.ProductItemID
LEFT JOIN dbo.tblEventProduct
	ON tblEventProduct.ProductionID = tblProduction.ProductionID
LEFT JOIN dbo.tblSaleProducts
	ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID
LEFT JOIN dbo.tblSale
	ON tblSale.SaleID = tblSaleProducts.SaleID
GROUP BY ProductName, SalePrice
ORDER BY TotalSales ASC
OFFSET 0 ROWS FETCH FIRST 5 ROWS ONLY;
