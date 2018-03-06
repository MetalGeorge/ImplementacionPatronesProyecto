INSERT INTO public.product_category(
            category_name, product_description, parent_category_id)
    VALUES ('Deportes', 'Deportes', 0);
    
INSERT INTO public.product_category(
            category_name, product_description, parent_category_id)
    VALUES ('Ropa', 'Ropa', 0);
    
INSERT INTO public.product_category(
            category_name, product_description, parent_category_id)
    VALUES ('Casa', 'Casa', 0);        



INSERT INTO public.product(
            product_name, product_description, units_in_stock, product_category_id)
    VALUES ('Pelota', 'Pelota', 10, 1);

INSERT INTO public.product(
            product_name, product_description, units_in_stock, product_category_id)
    VALUES ('Guantes', 'Guantes portero', 1, 1);

INSERT INTO public.product(
            product_name, product_description, units_in_stock, product_category_id)
    VALUES ('Camisa', 'Camisa varón', 10, 2);

INSERT INTO public.product(
            product_name, product_description, units_in_stock, product_category_id)
    VALUES ('Vestido rojo', 'Vestido dama', 10, 2);

INSERT INTO public.product(
            product_name, product_description, units_in_stock, product_category_id)
    VALUES ('FLorero', 'FLorero', 10, 3);

INSERT INTO public.product(
            product_name, product_description, units_in_stock, product_category_id)
    VALUES ('Cuadro', 'Cuadro', 10, 3);
    
