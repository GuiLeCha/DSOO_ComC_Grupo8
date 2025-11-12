CREATE DATABASE  IF NOT EXISTS `equipo8_comision_c` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `equipo8_comision_c`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: equipo8_comision_c
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aptosfisicos`
--

DROP TABLE IF EXISTS `aptosfisicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aptosfisicos` (
  `idApto` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  `fechaPresentacion` date NOT NULL,
  `observaciones` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idApto`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `aptosfisicos_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aptosfisicos`
--

LOCK TABLES `aptosfisicos` WRITE;
/*!40000 ALTER TABLE `aptosfisicos` DISABLE KEYS */;
INSERT INTO `aptosfisicos` VALUES (1,1,'2025-10-20','ok'),(2,2,'2025-10-21','ok'),(3,3,'2025-10-22','ok'),(4,4,'2025-10-23','ok'),(5,5,'2025-10-24','ok'),(6,6,'2025-10-25','ok'),(7,7,'2025-10-26','ok'),(8,8,'2025-10-27','ok'),(9,9,'2025-10-28','ok'),(10,10,'2025-10-29','ok'),(11,11,'2025-10-30','ok'),(12,12,'2025-10-31','ok'),(13,13,'2025-11-01','ok'),(14,14,'2025-11-02','ok'),(15,15,'2025-11-03','ok'),(16,16,'2025-11-04','ok'),(17,17,'2025-10-25','ok'),(18,18,'2025-10-25','ok'),(19,19,'2025-10-26','ok'),(20,20,'2025-10-26','ok');
/*!40000 ALTER TABLE `aptosfisicos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carnet`
--

DROP TABLE IF EXISTS `carnet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carnet` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  `numeroCarnet` varchar(50) NOT NULL,
  `fecha_emision` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `carnet_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carnet`
--

LOCK TABLES `carnet` WRITE;
/*!40000 ALTER TABLE `carnet` DISABLE KEYS */;
INSERT INTO `carnet` VALUES (1,1,'SOC-1-2025','2025-10-01 10:00:00'),(2,2,'SOC-2-2025','2025-09-01 11:00:00'),(3,3,'SOC-3-2025','2025-08-01 12:00:00'),(4,4,'SOC-4-2025','2025-07-01 09:30:00'),(5,5,'SOC-5-2025','2025-06-01 14:20:00'),(6,6,'SOC-6-2025','2025-05-01 16:45:00'),(7,7,'SOC-7-2025','2025-04-01 08:15:00'),(8,8,'SOC-8-2025','2025-03-01 13:50:00'),(9,9,'SOC-9-2024','2024-11-01 10:00:00'),(10,10,'SOC-10-2024','2024-09-01 10:00:00'),(11,11,'SOC-11-2025','2025-11-01 09:00:00'),(18,17,'SOC-17-2025','2025-10-25 09:00:00'),(19,19,'SOC-19-2025','2025-10-26 09:00:00');
/*!40000 ALTER TABLE `carnet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosocios`
--

DROP TABLE IF EXISTS `nosocios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocios` (
  `idNoSocio` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  PRIMARY KEY (`idNoSocio`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `nosocios_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocios`
--

LOCK TABLES `nosocios` WRITE;
/*!40000 ALTER TABLE `nosocios` DISABLE KEYS */;
INSERT INTO `nosocios` VALUES (1,11),(2,12),(3,13),(4,14),(5,15),(6,16),(17,18),(18,20);
/*!40000 ALTER TABLE `nosocios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pago`
--

DROP TABLE IF EXISTS `pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pago` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  `fecha_pago` date DEFAULT NULL,
  `monto` decimal(10,2) NOT NULL,
  `tipo_pago` varchar(50) DEFAULT NULL,
  `formaPago` varchar(50) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `pago_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
INSERT INTO `pago` VALUES (1,1,'2025-10-01',8000.00,'Cuota','Efectivo','Cuota Octubre 2025'),(2,2,'2025-09-01',8000.00,'Cuota','3 cuotas','Cuota Septiembre 2025'),(3,2,'2025-10-01',8000.00,'Cuota','Tarjeta','Cuota Octubre 2025'),(4,3,'2025-08-01',8000.00,'Cuota','Efectivo','Cuota Agosto 2025'),(5,4,'2025-07-01',8000.00,'Cuota','6 cuotas','Cuota Julio 2025'),(6,4,'2025-08-01',8000.00,'Cuota','Efectivo','Cuota Agosto 2025'),(7,4,'2025-09-01',8000.00,'Cuota','Efectivo','Cuota Septiembre 2025'),(8,5,'2025-06-01',8000.00,'Cuota','Efectivo','Cuota Junio 2025'),(9,5,'2025-07-01',8000.00,'Cuota','Efectivo','Cuota Julio 2025'),(10,5,'2025-08-01',8000.00,'Cuota','Efectivo','Cuota Agosto 2025'),(11,5,'2025-09-01',8000.00,'Cuota','Efectivo','Cuota Septiembre 2025'),(12,6,'2025-05-01',8000.00,'Cuota','Efectivo','Cuota Mayo 2025'),(13,6,'2025-10-01',8000.00,'Cuota','3 cuotas','Cuota Octubre 2025'),(14,7,'2025-04-01',8000.00,'Cuota','Efectivo','Cuota Abril 2025'),(15,8,'2025-03-01',8000.00,'Cuota','Efectivo','Cuota Marzo 2025'),(16,8,'2025-11-01',8000.00,'Cuota','6 cuotas','Cuota Noviembre 2025'),(17,9,'2024-11-01',7500.00,'Cuota','Efectivo','Cuota Noviembre 2024'),(18,9,'2025-10-01',8000.00,'Cuota','Efectivo','Cuota Octubre 2025'),(19,10,'2024-09-01',7500.00,'Cuota','Efectivo','Cuota Septiembre 2024'),(20,11,'2025-10-15',1800.00,'Actividad','Efectivo','Clase única - 15/10'),(21,11,'2025-10-22',1800.00,'Actividad','Efectivo','Clase única - 22/10'),(22,12,'2025-09-05',2000.00,'Actividad','Tarjeta','Clase única - 05/09'),(23,13,'2025-11-02',1600.00,'Actividad','Efectivo','Clase única - 02/11'),(24,14,'2025-08-12',1700.00,'Actividad','Efectivo','Clase única - 12/08'),(25,15,'2025-09-20',2000.00,'Actividad','Tarjeta','Clase única - 20/09'),(26,16,'2025-11-05',1500.00,'Actividad','Efectivo','Clase única - 05/11'),(27,11,'2025-11-01',8000.00,'Cuota','3 cuotas','Cuota Noviembre 2025 - incorporacion'),(28,17,'2025-10-25',8000.00,'Cuota','Efectivo','Cuota Octubre 2025'),(29,19,'2025-10-26',8000.00,'Cuota','3 cuotas','Cuota Octubre 2025'),(30,18,'2025-10-25',1800.00,'Actividad','Efectivo','Clase única 25/10/2025'),(31,20,'2025-10-26',2000.00,'Actividad','Tarjeta','Clase única 26/10/2025');
/*!40000 ALTER TABLE `pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persona` (
  `idPersona` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `tipoDocumento` varchar(20) DEFAULT NULL,
  `numeroDocumento` varchar(20) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'Juan','Pérez','DNI','30000001','Av. Siempre Viva 1','114000001','juan.perez@example.com','1990-01-15'),(2,'María','González','DNI','30000002','Calle Falsa 12','114000002','maria.gonzalez@example.com','1988-02-20'),(3,'Carlos','Rodríguez','DNI','30000003','Rivadavia 345','114000003','carlos.rodriguez@example.com','1992-03-05'),(4,'Laura','Martínez','DNI','30000004','Belgrano 77','114000004','laura.martinez@example.com','1995-04-10'),(5,'Andrés','López','DNI','30000005','Independencia 200','114000005','andres.lopez@example.com','1985-05-25'),(6,'Verónica','Casco','DNI','30000006','San Martín 50','114000006','veronica.casco@example.com','1991-06-30'),(7,'Natalia','Chertkoff','DNI','30000007','Mitre 120','114000007','natalia.chertkoff@example.com','1993-07-12'),(8,'Fernando','Baca','DNI','30000008','Sarmiento 88','114000008','fernando.baca@example.com','1987-08-08'),(9,'Eric','Bermudez','DNI','30000009','Colon 210','114000009','eric.bermudez@example.com','1994-09-09'),(10,'Guillermo','Chacón','DNI','30000010','Alvear 33','114000010','guillermo.chacon@example.com','1986-10-10'),(11,'Sofía','Alvarez','DNI','30000011','Jujuy 14','114000011','sofia.alvarez@example.com','1997-11-11'),(12,'Mateo','Fernández','DNI','30000012','Corrientes 900','114000012','mateo.fernandez@example.com','1998-12-12'),(13,'Camila','Rossi','DNI','30000013','Italia 45','114000013','camila.rossi@example.com','1996-06-06'),(14,'Lucía','Sosa','DNI','30000014','Perón 300','114000014','lucia.sosa@example.com','1989-09-02'),(15,'Diego','Vega','DNI','30000015','Pueyrredón 55','114000015','diego.vega@example.com','1990-04-04'),(16,'Martina','Iglesias','DNI','30000016','Belgrano 150','114000016','martina.iglesias@example.com','1992-02-02'),(17,'Tomás','Ruiz','DNI','30000017','Mendoza 18','114000017','tomas.ruiz@example.com','1991-01-01'),(18,'Paula','Silva','DNI','30000018','Chile 220','114000018','paula.silva@example.com','1984-07-07'),(19,'Alejandro','Morales','DNI','30000019','Urquiza 77','114000019','alejandro.morales@example.com','1993-03-03'),(20,'Florencia','Ortiz','DNI','30000020','Salta 44','114000020','florencia.ortiz@example.com','1995-05-05');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socios`
--

DROP TABLE IF EXISTS `socios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socios` (
  `idSocio` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  `fechaIngreso` date DEFAULT NULL,
  `cuotaVigente` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idSocio`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `socios_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socios`
--

LOCK TABLES `socios` WRITE;
/*!40000 ALTER TABLE `socios` DISABLE KEYS */;
INSERT INTO `socios` VALUES (1,1,'2025-10-01',1),(2,2,'2025-09-01',1),(3,3,'2025-08-01',1),(4,4,'2025-07-01',1),(5,5,'2025-06-01',1),(6,6,'2025-05-01',1),(7,7,'2025-04-01',1),(8,8,'2025-03-01',1),(9,9,'2024-11-01',1),(10,10,'2024-09-01',1),(11,11,'2025-11-01',1),(12,17,'2025-10-25',1),(13,19,'2025-10-26',1);
/*!40000 ALTER TABLE `socios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin','1234'),(2,'guille','123'),(3,'vero','123'),(4,'naty','123'),(5,'fer','123'),(6,'eric','123'),(7,'profe','123');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'equipo8_comision_c'
--

--
-- Dumping routines for database 'equipo8_comision_c'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-11 22:07:21
