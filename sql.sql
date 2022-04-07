SELECT Product.name, Category.name
FROM Product
LEFT JOIN Product_in_category AS pic ON Product.id = pic.product_id
LEFT JOIN Category ON pic.category_id = Category.id
