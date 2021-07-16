CREATE TABLE cliente(
   
   idCliente INT IDENTITY,
   nome VARCHAR(45) NOT NULL,
   dataNascimento DATETIME NOT NULL,
   telefone VARCHAR(25),
   cpf INT NOT NULL,
   rg INT NOT NULL,
   sexo CHAR (1),

   CONSTRAINT PK_ID_Cliente PRIMARY KEY (idCliente),
   CONSTRAINT REGRA_SEXO CHECK (sexo IN ('M', 'F')),
   CONSTRAINT UQ_CPF_Cliente UNIQUE (cpf),
   CONSTRAINT UQ_RG_Cliente UNIQUE (rg)
)

CREATE TABLE venda(

   idVenda INT IDENTITY,
   idCliente INT NOT NULL,
   dataVenda DATETIME DEFAULT GETDATE(),

   CONSTRAINT PK_ID_Venda PRIMARY KEY (idVenda),
   CONSTRAINT FK_ID_Cliente#Cliente_ID_Cliente FOREIGN KEY (idCliente) REFERENCES cliente (idCliente)

)
CREATE TABLE produto(
   
   idProduto INT IDENTITY,
   dataInclusao DATETIME DEFAULT GETDATE(),
   descricao VARCHAR (50),
   preco DECIMAL (6,2) NOT NULL,

   CONSTRAINT PK_ID_Produto PRIMARY KEY (idProduto),
)

CREATE TABLE itemVenda(

   idVenda INT NOT NULL,
   idProduto INT NOT NULL,
   quantidade INT NOT NULL,
   valorTotal DECIMAL (6,2) NOT NULL,

   CONSTRAINT FK_ID_Venda#Venda_ID_Venda FOREIGN KEY (idVenda) REFERENCES venda (idVenda),
   CONSTRAINT FK_ID_Produto#Produto_ID_Produto FOREIGN KEY (idProduto) REFERENCES produto (idProduto)

)

--Desenvolva um script que altere o campo Nome da tabela Cliente para o tipo VARCHAR(500)

ALTER TABLE cliente DROP COLUMN nome

ALTER TABLE cliente ADD nome VARCHAR(500) NOT NULL

--Desenvolva um script que delete o campo RG da tabela Cliente

ALTER TABLE cliente DROP CONSTRAINT UQ_RG_Cliente

ALTER TABLE cliente DROP COLUMN rg

--Desenvolva um script que delete a chave estrangeira da tabela Venda

ALTER TABLE venda DROP CONSTRAINT FK_ID_Cliente#Cliente_ID_Cliente

--Desenvolva um script que adicione a coluna Endereco na tabela Cliente

ALTER TABLE cliente ADD endereco VARCHAR(45)

