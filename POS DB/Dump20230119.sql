CREATE DATABASE  IF NOT EXISTS `pos` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `pos`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: pos
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Balance` double NOT NULL,
  `Salary` double DEFAULT NULL,
  `Type` varchar(45) NOT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Phone` varchar(45) DEFAULT NULL,
  `isactive` tinyint NOT NULL DEFAULT '1',
  `Datetime` datetime NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (1,'Shoaib',-6800,NULL,'Employee','R-16','03452408728',1,'2023-01-09 13:14:11'),(2,'asdas',36545.520000000004,NULL,'Purchase','asdasd','223232323',1,'2023-01-09 13:18:56'),(3,'Purchase1',4644,NULL,'Purchase','Latifabad unit 11','3002652145',1,'2023-01-09 13:18:59'),(4,'smk1',100180,NULL,'Employee','test','03452408728',1,'2023-01-09 13:18:59'),(5,'Walkin Customer',700,NULL,'Customer',NULL,NULL,1,'2023-01-09 13:18:59'),(6,'asdasd',12312,0,'Purchase','123123','112312321',1,'2023-01-19 22:42:32'),(7,'test',2323,30000,'Employee','asdas','232323',1,'2023-01-19 22:43:25'),(8,'',0,0,'Purchase','','',1,'2023-01-19 22:47:58');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `accounttransactions`
--

DROP TABLE IF EXISTS `accounttransactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounttransactions` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `AccountID` int NOT NULL,
  `Invoice` int DEFAULT NULL,
  `BillType` varchar(45) NOT NULL DEFAULT 'TR',
  `NetAmount` double NOT NULL DEFAULT '0',
  `PaidAmount` double NOT NULL DEFAULT '0',
  `RemainingAmount` double NOT NULL DEFAULT '0',
  `Datetime` datetime NOT NULL,
  `Description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounttransactions`
--

LOCK TABLES `accounttransactions` WRITE;
/*!40000 ALTER TABLE `accounttransactions` DISABLE KEYS */;
INSERT INTO `accounttransactions` VALUES (1,1,NULL,'TR',0,2000,0,'2023-01-10 17:29:04',''),(2,1,NULL,'TR',0,5000,0,'2023-01-10 17:29:39','Hello workd'),(3,3,NULL,'TR',0,-2222,0,'2023-01-10 17:30:19','-2222'),(4,5,33,'Selling',5000,4500,500,'2023-01-17 12:18:56',NULL),(5,5,34,'Selling',6698,6698,0,'2023-01-17 12:21:20',NULL),(6,2,1,'Purchasing',4073.52,0,4073.52,'2023-01-19 20:21:12',NULL),(7,2,3,'Purchasing',21000,0,21000,'2023-01-19 20:29:09',NULL),(8,2,5,'Purchasing',5550,0,5550,'2023-01-19 20:41:12',NULL),(9,2,6,'Purchasing',1800,300,1500,'2023-01-19 21:11:43',NULL),(10,2,7,'Purchasing',1500,500,1000,'2023-01-19 21:13:43',NULL),(11,2,8,'Purchasing',1000,0,1000,'2023-01-19 21:14:31',NULL),(12,2,9,'Purchasing',1000,1000,0,'2023-01-19 21:15:15',NULL);
/*!40000 ALTER TABLE `accounttransactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expense`
--

DROP TABLE IF EXISTS `expense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expense` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `Datetime` datetime NOT NULL,
  `IsActive` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expense`
--

LOCK TABLES `expense` WRITE;
/*!40000 ALTER TABLE `expense` DISABLE KEYS */;
INSERT INTO `expense` VALUES (1,'exp1','exp1 desc','2022-12-26 22:55:34',1),(2,'exp2','exp2 desc','2022-12-26 22:55:39',1),(3,'exp2','exp2 desc','2022-12-26 22:55:52',0);
/*!40000 ALTER TABLE `expense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `CustomerAccountID` int DEFAULT NULL,
  `Total` double NOT NULL,
  `Discount` double DEFAULT NULL,
  `NetTotal` double DEFAULT NULL,
  `Paid` double DEFAULT NULL,
  `Remaining` double DEFAULT NULL,
  `Datetime` datetime NOT NULL,
  `IsActive` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,NULL,1200,NULL,NULL,NULL,NULL,'2022-12-31 00:02:27',1),(2,NULL,1200,NULL,NULL,NULL,NULL,'2022-12-31 00:14:32',1),(3,NULL,1200,NULL,NULL,NULL,NULL,'2022-12-31 00:15:00',1),(4,NULL,3000,NULL,NULL,NULL,NULL,'2022-12-31 00:16:16',1),(5,NULL,4800,NULL,NULL,NULL,NULL,'2022-12-31 00:24:54',1),(6,NULL,5700,NULL,NULL,NULL,NULL,'2022-12-31 00:26:24',1),(7,NULL,4800,NULL,NULL,NULL,NULL,'2022-12-31 00:29:37',1),(8,NULL,16500,NULL,NULL,NULL,NULL,'2022-12-31 00:37:27',1),(9,NULL,16500,NULL,NULL,NULL,NULL,'2022-12-31 00:38:13',1),(10,NULL,9000,NULL,NULL,NULL,NULL,'2022-12-31 00:40:27',1),(11,NULL,0,NULL,NULL,NULL,NULL,'2022-12-31 00:44:14',1),(12,NULL,18500,NULL,NULL,NULL,NULL,'2022-12-31 01:03:11',1),(13,NULL,109000,NULL,NULL,NULL,NULL,'2023-01-01 15:45:06',1),(14,NULL,109000,NULL,NULL,NULL,NULL,'2023-01-01 15:48:19',1),(15,NULL,54500,NULL,NULL,NULL,NULL,'2023-01-01 15:50:51',1),(16,NULL,109000,NULL,NULL,NULL,NULL,'2023-01-01 15:53:21',1),(17,NULL,28485,NULL,NULL,NULL,NULL,'2023-01-06 16:17:36',1),(18,NULL,3000,NULL,NULL,NULL,NULL,'2023-01-14 17:42:31',1),(19,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 17:44:10',1),(20,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 17:49:56',1),(21,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 17:54:33',1),(22,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:02:33',1),(23,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:05:19',1),(24,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:10:55',1),(25,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:13:04',1),(26,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:14:35',1),(27,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:18:27',1),(28,NULL,1500,NULL,NULL,NULL,NULL,'2023-01-14 18:21:15',1),(29,NULL,2000,NULL,NULL,NULL,NULL,'2023-01-16 09:45:03',1),(30,5,2000,200,1800,1500,300,'2023-01-17 11:38:00',1),(31,5,5500,500,5000,4500,500,'2023-01-17 12:15:41',1),(32,5,5298,298,5000,4500,500,'2023-01-17 12:17:45',1),(33,5,5298,298,5000,4500,500,'2023-01-17 12:18:56',1),(34,5,6798,100,6698,6698,0,'2023-01-17 12:21:20',1);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetail`
--

DROP TABLE IF EXISTS `orderdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetail` (
  `OrderID` int NOT NULL,
  `ProductID` int NOT NULL,
  `Price` double NOT NULL,
  `Size` int NOT NULL,
  `Quantity` int NOT NULL,
  `Total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetail`
--

LOCK TABLES `orderdetail` WRITE;
/*!40000 ALTER TABLE `orderdetail` DISABLE KEYS */;
INSERT INTO `orderdetail` VALUES (7,2,1500,0,2,3000),(7,7,600,0,3,1800),(8,7,600,0,15,9000),(8,2,1500,0,5,7500),(9,2,1500,0,5,7500),(9,7,600,0,15,9000),(10,7,600,0,15,9000),(11,8,0,0,2,0),(12,9,2000,0,3,6000),(12,10,2500,0,5,12500),(14,2,1500,9000,8,6),(14,9,2000,42000,8,21),(14,9,2000,18000,9,9),(14,9,2000,20000,10,10),(14,9,2000,20000,11,10),(16,2,1500,8,6,9000),(16,9,2000,8,21,42000),(16,9,2000,9,9,18000),(16,9,2000,10,10,20000),(16,9,2000,11,10,20000),(17,11,1899,9,10,18990),(17,11,1899,8,5,9495),(18,2,1500,8,2,3000),(19,2,1500,8,1,1500),(20,2,1500,8,1,1500),(21,2,1500,8,1,1500),(22,2,1500,8,1,1500),(23,2,1500,8,1,1500),(24,2,1500,8,1,1500),(25,2,1500,8,1,1500),(26,2,1500,8,1,1500),(27,2,1500,8,1,1500),(28,2,1500,8,1,1500),(29,9,2000,11,1,2000),(30,9,2000,8,1,2000),(31,2,1500,8,1,1500),(31,9,2000,8,2,4000),(32,2,1500,8,1,1500),(32,11,1899,8,2,3798),(33,2,1500,8,1,1500),(33,11,1899,9,2,3798),(34,2,1500,8,2,3000),(34,11,1899,8,2,3798);
/*!40000 ALTER TABLE `orderdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `DateTime` datetime NOT NULL,
  `Quantity` int NOT NULL DEFAULT '0',
  `Price` double NOT NULL DEFAULT '0',
  `IsActive` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,'hello product','hello product desc1','2022-12-26 07:35:22',0,0,0),(2,'prodname','proddesc','2022-12-26 07:36:09',0,1500,1),(3,'','','2022-12-26 20:36:31',0,0,0),(4,'','','2022-12-26 20:36:32',0,0,0),(5,'','','2022-12-26 20:36:33',0,0,0),(6,'hello product','hello product des','2022-12-26 22:33:53',0,0,0),(7,'prodname222','proddesc2222','2022-12-27 14:03:56',0,600,1),(8,'test','test','2022-12-31 00:43:51',0,0,1),(9,'Classic Shoes 8 No','Classic Shoes 8 No','2022-12-31 00:52:34',2,2000,1),(10,'Stylish Shoes 8 No','Stylish Shoes 8 No','2022-12-31 00:52:50',1,2500,1),(11,'947 - Black','947 - Black','2023-01-06 16:15:55',0,1899,1);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productstock`
--

DROP TABLE IF EXISTS `productstock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productstock` (
  `ProductID` int NOT NULL,
  `Number` int NOT NULL,
  `Quantity` int NOT NULL,
  PRIMARY KEY (`ProductID`,`Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productstock`
--

LOCK TABLES `productstock` WRITE;
/*!40000 ALTER TABLE `productstock` DISABLE KEYS */;
INSERT INTO `productstock` VALUES (1,2,3),(2,8,32),(2,9,15),(9,8,20),(9,9,10),(9,10,10),(9,11,10),(11,8,6),(11,9,8);
/*!40000 ALTER TABLE `productstock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase`
--

DROP TABLE IF EXISTS `purchase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase` (
  `PurchaseID` int NOT NULL AUTO_INCREMENT,
  `PurchaseAccountID` int NOT NULL,
  `Total` double DEFAULT NULL,
  `Discount` double DEFAULT NULL,
  `NetTotal` double DEFAULT NULL,
  `Paid` double DEFAULT NULL,
  `Remaining` double DEFAULT NULL,
  `Datetime` datetime NOT NULL,
  `IsActive` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`PurchaseID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase`
--

LOCK TABLES `purchase` WRITE;
/*!40000 ALTER TABLE `purchase` DISABLE KEYS */;
INSERT INTO `purchase` VALUES (1,2,4073.52,0,4073.52,0,4073.52,'2023-01-19 20:21:12',1),(2,2,20000,0,20000,0,20000,'2023-01-19 20:26:14',1),(3,2,21000,0,21000,0,21000,'2023-01-19 20:29:09',1),(4,2,28886,0,28886,0,28886,'2023-01-19 20:40:14',1),(5,2,5550,0,5550,0,5550,'2023-01-19 20:41:12',1),(6,2,2000,200,1800,300,1500,'2023-01-19 21:11:43',1),(7,2,1500,0,1500,500,1000,'2023-01-19 21:13:43',1),(8,2,1000,0,1000,0,1000,'2023-01-19 21:14:31',1),(9,2,1000,0,1000,1000,0,'2023-01-19 21:15:15',1);
/*!40000 ALTER TABLE `purchase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchasedetail`
--

DROP TABLE IF EXISTS `purchasedetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchasedetail` (
  `PurchaseID` int NOT NULL,
  `ProductID` int NOT NULL,
  `Price` double NOT NULL,
  `Size` double NOT NULL,
  `Quantity` int NOT NULL,
  `Total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasedetail`
--

LOCK TABLES `purchasedetail` WRITE;
/*!40000 ALTER TABLE `purchasedetail` DISABLE KEYS */;
INSERT INTO `purchasedetail` VALUES (1,2,123.44,11,33,4073.52),(3,2,500,8,10,5000),(3,2,500,9,10,5000),(3,7,500,8,10,5000),(3,9,500,8,12,6000),(4,2,2222,8,3,6666),(4,2,2222,9,10,22220),(5,2,222,8,10,2220),(5,2,222,9,15,3330),(6,2,1000,8,2,2000),(7,2,500,8,3,1500),(8,2,1000,8,1,1000),(9,2,1000,8,1,1000);
/*!40000 ALTER TABLE `purchasedetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `size`
--

DROP TABLE IF EXISTS `size`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `size` (
  `Number` int NOT NULL,
  PRIMARY KEY (`Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `size`
--

LOCK TABLES `size` WRITE;
/*!40000 ALTER TABLE `size` DISABLE KEYS */;
INSERT INTO `size` VALUES (8),(9),(10),(11);
/*!40000 ALTER TABLE `size` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `Datetime` datetime NOT NULL,
  `isactive` tinyint NOT NULL DEFAULT '1',
  `isadmin` tinyint NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('admin','admin123','2022-12-31 15:21:28',1,1),('ayesha','aasasdaaaa','2022-12-31 16:09:33',0,0),('mam','mam123','2022-12-31 15:51:18',1,0),('shoaib','shoaib123','2022-12-31 15:51:04',1,1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'pos'
--
/*!50003 DROP PROCEDURE IF EXISTS `insertproductstock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertproductstock`(in pproductid int,in pnumber int,in pquantity int)
BEGIN
 DECLARE rowcount int DEFAULT 0;
	SELECT count(*) 
    INTO rowcount
    FROM productstock
    WHERE productid = pproductid and `number` = pnumber;

    IF rowcount > 0 THEN
        update productstock set quantity = quantity + pquantity
          WHERE productid = pproductid and `number` = pnumber;
    ELSE
       insert into productstock values(pproductid,pnumber,pquantity);
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-19 22:51:21
