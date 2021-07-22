-- CREATE DATABASE PeopleLucasGO

USE PeopleLucasGO

-- DROP TABLE

-- DROP TABLE person

-- CREATE TABLE

CREATE TABLE person(
	id INT IDENTITY,
	idDad INT,
	idMon INT,
	name VARCHAR(50) NOT NULL,
	lastName VARCHAR(100) NOT NULL,
	birthDate DATE NOT NULL,
	height DECIMAL(3,2),
	weight DECIMAL(5,2),
	race VARCHAR(5),
	status BIT NOT NULL,
	cpf VARCHAR(11) NOT NULL
)

-- ADD PK

   ALTER TABLE person
ADD CONSTRAINT FK_Person
   PRIMARY KEY (id)

-- ADD UQ

   ALTER TABLE person
ADD CONSTRAINT UQ_Person
		UNIQUE (cpf)

-- ADD FK

   ALTER TABLE person
ADD CONSTRAINT FK_ID_DAD_Person#ID_Person
   FOREIGN KEY (idDad)
    REFERENCES person (id)

   ALTER TABLE person
ADD CONSTRAINT FK_ID_MON_Person#ID_Person
   FOREIGN KEY (idMon)
    REFERENCES person (id)

-- ADD CK

ALTER TABLE person
  ADD CHECK (race IN ('White', 'Black'))

-- INSERT INTO

INSERT INTO person
			(name, lastName,    birthDate, height, weight,    race, status,         cpf)
	 VALUES ( 'a',		'b', '2000-12-01',    1.2,   99.3, 'White',      1, '254156389')

INSERT INTO person
			(name, lastName,    birthDate, height, weight,    race, status,         cpf, idDad)
	 VALUES ( 'b',		'c', '2000-12-01',    1.2,   99.3, 'White',      1, '254126389',     1)

SELECT * FROM person