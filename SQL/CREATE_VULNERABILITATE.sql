CREATE TABLE `vulnerabilitate` (
  `cod_vulnerabilitate` int NOT NULL,
  `cod_bun` int DEFAULT NULL,
  `nivel` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`cod_vulnerabilitate`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci