-- CREATE DATABASE Dev2B_LucasGO_Exercicio2

USE Dev2B_LucasGO_Exercicio2

-- Reinicia Banco

  If(OBJECT_ID('FK_ID_CATEGORIA_Produto#ID_Categoria') Is Not Null)
    ALTER TABLE produto
DROP CONSTRAINT FK_ID_CATEGORIA_Produto#ID_Categoria

  If(OBJECT_ID('FK_ID_PEDIDO_ItemPedido#ID_Pedido') Is Not Null)
    ALTER TABLE itemPedido
DROP CONSTRAINT FK_ID_PEDIDO_ItemPedido#ID_Pedido

  If(OBJECT_ID('FK_ID_PRODUTO_ItemPedido#ID_Produto') Is Not Null)
    ALTER TABLE itemPedido
DROP CONSTRAINT FK_ID_PRODUTO_ItemPedido#ID_Produto

  If(OBJECT_ID('FK_ID_CLIENTE_Pedido#ID_Cliente') Is Not Null)
    ALTER TABLE pedido
DROP CONSTRAINT FK_ID_CLIENTE_Pedido#ID_Cliente

If(OBJECT_ID('cliente') Is Not Null)
   DROP TABLE cliente

If(OBJECT_ID('categoria') Is Not Null)
   DROP TABLE categoria

If(OBJECT_ID('produto') Is Not Null)
   DROP TABLE produto

If(OBJECT_ID('itemPedido') Is Not Null)
   DROP TABLE itemPedido

If(OBJECT_ID('pedido') Is Not Null)
   DROP TABLE pedido

If(OBJECT_ID('Item Pedido') Is Not Null)
    DROP VIEW [Item Pedido]

-- Exercício 2

-- CREATE TABLE

CREATE TABLE categoria(
	id      INT IDENTITY,
	descricao VARCHAR(45)
)

CREATE TABLE produto(
	id       INT IDENTITY,
	descricao VARCHAR(45),
	preco   SMALLMONEY,
	quantidade        INT,
	idCategoria       INT
)

CREATE TABLE cliente(
	id    INT IDENTITY,
	nome  VARCHAR(100),
	email VARCHAR(100),
	senha VARCHAR(100)
)

CREATE TABLE pedido(
	id    INT IDENTITY,
	data          DATE,
	status VARCHAR(45),
	sessao VARCHAR(45),
	idCliente      INT
)

CREATE TABLE itemPedido(
	id     INT IDENTITY,
	quantidade      INT,
	idPedido        INT,
	idProduto       INT
)

-- ADD CONSTRAINT PK

   ALTER TABLE produto
ADD CONSTRAINT PK_ID_Produto
   PRIMARY KEY (id)

   ALTER TABLE categoria
ADD CONSTRAINT PK_ID_Categoria
   PRIMARY KEY (id)

   ALTER TABLE itemPedido
ADD CONSTRAINT PK_ID_ItemPedido
   PRIMARY KEY (id)

   ALTER TABLE pedido
ADD CONSTRAINT PK_ID_Pedido
   PRIMARY KEY (id)

   ALTER TABLE cliente
ADD CONSTRAINT PK_ID_Cliente
   PRIMARY KEY (id)

-- ADD CONSTRAINT FK

   ALTER TABLE produto
ADD CONSTRAINT FK_ID_CATEGORIA_Produto#ID_Categoria
   FOREIGN KEY (idCategoria)
    REFERENCES categoria (id)

   ALTER TABLE itemPedido
ADD CONSTRAINT FK_ID_PEDIDO_ItemPedido#ID_Pedido
   FOREIGN KEY (idPedido)
    REFERENCES pedido (id)

   ALTER TABLE itemPedido
ADD CONSTRAINT FK_ID_PRODUTO_ItemPedido#ID_Produto
   FOREIGN KEY (idProduto)
    REFERENCES produto (id)

   ALTER TABLE pedido
ADD CONSTRAINT FK_ID_CLIENTE_Pedido#ID_Cliente
   FOREIGN KEY (idCliente)
    REFERENCES cliente (id)

-- ALTER FK NOT NULL

 ALTER TABLE produto
ALTER COLUMN idCategoria INT NOT NULL

 ALTER TABLE itemPedido
ALTER COLUMN idProduto INT NOT NULL

 ALTER TABLE itemPedido
ALTER COLUMN idPedido INT NOT NULL

 ALTER TABLE pedido
ALTER COLUMN idCliente INT NOT NULL

-- ADD CONSTRAINT UNIQUE

   ALTER TABLE cliente
ADD CONSTRAINT UQ_EMAIL_Cliente
	    UNIQUE (email)

-- ADD CONSTRAINT CHECK

   ALTER TABLE pedido
ADD CONSTRAINT CK_STATUS_Pedido
		 CHECK (status IN ('Aberto', 'Concluido'))

   ALTER TABLE pedido
ADD CONSTRAINT CK_SESSAO_Pedido
		 CHECK (sessao IN ('Em transporte', 'Entregue', 'Aguardando Pagamento'))
GO

-- CREATE VIEW

CREATE VIEW [Item Pedido] AS
	 SELECT i.*,
			(p.preco) AS preco,
			(p.preco * i.quantidade) AS total
	   FROM itemPedido i
	   JOIN produto p
		 ON p.id = i.idProduto
GO
-- INSERT INTO

INSERT INTO categoria
		    (descricao    )
     VALUES	('Farmaco'    ),
			('Latricinio' ),
			('Polimorfico'),
			('Adulterado' ),
			('Amendoin'   )

-- SELECT * FROM categoria

INSERT INTO cliente
			(nome,     email,                      senha)
	 VALUES ('Homer',  'ogauga@tts.com',     '3081294sa'),
			('Jerg',   'aghljgr@312.com',      'c gy3ew'),
			('Lorena', 'treisoitao@gmail.com', '19304hy'),
			('Picapau','molezz@ruk.com', '190my3tu89143'),
			('Roberto','socrates@fg.com',     '981t9ux4')

-- SELECT * FROM cliente

-- SELECT * FROM categoria

INSERT INTO produto
			(descricao, quantidade,   preco, idCategoria)
	 VALUES ('Baixo',			15,	  32.32,		   2),
			('Joia',			 2, 3124.32,		   3),
			('Martelo',			32,	  42.32,		   1),
			('Roda',			22,	  32.32,		   2),
			('Bolacha',			33,	  44.32,		   4)

-- SELECT * FROM produto

-- SELECT * FROM cliente

INSERT INTO pedido 
			(data,         status,      sessao,         idCliente)
	 VALUES ('2009-12-03', 'Aberto',    'Aguardando Pagamento', 4),
		    ('2019-11-07', 'Concluido', 'Entregue',             2),
			('2000-05-21', 'Aberto',    'Em transporte',        3),
			('2003-02-19', 'Aberto',    'Aguardando Pagamento', 2),
			('1999-05-04', 'Aberto',    'Em transporte',        1)

-- SELECT * FROM pedido

-- SELECT p.id FROM pedido p; SELECT p.id FROM produto p

INSERT INTO itemPedido
			(quantidade, idPedido, idProduto)
	 VALUES (13,			    4,		   4),
			(32,				1,		   5),
			(43,				3,		   1),
			(12,		 		5,		   2),
			(54,		 	    4,		   3)

-- SELECT * FROM pedidoItem

-- UPDATE

-- SELECT * FROM produto

UPDATE produto
   SET descricao = 'Notebook'
 WHERE id = 2

-- SELECT * FROM produto

-- SELECT * FROM cliente

UPDATE cliente
   SET senha = '123456'
 WHERE id = 5

-- SELECT * FROM cliente

-- SELECT * FROM produto

UPDATE produto
   SET descricao = 'Bolacha Trakinas'
 WHERE descricao LIKE '%Bolacha%'

-- SELECT * FROM produto

-- DELETE

-- SELECT * FROM pedido; SELECT * FROM [Item Pedido]

DELETE itemPedido
 WHERE idPedido = 1

DELETE pedido
 WHERE id = 1

-- SELECT * FROM pedido

-- SELECT JOIN

-- SELECT * FROM categoria

SELECT p.descricao	AS Produto,
	   p.preco		AS Preço,
	   c.descricao  AS Categoria
  FROM produto p
  JOIN categoria c
	ON c.id = p.idCategoria

SELECT p.id		AS [ID do Pedido],
	   c.nome,
	   p.data,
	   p.status,
	   p.sessao AS sessão
  FROM pedido p
  JOIN cliente c
	ON c.id = p.idCliente
 WHERE c.id = 1

SELECT cli.nome,
	   cat.descricao AS Descrição
  FROM categoria cat
  JOIN produto pro
	ON pro.idCategoria = cat.id
  JOIN itemPedido i
	ON i.idProduto = pro.id
  JOIN pedido ped
	ON ped.id = i.idPedido
  JOIN cliente cli
	ON cli.id = ped.idCliente
 WHERE cli.id = 2
 ORDER BY pro.descricao

SELECT SUM(i.total) AS Total
  FROM pedido p
  JOIN cliente c
    ON c.id = p.idCliente
  JOIN [Item Pedido] i
	ON i.idPedido = p.id
 WHERE C.id = 2

SELECT TOP 10 ped.*
  FROM pedido ped
  JOIN itemPedido i
	ON i.idPedido = ped.id
  JOIN produto pro
	ON pro.id = i.idProduto
 WHERE pro.id = 3
 ORDER BY pro.id DESC

SELECT COUNT(p.id) AS [Quantidade de Pedidos]
  FROM pedido p
  JOIN cliente c
	ON c.id = p.idCliente
 WHERE c.id = 2

SELECT TOP 1
	   ped.data,
       c.nome
  FROM pedido ped
  JOIN cliente c
	ON c.id = ped.idCliente
  JOIN itemPedido i
    ON i.idPedido = ped.id
  JOIN produto pro
	ON pro.id = i.idProduto
 WHERE pro.descricao = 'Bolacha Trakinas'
 ORDER BY pro.id DESC

-- ESSE AQUI EM BAIXO NÃO ENTENDI MUITO BEM, FIZ O QUE PUDE

SELECT c.descricao  AS Categoria,
	   SUM(i.total) AS [Total por Categoria]
  FROM [Item Pedido] i
  JOIN produto p
	ON p.id = i.idProduto
  JOIN categoria c
	ON c.id = p.idCategoria
 GROUP BY c.descricao

SELECT c.nome		AS [Cliente],
	   MIN(i.preco) AS [Preço do Produto mais Barato]
  FROM [Item Pedido] i
  JOIN pedido p
    ON p.id = i.idPedido
  JOIN cliente c
    ON c.id = p.idCliente
 WHERE c.id = 2
 GROUP BY c.nome

SELECT COUNT(c.id) AS [Quantidade de Categorias de Produtos]
  FROM categoria c

SELECT p.descricao AS Produto,
	   p.preco	   AS Preço
  FROM produto p
 ORDER BY p.preco

  SELECT
DISTINCT p.status AS Status
    FROM pedido p

SELECT ped.id		 AS [Pedido],
	   ped.data		 AS [Data],
	   pro.descricao AS [Produto],
	   i.quantidade  AS [Quantidade],
	   pro.preco	 AS [Preço],
	   i.total		 AS [Total],
	   c.nome		 AS [Cliente],
	   c.email
  FROM pedido ped
  JOIN [Item Pedido] i
	ON i.idPedido = ped.id
  JOIN produto pro
	ON pro.id = i.idProduto
  JOIN cliente c
	ON c.id = ped.idCliente
 WHERE ped.status = 'Aberto'

SELECT MAX(p.preco) AS [Teto dos Produtos]
  FROM produto p

SELECT AVG(i.preco) AS [Média de Hoje]
  FROM [Item Pedido] i
  JOIN pedido p
	ON p.id = i.idPedido
 WHERE p.data = GETDATE()

SELECT c.*
  FROM cliente c
  LEFT JOIN pedido p
	ON p.idCliente = c.id
 WHERE p.id IS NULL