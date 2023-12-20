CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	profile_image VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_reg DATE NULL
)
﻿

INSERT INTO users (username, password, profile_image, role, status, date_reg) VALUES('admin','admin954','','Admin','Active','2023-12-1')

CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY (1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	prod_type VARCHAR(MAX) NULL,
	prod_stock INT NULL,
	prod_price FLOAT NULL,
	prod_status VARCHAR(MAX) NULL,
	prod_image VARCHAR(MAX) NULL,
	date_insert DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL
)


CREATE TABLE orders
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	prod_type VARCHAR(MAX) NULL,
	prod_price FLOAT NULL,
	order_date DATE NULL,
	delete_order DATE NULL,
	qty INT NULL
)


CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	total_price FLOAT NULL,
	date DATE NULL,
	amount FLOAT NULL,
	change FLOAT NULL
)
