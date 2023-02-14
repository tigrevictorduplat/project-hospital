CREATE SCHEMA `dbhospital` ;

CREATE TABLE `dbhospital`.`tbl_client` (
  `CPF` INT NOT NULL,
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
