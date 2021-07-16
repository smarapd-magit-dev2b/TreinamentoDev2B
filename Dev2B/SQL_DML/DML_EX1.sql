CREATE TABLE cliente(
   
   idCliente INT IDENTITY,
   nome VARCHAR(45) NOT NULL,
   dataNascimento DATETIME NOT NULL,
   telefone VARCHAR(25),
   cpf VARCHAR(11) NOT NULL,
   rg VARCHAR(9) NOT NULL,
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
   CONSTRAINT FK_ID_Cliente#Cliente_ID_Cliente FOREIGN KEY (idCliente) REFERENCES cliente(idCliente)

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
-- 1) Desenvolva um script que insere um registro na tabela Cliente

   INSERT
     INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
   VALUES ('Abner', '05/17/2000 00:00:00', '991161355', '33333333344', '112223335', 'M');
 
-- 2) Desenvolva um script que insere um registro na tabela Produto

   INSERT 
     INTO produto (descricao, preco) 
   VALUES ('Relogio', 200)

-- 3) Desenvolva um script que insere um registro na tabela Venda

   INSERT 
     INTO venda (idCliente, dataVenda)
   VALUES (1, '2016-05-13 00:00:00')


-- 4) Desenvolva um script que insere um registro na tabela Itens Venda

   INSERT 
     INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
   VALUES ('1', '1', '1', 200)


-- 5) Insira 5 Registros em cada tabela

-- Cliente------------------

   INSERT
     INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
   VALUES ('Julia' , '04/16/1999 00:00:00', '991161354', '44444444455', '111111111', 'F')

   INSERT
     INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
   VALUES('Laura','03/15/1998 00:00:00', '991161353', '55555555566', '222222222', 'F')

   INSERT
     INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
   VALUES('Marcus','02/13/1997 00:00:00', '991161352', '66666666677', '333333333', 'M' )
   
   INSERT
     INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
   VALUES('Pablo','01/14/1996 00:00:00', '991161351', '77777777788', '444444444', 'M')

   INSERT
     INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
   VALUES ('Amanda','06/12/1995 00:00:00', '991161350', '88888888899', '555555555', 'F')

   select * from cliente
-- Produto------------------
   
   INSERT 
     INTO produto (descricao, preco) 
   VALUES ('Chinelo', 20)
   
   INSERT 
     INTO produto (descricao, preco) 
   VALUES ('Sapato', 40)

   INSERT 
     INTO produto (descricao, preco) 
   VALUES ('Bolsa', 50)

    INSERT 
     INTO produto (descricao, preco) 
   VALUES ('Terno', 300)
   
   INSERT 
     INTO produto (descricao, preco) 
   VALUES ('Bermuda', 20)


-- Venda------------------
   
   INSERT 
     INTO venda (idCliente, dataVenda)
   VALUES (2, '05/14/2000 00:00:00')

   INSERT 
     INTO venda (idCliente, dataVenda)
   VALUES (7, '06/15/2000 00:00:00')

   INSERT 
     INTO venda (idCliente, dataVenda)
   VALUES (4, '07/16/2000 00:00:00')

    INSERT 
     INTO venda (idCliente, dataVenda)
   VALUES (5, '08/17/2000 00:00:00')

   INSERT 
     INTO venda (idCliente, dataVenda)
   VALUES (6, '09/18/2000 00:00:00')

-- Item Venda---------------
    
   INSERT 
     INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
   VALUES ('2', '2', '1', 20)

   INSERT 
     INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
   VALUES ('3', '3', '1', 40)

   INSERT 
     INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
   VALUES ('4', '4', '1', 50)

   INSERT 
     INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
   VALUES ('5', '5', '1', 300)

   INSERT 
     INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
   VALUES ('6', '6', '1', 20)

-- 6) Desenvolva um script que altere o Nome de um Cliente para “Luis Fernando de Oliveira” (Pode ser qualquer registro - Condicione pelo ID)

   UPDATE cliente
      SET nome = 'Luis Fernando de Oliveira'
	  WHERE idCliente = '4';

	  
-- 7) Desenvolva um script que altere a Data de Nascimento de um Cliente para 09/12/2000 (Pode ser qualquer registro - Condicione pelo ID)

    UPDATE cliente
	   SET dataNascimento = '12/09/2000 00:00:00'
	   WHERE idCliente = '4'

-- 8) Desenvolva um script que altere o Nome de um Produto para “Farinha de  Trigo” (Pode ser qualquer registro - Condicione pelo Nome Antigo)

   UPDATE produto
	   SET descricao = 'Farinha de Trigo'
	   WHERE descricao = 'Relogio'

-- 9)Desenvolva um script que delete um registro da tabela Venda (Pode ser qualquer registro - Condicione pelo ID)

     DELETE 
	  FROM itemVenda
	 WHERE  idVenda = 1

    DELETE 
	  FROM venda
	 WHERE  idVenda = 1
	 
	 select * from venda

-- 10)Desenvolva um script que delete um registro da tabela Produto (Pode ser qualquer registro - Condicione pelo ID)
   
     DELETE 
	  FROM itemVenda
	 WHERE  idProduto = 2

    DELETE 
	  FROM produto
	 WHERE  idProduto = 2

-- 11)Desenvolva um script que delete um registro da tabela Itens Venda (Pode ser qualquer registro - Condicione pelo ID_Venda e ID_Produto)
   
    DELETE 
	  FROM itemVenda
	 WHERE  idProduto = 3 AND idVenda = 3

-- 12)Desenvolva um script que selecione todos os dados da tabela Venda e da tabela Cliente (Utilize Inner Join)

   SELECT *
     FROM venda
	 JOIN cliente ON venda.idCliente = cliente.idCliente
	 JOIN itemVenda ON venda.idVenda = itemVenda.idVenda
	 JOIN produto ON itemVenda.idProduto = produto.idProduto

-- 13)Desenvolva um script que selecione o Nome do Cliente, Produto, Quantidade e Valor Total do Item de todas as Vendas de um determinado cliente (Utilize Inner Join e condicione pelo ID do Cliente)
   
   SELECT cliente.nome, produto.descricao, itemVenda.quantidade, itemVenda.valorTotal 
     FROM venda
	 JOIN cliente ON venda.idCliente = cliente.idCliente
	 JOIN itemVenda ON venda.idVenda = itemVenda.idVenda
	 JOIN produto ON itemVenda.idProduto = produto.idProduto

-- 14)Desenvolva um script que selecione o Nome do Cliente, Produto, Quantidade e Valor Total do Item de todas as Vendas realizadas no ano de 2016 (Utilize Inner Join)
   
   SELECT cliente.nome, produto.descricao, itemVenda.quantidade, itemVenda.valorTotal 
     FROM venda
	 JOIN cliente ON venda.idCliente = cliente.idCliente
	 JOIN itemVenda ON venda.idVenda = itemVenda.idVenda
	 JOIN produto ON itemVenda.idProduto = produto.idProduto
	 AND YEAR (venda.dataVenda) = 1999

-- 15)Desenvolva um script que exiba o Mês e a Quantidade de Vendas realizadas no mês correspondente (Utilize o Group By)
	 
       SELECT MONTH(venda.dataVenda) AS [Mês], SUM(itemVenda.quantidade) AS quntidadeDeVendas
       FROM venda
       JOIN itemVenda ON venda.idVenda = itemVenda.idVenda
       GROUP BY MONTH(venda.dataVenda)



    
   
   