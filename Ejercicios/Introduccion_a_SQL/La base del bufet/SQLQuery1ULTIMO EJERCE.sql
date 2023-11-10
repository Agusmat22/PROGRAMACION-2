CREATE TABLE Proveedores(
Numero_Proveedor int not null,
Nombre varchar(30),
Domicilio varchar(50),
Localidad varchar(80)
CONSTRAINT PK_Numero_Proveedor PRIMARY KEY (Numero_Proveedor)
)


CREATE TABLE Productos(
Codigo_Producto int NOT NULL,
Nombre varchar(30),
Precio float,
Dimensiones varchar(20)
CONSTRAINT PK_Codigo_Producto PRIMARY KEY (Codigo_Producto)
)

CREATE TABLE Envios(
Numero_Proveedor int NOT NULL,
Codigo_Producto int NOT NULL,
Cantidad int NOT NULL,
)

--INGRESAR PROVEEDORES
INSERT INTO Proveedores (Numero_Proveedor,Nombre,Domicilio,Localidad) 
VALUES (100,'Perez','Peron 876','Quilmes')

INSERT INTO Proveedores (Numero_Proveedor,Nombre,Domicilio,Localidad) 
VALUES (101,'Gimenez','Mitre 546','Avellaneda')

INSERT INTO Proveedores (Numero_Proveedor,Nombre,Domicilio,Localidad) 
VALUES (102,'Aguirre','Peron 876','Bernal')

--INGRESAR PRODUCTOS

INSERT INTO Productos(Codigo_Producto,Nombre,Precio,Dimensiones) 
VALUES (1,'Caramelos',1.5,'Chico')

INSERT INTO Productos (Codigo_Producto,Nombre,Precio,Dimensiones) 
VALUES (2,'Alfajores',45.89,'Mediano')

INSERT INTO Productos (Codigo_Producto,Nombre,Precio,Dimensiones) 
VALUES (3,'Gaseosa',15.80,'Grande')

--INGRESAR ENVIOS

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad) 
VALUES (100,1,500)

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad)
VALUES (100,2,1500)

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad)
VALUES (100,3,100)

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad)
VALUES (101,2,55)

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad)
VALUES (101,3,255)

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad)
VALUES (102,1,600)

INSERT INTO Envios(Numero_Proveedor,Codigo_Producto,Cantidad)
VALUES (102,3,300)


--3)

--Obtener los detalles completos de todos los productos, ordenados alfabéticamente.
SELECT * FROM Productos

--Obtener los detalles completos de todos los proveedores de ‘Quilmes’.
SELECT * FROM Proveedores WHERE Localidad = 'Quilmes'

--Obtener todos los envíos en los cuales la cantidad este entre 200 y 300 inclusive.
SELECT * FROM Envios WHERE Cantidad BETWEEN 200 AND 300

--Obtener la cantidad total de todos los productos enviados.
SELECT COUNT(Nombre) as Cantidad_toltal_productos FROM Productos

--Mostrar los primeros 3 números de productos que se han enviado.
SELECT TOP(3) p.* FROM Productos AS p

--Mostrar los nombres de proveedores y los nombres de los productos enviados.
SELECT Prov.Nombre as NOMBRE_PROVEEDOR, P.Nombre as NOMBRE_PRODUCTO FROM Envios AS E 
INNER JOIN Productos as P ON E.Codigo_Producto  = p.Codigo_Producto
INNER JOIN Proveedores as Prov ON E.Numero_Proveedor = Prov.Numero_Proveedor

--Indicar el monto (cantidad * precio) de todos los envíos.
SELECT P.PRECIO * E.CANTIDAD AS MONTO_TOTAL, E.* FROM ENVIOS AS E INNER JOIN Productos AS P ON E.Codigo_Producto = P.Codigo_Producto

--Obtener la cantidad total del producto 1 enviado por el proveedor 102.
SELECT P.PRECIO * E.CANTIDAD AS MONTO_TOTAL, E.* FROM ENVIOS AS E 
INNER JOIN Productos AS P ON E.Codigo_Producto = P.Codigo_Producto AND E.Codigo_Producto = 1 AND e.Numero_Proveedor = 102

--Obtener todos los números de los productos suministrados por algún proveedor de ‘Avellaneda’.
SELECT P.Nombre as Productos FROM Envios as E 
INNER JOIN Proveedores as PROV on E.Numero_Proveedor = PROV.Numero_Proveedor 
INNER JOIN Productos AS P ON E.Codigo_Producto = P.Codigo_Producto
WHERE PROV.Localidad = 'Avellaneda'

--4)

--Agregar el producto numero 4, llamado ‘Chocolate’, de tamaño chico y con un precio de 25,35.
INSERT INTO Productos (Codigo_Producto,Nombre,Precio,Dimensiones) VALUES (4,'Chocolate',25.35,'Tamanio chico')

--Insertar un nuevo proveedor (únicamente con los campos obligatorios).
INSERT INTO Proveedores(Numero_Proveedor) VALUES (103)

--Insertar un nuevo proveedor (107), donde el nombre y la localidad son ‘Rosales’ y ‘La Plata’.
INSERT INTO Proveedores(Numero_Proveedor,Nombre,Localidad) VALUES (107,'Rosales','La plata')

--Cambiar los precios de los productos de tamaño ‘grande’ a 97,50.
UPDATE Productos SET Precio = 97.50 WHERE Dimensiones = 'grande'

--Eliminar el producto número 1.
DELETE Productos WHERE Codigo_Producto = 1
