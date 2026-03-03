CREATE SCHEMA ORMModel1
GO

GO


CREATE TABLE ORMModel1.Patient
(
	patientNr int NOT NULL,
	patientName nvarchar(30) NOT NULL,
	isSmoker bit,
	CONSTRAINT Patient_PK PRIMARY KEY(patientNr)
)
GO


CREATE TABLE ORMModel1.DrugAllergy
(
	patientNr int NOT NULL,
	allergy nvarchar(20) NOT NULL,
	CONSTRAINT DrugAllergy_PK PRIMARY KEY(patientNr, allergy)
)
GO


ALTER TABLE ORMModel1.DrugAllergy ADD CONSTRAINT DrugAllergy_FK FOREIGN KEY (patientNr) REFERENCES ORMModel1.Patient (patientNr) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


GO