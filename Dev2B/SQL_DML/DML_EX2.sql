--Tabela Cliente--------------

CREATE TABLE cliente(
   
   idClientes INT IDENTITY,
   nome VARCHAR(100) NOT NULL,
   email VARCHAR(100) NOT NULL,
   senha VARCHAR(100) NOT NULL
)

--Tabela Pedido--------------

CREATE TABLE pedido(
   
   idPedidos INT IDENTITY,
   data DATE NOT NULL,
   status VARCHAR(45) NOT NULL,
   sessao VARCHAR(45) NOT NULL,
   idClientes INT NOT NULL
)

--Tabela Pedido Item---------

CREATE TABLE pedidoItem(
   
   idPedidoItens INT IDENTITY,
   qtade INT NOT NULL,
   preco DECIMAL(16,2) NOT NULL,
   total DECIMAL(16,2) NOT NULL,
   idProdutos INT NOT NULL,
   idPedidos INT NOT NULL
)

--Tabela Produtos------------

CREATE TABLE produto(
   
   idProdutos INT IDENTITY,
   dsproduto VARCHAR(45) NOT NULL,
   preco DECIMAL (16,2) NOT NULL,
   qtdade INT NOT NULL,
   idCategorias INT NOT NULL
)

CREATE TABLE categoria(
   
   idCategorias INT IDENTITY,
   dscategoria VARCHAR(45) NOT NULL,

)

--Chave Primaria todas as tabelas---------

 ALTER TABLE cliente ADD CONSTRAINT PK_ID_Cliente PRIMARY KEY (idClientes)
 
 ALTER TABLE pedido ADD CONSTRAINT PK_ID_Pedido PRIMARY KEY (idPedidos)
 
 ALTER TABLE pedidoItem ADD CONSTRAINT PK_ID_Pedido_Item PRIMARY KEY (idPedidoItens)
 
 ALTER TABLE produto ADD CONSTRAINT PK_ID_Produto PRIMARY KEY (idProdutos)
 
 ALTER TABLE categoria ADD CONSTRAINT PK_ID_Categoria PRIMARY KEY (idCategorias)

--Chave estrangeira todas as tabelas-------
   
 ALTER TABLE pedido ADD CONSTRAINT FK_ID_Cliente#Cliente_ID_Cliente FOREIGN KEY (idClientes) REFERENCES cliente(idClientes) 
 
 ALTER TABLE pedidoItem ADD CONSTRAINT FK_ID_Pedido#Pedido_ID_Pedido FOREIGN KEY (idPedidos) REFERENCES pedido(idPedidos)
 
 ALTER TABLE pedidoItem ADD CONSTRAINT FK_ID_Produto#Produto_ID_Produto FOREIGN KEY (idProdutos) REFERENCES produto(idProdutos)

 ALTER TABLE produto ADD CONSTRAINT FK_ID_Categoria#Categoria_ID_Categoria FOREIGN KEY (idCategorias) REFERENCES categoria(idCategorias)

--Desenvolva um script que insira 5 registros em cada tabela

-- Cliente------------------

   INSERT
     INTO cliente (nome, email, senha)
   VALUES ('ABNER', 'abnerwillian@hotmail.com', '12345678')
   
   INSERT
     INTO cliente (nome, email, senha)
   VALUES ('YURI', 'yuriquissak@hotmail.com', '12345678')

    INSERT
     INTO cliente (nome, email, senha)
   VALUES ('LUCAS', 'lucascapalbo@hotmail.com', '12345678')

   INSERT
     INTO cliente (nome, email, senha)
   VALUES ('GABRIEL', 'gabrielbeserra@hotmail.com', '12345678')

    INSERT
     INTO cliente (nome, email, senha)
   VALUES ('MARCUS', 'marcusvinicios@hotmail.com', '12345678')

--Categorias-------------------
   
   INSERT
     INTO categoria(dscategoria)
   VALUES ('Alimento')
   
   INSERT
     INTO categoria(dscategoria)
   VALUES ('Alimento')

   INSERT
     INTO categoria(dscategoria)
   VALUES ('Alimento')
   
   INSERT
     INTO categoria(dscategoria)
   VALUES ('Alimento')

   INSERT
     INTO categoria(dscategoria)
   VALUES ('Alimento')

-- Pedido------------------

    INSERT
     INTO pedido (data, status, sessao, idClientes)
   VALUES ('04/16/1999', 'Aberto', 'Area_B', '1')

   INSERT
     INTO pedido (data, status, sessao, idClientes)
   VALUES ('04/17/1999', 'Disponivel', 'Area_B', '2')

   INSERT
     INTO pedido (data, status, sessao, idClientes)
   VALUES ('04/18/1999', 'Disponivel', 'Area_A', '3')

   INSERT
     INTO pedido (data, status, sessao, idClientes)
   VALUES ('04/19/1999', 'Aberto', 'Area_A', '4')

   INSERT
     INTO pedido (data, status, sessao, idClientes)
   VALUES ('04/20/1999', 'Disponivel', 'Area_B', '5')

-- Produtos----------------
   INSERT
     INTO produto (dsproduto, preco, qtdade, idCategorias)
   VALUES ('Leite', 10, 1, 1)

   INSERT
     INTO produto (dsproduto, preco, qtdade, idCategorias)
   VALUES ('Bolacha', 20, 1, 2)

   INSERT
     INTO produto (dsproduto, preco, qtdade, idCategorias)
   VALUES ('Chocolate', 30, 1, 3)

   INSERT
     INTO produto (dsproduto, preco, qtdade, idCategorias)
   VALUES ('Macarrão', 40, 1, 4)

   INSERT
     INTO produto (dsproduto, preco, qtdade, idCategorias)
   VALUES ('Danone', 50, 1, 5)

-- Pedido Item------------------

   INSERT
     INTO pedidoItem (qtade, preco, total, idProdutos, idPedidos)
   VALUES (1, 10, 10, 1, 1)

   INSERT
     INTO pedidoItem (qtade, preco, total, idProdutos, idPedidos)
   VALUES (1, 20, 20, 2, 2)

   INSERT
     INTO pedidoItem (qtade, preco, total, idProdutos, idPedidos)
   VALUES (1, 30, 30, 3, 3)

   INSERT
     INTO pedidoItem (qtade, preco, total, idProdutos, idPedidos)
   VALUES (1, 40, 40, 4, 4)

   INSERT
     INTO pedidoItem (qtade, preco, total, idProdutos, idPedidos)
   VALUES (1, 50, 50, 5, 5)

-- Desenvolva um script que altere o descrição de um Produto para “Notebook” (Pode ser qualquer registro - Condicione pelo ID)

   UPDATE produto
      SET dsproduto = 'Notebook'
	  WHERE idProdutos = 5

-- Desenvolva um script que altere a senha  de um Cliente para 123456 (Pode ser qualquer registro - Condicione pelo ID)

   UPDATE cliente
      SET senha = 123456
	WHERE idClientes = 3

-- Desenvolva um script que altere o Nome de um Produto para “Bolacha Trakinas” (Condicione onde a descrição contenha a palavra “Bolacha”)

   UPDATE produto
      SET dsproduto = 'Bolacha Trakinas'
	WHERE idProdutos = 5

-- Desenvolva um script que delete um registro da tabela Pedido (Pode ser qualquer registro Condicione pelo ID)

    DELETE 
	  FROM pedidoItem
	 WHERE  idPedidos = 3

    DELETE 
	  FROM pedido
	 WHERE  idPedidos = 3

-- Desenvolva um script que delete um registro da tabela Produto (Pode ser qualquer registro Condicione pelo ID)

    DELETE 
	  FROM  pedidoItem
	 WHERE  idProdutos = 2

    DELETE 
	  FROM  produto
	 WHERE  idProdutos = 2

-- Desenvolva um script que selecione a descrição, preço e categoria dos produtos
   
   SELECT produto.dsproduto, produto.preco, categoria.dscategoria
     FROM produto
	 JOIN categoria ON produto.idCategorias = categoria.idCategorias

-- Desenvolva um script que selecione todos os pedidos feitos por um Cliente. Do Cliente exiba apenas o nome (Pode ser qualquer registro - Condicione pelo ID)

   SELECT cliente.nome 
     FROM pedido
	 JOIN cliente ON pedido.idClientes = cliente.idClientes
	 WHERE pedido.idClientes = 4 
	 
-- Desenvolva um script que selecione todas as categorias de um produto que um cliente tenha feito um pedido, ordenados pela descrição do produto. Exiba apenas nome do Cliente e descrição da Categoria (Pode ser qualquer registro - Condicione pelo ID)

   SELECT cliente.nome,categoria.dscategoria
     FROM pedido
	 JOIN cliente ON pedido.idClientes = cliente.idClientes
	 JOIN produto ON pedido.idPedidos = produto.idProdutos
	 JOIN categoria ON produto.idCategorias = categoria.idCategorias
	 WHERE cliente.idClientes = 4 
	 
-- Desenvolva um script que selecione a soma total de um pedido feito por um cliente (Pode ser qualquer registro - Condicione pelo ID)

   SELECT pedidoItem.idPedidoItens, pedidoItem.total, cliente.nome 
     FROM pedidoItem
	 JOIN pedido ON pedidoItem.idPedidos = pedido.idPedidos
	 JOIN cliente ON pedido.idClientes = cliente.idClientes
	 WHERE cliente.idClientes = 1 

-- Desenvolva um script que selecione os 10 últimos pedidos feitos por um produto (Pode ser qualquer registro - Condicione pelo ID do produto) 

       SELECT TOP 10 pedido.*, produto.dsproduto
         FROM pedido
		 JOIN pedidoItem ON pedidoItem.idPedidos = pedido.idPedidos
		 JOIN produto ON produto.idProdutos = pedidoItem.idProdutos
		 WHERE produto.idProdutos = 4
		 ORDER BY produto.idProdutos DESC

-- Desenvolva um script que selecione a quantidade de pedidos realizados por um cliente (Pode ser qualquer registro - Condicione pelo ID)

 SELECT COUNT(pedido.idPedidos) AS [Quantidade de pedidos]
   FROM pedido 
   JOIN cliente ON pedido.idClientes = cliente.idClientes
  WHERE cliente.idClientes = 4

-- Desenvolva um script que selecione o último pedido feito com o produto de descrição “Bolacha Trakinas”. Exiba apenas a data do Pedido e o nome do Cliente que fez o pedido
   
       SELECT TOP 1 pedido.data AS [Data do Pedido], cliente.nome[Nome]
         FROM pedido
		 JOIN cliente ON pedido.idClientes = cliente.idClientes
		 JOIN pedidoItem ON pedidoItem.idPedidos = pedido.idPedidos
		 JOIN produto ON produto.idProdutos = pedidoItem.idProdutos
		 WHERE produto.dsproduto = 'Bolacha Trakinas'
		 ORDER BY produto.idProdutos DESC

-- Desenvolva um script que selecione o preço total dos produtos feitos em cada pedido agrupados pela Categoria

  SELECT categoria.dscategoria AS [Descrição da categori], SUM (pedidoItem.total) AS [Preço Total]
    FROM categoria
	JOIN produto ON categoria.idCategorias = produto.idCategorias
	JOIN pedidoItem ON produto.idProdutos = pedidoItem.idProdutos
	JOIN pedido ON pedidoItem.idPedidos = pedido.idPedidos
	GROUP BY categoria.dscategoria

-- Desenvolva um script que selecione o produto com menor valor feito em um pedido por um cliente. Exiba apenas o preço (Condicione pelo Id)

       SELECT MIN (produto.preco) AS [Preço do produto]
         FROM pedido
		 JOIN cliente ON pedido.idClientes = cliente.idClientes
		 JOIN pedidoItem ON pedidoItem.idPedidos = pedido.idPedidos
		 JOIN produto ON produto.idProdutos = pedidoItem.idProdutos
		 WHERE cliente.idClientes = 5
		 

-- Desenvolva um script que informe a quantidade de categorias de produtos.

   SELECT COUNT(categoria.idCategorias) AS [Quantidade de Categorias]
     FROM categoria

-- Desenvolva um script que selecione a descrição e o preço dos produtos, ordenados pelo preço, do mais barato ao mais caro.

   SELECT produto.dsproduto AS [Descrição Produto], produto.preco AS [Preço do produto]
     FROM produto
    ORDER BY produto.preco ASC

-- Desenvolva um script que selecione quais os tipos de Status que estão atribuídos aos pedidos.

   SELECT DISTINCT pedido.status 
     FROM pedido
    ORDER BY pedido.status

-- Desenvolva um script que selecione o Id do pedido, data do pedido, descrição do produto, quantidade do produto, preco do produto, preco total do produto, nome do cliente e email do cliente, em que os pedidos estejam com a situação 'Aberto'.

 SELECT pedido.idPedidos, pedido.data, produto.dsProduto, produto.qtdade, produto.preco, pedidoItem.total, cliente.nome, cliente.email
   FROM produto 
   JOIN pedidoitem ON produto.idProdutos = pedidoItem.idProdutos
   JOIN pedido ON pedidoItem.idPedidos = pedido.idPedidos
   JOIN cliente ON pedido.idClientes = cliente.idClientes
  WHERE pedido.status = 'Aberto'

-- Desenvolva um script que selecione o maior valor de um produto.

  SELECT MAX(produto.preco) AS [Maior Valor]
    FROM produto

-- Desenvolva um script que selecione o valor médios dos pedidos na data atual.

   SELECT AVG(pedidoItem.total) AS [Média dos pedidos] 
     FROM pedidoItem
	 JOIN pedido ON pedidoItem.idPedidos = pedido.idPedidos
	 WHERE CONVERT(DATE, pedido.data) = CONVERT(DATE, GETDATE())

-- Desenvolva um script que selecione todos os clientes que não tenham um pedido atribuido aos mesmos.

   SELECT cliente.idClientes, cliente.email, cliente.nome, pedido.data, pedido.IdPedidos, pedido.sessao, pedido.status
     FROM cliente 
	 LEFT JOIN pedido ON cliente.idClientes = pedido.idClientes
	 WHERE pedido.idClientes IS NULL

