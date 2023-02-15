CREATE SCHEMA `dbhospital` ;

CREATE TABLE `dbhospital`.`tbl_client` (
  `CPF` VARCHAR(11) NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `register_date` DATETIME NOT NULL,
  `health_insurance` VARCHAR(45) NULL,
  PRIMARY KEY (`CPF`));

CREATE TABLE `dbhospital`.`tbl_user` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(20) NOT NULL,
  `user_type` VARCHAR(45) NOT NULL DEFAULT 'Paciente',
  `register_date` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`));
 
 CREATE TABLE `dbhospital`.`tbl_services` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `service_name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(45) NULL,
  `service_price` DECIMAL(6,2) NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`ID`));
  
  CREATE TABLE `dbhospital`.`tbl_appointment` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `service_date` VARCHAR(45) NOT NULL,
  `description` VARCHAR(45) NULL,
  `fk_idclient` VARCHAR(11) NOT NULL,
  `fk_idservice` INT NOT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `fk_idclient`
    FOREIGN KEY (`fk_idclient`)
    REFERENCES `dbhospital`.`tbl_client` (`CPF`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_idservices`
    FOREIGN KEY (`fk_idservice`)
    REFERENCES `dbhospital`.`tbl_services` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

