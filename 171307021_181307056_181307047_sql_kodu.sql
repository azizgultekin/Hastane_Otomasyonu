-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: hastaneotomasyonu
-- ------------------------------------------------------
-- Server version	8.0.20

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
-- Table structure for table `bolum`
--

DROP TABLE IF EXISTS `bolum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bolum` (
  `bolum_id` int NOT NULL,
  `bolum_adi` varchar(30) NOT NULL,
  PRIMARY KEY (`bolum_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bolum`
--

LOCK TABLES `bolum` WRITE;
/*!40000 ALTER TABLE `bolum` DISABLE KEYS */;
INSERT INTO `bolum` VALUES (0,'Acil Servis'),(1,'Ağız ve Diş Sağlığı'),(2,'Anestezi'),(3,'Beyin ve Sinir Cerrahisi'),(4,'Çocuk Cerrahisi'),(5,'Çocuk Kardiyolojisi'),(6,'Dermatoloji'),(7,'Fizik Tedavi ve Rehabilitasyon'),(8,'Göz Hastalıkları'),(9,'Dahiliye'),(10,'Göğüs Cerrahisi'),(11,'Kardiyoloji'),(12,'Kulak Burun Boğaz '),(13,'Psikiyatri'),(14,'Radyoloji'),(15,'Genel Cerrahi'),(16,'Ortapedi');
/*!40000 ALTER TABLE `bolum` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doktor`
--

DROP TABLE IF EXISTS `doktor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doktor` (
  `doktor_ad_soyadi` varchar(60) NOT NULL,
  `doktor_id` int DEFAULT NULL,
  `bolum_id` int DEFAULT NULL,
  PRIMARY KEY (`doktor_ad_soyadi`),
  KEY `bolum_id` (`bolum_id`),
  CONSTRAINT `doktor_ibfk_1` FOREIGN KEY (`bolum_id`) REFERENCES `bolum` (`bolum_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doktor`
--

LOCK TABLES `doktor` WRITE;
/*!40000 ALTER TABLE `doktor` DISABLE KEYS */;
INSERT INTO `doktor` VALUES ('Doç. Dr. Ayşe Çetin',6,0),('Doç. Dr. İnanç Güvenç',20,14),('Doç. Dr. Nil Sayıner Çağlar',24,7),('Doç. Dr. Tarık Ocak',5,0),('Doç. Dr. Tufan Akın Giray',7,2),('Dr. Ali Vefa',0,15),('Dt. Öğr. Üyesi Kemal Tuzkan',11,12),('Op. Dr. Dilek Polat',14,4),('Prof. Dr. Adalet Demir',2,10),('Prof. Dr. Ahmet Hakan Gerçekoğlu',3,1),('Prof. Dr. Aziz Kardede',1,11),('Prof. Dr. Binnur Üstün',16,6),('Prof. Dr. Cem Ertan',4,0),('Prof. Dr. Gülendam Koçak',15,5),('Prof. Dr. Hakkı Birinci',18,8),('Prof. Dr. Halil İbrahim Bekler',22,16),('Prof. Dr. Mustafa Çeliktaş',23,16),('Prof. Dr. Mutlu Sağlam',21,14),('Prof. Dr. Özcan Hız',17,7),('Prof. Dr. Yusuf Özkan',19,9),('Uzm. Dr. Halil Sağlık',8,3),('Uzm. Dt. Halil Çelik',12,12),('Uzm. Dt. Pınar Yüce',13,1),('Uzm. Klnk. Psk. Dilay Süloğlu',10,13),('Uzm. Klnk. Psk. Tuba Ertunç',9,13);
/*!40000 ALTER TABLE `doktor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `giris`
--

DROP TABLE IF EXISTS `giris`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `giris` (
  `kullanici_adi` varchar(15) NOT NULL,
  `sifre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kullanici_adi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `giris`
--

LOCK TABLES `giris` WRITE;
/*!40000 ALTER TABLE `giris` DISABLE KEYS */;
INSERT INTO `giris` VALUES ('admin','admin'),('aleynadurmaz','4'),('aysesenol','2'),('berkgelir','3'),('d','1'),('efecan','1234');
/*!40000 ALTER TABLE `giris` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hastalar`
--

DROP TABLE IF EXISTS `hastalar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hastalar` (
  `tc` varchar(11) NOT NULL,
  `dosya_no` int DEFAULT NULL,
  `adi` varchar(30) DEFAULT NULL,
  `soyadi` varchar(30) DEFAULT NULL,
  `anne_adi` varchar(30) DEFAULT NULL,
  `baba_adi` varchar(30) DEFAULT NULL,
  `kan_grubu` varchar(30) DEFAULT NULL,
  `meslek` varchar(30) DEFAULT NULL,
  `es_meslek` varchar(30) DEFAULT NULL,
  `dogum_yeri` varchar(30) DEFAULT NULL,
  `dogum_tarihi` varchar(20) DEFAULT NULL,
  `cinsiyet` varchar(30) DEFAULT NULL,
  `medeni_hal` varchar(30) DEFAULT NULL,
  `es_ad` varchar(30) DEFAULT NULL,
  `es_kan_grubu` varchar(30) DEFAULT NULL,
  `referans` varchar(100) DEFAULT NULL,
  `ev_tel` varchar(30) DEFAULT NULL,
  `is_tel` varchar(30) DEFAULT NULL,
  `cep_tel` varchar(30) DEFAULT NULL,
  `fax` varchar(30) DEFAULT NULL,
  `e_mail` varchar(30) DEFAULT NULL,
  `dosya_acilis` varchar(30) DEFAULT NULL,
  `dosya_acan_kisi` varchar(30) DEFAULT NULL,
  `aciklama` varchar(300) DEFAULT NULL,
  `indirim` varchar(30) DEFAULT NULL,
  `ev_adresi` varchar(300) DEFAULT NULL,
  `is_adresi` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`tc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hastalar`
--

LOCK TABLES `hastalar` WRITE;
/*!40000 ALTER TABLE `hastalar` DISABLE KEYS */;
INSERT INTO `hastalar` VALUES ('15412352691',5,'Kaan','Bayrak','Nil','Burak','B Rh+','Şoför','Diğer','İstanbul','15.07.1996','Erkek','Evli','Nalan','AB Rh-','Doç. Dr. Nil Sayıner Çağlar','','','(522) (223) (33) (14)','','','','Doç. Dr. Nil Sayıner Çağlar','Hastane doktorumuz Doç. Dr. Nil Sayıner Çağlar oğlu.','Var','İstanbul / Kadıköy / Eğitim Mh.',''),('28958210563',4,'Lale','Tunç','Neslihan','Erhan','B Rh+','Asker','Asker','Bursa','22.03.1990','Kadın','Evli','Erol','0 Rh+','','','','(511) (233) (44) (32)','','laletunccc@hotmail.com','','','','Yok','Muş / Merkez / Zafer Mah.',''),('45212525489',1,'Fatma','Kur','Ayşe','Ahmet','AB Rh-','Polis','Diğer','Ankara','01.01.1955','Kadın','Dul','Recep','0 Rh-','Kızı Baş Hemşire','0(312) (444) (22) (14)','','(544) (444) (33) (22)','','','  .  .','Kızı Baş Hemşire','','Var','Ankara / Altındağ / Güneşevler Mh.',''),('45612514756',7,'Mehmet','Atuçuranoğlu','Pelin','Ahmet','B Rh-','Diğer','','Kırıkkale','11.11.1991','Erkek','Bekar','','','','','','(511) (122) (34) (44)','','','','','Hastane personeli','Var','İstanbul / Esenyurt / Gökevler Mh.',''),('49047414520',0,'Ali','Çelik','Fatma','Çelik','A Rh-','İşçi','Diğer','Ardahan','22.06.1988','Erkek','Evli','Ayşe','B Rh-','','','','(555) (333) (22) (22)','','ali07celik@yandex.com','','','','Yok','İstanbul / Beylikdüzü / Cumhuriyet Mah.',''),('52032102541',9,'Halil','Mehmet','Leyla','Diri','A Rh+','Diğer','','Iğdır','05.07.1999','Erkek','Bekar','','','','','','(522) (112) (33) (34)','','halillldirii11@gmail.com','','','','Var','Samsun / Atakum / Yenimahalle Mah.','Samsun / Atakum / Körfez Mh.'),('52065412356',10,'Taner','Ölmez','Nalan','Bekir','B Rh-','Diğer','','İstanbul','09.08.1986','Erkek','Bekar','','','','','','(522) (331) (11) (22)','','tanerolmezz@outlook.com','','','','Var','İstanbul / Bahçelievler / Yenibosna Merkez Mah.','İstanbul / Kadıköy / Erenköy Mh.'),('74125445863',2,'Tekin','Korkmaz','Berrin','Mehmet','B Rh+','İtfaiyeci','','Muğla','12.02.1985','Erkek','Bekar','','','','','','(544) (332) (22) (12)','','','','','İtfaiye Dairesi Başkanlığı - TC Muğla Büyükşehir Belediyesi','Var','Muğla / Marmaris / İçmeler Mh.\n','Marmaris İtfaiye Amirliği'),('78521425454',11,'Efecan','Engin','Ayşe','Ahmet','B Rh-','Diğer','','Ardahan','28.03.1998','Erkek','Bekar','','','','(   ) (   ) (  ) (  )','(   ) (   ) (  ) (  )','(556) (456) (54) (65)','','','  .  .','','','Yok','',''),('85214741245',8,'Buğra','İlker','Nazlı','Gezen','A Rh+','Şoför','Diğer','Hatay','07.05.1988','Erkek','Evli','Nihal','B Rh-','','','','(522) (112) (33) (12)','','iilkkerbgraa@ynadex.com','','','','Yok','Zafer, Bülent Ecevit Blv, 59850 Çorlu/Tekirdağ','Tekirdağ / Çorlu / Önerler Mh.'),('85465425412',3,'Berrak','Derdiyok','Hilal','Ziya','AB Rh+','Diğer','','İzmir','11.05.2002','Kadın','Bekar','','','','','','(532) (999) (55) (43)','','','','','','Yok','İzmir / Karabağlar / Vatan Mah.',''),('98565232114',6,'Fdime','Turan','Tülay','Sönmezerler','0 Rh-','Diğer','','Tekirdağ','25.03.1991','Kadın','Bekar','','','','(   ) (   ) (  ) (  )','(   ) (   ) (  ) (  )','(534) (435) (53) (30)','','turannnzehra@gmail.com','  .  .','','','Yok','Tekirdağ / Çorlu / Önerler Mh.','Tekirdağ / Çorlu / Hatip Mahallesi Muhtarlığı');
/*!40000 ALTER TABLE `hastalar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odeme`
--

DROP TABLE IF EXISTS `odeme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odeme` (
  `odeme_id` int NOT NULL,
  `fis_no` int DEFAULT NULL,
  `tarih` varchar(30) DEFAULT NULL,
  `tc` varchar(11) DEFAULT NULL,
  `odeme_durumu` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`odeme_id`),
  KEY `tc` (`tc`),
  CONSTRAINT `odeme_ibfk_1` FOREIGN KEY (`tc`) REFERENCES `hastalar` (`tc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odeme`
--

LOCK TABLES `odeme` WRITE;
/*!40000 ALTER TABLE `odeme` DISABLE KEYS */;
INSERT INTO `odeme` VALUES (0,0,'26 Mayıs 2020 Pazartesi','15412352691','Ödendi'),(1,1,'26 Mayıs 2020 Salı','28958210563','Ödendi'),(2,2,'27 Mayıs 2020 Çarşamba','45612514756','Ödendi'),(3,2,'','45612514756','Ödenmedi'),(4,3,'28 Mayıs 2020 Perşembe','74125445863','Ödendi'),(5,3,'28 Mayıs 2020 Perşembe','74125445863','Ödendi'),(6,4,'','28958210563','Ödenmedi'),(7,5,'27 Mayıs 2020 Çarşamba','49047414520','Ödendi'),(8,6,'','49047414520','Ödenmedi'),(9,7,'','45612514756','Ödenmedi');
/*!40000 ALTER TABLE `odeme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `randevu`
--

DROP TABLE IF EXISTS `randevu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `randevu` (
  `randevu_id` int NOT NULL,
  `saat` varchar(15) DEFAULT NULL,
  `adi` varchar(30) DEFAULT NULL,
  `soyadi` varchar(30) DEFAULT NULL,
  `randevu_tc` varchar(11) DEFAULT NULL,
  `randevu_tarihi` varchar(65) DEFAULT NULL,
  `doktor_ad_soyadi` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`randevu_id`),
  KEY `doktor_ad_soyadi` (`doktor_ad_soyadi`),
  CONSTRAINT `randevu_ibfk_1` FOREIGN KEY (`doktor_ad_soyadi`) REFERENCES `doktor` (`doktor_ad_soyadi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `randevu`
--

LOCK TABLES `randevu` WRITE;
/*!40000 ALTER TABLE `randevu` DISABLE KEYS */;
INSERT INTO `randevu` VALUES (0,'09:00','Kaan','Bayrak','15412352691','30 Mayıs 2020 Cumartesi','Doç. Dr. Ayşe Çetin'),(1,'11:00','Lale','Tunç','28958210563','31 Mayıs 2020 Pazar','Op. Dr. Dilek Polat'),(2,'13:00','Mehmet ','Atuçuranoğlu','45612514756','31 Mayıs 2020 Pazar','Prof. Dr. Aziz Kardede'),(3,'10:00','melek','şahin','45646465465','28 Mayıs 2020 Perşembe','Doç. Dr. Tarık Ocak'),(4,'15:00','şahin','kaya','21645418974','28 Mayıs 2020 Perşembe','Prof. Dr. Gülendam Koçak'),(5,'10:00','Tekin','Korkmaz','74125445863','1 Haziran 2020 Pazartesi','Doç. Dr. Ayşe Çetin'),(6,'10:00','Ali','Çelik','49047414520','30 Mayıs 2020 Cumartesi','Doç. Dr. Ayşe Çetin');
/*!40000 ALTER TABLE `randevu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yapilacak_islemler`
--

DROP TABLE IF EXISTS `yapilacak_islemler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yapilacak_islemler` (
  `yapilacak_islem_id` int NOT NULL,
  `yapilacak_islem` varchar(30) DEFAULT NULL,
  `yapilacak_islem_tutari` float DEFAULT NULL,
  `tc` varchar(11) DEFAULT NULL,
  `odeme_id` int DEFAULT NULL,
  PRIMARY KEY (`yapilacak_islem_id`),
  KEY `odeme_id` (`odeme_id`),
  KEY `tc` (`tc`),
  CONSTRAINT `yapilacak_islemler_ibfk_1` FOREIGN KEY (`odeme_id`) REFERENCES `odeme` (`odeme_id`),
  CONSTRAINT `yapilacak_islemler_ibfk_2` FOREIGN KEY (`tc`) REFERENCES `hastalar` (`tc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yapilacak_islemler`
--

LOCK TABLES `yapilacak_islemler` WRITE;
/*!40000 ALTER TABLE `yapilacak_islemler` DISABLE KEYS */;
INSERT INTO `yapilacak_islemler` VALUES (0,'MR',250,'28958210563',1),(1,'MR',250,'45612514756',2),(2,'İdrar Testi',90,'45612514756',3),(3,'Kan Tahlili',75,'74125445863',4),(4,'MR',250,'74125445863',5),(5,'Kan Tahlili',75,'28958210563',6),(6,'Kan Tahlili',75,'49047414520',7),(7,'MR',250,'49047414520',8),(8,'Röntgen',50,'45612514756',9);
/*!40000 ALTER TABLE `yapilacak_islemler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-30 13:41:41
