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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aptosfisicos`
--

LOCK TABLES `aptosfisicos` WRITE;
/*!40000 ALTER TABLE `aptosfisicos` DISABLE KEYS */;
INSERT INTO `aptosfisicos` VALUES (1,1,'2025-10-20','Apto completo'),(2,2,'2025-10-21','Apto para yoga'),(3,3,'2025-10-22','Apto con control de presión'),(4,4,'2025-10-23','Apto sin observaciones'),(5,5,'2025-10-24','Apto completo'),(6,6,'2025-10-25','Apto completo'),(7,7,'2025-10-26','Apto completo'),(8,8,'2025-10-27','Apto completo'),(9,9,'2025-10-28','Apto completo'),(10,10,'2025-10-29','Apto completo');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carnet`
--

LOCK TABLES `carnet` WRITE;
/*!40000 ALTER TABLE `carnet` DISABLE KEYS */;
INSERT INTO `carnet` VALUES (1,1,'SOC-1-2025','2025-10-01 00:00:00'),(2,3,'SOC-3-2023','2023-09-06 00:00:00'),(3,4,'SOC-4-2025','2025-02-01 00:00:00'),(4,5,'SOC-5-2022','2022-05-21 00:00:00'),(5,6,'SOC-6-2025','2025-09-10 00:00:00');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocios`
--

LOCK TABLES `nosocios` WRITE;
/*!40000 ALTER TABLE `nosocios` DISABLE KEYS */;
INSERT INTO `nosocios` VALUES (1,2),(2,7),(3,8),(4,9),(5,10);
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
  `fecha_pago` datetime NOT NULL,
  `monto` decimal(10,2) NOT NULL,
  `tipo_pago` varchar(50) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `pago_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pago`
--

LOCK TABLES `pago` WRITE;
/*!40000 ALTER TABLE `pago` DISABLE KEYS */;
INSERT INTO `pago` VALUES (1,1,'2025-11-01 00:00:00',15000.00,'Cuota','Cuota noviembre 2025'),(2,4,'2025-11-01 00:00:00',15000.00,'Cuota','Cuota noviembre 2025'),(3,6,'2025-10-15 00:00:00',15000.00,'Cuota','Cuota octubre 2025'),(4,3,'2025-08-01 00:00:00',15000.00,'Cuota','Cuota agosto 2025'),(5,5,'2025-07-01 00:00:00',15000.00,'Cuota','Cuota julio 2025'),(6,2,'2025-10-30 00:00:00',5000.00,'Actividad','Clase de yoga'),(7,7,'2025-10-20 00:00:00',6000.00,'Actividad','Pilates'),(8,8,'2025-09-15 00:00:00',4000.00,'Actividad','Entrenamiento funcional'),(9,9,'2025-08-10 00:00:00',3000.00,'Actividad','Zumba'),(10,10,'2025-11-01 00:00:00',5500.00,'Actividad','Tenis libre');
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'Juan','Perez','DNI','12345678','Av. Siempre Viva 123','1112345678','juan.perez@mail.com','1985-03-10'),(2,'Carlos','Gomez','DNI','23456789','Belgrano 456','1123456789','carlos.gomez@mail.com','1990-06-25'),(3,'Ana','Lopez','DNI','34567890','Mitre 789','1134567890','ana.lopez@mail.com','1992-09-15'),(4,'Lucia','Torres','DNI','45678901','Sarmiento 1500','1145678901','lucia.torres@mail.com','1995-12-05'),(5,'Roberto','Suarez','DNI','56789012','Corrientes 2000','1156789012','roberto.suarez@mail.com','1980-07-20'),(6,'Marta','Fernandez','DNI','67890123','San Juan 300','1167890123','marta.fernandez@mail.com','1978-01-30'),(7,'Sofia','Acosta','DNI','78901234','Urquiza 800','1178901234','sofia.acosta@mail.com','1998-02-10'),(8,'Diego','Ramos','DNI','89012345','Medrano 2500','1189012345','diego.ramos@mail.com','1993-11-02'),(9,'Julia','Benitez','DNI','90123456','Independencia 350','1190123456','julia.benitez@mail.com','1987-04-22'),(10,'Pablo','Morales','DNI','91234567','Córdoba 1100','1191234567','pablo.morales@mail.com','1982-08-12');
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
  `nroSocioCarnet` int DEFAULT NULL,
  `fechaIngreso` date DEFAULT NULL,
  `cuotaVigente` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idSocio`),
  KEY `idPersona` (`idPersona`),
  CONSTRAINT `socios_ibfk_1` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socios`
--

LOCK TABLES `socios` WRITE;
/*!40000 ALTER TABLE `socios` DISABLE KEYS */;
INSERT INTO `socios` VALUES (1,1,1001,'2024-01-10',1),(2,3,1002,'2023-09-05',0),(3,4,1003,'2025-02-01',1),(4,5,1004,'2022-05-20',0),(5,6,1005,'2025-09-10',1);
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-01 14:39:32
