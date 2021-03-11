CREATE TABLE `activ` (
  `cod_bun` int NOT NULL,
  `nume_bun` varchar(45) DEFAULT NULL,
  `cod_proiect` int DEFAULT NULL,
  `impact_min` decimal(10,0) DEFAULT NULL,
  `impact_max` decimal(10,0) DEFAULT NULL,
  `domeniu_cat` varchar(45) DEFAULT NULL,
  `cost` decimal(10,0) DEFAULT NULL,
  `cost_reducere` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`cod_bun`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Denumirea tabelei trebuie sa fie la singular conform conventiei Oracle   -- >Activ = Bun'