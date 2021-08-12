-- CREATE
--   DATABASE
CREATE DATABASE teacher_lucas_g

USE teacher_lucas_g

--   TABLE
CREATE TABLE usuario(
	id			    INT IDENTITY,
	userName		VARCHAR(100),
	senha			 VARCHAR(75),
	nome_do_usuario VARCHAR(100),
	status					 BIT,
)
-- DROP TABLE usuario

-- ALTER
--   PK
   ALTER TABLE usuario
ADD CONSTRAINT PK_ID_Usuario
   PRIMARY KEY (id)

--   NOT NULL
 ALTER TABLE usuario
ALTER COLUMN userName
VARCHAR(100)
    NOT NULL

 ALTER TABLE usuario
ALTER COLUMN senha
 VARCHAR(75)
    NOT NULL

 ALTER TABLE usuario
ALTER COLUMN nome_do_usuario
VARCHAR(100)
    NOT NULL

 ALTER TABLE usuario
ALTER COLUMN status
		 BIT
    NOT NULL

--   UQ
   ALTER TABLE usuario
ADD CONSTRAINT UQ_USER_NAME_Usuario
	    UNIQUE (userName)