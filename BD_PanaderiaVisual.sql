USE BD_Panaderia;

CREATE TABLE Recepcionista (
    id VARCHAR(1) PRIMARY KEY,
    nombreR VARCHAR(30)
);
GO

CREATE TABLE Cliente (
    id VARCHAR(8) PRIMARY KEY,
    nombre VARCHAR(30),
    apellido VARCHAR(15),
    telefono VARCHAR(9)
);
GO

CREATE TABLE Producto (
    id_producto VARCHAR(9) PRIMARY KEY,
    nombrepro VARCHAR(30),
    tipo_producto VARCHAR(30),
    fecha_entrega DATE,
    precio_unitario NUMERIC(9,2),
	cantidad INT
);
GO

CREATE TABLE Dim_tiempo (
    fecha DATETIME PRIMARY KEY,
    mes INT,
    año INT
);
GO

CREATE TABLE unidad_medida (
    unidad_medida VARCHAR(15) PRIMARY KEY
);
GO

CREATE TABLE comprobante_venta (
    venta_id INT PRIMARY KEY IDENTITY,
    id_recepcionista VARCHAR(1) REFERENCES Recepcionista(id),
    id_cliente VARCHAR(8) REFERENCES Cliente(id),
    id_producto VARCHAR(9) REFERENCES Producto(id_producto),
    fecha_venta DATETIME REFERENCES Dim_tiempo(fecha),
    unidad_medida_venta VARCHAR(15) REFERENCES unidad_medida(unidad_medida)
);
GO

ALTER AUTHORIZATION ON DATABASE::[BD_Panaderia] TO sa;
GO

-- Población de la tabla Recepcionista
INSERT INTO Recepcionista (id, nombreR) VALUES
('1', 'María López'),
('2', 'Juan Pérez'),
('3', 'Ana Torres');

-- Población de la tabla Cliente
INSERT INTO Cliente (id, nombre, apellido, telefono) VALUES
('C001', 'Carlos', 'Gómez', '123456789'),
('C002', 'Laura', 'Martínez', '987654321'),
('C003', 'Pedro', 'Ramírez', '456789123'),
('C004', 'Pedro', 'Ramírez', '412312323');

-- Población de la tabla Producto
INSERT INTO Producto (id_producto, nombrepro, tipo_producto, fecha_entrega, precio_unitario, cantidad) VALUES
('P001', 'Bocadito de Jamón', 'Bocadito', '2024-06-01', 2.50, 20),
('P002', 'Pan Integral', 'Pan', '2024-06-01', 1.20, 53),
('P003', 'Torta de Chocolate (Tajada)', 'Torta', '2024-06-01', 3.00, 8),
('P004', 'Keke de Naranja', 'Keke', '2024-06-01', 4.50, 12);

-- Población de la tabla Dim_tiempo
INSERT INTO Dim_tiempo (fecha, mes, año) VALUES
('2024-06-01', 6, 2024),
('2024-06-02', 6, 2024),
('2024-06-03', 6, 2024);

-- Población de la tabla unidad_medida
INSERT INTO unidad_medida (unidad_medida) VALUES
('Unidad'),
('Kilogramo'),
('Tajada');

-- Población de la tabla comprobante_venta
INSERT INTO comprobante_venta (id_recepcionista, id_cliente, id_producto, fecha_venta, unidad_medida_venta) VALUES
('1', 'C001', 'P001', '2024-06-01', 'Unidad'),
('2', 'C002', 'P002', '2024-06-01', 'Unidad'),
('3', 'C003', 'P003', '2024-06-02', 'Tajada'),
('1', 'C001', 'P004', '2024-06-03', 'Unidad');

-- Consultas de verificación
SELECT * FROM comprobante_venta;
SELECT * FROM unidad_medida;
SELECT * FROM Cliente;
SELECT * FROM Producto;

-- Procedimientos almacenados
CREATE PROCEDURE [dbo].[spInsertaCliente] 
(
    @id VARCHAR(8),
    @nombre VARCHAR(30),
    @apellido VARCHAR(15),
    @telefono VARCHAR(9)
)
AS
BEGIN 
    INSERT INTO Cliente (id, nombre, apellido, telefono) 
    VALUES (@id, @nombre, @apellido, @telefono);
END;
GO

CREATE PROCEDURE [dbo].[spListarCliente] 
AS
BEGIN
    SELECT id, nombre, apellido, telefono
    FROM Cliente;
END;
GO

CREATE PROCEDURE [dbo].[spListarStock] 
AS
BEGIN
    SELECT id_producto, nombrepro, cantidad
    FROM Producto;
END;
GO

CREATE PROCEDURE [dbo].[spEditarCliente] 
(
    @id VARCHAR(8),
    @nombre VARCHAR(30),
    @apellido VARCHAR(15),
    @telefono VARCHAR(9)
)
AS
BEGIN
    UPDATE Cliente
    SET 
        nombre = @nombre,
        apellido = @apellido,
        telefono = @telefono
    WHERE id = @id;
END;
GO

CREATE PROCEDURE [dbo].[spEliminarCliente]
(
    @id VARCHAR(8)
)
AS
BEGIN
    DELETE FROM Cliente 
    WHERE id = @id;
END;
GO

CREATE PROCEDURE [dbo].[BuscarCliente]
(
    @id VARCHAR(8) = NULL,
    @nombre VARCHAR(30) = NULL,
    @apellidos VARCHAR(15) = NULL,
    @telefono VARCHAR(9) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, nombre, apellido, telefono
    FROM Cliente
    WHERE (@id IS NULL OR id = @id)
      AND (@nombre IS NULL OR nombre LIKE '%' + @nombre + '%')
      AND (@apellidos IS NULL OR apellido LIKE '%' + @apellidos + '%')
      AND (@telefono IS NULL OR telefono = @telefono);
END;
GO
