SELECT 
	CustomerFirstName,
	tblCustomer.CustomerID,
	COUNT(tblSale.SaleID) AS totalSales,
	'Eligible' AS Status
FROM dbo.tblSale
JOIN dbo.tblSaleProducts
	ON tblSaleProducts.SaleID = tblSale.SaleID
JOIN dbo.tblCustomer 
	ON tblCustomer.CustomerID = tblSale.CustomerID
WHERE tblCustomer.CustomerID != 0
GROUP BY tblCustomer.CustomerID, CustomerFirstName

HAVING COUNT(tblSale.SaleID) > 5
UNION
SELECT 
	CustomerFirstName,
	tblCustomer.CustomerID,
	COUNT(tblSale.SaleID) AS totalSales,
	'Not Eligible' AS Status
FROM dbo.tblSale
JOIN dbo.tblSaleProducts
	ON tblSaleProducts.SaleID = tblSale.SaleID
JOIN dbo.tblCustomer 
	ON tblCustomer.CustomerID = tblSale.CustomerID
WHERE tblCustomer.CustomerID != 0
GROUP BY tblCustomer.CustomerID, CustomerFirstName

HAVING COUNT(tblSale.SaleID) < 5
ORDER BY Status, totalSales
