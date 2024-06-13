
-- Assume 2 tables Products, and Category and Many2Many relationship

SELECT Products.Name, Categories.Name FROM Products 
LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId 
LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.Id