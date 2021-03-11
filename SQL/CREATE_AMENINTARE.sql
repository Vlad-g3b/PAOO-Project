CREATE TABLE `amenintare` (
  `cod_amenintare` int NOT NULL,
  `amenintare` varchar(45) DEFAULT NULL,
  `cod_bun` int DEFAULT NULL,
  `nivel_min` decimal(10,0) DEFAULT NULL,
  `nivel_max` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`cod_amenintare`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='	'