/*
=========================================================
   Registro de Personas y Apto Físico
   Fecha: 30/10/2025
=========================================================
   Descripción:
   Estructura base del sistema del Club Deportivo,
   Incluye las tablas necesarias para registrar personas (socios y no socios),
   con control de apto físico obligatorio.
=========================================================
*/

-- --------------------------------------------------
-- BASE DE DATOS
-- --------------------------------------------------
CREATE DATABASE IF NOT EXISTS equipo8_comision_c;
USE equipo8_comision_c;

-- --------------------------------------------------
-- TABLA PERSONA
-- Contiene los datos básicos y únicos de cada persona.
-- --------------------------------------------------
CREATE TABLE IF NOT EXISTS persona (
    idPersona INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    tipoDocumento VARCHAR(20) NOT NULL,
    numeroDocumento VARCHAR(10) NOT NULL,
    direccion VARCHAR(100) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    email VARCHAR(80) NOT NULL,
    fechaNacimiento DATE NOT NULL
);

-- --------------------------------------------------
-- TABLA SOCIOS
-- Vincula a las personas que están asociadas al club.
-- --------------------------------------------------
CREATE TABLE IF NOT EXISTS socios (
    idSocio INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT NOT NULL,
    nroSocioCarnet INT NOT NULL,
    fechaIngreso DATE NOT NULL,
    cuotaVigente BOOLEAN DEFAULT 0,
    FOREIGN KEY (idPersona) REFERENCES persona(idPersona)
);

-- --------------------------------------------------
-- TABLA NO SOCIOS
-- Registra personas que no están asociadas al club,
-- pero pueden participar de actividades con apto físico.
-- --------------------------------------------------
CREATE TABLE IF NOT EXISTS nosocios (
    idNoSocio INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT NOT NULL,
    FOREIGN KEY (idPersona) REFERENCES persona(idPersona)
);

-- --------------------------------------------------
-- TABLA APTO FÍSICO
-- Controla la presentación del certificado médico.
-- --------------------------------------------------
CREATE TABLE IF NOT EXISTS aptosfisicos (
    idApto INT AUTO_INCREMENT PRIMARY KEY,
    idPersona INT NOT NULL,
    fechaPresentacion DATE NOT NULL,
    observaciones VARCHAR(100),
    FOREIGN KEY (idPersona) REFERENCES persona(idPersona)
);

-- --------------------------------------------------
-- DATOS DE PRUEBA.
-- --------------------------------------------------
INSERT INTO persona (nombre, apellido, tipoDocumento, numeroDocumento, direccion, telefono, email, fechaNacimiento)
VALUES ('Juan', 'Pérez', 'DNI', '30111222', 'Calle Falsa 123', '1144455566', 'juanperez@mail.com', '1990-05-20');

INSERT INTO socios (idPersona, nroSocioCarnet, fechaIngreso, cuotaVigente)
VALUES (1, 1001, CURDATE(), 0);

INSERT INTO aptosfisicos (idPersona, fechaPresentacion, observaciones)
VALUES (1, CURDATE(), 'Apto sin observaciones');

-- --------------------------------------------------
-- FIN DEL SCRIPT –
-- --------------------------------------------------
