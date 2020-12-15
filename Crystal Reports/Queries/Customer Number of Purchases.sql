

SELECT 
	CustomerFirstName, 
	CustomerLastName,
	tblSale.SaleID,
	ProductName, 
	SaleQuantity AS 'Quantity',
	SalePrice AS 'Price',
	SaleQuantity*SalePrice AS 'Total'

FROM tblSale
JOIN tblCustomer 
	ON tblCustomer.CustomerID = tblSale.CustomerID
JOIN tblSaleProducts
	ON tblSaleProducts.SaleID = tblSale.SaleID
JOIN tblEventProduct
	ON tblEventProduct.EventProductID = tblSaleProducts.EventProductID
JOIN tblProduction
	ON tblProduction.ProductionID = tblEventProduct.ProductionID
JOIN tblProductItem
	ON tblProductItem.ProductItemID = tblProduction.ProductItemID
JOIN tblProduct
	ON tblProduct.ProductID = tblProductItem.ProductID
GROUP BY tblCustomer.CustomerFirstName, CustomerLastName, ProductName, tblSale.SaleID, SaleQuantity, SalePrice
ORDER BY CustomerFirstName, tblSale.SaleID