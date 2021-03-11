CREATE TABLE `organizatie` (
  `idOrganizatie` int NOT NULL,
  `Denumire` varchar(45) NOT NULL,
  `Adresa` varchar(45) DEFAULT NULL,
  `pers_contact` varchar(45) DEFAULT NULL,
  `telefon` varchar(45) DEFAULT NULL,
  `user` varchar(45) DEFAULT NULL,
  `parola` varchar(45) DEFAULT NULL,
  `cod_proiect` varchar(45) NOT NULL,
  PRIMARY KEY (`idOrganizatie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='			'