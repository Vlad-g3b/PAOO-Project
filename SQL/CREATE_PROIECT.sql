CREATE TABLE `proiect` (
  `cod_proiect` int NOT NULL,
  `denumire` varchar(45) DEFAULT NULL,
  `domeniu` varchar(45) DEFAULT NULL,
  `data_inceput` date DEFAULT NULL,
  `data_final` date DEFAULT NULL,
  PRIMARY KEY (`cod_proiect`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci