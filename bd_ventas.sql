-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: bd_ventas
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `tb_clientes`
--

DROP TABLE IF EXISTS `tb_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_clientes` (
  `codigo_cl` int NOT NULL AUTO_INCREMENT,
  `nombre_cl` varchar(180) DEFAULT NULL,
  `documento_cl` varchar(20) DEFAULT NULL,
  `direccion_cl` varchar(180) DEFAULT NULL,
  `telefono_cl` varchar(50) DEFAULT NULL,
  `codigo_us` int DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_cl`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_clientes`
--

LOCK TABLES `tb_clientes` WRITE;
/*!40000 ALTER TABLE `tb_clientes` DISABLE KEYS */;
INSERT INTO `tb_clientes` VALUES (1,'JUAN','214590386','CALLE 31-12A3 BOGOTA, CUNDINAMARCA','312593042834',2,_binary ''),(2,'ANDRES','312413132','MZ 21 CASA 221 VILLA PAMPLONA','43242343',3,_binary '');
/*!40000 ALTER TABLE `tb_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_empresa`
--

DROP TABLE IF EXISTS `tb_empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_empresa` (
  `codigo_em` int NOT NULL AUTO_INCREMENT,
  `nombre_em` varchar(180) DEFAULT NULL,
  `ndocumento_em` varchar(20) DEFAULT NULL,
  `direccion_em` varchar(180) DEFAULT NULL,
  `telefono_em` varchar(50) DEFAULT NULL,
  `correo_em` varchar(180) DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_em`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_empresa`
--

LOCK TABLES `tb_empresa` WRITE;
/*!40000 ALTER TABLE `tb_empresa` DISABLE KEYS */;
INSERT INTO `tb_empresa` VALUES (1,'ECOPETROL','12234324324','CRA 13 #23-187 A23-1 BOGOTA, CUNDINAMARCA','3104512321','ecopetrol@gmail.com',_binary '\0'),(2,'PARMALAT','123123213','CALLE 15 LA ALVIRA BUCARRAMANGA, CUNDINAMARCA','12312312','parmalat@gmail.com',_binary '');
/*!40000 ALTER TABLE `tb_empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_productos`
--

DROP TABLE IF EXISTS `tb_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_productos` (
  `codigo_pr` int NOT NULL AUTO_INCREMENT,
  `nombre_pr` varchar(180) DEFAULT NULL,
  `descripcion_pr` varchar(180) DEFAULT NULL,
  `codigo_po` int DEFAULT NULL,
  `codigo_me` int DEFAULT NULL,
  `abreviatura_me` varchar(3) DEFAULT NULL,
  `descripcion_me` varchar(20) DEFAULT NULL,
  `preciounitario_pr` decimal(18,2) DEFAULT NULL,
  `stock` decimal(18,2) DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_pr`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_productos`
--

LOCK TABLES `tb_productos` WRITE;
/*!40000 ALTER TABLE `tb_productos` DISABLE KEYS */;
INSERT INTO `tb_productos` VALUES (2,'COCA COLA','GASEOSA',3,3,'LIT','LITROS',2000.00,50.00,_binary '');
/*!40000 ALTER TABLE `tb_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_proveedores`
--

DROP TABLE IF EXISTS `tb_proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_proveedores` (
  `codigo_po` int NOT NULL AUTO_INCREMENT,
  `nombre_po` varchar(180) DEFAULT NULL,
  `ndocumento_po` varchar(20) DEFAULT NULL,
  `direccion_po` varchar(180) DEFAULT NULL,
  `telefono_po` varchar(50) DEFAULT NULL,
  `contacto_po` varchar(180) DEFAULT NULL,
  `correo_po` varchar(180) DEFAULT NULL,
  `banco_po` varchar(180) DEFAULT NULL,
  `ncuenta_po` varchar(180) DEFAULT NULL,
  `codigo_us` int DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_po`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_proveedores`
--

LOCK TABLES `tb_proveedores` WRITE;
/*!40000 ALTER TABLE `tb_proveedores` DISABLE KEYS */;
INSERT INTO `tb_proveedores` VALUES (3,'SERVIENTREGA','12312313','MZ 321 CSD123','32432423','CASDASD12313','servientrega@gmail.com','BANCO CAJA SOCIAL','1414324234234',2,_binary '');
/*!40000 ALTER TABLE `tb_proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_roles_usuario`
--

DROP TABLE IF EXISTS `tb_roles_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_roles_usuario` (
  `codigo_ru` int NOT NULL AUTO_INCREMENT,
  `descripcion_ru` varchar(45) DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_ru`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_roles_usuario`
--

LOCK TABLES `tb_roles_usuario` WRITE;
/*!40000 ALTER TABLE `tb_roles_usuario` DISABLE KEYS */;
INSERT INTO `tb_roles_usuario` VALUES (1,'ADMINISTRADOR',_binary ''),(2,'USUARIO',_binary '');
/*!40000 ALTER TABLE `tb_roles_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario` (
  `codigo_us` int NOT NULL AUTO_INCREMENT,
  `login_us` varchar(20) DEFAULT NULL,
  `password_us` varchar(20) DEFAULT NULL,
  `nombre_us` varchar(100) DEFAULT NULL,
  `codigo_ru` int DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_us`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` VALUES (1,'aleovalle','12345678','ALEJANDRO OVALLE',1,_binary ''),(2,'usuario1','1234','usuario basico',2,_binary ''),(3,'usuario prueba','123','JUAN ALBERT',2,_binary ''),(4,'empresa','empresa','Parmalat',2,_binary '');
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_ventas`
--

DROP TABLE IF EXISTS `tb_ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_ventas` (
  `codigo_ven` int NOT NULL AUTO_INCREMENT,
  `subtotal_ven` decimal(18,2) DEFAULT NULL,
  `impuesto_ven` decimal(18,2) DEFAULT NULL,
  `total_ven` decimal(18,2) DEFAULT NULL,
  `codigo_pr` int DEFAULT NULL,
  `codig_cl` int DEFAULT NULL,
  `preciounitario_pr` decimal(18,2) DEFAULT NULL,
  `cantidad_co` decimal(18,2) DEFAULT NULL,
  `activo` bit(1) DEFAULT b'1',
  PRIMARY KEY (`codigo_ven`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_ventas`
--

LOCK TABLES `tb_ventas` WRITE;
/*!40000 ALTER TABLE `tb_ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-05 19:24:58
