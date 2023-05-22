SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products AS p
LEFT JOIN ProductsCaregories AS pc on pc.ProductId = p.Id
LEFT JOIN Categories AS c on c.Id = pc.CategoryId