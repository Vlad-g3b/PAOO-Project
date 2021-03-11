
CREATE TABLE  organizatie  (
   cod_org  int NOT NULL,
   Denumire  varchar(45) NOT NULL,
   Adresa  varchar(45) DEFAULT NULL,
   pers_contact  varchar(45) DEFAULT NULL,
   telefon  varchar(45) DEFAULT NULL,
   username  varchar(45) DEFAULT NULL,
   parola  varchar(45) DEFAULT NULL,
   cod_proiect  int NOT NULL,
  PRIMARY KEY ( cod_org )
)