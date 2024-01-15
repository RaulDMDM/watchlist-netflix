-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: netflix_watchlist
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `content`
--

DROP TABLE IF EXISTS `content`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `content` (
  `content_id` int NOT NULL AUTO_INCREMENT,
  `image_url` varchar(225) NOT NULL,
  `content_name` varchar(225) NOT NULL,
  `type` varchar(225) NOT NULL,
  `director` varchar(225) NOT NULL,
  `content_description` varchar(500) DEFAULT NULL,
  `genre` varchar(225) DEFAULT NULL,
  PRIMARY KEY (`content_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `content`
--

LOCK TABLES `content` WRITE;
/*!40000 ALTER TABLE `content` DISABLE KEYS */;
INSERT INTO `content` VALUES (1,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScMLrxmcBiz8x0pFR8ENtGQWB7tZI0nvDEO8wzj6h2O9EFg4-K','La sociedad de la nieve','Pelicula','Juan Antonio Bayona','Cuando un avión se estrella en los Andes, cada uno de los supervivientes se convierte en la mejor esperanza del otro mientras aúnan fuerzas para buscar el camino a casa.','Dramas'),(2,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReF-7BTM0Bg30CePalC-QCXry9rCwc-siFe4p9cmEdFEAh-EE-','Vacaciones de verano','Pelicula','Santiago Segura','Tras ser despedidos, dos amigos encuentran trabajo como animadores infantiles en un hotel de lujo y deciden colar a sus hijos para que disfruten de unas vacaciones.','Infantiles'),(3,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS6fizNzdu8Tjdouj3avaO4QmsHRHpQNHC4mG7NewjcVlVdJWpA','Tyler Rake 2','Pelicula','Sam Hargrave','Tras haber estado al borde de la muerte, el agente de élite Tyler Rake emprende una misión de alto riesgo: sacar de la cárcel a la familia de un despiadado gánster.','Acción'),(4,'https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQuneSn-yB1hY6XAEuaGINiDad4aC3oy859bdEtjibj-v06zsrT','Emboscada final','Pelicula','John Lee Hancock','En este drama policiaco basado en hechos reales, dos exrangers de Texas tienen la misión de encontrar y asesinar a los infames criminales Bonnie y Clyde.','Dramas'),(5,'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRBueCAgagI6zkeI0gcl2T5WE6ZJuINzigkPDVVINRipwvV_9ed','Trol','Pelicula','Roar Uthaug','Las autoridades recurren a una audaz paleontóloga para evitar que un trol ancestral, al que ha despertado una explosión en las montañas de Noruega, siembre el caos.','Acción'),(6,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRfVeTWX6IIR-5CYKdCr7InTf5dceCY3pvqkK4wQap25u3H8b_Y','Berlín','Serie','Álex Pina','En sus días de gloria, Berlín y una banda de ladrones se reúnen en París para llevar a cabo un ambicioso golpe: robar 44 millones de euros en joyas en una noche.','Dramas'),(7,'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRcaKbFZ0LVclRZ4ars-GnqrO-Yi0XPOlaNQ1XiiVolj2sanIRh','La clave del éxito','Serie','Aaron Korsh','Cuando un alumno que abandonó la universidad impresiona a un abogado con su gran inteligencia, consigue un puesto como asociado, aunque no tiene credenciales legales.','Dramas'),(8,'https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSt6DPj8ov2fZ_WzpeD-kG19Yzx2s57oT-mlKXAwS-ayw2xpkCn','La patrulla canina','Serie','Keith V. Chapman','Seis cachorros liderados por un niño experto en tecnología realizan misiones de rescate de alto riesgo con humor, ingenio y vehículos muy chulos.','Infantiles'),(9,'https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR9oH77LHc8Sa5RWLvjz_6c7_UJrd7zk3_QmnloQnOdbakUYcJp','The Walking Dead','Serie','Frank Darabont','En el despertar del apocalipsis zombi, los supervivientes se aferran a la esperanza de la humanidad y se unen para librar una batalla por su propia supervivencia.','Terror');
/*!40000 ALTER TABLE `content` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-14 22:51:59
