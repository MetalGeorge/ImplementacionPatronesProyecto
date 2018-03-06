CREATE TABLE product
(
	id 			SERIAL,
	product_name 		VARCHAR,
	product_description 	VARCHAR,
	units_in_stock		INTEGER,
	product_category_id	INTEGER
)
WITH (
  OIDS=FALSE
);
ALTER TABLE product
  OWNER TO root;




CREATE TABLE product_category
(
	id 			SERIAL,
	category_name 		VARCHAR,
	product_description 	VARCHAR,
	parent_category_id	INTEGER
)
WITH (
  OIDS=FALSE
);
ALTER TABLE product
  OWNER TO root;



CREATE TABLE product_category_discount
(
	id 			SERIAL,
	product_category_id	INTEGER,
	discount_value		DECIMAL,
	discount_unit		VARCHAR,
	date_created		TIMESTAMP WITHOUT TIME ZONE,
	valid_until		TIMESTAMP WITHOUT TIME ZONE,
	coupon_code	 	VARCHAR,
	minimum_order_value	INTEGER,
	maximum_discount_amount	DECIMAL,
	is_redeem_allowed	BOOLEAN
)
WITH (
  OIDS=FALSE
);
ALTER TABLE product
  OWNER TO root;


CREATE TABLE product_pricing
(
	id 			SERIAL,
	product_id		INTEGER,
	discount_value		INTEGER,
	base_price		DECIMAL,
	date_created		TIMESTAMP WITHOUT TIME ZONE,
	date_expired		TIMESTAMP WITHOUT TIME ZONE,
	in_active		BOOLEAN
)
WITH (
  OIDS=FALSE
);
ALTER TABLE product
  OWNER TO root;



CREATE TABLE product_discount
(
	id 			SERIAL,
	product_id		INTEGER,
	discount_value		DECIMAL,
	discount_unit		VARCHAR,
	date_created		TIMESTAMP WITHOUT TIME ZONE,
	valid_until		TIMESTAMP WITHOUT TIME ZONE,
	coupon_code	 	VARCHAR,
	minimum_order_value	INTEGER,
	maximum_discount_amount	DECIMAL,
	is_redeem_allowed	BOOLEAN
)
WITH (
  OIDS=FALSE
);
ALTER TABLE product
  OWNER TO root;