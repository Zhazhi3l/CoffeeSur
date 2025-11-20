CREATE DATABASE IF NOT EXISTS panaderia_bd;
USE panaderia_bd;

-- Tabla de usuarios/empleados
CREATE TABLE Empleado(
    EmpleadoId		INT             NOT NULL    AUTO_INCREMENT        PRIMARY KEY,
    firstname       VARCHAR(50)     NOT NULL,
    lastname        VARCHAR(50)     NOT NULL,
    username        VARCHAR(50)     UNIQUE      NOT NULL,
    password        VARCHAR(256)    NOT NULL,
    email           VARCHAR(100)    UNIQUE      NOT NULL,
    userrole        ENUM("Admin", "Empleado") DEFAULT "Empleado",
    createddate     TIMESTAMP DEFAULT        CURRENT_TIMESTAMP,
    activo          BOOLEAN         DEFAULT TRUE
);

-- Tabla de categorías de productos
CREATE TABLE categorias (
    CategoriaID     INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    Nombre          VARCHAR(50)     NOT NULL,
    Descripcion     TEXT
);

-- Tabla de productos
CREATE TABLE productos (
    ProductoID      INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    Clave           VARCHAR(13)     UNIQUE      NOT NULL,
    Nombre          VARCHAR(30)     NOT NULL,
    Precio          DECIMAL(10, 2)  NOT NULL,
    Stock           INT             NOT NULL    DEFAULT 0,
    Descripcion     TEXT,
    CategoriaID     INT,
    Disponibilidad  BOOLEAN         DEFAULT TRUE,
    createddate     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CategoriaID) REFERENCES categorias(CategoriaID)
);

-- Tabla de ventas
CREATE TABLE ventas (
    VentaID         INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    FechaVenta      TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Total           DECIMAL(10,2)   NOT NULL,
    EmpleadoId          INT             NOT NULL,
    FOREIGN KEY (EmpleadoId) 
    REFERENCES Empleado(EmpleadoId)
);

-- Tabla de detalles de venta
CREATE TABLE detalle_venta (
    DetalleVentaID  INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    VentaID         INT             NOT NULL,
    ProductoID      INT             NOT NULL,
    Cantidad        INT             NOT NULL,
    PrecioUnitario  DECIMAL(10,2)   NOT NULL,
    Subtotal        DECIMAL(10,2)   NOT NULL,
    FOREIGN KEY (VentaID) REFERENCES ventas(VentaID),
    FOREIGN KEY (ProductoID) REFERENCES productos(ProductoID)
);

-- Tabla de auditoría de productos
CREATE TABLE AuditoriaProductos (
    AuditoriaID     INT             PRIMARY KEY AUTO_INCREMENT,
    ProductoID      INT             NOT NULL,
    FechaCambio     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    TipoCambio      ENUM('INSERT','UPDATE','DELETE') NOT NULL,
    Empleado         VARCHAR(100)    NOT NULL,
    ValorAnterior   TEXT,
    ValorNuevo      TEXT
);

-- Tabla de compras/proveedores
CREATE TABLE compras (
    CompraID        INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    FechaCompra     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Proveedor       VARCHAR(100)    NOT NULL,
    Total           DECIMAL(10,2)   NOT NULL,
    EmpleadoId          INT             NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(userid)
);

CREATE TABLE detalle_compra (
    DetalleCompraID INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    CompraID        INT             NOT NULL,
    ProductoID      INT             NOT NULL,
    Cantidad        INT             NOT NULL,
    PrecioUnitario  DECIMAL(10,2)   NOT NULL,
    Subtotal        DECIMAL(10,2)   NOT NULL,
    FOREIGN KEY (CompraID) REFERENCES compras(CompraID),
    FOREIGN KEY (ProductoID) REFERENCES productos(ProductoID)
);

-- --------------------------------------------------------------------------------------------
-- Funcionalidad de la BD

-- Procedimiento para login
DELIMITER $$
CREATE PROCEDURE sp_Login(
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(256)
)
BEGIN
    SELECT userid, firstname, lastname, username, email, userrole
    FROM Users 
    WHERE username = p_username 
    AND password = SHA2(p_password, 256)
    AND activo = TRUE;
END $$
DELIMITER ;

-- CRUD de Empleados
DELIMITER $$
CREATE PROCEDURE sp_InsertarEmpleado(
    IN p_firstname VARCHAR(50),
    IN p_lastname VARCHAR(50),
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(256),
    IN p_email VARCHAR(100),
    IN p_userrole ENUM('Admin','Empleado')
)
BEGIN
    INSERT INTO Users (firstname, lastname, username, password, email, userrole)
    VALUES (p_firstname, p_lastname, p_username, SHA2(p_password, 256), p_email, p_userrole);
END $$
DELIMITER ;

-- Actualizar Empleado
DELIMITER $$
CREATE PROCEDURE sp_ActualizarEmpleado(
    IN p_userid INT,
    IN p_firstname VARCHAR(50),
    IN p_lastname VARCHAR(50),
    IN p_email VARCHAR(100)
)
BEGIN
    UPDATE Users 
    SET firstname = p_firstname,
        lastname = p_lastname,
        email = p_email
    WHERE userid = p_userid;
END $$
DELIMITER ;

-- Eliminar Empleado
DELIMITER $$
CREATE PROCEDURE sp_EliminarEmpleado(IN p_userid INT)
BEGIN
    UPDATE Users SET activo = FALSE 
    WHERE userid = p_userid;
END $$
DELIMITER ;

-- Lista de empleados
DELIMITER $$
CREATE PROCEDURE sp_ListarEmpleados()
BEGIN
    SELECT userid, firstname, lastname, username, email, userrole, createddate
    FROM Users;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE sp_ListarEmpleadosActivos()
BEGIN
    SELECT userid, firstname, lastname, username, email, userrole, createddate
    FROM Users WHERE activo = TRUE;
END $$
DELIMITER ;

-- CRUD de Productos
DELIMITER $$
CREATE PROCEDURE sp_InsertarProducto(
    IN p_Clave VARCHAR(13),
    IN p_Nombre VARCHAR(30),
    IN p_Precio DECIMAL(10,2),
    IN p_Stock INT,
    IN p_Descripcion TEXT,
    IN p_CategoriaID INT,
    IN p_Disponibilidad BOOLEAN
)
BEGIN
    INSERT INTO productos (Clave, Nombre, Precio, Stock, Descripcion, CategoriaID, Disponibilidad)
    VALUES (p_Clave, p_Nombre, p_Precio, p_Stock, p_Descripcion, p_CategoriaID, p_Disponibilidad);
END $$
DELIMITER ;

-- Actualizar Producto
DELIMITER $$
CREATE PROCEDURE sp_ActualizarProducto(
    IN p_ProductoID INT,
    IN p_Clave VARCHAR(13),
    IN p_Nombre VARCHAR(30),
    IN p_Precio DECIMAL(10,2),
    IN p_Stock INT,
    IN p_Descripcion TEXT,
    IN p_CategoriaID INT,
    IN p_Disponibilidad BOOLEAN
)
BEGIN
    UPDATE productos
    SET Clave = p_Clave,
        Nombre = p_Nombre,
        Precio = p_Precio,
        Stock = p_Stock,
        Descripcion = p_Descripcion,
        CategoriaID = p_CategoriaID,
        Disponibilidad = p_Disponibilidad
    WHERE ProductoID = p_ProductoID;
END $$
DELIMITER ;

-- Eliminar Producto
DELIMITER $$
CREATE PROCEDURE sp_EliminarProducto(IN p_ProductoID INT)
BEGIN
    DELETE FROM productos WHERE ProductoID = p_ProductoID;
END $$
DELIMITER ;

-- Lista de Productos
DELIMITER $$
CREATE PROCEDURE sp_ListarProductos()
BEGIN
    SELECT p.ProductoID, p.Clave, p.Nombre, p.Precio, p.Stock, p.Descripcion, 
           c.Nombre as Categoria, p.Disponibilidad
    FROM productos p
    LEFT JOIN categorias c ON p.CategoriaID = c.CategoriaID;
END $$
DELIMITER ;



-- Función para ventas del día
DELIMITER $$
CREATE FUNCTION fn_VentasHoy()
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE total DECIMAL(10,2);
    SELECT COALESCE(SUM(Total), 0) INTO total
    FROM ventas 
    WHERE DATE(FechaVenta) = CURDATE();
    RETURN total;
END $$
DELIMITER ;

-- Función para producto más vendido
DELIMITER $$
CREATE FUNCTION fn_ProductoMasVendido(p_FechaInicio DATE, p_FechaFin DATE)
RETURNS VARCHAR(30)
DETERMINISTIC
BEGIN
    DECLARE producto_nombre VARCHAR(30);
    
    SELECT p.Nombre INTO producto_nombre
    FROM detalle_venta dv
    JOIN productos p ON dv.ProductoID = p.ProductoID
    JOIN ventas v ON dv.VentaID = v.VentaID
    WHERE v.FechaVenta BETWEEN p_FechaInicio AND p_FechaFin
    GROUP BY p.ProductoID
    ORDER BY SUM(dv.Cantidad) DESC
    LIMIT 1;
    
    RETURN COALESCE(producto_nombre, 'No hay ventas');
END $$
DELIMITER ;

-- Función para total de ventas por empleado
DELIMITER $$
CREATE FUNCTION fn_TotalVentasEmpleado(p_UserID INT, p_FechaInicio DATE, p_FechaFin DATE)
RETURNS DECIMAL(10,2)
DETERMINISTIC
BEGIN
    DECLARE total DECIMAL(10,2);
    
    SELECT COALESCE(SUM(Total), 0) INTO total
    FROM ventas
    WHERE UserID = p_UserID
    AND DATE(FechaVenta) BETWEEN p_FechaInicio AND p_FechaFin;
    
    RETURN total;
END $$
DELIMITER ;

-- Reporte de ventas por período
DELIMITER $$
CREATE PROCEDURE sp_ReporteVentas(
    IN p_FechaInicio DATE,
    IN p_FechaFin DATE
)
BEGIN
    SELECT 
        v.VentaID,
        v.FechaVenta,
        CONCAT(u.firstname, ' ', u.lastname) as Empleado,
        v.Total,
        COUNT(dv.DetalleVentaID) as TotalProductos
    FROM ventas v
    JOIN Users u ON v.UserID = u.userid
    JOIN detalle_venta dv ON v.VentaID = dv.VentaID
    WHERE DATE(v.FechaVenta) BETWEEN p_FechaInicio AND p_FechaFin
    GROUP BY v.VentaID
    ORDER BY v.FechaVenta DESC;
END $$
DELIMITER ;

-- Reporte de productos vendidos
DELIMITER $$
CREATE PROCEDURE sp_ReporteProductosPorPeriodo(
    IN p_FechaInicio DATE,
    IN p_FechaFin DATE
)
BEGIN
    SELECT 
        p.ProductoID,
        p.Nombre as Producto,
        SUM(dv.Cantidad) as CantidadVendida,
        SUM(dv.Subtotal) as TotalVendido
    FROM detalle_venta dv
    JOIN productos p ON dv.ProductoID = p.ProductoID
    JOIN ventas v ON dv.VentaID = v.VentaID
    WHERE DATE(v.FechaVenta) BETWEEN p_FechaInicio AND p_FechaFin
    GROUP BY p.ProductoID
    ORDER BY CantidadVendida DESC;
END $$
DELIMITER ;
