
-- TopProductMarkets.sql
-- Date: 12/14/2020
--
-- This query displays per product type, the total sold products and the total revenue

SELECT ProductType,
		SUM(SaleQuantity) AS TotalQuantity, 
		dbo.tblProductItem.Price,
		(SUM(SaleQuantity)*price) AS TotalRevenue
FROM dbo.tblProduct
LEFT JOIN dbo.tblProductItem
	ON tblProductItem.ProductID = tblProduct.ProductID
LEFT JOIN dbo.tblProduction
	ON tblProduction.ProductItemID = tblProductItem.ProductItemID
LEFT JOIN dbo.tblEventProduct
	ON tblEventProduct.ProductionID = tblProduction.ProductionID
JOIN dbo.tblSaleProducts -- Only the products with a sale
	ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID
GROUP BY ProductType, Price
