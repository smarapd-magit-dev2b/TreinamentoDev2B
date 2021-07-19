USE Loja_LucasGO

-- Reiniciar tabelas

If(OBJECT_ID('FK_ID_CLIENTE_Venda#ID_Cliente') Is Not Null)
                ALTER TABLE venda
            DROP CONSTRAINT FK_ID_CLIENTE_Venda#ID_Cliente

If(OBJECT_ID('cliente') Is Not Null)
   DROP TABLE cliente

If(OBJECT_ID('itemVenda') Is Not Null)
   DROP TABLE itemVenda

If(OBJECT_ID('produto') Is Not Null)
   DROP TABLE produto

If(OBJECT_ID('venda') Is Not Null)
   DROP TABLE venda

-- DLL CREATE

CREATE TABLE cliente(
	id INT IDENTITY,
	nome VARCHAR(125),
	dataNascimento DATETIME,
	telefone BIGINT,
	cpf VARCHAR(11) NOT NULL,
	rg VARCHAR(9) NOT NULL,
	sexo CHAR

	 CONSTRAINT PK_ID_Cliente
	PRIMARY KEY (id),

	CONSTRAINT CC_SEXO_Cliente
	     CHECK (sexo IN ('M', 'F')),

	CONSTRAINT UQ_CPF_Cliente
	    UNIQUE (cpf),

	CONSTRAINT UQ_RG_Cliente
	    UNIQUE (rg)
)

CREATE TABLE venda(
	id INT IDENTITY,
	idCliente INT,
	data DATETIME

	 CONSTRAINT PK_ID_Venda
	PRIMARY KEY (Id),

	 CONSTRAINT FK_ID_CLIENTE_Venda#ID_Cliente
	FOREIGN KEY (idCliente)
	 REFERENCES cliente (id)
)

CREATE TABLE produto(
	id INT IDENTITY,
	dataInclusao DATETIME,
	descricao VARCHAR(140),
	preco DECIMAL(11, 2)

	 CONSTRAINT PK_ID_Produto
	PRIMARY KEY (id)
)

CREATE TABLE itemVenda(
	id INT IDENTITY,
	idVenda INT,
	idProduto INT,
	quantidade INT,
	valorTotal DECIMAL(11, 2)

	 CONSTRAINT PK_ID_Itens
	PRIMARY KEY (id),

	 CONSTRAINT FK_ID_VENDA_ItemVenda#ID_Venda
	FOREIGN KEY (idVenda)
	 REFERENCES venda (id),

	 CONSTRAINT FK_ID_PRODUTO_ItemVenda#ID_Produto
	FOREIGN KEY (idProduto)
	 REFERENCES produto (id)
)

--DLL ALTER

 ALTER TABLE cliente
ALTER COLUMN nome VARCHAR(500)

    ALTER TABLE cliente
DROP CONSTRAINT UQ_RG_Cliente

ALTER TABLE cliente
DROP COLUMN rg

    ALTER TABLE venda
DROP CONSTRAINT FK_ID_CLIENTE_Venda#ID_Cliente

ALTER TABLE cliente
        ADD endereco VARCHAR(125)