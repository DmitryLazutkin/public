/*Так как отношение таблиц продукт и категорий многие-ко-многим, предполагаю следующую структуру БД:

product TABLE
 id - primary key
 name - varchar

 category TABLE
  id - primary key
  title - varchar

product_category TABLE
 product_id - foreign key to product table
 category_id - foreign key to product table

 Вспомогательная таблица product_category содержит все доступные пары продукт-категория
 Тогда ответ на задание:
*/
select name, title
from product p left join (product_category pc join category c on pc.category_id = c.id) pcc on p.id = pcc.product_id

