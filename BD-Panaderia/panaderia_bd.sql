DROP DATABASE IF EXISTS CoffeeSur;
CREATE DATABASE CoffeeSur;
USE CoffeeSur;

-- Credenciales de acceso temporal (admin / admin123)

-- ==========
-- 1. TABLAS 
-- ==========

CREATE TABLE Usuarios (
    IdUsuario       INT AUTO_INCREMENT PRIMARY KEY,
    Nombre          VARCHAR(100) NOT NULL,
    Apellido        VARCHAR(100) NOT NULL,
    Username        VARCHAR(50) NOT NULL UNIQUE,
    Password        VARCHAR(256) NOT NULL, -- Se guardará el Hash SHA2
    Rol             ENUM('Admin', 'Empleado') NOT NULL,
    Activo          BOOLEAN DEFAULT TRUE,
    FechaRegistro   TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Datos Inicial (Usuario Admin por defecto: admin / admin123)
INSERT INTO Usuarios (Nombre, Apellido, Username, Password, Rol, Activo) VALUES ('Administrador', 'Principal', 'admin', SHA2('admin123', 256), 'Admin', 1);

CREATE TABLE Productos (
    IdProducto      INT AUTO_INCREMENT PRIMARY KEY, -- Tu C# busca "IdProducto"
    Clave           VARCHAR(50),                    -- Código de barras/SKU
    Nombre          VARCHAR(100) NOT NULL,
    Descripcion     TEXT,
    Precio          DECIMAL(10,2) NOT NULL,
    Stock           INT NOT NULL DEFAULT 0,
    Descuento       DECIMAL(10,2) DEFAULT 0,
    Imagen          LONGBLOB,                       -- Para guardar el byte[]
    Activo          BOOLEAN DEFAULT TRUE
);

CREATE TABLE Ventas (
    IdVenta         INT AUTO_INCREMENT PRIMARY KEY,
    IdUsuario       INT NOT NULL,
    FechaVenta      DATETIME DEFAULT CURRENT_TIMESTAMP,
    Total           DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE DetalleVenta (
    IdDetalleVenta  INT AUTO_INCREMENT PRIMARY KEY,
    IdVenta         INT NOT NULL,
    IdProducto      INT NOT NULL,
    Cantidad        INT NOT NULL,
    PrecioUnitario  DECIMAL(10,2) NOT NULL,
    Subtotal        DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);

-- Tabla de Auditoría_Productos
CREATE TABLE AuditoriaProductos (
    IdAuditoria     INT AUTO_INCREMENT PRIMARY KEY,
    IdProducto      INT,
    Accion          VARCHAR(20),
    Fecha           TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UsuarioBD       VARCHAR(50),
    Detalles        TEXT
);

CREATE TABLE AuditoriaUsuarios (
    IdAuditoria     INT AUTO_INCREMENT PRIMARY KEY,
    IdUsuario       INT,
    Accion          VARCHAR(20),
    Fecha           TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UsuarioBD       VARCHAR(50),
    Detalles        TEXT
);

CREATE TABLE AuditoriaVentas (
    IdAuditoria     INT AUTO_INCREMENT PRIMARY KEY,
    IdVenta       INT,
    Accion          VARCHAR(20),
    Fecha           TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UsuarioBD       VARCHAR(50),
    Detalles        TEXT
);


/*
-- Tabla de categorías de productos
CREATE TABLE categorias (
    CategoriaID     INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    Nombre          VARCHAR(50)     NOT NULL,
    Descripcion     TEXT
);
*/

/*
-- Tabla de compras/proveedores
CREATE TABLE compras (
    CompraID        INT             NOT NULL    AUTO_INCREMENT    PRIMARY KEY,
    FechaCompra     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Proveedor       VARCHAR(100)    NOT NULL,
    Total           DECIMAL(10,2)   NOT NULL,
    EmpleadoId          INT             NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(userid)
);
*/

/*
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
*/

-- --------------------------------------------------------------------------------------------
-- Funcionalidad de la BD

-- ================================
-- 2.1 STORED PROCEDURES: USUARIOS
-- ================================

DELIMITER $$

-- Insertar Usuario
CREATE PROCEDURE sp_InsertarUsuario(
    IN p_Nombre VARCHAR(100),
    IN p_Apellido VARCHAR(100),
    IN p_Username VARCHAR(50),
    IN p_Password VARCHAR(256),
    IN p_Rol VARCHAR(20)
)
BEGIN
    INSERT INTO Usuarios (Nombre, Apellido, Username, Password, Rol, Activo)
    VALUES (p_Nombre, p_Apellido, p_Username, SHA2(p_Password, 256), p_Rol, 1);
END$$

-- Modificar Usuario
CREATE PROCEDURE sp_ModificarUsuario(
    IN p_IdUsuario INT,
    IN p_Nombre VARCHAR(100),
    IN p_Apellido VARCHAR(100),
    IN p_Username VARCHAR(50),
    IN p_Password VARCHAR(256), -- Si viene vacío, no se cambia
    IN p_Rol VARCHAR(20),
    IN p_Activo BOOLEAN
)
BEGIN
    UPDATE Usuarios
    SET Nombre = p_Nombre,
        Apellido = p_Apellido,
        Username = p_Username,
        Rol = p_Rol,
        Activo = p_Activo,
        -- Solo actualiza password si el parámetro no está vacío
        Password = IF(p_Password = '', Password, SHA2(p_Password, 256))
    WHERE IdUsuario = p_IdUsuario;
END$$

-- Eliminar Usuario (Borrado Lógico)
CREATE PROCEDURE sp_EliminarUsuario(
    IN p_Username VARCHAR(50)
)
BEGIN
    UPDATE Usuarios 
    SET Activo = 0 
    WHERE Username = p_Username;
END$$

CREATE PROCEDURE sp_ValidarLogin(
    IN p_Username VARCHAR(50),
    IN p_Password VARCHAR(256)
)
BEGIN
    SELECT IdUsuario, Nombre, Apellido, Username, Rol, Activo
    FROM Usuarios
    WHERE Username = p_Username 
      AND Password = SHA2(p_Password, 256) -- Compara con el Hash
      AND Activo = 1;
END$$

-- Usuario por Id
CREATE PROCEDURE sp_ObtenerUsuarioPorId(
    IN p_IdUsuario INT
)
BEGIN
    SELECT IdUsuario, Nombre, Apellido, Username, Rol, Activo
    FROM Usuarios  -- Asegúrate que coincida con el nombre real de tu tabla (Usuarios/Empleado/Users)
    WHERE IdUsuario = p_IdUsuario;
END$$

-- Listar Usuarios 
CREATE PROCEDURE sp_ListarUsuarios()
BEGIN
    SELECT IdUsuario, Nombre, Apellido, Username, Rol, Activo
    FROM Usuarios;
END$$

DELIMITER ;

-- ==================================
-- 2.2. STORED PROCEDURES: PRODUCTOS
-- ==================================

DELIMITER $$
-- Insertar Producto
CREATE PROCEDURE sp_InsertarProducto(
    IN p_Clave VARCHAR(50),
    IN p_Nombre VARCHAR(100),
    IN p_Descripcion TEXT,
    IN p_Precio DECIMAL(10,2),
    IN p_Stock INT,
    IN p_Descuento DECIMAL(10,2),
    IN p_Activo BOOLEAN,
    IN p_Imagen LONGBLOB
)
BEGIN
    INSERT INTO Productos (Clave, Nombre, Descripcion, Precio, Stock, Descuento, Activo, Imagen)
    VALUES (p_Clave, p_Nombre, p_Descripcion, p_Precio, p_Stock, p_Descuento, p_Activo, p_Imagen);
END$$

-- Actualizar Producto
CREATE PROCEDURE sp_ActualizarProducto(
    IN p_IdProducto INT,
    IN p_Clave VARCHAR(50),
    IN p_Nombre VARCHAR(100),
    IN p_Descripcion TEXT,
    IN p_Precio DECIMAL(10,2),
    IN p_Stock INT,
    IN p_Descuento DECIMAL(10,2),
    IN p_Activo BOOLEAN,
    IN p_Imagen LONGBLOB
)
BEGIN
    UPDATE Productos
    SET Clave = p_Clave,
        Nombre = p_Nombre,
        Descripcion = p_Descripcion,
        Precio = p_Precio,
        Stock = p_Stock,
        Descuento = p_Descuento,
        Activo = p_Activo,
        -- Si la imagen es NULL (no se envió nueva), conserva la anterior
        Imagen = IF(p_Imagen IS NULL, Imagen, p_Imagen)
    WHERE IdProducto = p_IdProducto;
END$$

-- Eliminar Producto (Borrado Lógico)
CREATE PROCEDURE sp_EliminarProducto(
    IN p_IdProducto INT
)
BEGIN
    UPDATE Productos SET Activo = 0 WHERE IdProducto = p_IdProducto;
END$$

-- Listar Productos
CREATE PROCEDURE sp_ListarProductos()
BEGIN
    SELECT IdProducto, Clave, Nombre, Descripcion, Precio, Stock, Descuento, Activo, Imagen
    FROM Productos;
END$$

CREATE PROCEDURE sp_ObtenerProductoPorClave(
    IN p_Clave VARCHAR(50)
)
BEGIN
    SELECT IdProducto, Clave, Nombre, Descripcion, Precio, Stock, Descuento, Activo, Imagen
    FROM Productos
    WHERE Clave = p_Clave;
END$$

-- ==============================
-- 2.3 STORED PROCEDURES: VENTAS 
-- ==============================
DELIMITER $$

CREATE PROCEDURE sp_InsertarVenta(
    IN p_IdUsuario INT,
    IN p_Total DECIMAL(10,2),
    OUT p_IdVentaGenerado INT -- Parámetro de Salida vital para el BackEnd
)
BEGIN
    INSERT INTO Ventas (IdUsuario, Total, FechaVenta)
    VALUES (p_IdUsuario, p_Total, NOW());
    
    SET p_IdVentaGenerado = LAST_INSERT_ID();
END$$

CREATE PROCEDURE sp_InsertarDetalleVenta(
    IN p_IdVenta INT,
    IN p_IdProducto INT,
    IN p_Cantidad INT,
    IN p_PrecioUnitario DECIMAL(10,2),
    IN p_Subtotal DECIMAL(10,2)
)
BEGIN
    INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario, Subtotal)
    VALUES (p_IdVenta, p_IdProducto, p_Cantidad, p_PrecioUnitario, p_Subtotal);
END$$

CREATE PROCEDURE sp_DescontarStock(
    IN p_IdProducto INT,
    IN p_Cantidad INT
)
BEGIN
    UPDATE Productos 
    SET Stock = Stock - p_Cantidad
    WHERE IdProducto = p_IdProducto;
END$$

CREATE PROCEDURE sp_ListarVentas()
BEGIN
    SELECT IdVenta, IdUsuario, FechaVenta, Total
    FROM Ventas
    ORDER BY FechaVenta DESC;
END$$

CREATE PROCEDURE sp_ObtenerVentaPorId(
    IN p_IdVenta INT
)
BEGIN
    SELECT IdVenta, IdUsuario, FechaVenta, Total
    FROM Ventas
    WHERE IdVenta = p_IdVenta;
END$$

CREATE PROCEDURE sp_ObtenerDetallesVenta(
    IN p_IdVenta INT
)
BEGIN
    SELECT IdDetalleVenta, IdVenta, IdProducto, Cantidad, PrecioUnitario, Subtotal
    FROM DetalleVenta
    WHERE IdVenta = p_IdVenta;
END$$

-- =============================================
-- 2.4. STORED PROCEDURES: AUDITORÍA
-- =============================================

CREATE PROCEDURE sp_ObtenerAuditoriaProductos()
BEGIN
    SELECT IdAuditoria, IdProducto, Accion, Fecha, UsuarioBD, Detalles
    FROM AuditoriaProductos
    ORDER BY Fecha DESC;
END$$

CREATE PROCEDURE sp_ObtenerAuditoriaUsuarios()
BEGIN
    SELECT IdAuditoria, IdUsuario, Accion, Fecha, UsuarioBD, Detalles
    FROM AuditoriaUsuarios
    ORDER BY Fecha DESC;
END$$

CREATE PROCEDURE sp_ObtenerAuditoriaVentas()
BEGIN
    SELECT IdAuditoria, IdVenta, Accion, Fecha, UsuarioBD, Detalles
    FROM AuditoriaVentas
    ORDER BY Fecha DESC;
END$$


-- === REPORTES DE VENTAS ===

-- Reporte de Ventas por Producto en un período
CREATE PROCEDURE sp_ReporteVentasPorProducto(
    IN p_FechaInicio DATETIME,
    IN p_FechaFin DATETIME
)
BEGIN
    SELECT 
        p.Clave,
        p.Nombre AS Producto, -- Aquí tengo duda, no se si es la clave del producto o su Id
        SUM(d.Cantidad) AS Unidades,
        SUM(d.Subtotal) AS Monto
    FROM DetalleVenta d
    JOIN Ventas v 
        ON d.IdVenta = v.IdVenta
    JOIN Productos p 
        ON d.IdProducto = p.IdProducto
    WHERE v.FechaVenta BETWEEN p_FechaInicio AND p_FechaFin
    GROUP BY p.IdProducto, p.Nombre
    ORDER BY CantidadVendida DESC;
END$$

DELIMITER ;
-- -----------------------------------------------------------------------------------------------
-- 3. TRIGGERS DE AUDITORÍA

-- =============================================
-- TRIGGERS DE AUDITORÍA PARA PRODUCTOS
-- =============================================

DELIMITER $$
CREATE TRIGGER trg_Auditoria_InsertProducto
AFTER INSERT ON Productos
FOR EACH ROW
BEGIN
    INSERT INTO AuditoriaProductos (IdProducto, Accion, UsuarioBD, Detalles)
    VALUES (
        NEW.IdProducto, 
        'INSERT', 
        USER(), 
        CONCAT('Nuevo producto: ', NEW.Nombre, ' | Clave: ', NEW.Clave, ' | Precio: ', NEW.Precio, ' | Stock: ', NEW.Stock)
    );
END$$


DELIMITER $$
CREATE TRIGGER trg_Auditoria_UpdateProducto
AFTER UPDATE ON Productos
FOR EACH ROW
BEGIN
    DECLARE detalles TEXT;
    
    SET detalles = CONCAT(
        'Producto actualizado: ', NEW.Nombre,
        ' | Cambios: ',
        IF(OLD.Clave != NEW.Clave, CONCAT('Clave: ', OLD.Clave, ' , Nueva Clave: ', NEW.Clave, '; '), ''),
        IF(OLD.Nombre != NEW.Nombre, CONCAT('Nombre: ', OLD.Nombre, ' , Nuevo Nombre: ', NEW.Nombre, '; '), ''),
        IF(OLD.Precio != NEW.Precio, CONCAT('Precio: ', OLD.Precio, ' , Nuevo Precio: ', NEW.Precio, '; '), ''),
        IF(OLD.Stock != NEW.Stock, CONCAT('Stock: ', OLD.Stock, ' , Nuevo Stock: ', NEW.Stock, '; '), ''),
        IF(OLD.Activo != NEW.Activo, CONCAT('Activo: ', OLD.Activo, ' , Nuevo Activo: ', NEW.Activo, '; '), '')
    );
    
    INSERT INTO AuditoriaProductos (IdProducto, Accion, UsuarioBD, Detalles)
    VALUES (NEW.IdProducto, 'UPDATE', USER(), detalles);
END$$


CREATE TRIGGER trg_Auditoria_DeleteProducto
AFTER UPDATE ON Productos
FOR EACH ROW
BEGIN
    IF OLD.Activo = 1 AND NEW.Activo = 0 THEN
        INSERT INTO AuditoriaProductos (IdProducto, Accion, UsuarioBD, Detalles)
        VALUES (
            OLD.IdProducto, 
            'DELETE', 
            USER(), 
            CONCAT('Producto desactivado: ', OLD.Nombre, ' | Clave: ', OLD.Clave)
        );
    END IF;
END$$

-- =============================================
-- TRIGGERS DE AUDITORÍA PARA USUARIOS
-- =============================================


CREATE TRIGGER trg_Auditoria_InsertUsuario
AFTER INSERT ON Usuarios
FOR EACH ROW
BEGIN
    INSERT INTO AuditoriaUsuarios (IdUsuario, Accion, UsuarioBD, Detalles)
    VALUES (
        NEW.IdUsuario, 
        'INSERT', 
        USER(), 
        CONCAT('Nuevo usuario: ', NEW.Nombre, ' ', NEW.Apellido, ' | Username: ', NEW.Username, ' | Rol: ', NEW.Rol)
    );
END$$


CREATE TRIGGER trg_Auditoria_UpdateUsuario
AFTER UPDATE ON Usuarios
FOR EACH ROW
BEGIN
    DECLARE detalles TEXT;
    
    SET detalles = CONCAT(
        'Usuario actualizado: ', NEW.Nombre, ' ', NEW.Apellido,
        ' | Cambios: ',
        IF(OLD.Nombre != NEW.Nombre, CONCAT('Nombre: ', OLD.Nombre, ' , Nuevo Nombre: ', NEW.Nombre, '; '), ''),
        IF(OLD.Apellido != NEW.Apellido, CONCAT('Apellido: ', OLD.Apellido, ' , Nuevo Apellido: ', NEW.Apellido, '; '), ''),
        IF(OLD.Username != NEW.Username, CONCAT('Username: ', OLD.Username, ' , Nuevo Username: ', NEW.Username, '; '), ''),
        IF(OLD.Rol != NEW.Rol, CONCAT('Rol: ', OLD.Rol, ' , Nuevo Rol: ', NEW.Rol, '; '), ''),
        IF(OLD.Activo != NEW.Activo, CONCAT('Activo: ', OLD.Activo, ' Nuevo Activo: ', NEW.Activo, '; '), '')
    );
    
    INSERT INTO AuditoriaUsuarios (IdUsuario, Accion, UsuarioBD, Detalles)
    VALUES (NEW.IdUsuario, 'UPDATE', USER(), detalles);
END$$


CREATE TRIGGER trg_Auditoria_DeleteUsuario
AFTER UPDATE ON Usuarios
FOR EACH ROW
BEGIN
    IF OLD.Activo = 1 AND NEW.Activo = 0 THEN
        INSERT INTO AuditoriaUsuarios (IdUsuario, Accion, UsuarioBD, Detalles)
        VALUES (
            OLD.IdUsuario, 
            'DELETE', 
            USER(), 
            CONCAT('Usuario desactivado: ', OLD.Nombre, ' ', OLD.Apellido, ' | Username: ', OLD.Username)
        );
    END IF;
END$$

-- =============================================
-- TRIGGERS DE AUDITORÍA PARA VENTAS
-- =============================================

CREATE TRIGGER trg_Auditoria_InsertVenta
AFTER INSERT ON Ventas
FOR EACH ROW
BEGIN
    INSERT INTO AuditoriaVentas (IdVenta, Accion, UsuarioBD, Detalles)
    VALUES (
        NEW.IdVenta, 
        'INSERT', 
        USER(), 
        CONCAT('Nueva venta registrada | Total: $', NEW.Total, ' | Fecha: ', NEW.FechaVenta)
    );
END$$


CREATE TRIGGER trg_Auditoria_UpdateVenta
AFTER UPDATE ON Ventas
FOR EACH ROW
BEGIN
    DECLARE detalles TEXT;
    
    SET detalles = CONCAT(
        'Venta actualizada ID: ', NEW.IdVenta,
        ' | Cambios: ',
        IF(OLD.Total != NEW.Total, CONCAT('Total: $', OLD.Total, ' , Nuevo Total: $', NEW.Total, '; '), ''),
        IF(OLD.IdUsuario != NEW.IdUsuario, CONCAT('Vendedor cambiado; '), '')
    );
    
    INSERT INTO AuditoriaVentas (IdVenta, Accion, UsuarioBD, Detalles)
    VALUES (NEW.IdVenta, 'UPDATE', USER(), detalles);
END$$


CREATE TRIGGER trg_Auditoria_DeleteVenta
AFTER DELETE ON Ventas
FOR EACH ROW
BEGIN
    INSERT INTO AuditoriaVentas (IdVenta, Accion, UsuarioBD, Detalles)
    VALUES (
        OLD.IdVenta, 
        'DELETE', 
        USER(), 
        CONCAT('Venta eliminada ID: ', OLD.IdVenta, ' | Total: $', OLD.Total, ' | Fecha: ', OLD.FechaVenta)
    );
END$$

-- -----------------------------------------------------------------------------------------------

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
        CONCAT(u.Nombre, ' ', u.Apellido) as Empleado,
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
        p.Nombre usuariosas Producto,
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

-- Reporte comparativo de productos
DELIMITER $$
CREATE PROCEDURE sp_ReporteComparativoProductos(
    IN p_IdProducto INT,
    IN p_Fecha1 DATE,
    IN p_Fecha2 DATE
)
BEGIN
    SELECT 
        p.IdProducto AS 'Id',
        p.Nombre AS 'Producto',
        FORMAT(p.Precio, 2) AS 'Precio',
        FORMAT(
            COALESCE((
                SELECT SUM(dv.Subtotal) 
                FROM DetalleVenta dv JOIN Ventas v ON dv.IdVenta = v.IdVenta 
                WHERE dv.IdProducto = p.IdProducto 
                AND MONTH(v.FechaVenta) = MONTH(p_Fecha1)
                AND YEAR(v.FechaVenta) = YEAR(p_Fecha1)
            ), 0), 2)
        AS 'Ventas_Mes1',
        FORMAT(
            COALESCE((
                SELECT SUM(dv.Subtotal) 
                FROM DetalleVenta dv JOIN Ventas v ON dv.IdVenta = v.IdVenta 
                WHERE dv.IdProducto = p.IdProducto 
                AND MONTH(v.FechaVenta) = MONTH(p_Fecha2)
                AND YEAR(v.FechaVenta) = YEAR(p_Fecha2)
            ), 0), 2)
        AS 'Ventas_Mes2'
    FROM Productos p
    WHERE p.IdProducto = p_IdProducto;
END$$
DELIMITER ;