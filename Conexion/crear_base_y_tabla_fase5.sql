-- 1 Crear base de datos
CREATE DATABASE IF NOT EXISTS equipo8_comision_c;
USE equipo8_comision_c;

-- 2 Eliminar tablas por si existen
DROP TABLE IF EXISTS socios;
DROP TABLE IF EXISTS persona;
DROP TABLE IF EXISTS usuarios;

-- 3 Crear tabla de usuarios
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    clave VARCHAR(50) NOT NULL
);

-- 4 Cargar usuarios
INSERT INTO usuarios (usuario, clave) VALUES
('admin', '1234'),
('guille', '123'),
('vero', '123'),
('naty', '123'),
('fer', '123'),
('eric', '123');

-- 5 Crear tabla persona
CREATE TABLE persona (
    idPersona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    tipoDocumento VARCHAR(20),
    numeroDocumento VARCHAR(20),
    direccion VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100),
    fechaNacimiento DATE
);

-- 6 Crear tabla de socios
CREATE TABLE socios (
    idSocio INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT NOT NULL,
    nroSocioCarnet INT,
    fechaIngreso DATE,
    cuotaVigente BOOLEAN,
    FOREIGN KEY (idPersona) REFERENCES persona(idPersona)
);
