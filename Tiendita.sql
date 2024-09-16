
CREATE DATABASE Tiendita;
USE Tiendita;

CREATE TABLE Producto
(
idProducto INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
decripcion VARCHAR(100),
precio INT
);


-- ----------------------------------------------

DELIMITER //
DROP PROCEDURE IF EXISTS p_AgregarProducto;
CREATE PROCEDURE p_AgregarProducto
(
    IN _nombre VARCHAR(100),
    IN _descripcion VARCHAR(100),
    IN _precio INT
)
BEGIN
    INSERT INTO Producto (nombre, decripcion, precio)
    VALUES (_nombre, _descripcion, _precio);
END //
DELIMITER ;


-- ----------------------------------------------------------

DELIMITER //
DROP PROCEDURE IF EXISTS p_EliminarProducto;
CREATE PROCEDURE p_EliminarProducto
(
    IN _idProducto INT
)
BEGIN
    DELETE FROM Producto
    WHERE idProducto = _idProducto;
END //
DELIMITER ;

-- -------------------------------------------------------

DELIMITER //
DROP PROCEDURE IF EXISTS p_ModificarProducto;
CREATE PROCEDURE p_ModificarProducto
(
    IN _idProducto INT,
    IN _nombre VARCHAR(100),
    IN _descripcion VARCHAR(100),
    IN _precio INT
)
BEGIN
    UPDATE Producto
    SET nombre = _nombre,
        decripcion = _descripcion,
        precio = _precio
    WHERE idProducto = _idProducto;
END //
DELIMITER ;
