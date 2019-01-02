-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.6.35


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema restapi
--

CREATE DATABASE IF NOT EXISTS restapi;
USE restapi;

--
-- Definition of table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__efmigrationshistory`
--

/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` (`MigrationId`,`ProductVersion`) VALUES 
 ('20180826230617_InitialCreate','2.0.3-rtm-10026');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;


--
-- Definition of table `prato`
--

DROP TABLE IF EXISTS `prato`;
CREATE TABLE `prato` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `idrestaurante` int(11) NOT NULL,
  `NOME` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `prato`
--

/*!40000 ALTER TABLE `prato` DISABLE KEYS */;
INSERT INTO `prato` (`ID`,`idrestaurante`,`NOME`) VALUES 
 (1,1,'Prato 01'),
 (2,1,'Prato 01');
/*!40000 ALTER TABLE `prato` ENABLE KEYS */;


--
-- Definition of table `restaurante`
--

DROP TABLE IF EXISTS `restaurante`;
CREATE TABLE `restaurante` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `restaurante`
--

/*!40000 ALTER TABLE `restaurante` DISABLE KEYS */;
INSERT INTO `restaurante` (`ID`,`NOME`) VALUES 
 (1,'Restaurante 01'),
 (2,'Restaurante 01');
/*!40000 ALTER TABLE `restaurante` ENABLE KEYS */;

--
-- Create schema restaurante
--

CREATE DATABASE IF NOT EXISTS restaurante;
USE restaurante;

--
-- Definition of table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `__efmigrationshistory`
--

/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` (`MigrationId`,`ProductVersion`) VALUES 
 ('20180819143738_VersaoInicial','2.0.3-rtm-10026');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;


--
-- Definition of table `prato`
--

DROP TABLE IF EXISTS `prato`;
CREATE TABLE `prato` (
  `SQPRATO` bigint(20) NOT NULL AUTO_INCREMENT,
  `NMPRATO` varchar(255) NOT NULL,
  `SQRESTAURANTE` bigint(20) NOT NULL,
  PRIMARY KEY (`SQPRATO`),
  KEY `IX_PRATO_SQRESTAURANTE` (`SQRESTAURANTE`),
  CONSTRAINT `FKRESTAURANTEPRATO` FOREIGN KEY (`SQRESTAURANTE`) REFERENCES `restaurante` (`SQRESTAURANTE`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `prato`
--

/*!40000 ALTER TABLE `prato` DISABLE KEYS */;
/*!40000 ALTER TABLE `prato` ENABLE KEYS */;


--
-- Definition of table `restaurante`
--

DROP TABLE IF EXISTS `restaurante`;
CREATE TABLE `restaurante` (
  `SQRESTAURANTE` bigint(20) NOT NULL AUTO_INCREMENT,
  `NMRESTAURANTE` varchar(255) NOT NULL,
  PRIMARY KEY (`SQRESTAURANTE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `restaurante`
--

/*!40000 ALTER TABLE `restaurante` DISABLE KEYS */;
INSERT INTO `restaurante` (`SQRESTAURANTE`,`NMRESTAURANTE`) VALUES 
 (1,'R01'),
 (2,'R01'),
 (3,'R01');
/*!40000 ALTER TABLE `restaurante` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
