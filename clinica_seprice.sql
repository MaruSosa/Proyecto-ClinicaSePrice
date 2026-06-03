-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: clinica_seprice
-- ------------------------------------------------------
-- Server version	8.0.46

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
-- Table structure for table `derivaciones`
--

DROP TABLE IF EXISTS `derivaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `derivaciones` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int DEFAULT NULL,
  `dni_paciente` varchar(20) NOT NULL,
  `medico_derivante` varchar(150) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `observaciones` text,
  `historia_clinica` text,
  `archivo_estudio` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `derivaciones`
--

LOCK TABLES `derivaciones` WRITE;
/*!40000 ALTER TABLE `derivaciones` DISABLE KEYS */;
INSERT INTO `derivaciones` VALUES (1,NULL,'40111222','Juan Carlos Gomez','2026-05-20 11:39:43','Dolor Lumbar','Hipertension-Artrosis','40111222_20260521_114347.png');
/*!40000 ALTER TABLE `derivaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidades`
--

DROP TABLE IF EXISTS `especialidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `especialidades` (
  `id_especialidad` int NOT NULL AUTO_INCREMENT,
  `nombre_especialidad` varchar(100) NOT NULL,
  PRIMARY KEY (`id_especialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidades`
--

LOCK TABLES `especialidades` WRITE;
/*!40000 ALTER TABLE `especialidades` DISABLE KEYS */;
INSERT INTO `especialidades` VALUES (12,'Ecografía'),(13,'Radiografía'),(14,'Mamografía'),(15,'Resonancia'),(16,'Eco Doppler'),(17,'Tomografía');
/*!40000 ALTER TABLE `especialidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estudios`
--

DROP TABLE IF EXISTS `estudios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estudios` (
  `id_estudio` int NOT NULL AUTO_INCREMENT,
  `nombre_estudio` varchar(100) NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_estudio`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estudios`
--

LOCK TABLES `estudios` WRITE;
/*!40000 ALTER TABLE `estudios` DISABLE KEYS */;
INSERT INTO `estudios` VALUES (1,'Ecografía',25000.00),(2,'Radiografía',20000.00),(3,'Resonancia Magnética',80000.00),(5,'Mamografía',35000.00),(6,'Ecografía Abdominal',35000.00),(7,'Ecografía Ginecológica',40000.00),(8,'Ecografía Mamaria',32000.00),(9,'Ecografía 5D',60000.00),(10,'Ecografía 3D',45000.00),(11,'Ecografía 2D',25000.00),(12,'Radiografía Lumbar',15000.00),(13,'Radiografía Dorsal',18000.00),(14,'Radiografía Cervical',20000.00),(15,'Resonancia Cerebral',85000.00),(16,'Resonancia Vertebral',80000.00),(17,'Resonancia Músculo-esquelética',88000.00),(18,'Resonancia Abdominal y pélvica',75000.00),(19,'Resonancia Cardíaca',83000.00);
/*!40000 ALTER TABLE `estudios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `insumos`
--

DROP TABLE IF EXISTS `insumos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `insumos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `stock_actual` int NOT NULL DEFAULT '0',
  `unidad_medida` varchar(20) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `insumos`
--

LOCK TABLES `insumos` WRITE;
/*!40000 ALTER TABLE `insumos` DISABLE KEYS */;
INSERT INTO `insumos` VALUES (1,'GEL CONDUCTOR',10,'unidades',NULL),(2,'GUANTES DESCARTABLES',10,'cajas',NULL),(3,'PLACAS RADIOGRAFICAS',20,'unidades',NULL),(4,'PAPEL TERMICO',30,'rollos',NULL),(5,'PELÍCULA ORTOCROMÁTICA',3,'unidades',NULL),(6,'PELÍCULA PARA MAMOGRAFÍA',5,'unidades',NULL),(7,'CHASIS PARA RAYOS X',5,'unidades',NULL),(8,'CHASIS PARA MAMOGRAFÍA',4,'unidades',NULL),(9,'BATAS DESCARTABLES',100,'unidades',NULL),(10,'GADOLINIO',3,'unidades',NULL);
/*!40000 ALTER TABLE `insumos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `id_paciente` int NOT NULL AUTO_INCREMENT,
  `dni` varchar(20) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `telefono` varchar(30) DEFAULT NULL,
  `fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `obra_social` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_paciente`),
  UNIQUE KEY `dni` (`dni`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (1,'40111222','Mariana','Sosa','3815551111','2026-05-18 14:51:10','OSDE'),(2,'38999444','Juan','Perez','3814442222','2026-05-18 14:51:10','Swiss Medical'),(3,'38402520','Laura','Monasterio','3814502233','2026-05-20 21:28:40','Prensa');
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesionales`
--

DROP TABLE IF EXISTS `profesionales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profesionales` (
  `id_profesional` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `id_especialidad` int DEFAULT NULL,
  `id_estudio` int DEFAULT NULL,
  `dni` varchar(20) DEFAULT NULL,
  `matricula` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_profesional`),
  KEY `fk_especialidad` (`id_especialidad`),
  KEY `fk_estudio` (`id_estudio`),
  CONSTRAINT `fk_especialidad` FOREIGN KEY (`id_especialidad`) REFERENCES `especialidades` (`id_especialidad`),
  CONSTRAINT `fk_estudio` FOREIGN KEY (`id_estudio`) REFERENCES `estudios` (`id_estudio`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesionales`
--

LOCK TABLES `profesionales` WRITE;
/*!40000 ALTER TABLE `profesionales` DISABLE KEYS */;
INSERT INTO `profesionales` VALUES (30,'Ana','Perez','3865415230','anaperez@gmail.com',12,1,'32415630','4152'),(31,'Juan','Gomez','3814512033','juangomez@gmail.com',12,2,'22451021','2003'),(32,'Lucia','Martinez','386341523','luciamartinez',13,3,'39587410','3140'),(34,'gabriela','Lucero','3814787893','gabrielalucero@hotmail.com',14,2,'28941563','4411'),(35,'Tomas','Rojas','3865415869','tomasrojas@gmail.com',15,3,'29635410','2039');
/*!40000 ALTER TABLE `profesionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turnos`
--

DROP TABLE IF EXISTS `turnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `turnos` (
  `id_turno` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `id_profesional` int NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `observaciones` varchar(255) DEFAULT NULL,
  `estado` varchar(20) DEFAULT 'Activo',
  `id_estudio` int DEFAULT NULL,
  `fecha_pago` datetime DEFAULT NULL,
  `forma_pago` varchar(50) DEFAULT NULL,
  `codigo_ticket` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id_turno`),
  UNIQUE KEY `codigo_ticket` (`codigo_ticket`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_profesional` (`id_profesional`),
  CONSTRAINT `turnos_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `pacientes` (`id_paciente`),
  CONSTRAINT `turnos_ibfk_2` FOREIGN KEY (`id_profesional`) REFERENCES `profesionales` (`id_profesional`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turnos`
--

LOCK TABLES `turnos` WRITE;
/*!40000 ALTER TABLE `turnos` DISABLE KEYS */;
INSERT INTO `turnos` VALUES (2,1,30,'2026-05-19','08:30:00',NULL,'Pagado',1,'2026-06-02 19:13:43','Transferencia','CA3JY501'),(4,1,30,'2026-05-19','08:00:00',NULL,'Pagado',1,'2026-06-02 19:13:13','Efectivo','VC3FX9YG'),(9,1,31,'2026-05-20','10:00:00',NULL,'Pendiente',NULL,NULL,NULL,NULL),(10,1,32,'2026-05-22','09:30:00',NULL,'Pendiente',NULL,NULL,NULL,NULL),(11,1,32,'2026-05-20','11:30:00',NULL,'Pendiente',NULL,NULL,NULL,NULL),(12,1,32,'2026-05-20','12:00:00',NULL,'Pagado',3,'2026-06-02 19:09:10','Efectivo','MKWQKD60'),(13,1,35,'2026-06-02','08:30:00',NULL,'Pagado',3,'2026-06-02 19:14:37','Transferencia','1M2ESA3B'),(14,1,30,'2026-06-02','08:00:00',NULL,'Pagado',1,'2026-06-02 19:17:39','Efectivo','NGN81F3Y'),(15,1,30,'2026-06-02','09:00:00',NULL,'Pagado',1,'2026-06-02 19:20:43','Efectivo','Z32KY8TI'),(16,1,31,'2026-06-02','08:00:00',NULL,'Pagado',2,'2026-06-02 19:24:16','Efectivo','C33SJ6NY'),(17,1,30,'2026-06-02','08:30:00',NULL,'Pagado',1,'2026-06-02 19:29:09','Débito','IXLHBG7S'),(18,1,30,'2026-06-02','09:30:00',NULL,'Pagado',1,'2026-06-02 19:33:51','Débito','XF0KL9ES'),(19,1,30,'2026-06-02','11:30:00',NULL,'Pagado',1,'2026-06-02 19:35:58','Efectivo','PXXVMTRB');
/*!40000 ALTER TABLE `turnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `telefono` varchar(30) DEFAULT NULL,
  `rol` varchar(50) NOT NULL DEFAULT 'Recepcionista',
  PRIMARY KEY (`id_usuario`),
  CONSTRAINT `chk_roles` CHECK ((`rol` in (_utf8mb4'Admin',_utf8mb4'Medico',_utf8mb4'Recepcionista')))
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin','1234',NULL,NULL,NULL,NULL,'Recepcionista'),(2,'marusosa','15611376','Mariana','Sosa','marianass712@gmail.com','15611376','Admin'),(3,'juanlopez2026','123456','Juan','Lopez','juanlopez@gmail.com','3814576963','Recepcionista');
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

-- Dump completed on 2026-06-02 21:13:18
