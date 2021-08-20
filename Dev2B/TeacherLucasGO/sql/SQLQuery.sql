-- CREATE
--   DATABASE
CREATE DATABASE teacher_lucas_g
-- USE master; DROP DATABASE teacher_lucas_g

USE teacher_lucas_g

--   TABLE
CREATE TABLE usuario
(
	idUsuario INT IDENTITY,
	userName VARCHAR(100) NOT NULL,
	senha VARCHAR(75) NOT NULL,
	nomeDoUsuario VARCHAR(100) NOT NULL,
	status BIT NOT NULL
)
-- DROP TABLE usuario

CREATE TABLE professor
(
	idProfessor INT IDENTITY,
	nomeCompleto VARCHAR(100) NOT NULL,
	cpf CHAR(11) NOT NULL,
	dataNascimento DATETIME,
	telefone VARCHAR(14),
	email VARCHAR(50),
	inglesFluente BIT,
	formacao VARCHAR(15),
	dataAdmissao DATETIME NOT NULL,
	salario DECIMAL(12, 2) NOT NULL,
	idEndereco INT NOT NULL,
	experienciaProfissional VARCHAR(500)
)
-- DROP

CREATE TABLE endereco
(
	idEndereco INT IDENTITY,
	cep CHAR(8) NOT NULL,
	logradouro VARCHAR(100) NOT NULL,
	bairro VARCHAR(75) NOT NULL,
	cidade VARCHAR(100) NOT NULL,
	uf CHAR(2) NOT NULL,
	numero VARCHAR(6) NOT NULL
)

CREATE TABLE disciplina
(
	idDisciplina INT IDENTITY,
	descricao VARCHAR(100) NOT NULL,
	cid VARCHAR(35) NOT NULL,
	dataInclusao DATETIME NOT NULL,
	idProfessor INT
)

-- ALTER TABLE
--   PK
ALTER TABLE usuario
ADD CONSTRAINT PK_ID_Usuario
   PRIMARY KEY (idUsuario)

ALTER TABLE professor
ADD CONSTRAINT PK_ID_Professor
   PRIMARY KEY (idProfessor)

ALTER TABLE endereco
ADD CONSTRAINT PK_ID_Endereco
   PRIMARY KEY (idEndereco)

ALTER TABLE disciplina
ADD CONSTRAINT PK_ID_Disciplina
   PRIMARY KEY (idDisciplina)

--   UQ
ALTER TABLE usuario
ADD CONSTRAINT UQ_USER_NAME_Usuario
	    UNIQUE (userName)

ALTER TABLE professor
ADD CONSTRAINT UQ_CPF_Professor
	    UNIQUE (cpf)

ALTER TABLE disciplina
ADD CONSTRAINT UQ_CID_Disciplina
	    UNIQUE (cid)

--   CHECK

ALTER TABLE professor
ADD CONSTRAINT formacaoEspecifica
		 CHECK (formacao IN ('Graduado', 'P�s Graduado', 'Mestrado', 'Doutorado'))

--   FOREIGN KEY
ALTER TABLE professor
ADD CONSTRAINT FK_PROFESSOR_ENDERECO
   FOREIGN KEY (idEndereco)
	REFERENCES endereco (idEndereco)

ALTER TABLE disciplina
ADD CONSTRAINT FK_DISCIPLINA_PROFESSOR
   FOREIGN KEY (idProfessor)
	REFERENCES professor (idProfessor)

-- INSERT INTO

INSERT INTO usuario
	( userName, senha, nomeDoUsuario, status)
VALUES
	( 'Roberto', '1234', 'Roberto Gon�alves', 1),
	('Maquinho01', '223', 'Marcos Solano', 0),
	( 'Rodrigo', '32', 'Rodrigo Banelli', 1),
	( 'Bernadete', 'bbnadete', 'Bernardo Rodolfo', 1),
	( 'Flauber', 'skate', 'Marcos Pereira', 1)
-- SELECT * FROM usuario

INSERT INTO endereco
	( cep, logradouro, bairro, cidade, uf, numero)
VALUES
	('1414000', 'Rua Sebasti�o', 'Luis Gonzaga', 'Cravinhos', 'SP', '15'),
	('1414000', 'Rua Homero', 'Montreal', 'Cravinhos', 'SP', '400'),
	('1424321', 'Avenida Bombeiros', 'Congonhas', 'Ribeir�o Preto', 'SP', '230'),
	('1424321', 'Avenida Sanches', 'Cegonha', 'Ribeir�o Preto', 'SP', '999'),
	('1424321', 'Rua Muri�oca', 'Cura�u', 'Ribeir�o Preto', 'SP', '111')
-- SELECT * FROM endereco

INSERT INTO professor
	( nomeCompleto, cpf, dataNascimento, telefone, email, inglesFluente, formacao, dataAdmissao, salario, idEndereco, experienciaProfissional)
VALUES
	( 'Rog�rio Domingos', '77952738828', '2002-05-11', '16903958301', 'rogerin@yahoo.com.br', 0, 'Graduado', '2015-11-02', 1500.2, 3, 'Trabalhei no MAC'),
	( 'Silva Anderson', '40607489006', '1999-07-14', '16957643528', 'silvasilva@yahoo.com.br', 1, 'Doutorado', '2019-12-24', 2000.12, 4, 'Trabalhei no Burguer King'),
	('Roberto Cavanhaque', '33201960730', '1971-02-23', '21957246195', 'roro@yahoo.com.br', 1, 'Mestrado', '2000-02-15', 3000.15, 2, 'Trabalhei nas Americanas'),
	( 'Carla da Silva', '34649434530', '1994-01-29', '16957941234', 'alecrin@yahoo.com.br', 0, 'Graduado', '2012-05-04', 200, 1, 'Trabalhei na SMARAPD'),
	( 'Xerox Machado', '09026356544', '1982-09-15', '19987542135', 'penelope@yahoo.com.br', 1, 'Mestrado', '2011-09-03', 155555.9, 5, 'Trabalhei na Microsoft')
-- SELECT * FROM professor

	INSERT INTO disciplina
	( descricao, cid, dataInclusao, idProfessor)
VALUES
	('Ci�ncia da Computa��o', '496231976723', '2003-05-12', 3),
	( 'Contabilidade', '43214321', '1999-12-02', 2),
	( 'Medicina', '4324213', '1999-08-16', 1),
	( 'Pedagogia', '341423423', '1996-01-02', 5),
	( 'Engenharia Civil', '459067320', '2031-01-22', 4)
-- SELECT * FROM disciplina