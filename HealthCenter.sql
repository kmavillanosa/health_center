-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: healthcenter_db
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `accountlogs`
--

DROP TABLE IF EXISTS `accountlogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `accountlogs` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AccountId` int(11) DEFAULT NULL,
  `TimeIn` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `TimeOut` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=147 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accountlogs`
--

LOCK TABLES `accountlogs` WRITE;
/*!40000 ALTER TABLE `accountlogs` DISABLE KEYS */;
INSERT INTO `accountlogs` VALUES (1,1,'2019-02-14 23:30:38','2019-02-14 23:30:38'),(2,1,'2019-02-14 23:36:10','2019-02-14 23:36:10'),(3,1,'2019-02-14 23:39:30','0001-01-01 00:00:00'),(4,1,'2019-02-14 23:47:06','2019-02-14 23:47:07'),(5,1,'2019-02-14 23:48:35','2019-02-14 23:48:35'),(6,1,'2019-02-14 23:49:32','2019-02-14 23:49:33'),(7,1,'2019-02-14 23:52:55','2019-02-14 23:52:55'),(8,1,'2019-02-14 23:54:50','2019-02-14 23:54:51'),(9,1,'2019-02-14 23:56:18','0001-01-01 00:00:00'),(10,1,'2019-02-14 23:58:06','2019-02-14 23:58:06'),(11,1,'2019-02-14 23:59:54','0001-01-01 00:00:00'),(12,1,'2019-02-15 00:06:01','2019-02-15 00:06:02'),(13,1,'2019-02-15 00:07:05','2019-02-15 00:07:05'),(14,1,'2019-02-15 00:17:32','2019-02-15 00:17:33'),(15,1,'2019-02-15 00:21:02','0001-01-01 00:00:00'),(16,1,'2019-02-15 00:24:55','0001-01-01 00:00:00'),(17,1,'2019-02-15 00:26:18','0001-01-01 00:00:00'),(18,1,'2019-02-15 00:27:20','0001-01-01 00:00:00'),(19,1,'2019-02-15 00:29:57','0001-01-01 00:00:00'),(20,1,'2019-02-15 00:30:55','0001-01-01 00:00:00'),(21,1,'2019-02-15 00:31:22','0001-01-01 00:00:00'),(22,1,'2019-02-15 00:34:06','2019-02-15 00:34:06'),(23,1,'2019-02-15 00:35:03','0001-01-01 00:00:00'),(24,1,'2019-02-15 00:36:00','0001-01-01 00:00:00'),(25,1,'2019-02-15 00:36:22','0001-01-01 00:00:00'),(26,1,'2019-02-15 00:37:19','0001-01-01 00:00:00'),(27,1,'2019-02-15 00:37:48','0001-01-01 00:00:00'),(28,1,'2019-02-15 00:38:12','0001-01-01 00:00:00'),(29,1,'2019-02-15 00:44:23','0001-01-01 00:00:00'),(30,1,'2019-02-15 00:47:13','0001-01-01 00:00:00'),(31,1,'2019-02-15 00:56:14','2019-02-15 00:56:15'),(32,1,'2019-02-15 00:57:01','2019-02-15 00:57:01'),(33,1,'2019-02-15 00:58:42','2019-02-15 00:58:43'),(34,1,'2019-02-15 01:04:07','2019-02-15 01:04:08'),(35,1,'2019-02-15 01:05:01','2019-02-15 01:05:02'),(36,1,'2019-02-15 20:43:49','2019-02-15 20:43:49'),(37,1,'2019-02-15 20:43:55','2019-02-15 20:43:55'),(38,1,'2019-02-15 20:54:48','2019-02-15 20:54:48'),(39,1,'2019-02-15 21:21:22','0001-01-01 00:00:00'),(40,1,'2019-02-15 21:39:38','0001-01-01 00:00:00'),(41,1,'2019-02-15 21:40:30','0001-01-01 00:00:00'),(42,1,'2019-02-15 21:42:10','0001-01-01 00:00:00'),(43,1,'2019-02-15 21:44:16','0001-01-01 00:00:00'),(44,1,'2019-02-15 21:45:55','0001-01-01 00:00:00'),(45,1,'2019-02-15 21:49:01','0001-01-01 00:00:00'),(46,1,'2019-02-15 21:50:12','0001-01-01 00:00:00'),(47,1,'2019-02-15 21:51:25','0001-01-01 00:00:00'),(48,1,'2019-02-15 21:52:35','0001-01-01 00:00:00'),(49,1,'2019-02-15 21:54:45','0001-01-01 00:00:00'),(50,1,'2019-02-15 22:25:03','2019-02-15 22:25:04'),(51,1,'2019-02-15 22:38:05','0001-01-01 00:00:00'),(52,1,'2019-02-15 22:59:37','0001-01-01 00:00:00'),(53,1,'2019-02-15 23:00:26','0001-01-01 00:00:00'),(54,1,'2019-02-15 23:04:18','0001-01-01 00:00:00'),(55,1,'2019-02-15 23:07:55','0001-01-01 00:00:00'),(56,1,'2019-02-15 23:09:12','2019-02-15 23:09:13'),(57,1,'2019-02-15 23:10:54','0001-01-01 00:00:00'),(58,1,'2019-02-15 23:13:28','0001-01-01 00:00:00'),(59,1,'2019-02-15 23:22:55','2019-02-15 23:22:56'),(60,1,'2019-02-15 23:35:00','2019-02-15 23:35:00'),(61,1,'2019-02-15 23:41:26','0001-01-01 00:00:00'),(62,1,'2019-02-15 23:54:46','2019-02-15 23:54:46'),(63,1,'2019-02-15 23:56:00','2019-02-15 23:56:00'),(64,1,'2019-02-15 23:56:50','2019-02-15 23:56:50'),(65,1,'2019-02-16 00:01:08','2019-02-16 00:01:09'),(66,1,'2019-02-16 00:03:16','0001-01-01 00:00:00'),(67,1,'2019-02-16 00:07:11','0001-01-01 00:00:00'),(68,1,'2019-02-16 00:08:49','2019-02-16 00:08:49'),(69,1,'2019-02-16 00:09:54','0001-01-01 00:00:00'),(70,1,'2019-02-16 00:11:45','2019-02-16 00:11:46'),(71,1,'2019-02-25 20:12:26','2019-02-25 20:12:27'),(72,1,'2019-02-25 20:15:19','2019-02-25 20:15:20'),(73,1,'2019-02-25 20:25:37','2019-02-25 20:25:37'),(74,1,'2019-02-25 20:32:47','2019-02-25 20:32:47'),(75,1,'2019-02-25 20:34:08','2019-02-25 20:34:09'),(76,1,'2019-02-25 20:37:02','2019-02-25 20:37:03'),(77,1,'2019-02-25 20:38:44','2019-02-25 20:38:44'),(78,1,'2019-02-25 20:38:48','2019-02-25 20:38:48'),(79,1,'2019-02-25 20:41:44','2019-02-25 20:41:44'),(80,1,'2019-02-25 20:48:37','2019-02-25 20:48:37'),(81,1,'2019-02-25 20:49:53','2019-02-25 20:49:53'),(82,1,'2019-02-25 21:12:20','2019-02-25 21:12:21'),(83,1,'2019-02-25 21:55:41','2019-02-25 21:55:41'),(84,1,'2019-02-25 21:58:13','0001-01-01 00:00:00'),(85,1,'2019-02-25 21:58:39','0001-01-01 00:00:00'),(86,1,'2019-02-25 21:59:12','0001-01-01 00:00:00'),(87,1,'2019-02-25 22:00:42','0001-01-01 00:00:00'),(88,1,'2019-02-25 22:01:59','0001-01-01 00:00:00'),(89,1,'2019-02-25 22:02:39','0001-01-01 00:00:00'),(90,1,'2019-02-25 22:03:03','0001-01-01 00:00:00'),(91,1,'2019-02-25 22:05:59','0001-01-01 00:00:00'),(92,1,'2019-02-25 22:13:40','2019-02-25 22:13:40'),(93,1,'2019-02-25 22:18:13','0001-01-01 00:00:00'),(94,1,'2019-02-25 22:30:00','2019-02-25 22:30:01'),(95,1,'2019-02-25 22:31:57','2019-02-25 22:31:58'),(96,1,'2019-02-25 22:34:09','0001-01-01 00:00:00'),(97,1,'2019-02-25 22:37:40','2019-02-25 22:37:40'),(98,1,'2019-02-25 22:37:43','2019-02-25 22:37:43'),(99,1,'2019-02-25 22:39:14','2019-02-25 22:39:14'),(100,1,'2019-02-25 22:39:18','2019-02-25 22:39:19'),(101,1,'2019-02-25 22:39:34','2019-02-25 22:39:35'),(102,1,'2019-02-25 22:39:39','2019-02-25 22:39:40'),(103,1,'2019-02-25 22:45:47','2019-02-25 22:45:48'),(104,1,'2019-03-08 21:25:17','2019-03-08 21:25:18'),(105,1,'2019-03-09 21:00:29','2019-03-09 21:00:30'),(106,1,'2019-03-09 21:07:58','0001-01-01 00:00:00'),(107,1,'2019-03-09 21:14:33','0001-01-01 00:00:00'),(108,1,'2019-03-09 21:17:19','0001-01-01 00:00:00'),(109,1,'2019-03-09 21:18:35','0001-01-01 00:00:00'),(110,1,'2019-03-09 21:22:31','2019-03-09 21:22:32'),(111,1,'2019-03-09 21:25:03','2019-03-09 21:25:04'),(112,1,'2019-03-09 21:27:06','2019-03-09 21:27:07'),(113,1,'2019-03-09 21:27:07','0001-01-01 00:00:00'),(114,1,'2019-03-09 21:30:18','0001-01-01 00:00:00'),(115,1,'2019-03-09 21:34:17','2019-03-09 21:34:17'),(116,1,'2019-03-09 21:36:16','2019-03-09 21:36:17'),(117,1,'2019-03-09 21:37:26','0001-01-01 00:00:00'),(118,1,'2019-03-09 21:42:19','2019-03-09 21:42:19'),(119,1,'2019-03-09 21:42:57','0001-01-01 00:00:00'),(120,1,'2019-03-09 21:44:38','0001-01-01 00:00:00'),(121,1,'2019-03-09 21:56:23','0001-01-01 00:00:00'),(122,1,'2019-03-09 22:08:42','2019-03-09 22:08:43'),(123,1,'2019-03-09 22:08:43','0001-01-01 00:00:00'),(124,1,'2019-03-09 22:09:34','2019-03-09 22:09:35'),(125,1,'2019-03-09 22:09:43','0001-01-01 00:00:00'),(126,1,'2019-03-09 22:12:14','0001-01-01 00:00:00'),(127,1,'2019-03-09 22:13:55','2019-03-09 22:13:55'),(128,1,'2019-03-09 22:14:09','0001-01-01 00:00:00'),(129,1,'2019-03-09 22:14:49','0001-01-01 00:00:00'),(130,1,'2019-03-09 22:17:15','0001-01-01 00:00:00'),(131,1,'2019-03-09 22:18:04','0001-01-01 00:00:00'),(132,1,'2019-03-09 22:21:48','2019-03-09 22:21:48'),(133,1,'2019-03-09 22:36:54','2019-03-09 22:36:55'),(134,1,'2019-03-24 19:01:33','0001-01-01 00:00:00'),(135,1,'2019-03-24 19:46:56','2019-03-24 19:46:57'),(136,1,'2019-04-13 14:03:17','2019-04-13 14:03:18'),(137,1,'2019-04-13 14:08:07','0001-01-01 00:00:00'),(138,1,'2019-04-13 14:19:19','2019-04-13 14:19:19'),(139,1,'2019-04-13 14:19:26','2019-04-13 14:19:27'),(140,1,'2019-04-13 14:20:49','2019-04-13 14:20:49'),(141,1,'2019-04-13 14:21:43','2019-04-13 14:21:44'),(142,4,'2019-04-13 14:23:46','2019-04-13 14:23:46'),(143,1,'2019-04-13 14:24:33','2019-04-13 14:24:33'),(144,1,'2019-04-13 14:35:06','2019-04-13 14:35:06'),(145,1,'2019-09-15 14:10:36','2019-09-15 14:10:37'),(146,1,'2019-09-15 14:12:28','2019-09-15 14:12:28');
/*!40000 ALTER TABLE `accountlogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ailments`
--

DROP TABLE IF EXISTS `ailments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ailments` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text,
  `Description` text,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ailments`
--

LOCK TABLES `ailments` WRITE;
/*!40000 ALTER TABLE `ailments` DISABLE KEYS */;
INSERT INTO `ailments` VALUES (1,'Lagnat','Hot temparature','2019-02-11 21:30:17'),(2,'Diarrea','tae tae asdasd','2019-03-09 21:44:52'),(3,'Nagpatuli','qwe','2019-04-13 14:18:45');
/*!40000 ALTER TABLE `ailments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventlogs`
--

DROP TABLE IF EXISTS `eventlogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `eventlogs` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Event` int(11) DEFAULT NULL,
  `PersonId` int(11) DEFAULT NULL,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `ConsultationId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventlogs`
--

LOCK TABLES `eventlogs` WRITE;
/*!40000 ALTER TABLE `eventlogs` DISABLE KEYS */;
INSERT INTO `eventlogs` VALUES (1,1,49,'2019-09-15 14:08:11',1);
/*!40000 ALTER TABLE `eventlogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `events` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) DEFAULT NULL,
  `Description` text,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (1,'For Adding','asdad','2019-09-15 14:07:40');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medical_consultation`
--

DROP TABLE IF EXISTS `medical_consultation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `medical_consultation` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PersonId` int(11) DEFAULT NULL,
  `AilmentGroupId` int(11) DEFAULT NULL,
  `Diagnosis` text,
  `Remarks` text,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medical_consultation`
--

LOCK TABLES `medical_consultation` WRITE;
/*!40000 ALTER TABLE `medical_consultation` DISABLE KEYS */;
INSERT INTO `medical_consultation` VALUES (1,49,1,'Create Details','Ok','2019-09-15 14:08:11'),(2,1,1,'asdas','asds','2019-09-15 14:12:06');
/*!40000 ALTER TABLE `medical_consultation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `person` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryId` int(11) DEFAULT NULL,
  `FirstName` text,
  `LastName` text,
  `MiddleName` text,
  `Suffix` text,
  `Gender` tinyint(4) DEFAULT NULL,
  `BirthDate` datetime DEFAULT NULL,
  `Address` text,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `CreatedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
INSERT INTO `person` VALUES (1,1,'Kemm','AVILLANOSA','SAMANIEGO','sr',2,'2019-04-13 14:12:51','qwe','2019-04-13 14:13:09',NULL),(49,3,'Pepito qweqweqwe','Manaloto yawa','Pedro','Jr.',2,'2019-02-15 00:00:18','Bisakol','2019-02-15 00:00:21',NULL);
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personcategory`
--

DROP TABLE IF EXISTS `personcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `personcategory` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personcategory`
--

LOCK TABLES `personcategory` WRITE;
/*!40000 ALTER TABLE `personcategory` DISABLE KEYS */;
INSERT INTO `personcategory` VALUES (1,'Pregnant','Member of a certain area','2019-02-14 22:00:46'),(2,'Child','Infant or a person 1 - 13 yrs old','2019-02-14 22:00:46'),(3,'Person with Disability','Physically or mentally impaired person','2019-02-14 22:00:46');
/*!40000 ALTER TABLE `personcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useraccount`
--

DROP TABLE IF EXISTS `useraccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `useraccount` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(30) DEFAULT NULL,
  `Password` varchar(30) DEFAULT NULL,
  `Type` tinyint(4) DEFAULT NULL,
  `AccountStatus` tinyint(4) DEFAULT NULL,
  `LastModified` datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useraccount`
--

LOCK TABLES `useraccount` WRITE;
/*!40000 ALTER TABLE `useraccount` DISABLE KEYS */;
INSERT INTO `useraccount` VALUES (1,'kmavillanosa','zxczxc',101,1,'2019-09-15 14:10:32'),(4,'kzandueta','12345',100,1,'2019-04-13 14:21:26');
/*!40000 ALTER TABLE `useraccount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'healthcenter_db'
--

--
-- Dumping routines for database 'healthcenter_db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-15 19:04:33
