--CREATE DATABASE University

USE University

---------------------------------------------------------------

CREATE TABLE SpecialisationList -- main info about university
(
SpecialisationID INT IDENTITY NOT NULL,
SpecialisationName VARCHAR(25) NOT NULL,
);


ALTER TABLE SpecialisationList
ADD CONSTRAINT SPLPK PRIMARY KEY(SpecialisationName)
GO

ALTER TABLE SpecialisationList
ADD CONSTRAINT SPLU UNIQUE(SpecialisationID)
GO

INSERT INTO SpecialisationList
VALUES('IT'),
('Design'),
('AI');
GO

---------------------------------------------------------------

CREATE TABLE Subjects
(
SubjectID INT IDENTITY NOT NULL UNIQUE,
SubjectName VARCHAR(30) NOT NULL,
Specialisation VARCHAR(20) not null,
language VARCHAR(3) not null,
Semester SMALLINT not null,
Date VARCHAR(MAX)
)
GO

---------------------------------------------------------------

INSERT INTO Subjects
(SubjectName, Specialisation, language, Semester)
VALUES
('TestSubjectA1', 'AI', 'PL', 2),
('TestSubjectA2', 'AI', 'PL', 2),
('TestSubjectA3', 'AI', 'PL', 2),
('TestSubjectA4', 'AI', 'PL', 2),
('TestSubjectA5', 'AI', 'PL', 2),

('TestSubjectI1', 'IT', 'PL', 1),
('TestSubjectI2', 'IT', 'PL', 1),
('TestSubjectI3', 'IT', 'PL', 1),
('TestSubjectI4', 'IT', 'PL', 1),
('TestSubjectI5', 'IT', 'PL', 1),

('ProgramingI2', 'IT', 'PL', 2),
('ProgramingI2', 'IT', 'PL', 2),
('ProgramingI2', 'IT', 'PL', 2),
('ProgramingI2', 'IT', 'PL', 2),
('ProgramingI2', 'IT', 'PL', 2),

('Data buildingI1', 'IT', 'ENG', 1),
('Data buildingI1', 'IT', 'ENG', 1),
('Data buildingI1', 'IT', 'ENG', 1),
('Data buildingI1', 'IT', 'ENG', 1),
('Data buildingI1', 'IT', 'ENG', 1)
go

---------------------------------------------------------------

CREATE TABLE Students
(StudentID INT IDENTITY PRIMARY KEY NOT NULL,
FirstName VARCHAR(20) NOT NULL,
LastName VARCHAR(20) NOT NULL,
Adress VARCHAR(40) NULL DEFAULT 'unknown',
PhoneNumber VARCHAR(11) NULL DEFAULT 'unknown',
SpecialisationName VARCHAR(20) NOT NULL ,
Language VARCHAR(15) NOT NULL,
ActuallySemester SMALLINT NOT NULL DEFAULT 1,
MoneyTransfers MONEY
)
GO

---------------------------------------------------------------

SELECT * FROM SpecialisationList

SELECT * FROM Subjects

SELECT * FROM Students