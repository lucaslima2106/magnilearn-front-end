-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: magnilearn
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `word_score_per_exercise`
--

DROP TABLE IF EXISTS `word_score_per_exercise`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `word_score_per_exercise` (
  `exerciseId` int unsigned NOT NULL,
  `wordId` int unsigned NOT NULL,
  `score` double DEFAULT NULL,
  KEY `word_score_per_exercise_idx` (`exerciseId`,`wordId`) /*!80000 INVISIBLE */
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='For each exercise, for each word practiced in this exercise, the score the user got for that word in that exercise.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `word_score_per_exercise`
--

LOCK TABLES `word_score_per_exercise` WRITE;
/*!40000 ALTER TABLE `word_score_per_exercise` DISABLE KEYS */;
INSERT INTO `word_score_per_exercise` VALUES (1,1,4.3),(1,2,3),(1,3,5),(1,4,2),(1,5,1.5),(2,1,4.3),(2,2,3),(2,3,5),(2,4,2),(2,5,1.5),(13,6,4.3),(13,7,3),(13,8,5),(13,9,2),(13,10,1.5),(14,1,4.3),(14,2,3),(14,3,5),(14,4,2),(15,5,1.5),(5,6,4.3),(5,7,3),(5,8,5),(6,9,2),(6,10,1.5),(20,1,3),(21,2,2),(22,3,5),(23,4,1),(24,5,1.5),(25,1,4),(26,2,3.8),(27,3,5),(28,4,2.8),(29,5,2.5),(30,6,3.3),(31,7,4),(32,8,5),(33,9,2),(34,10,1.8),(35,1,4.1),(36,2,3),(37,3,2),(38,4,5),(39,5,3.5),(40,6,2.3),(41,7,4),(42,8,3),(43,9,5),(44,10,1.2),(44,10,5),(44,10,5),(44,10,5),(44,10,5),(44,10,5),(44,10,5),(44,10,5);
/*!40000 ALTER TABLE `word_score_per_exercise` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  1:52:19
