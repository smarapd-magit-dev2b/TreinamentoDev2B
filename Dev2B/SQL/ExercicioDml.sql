USE Loja_LucasGO

-- EXECUTE PRIMEIRO O EXERCÍCIO DLL

-- Reiniciar tabelas

 ALTER TABLE cliente
ALTER COLUMN nome VARCHAR(125)

ALTER TABLE cliente
        ADD rg INT NOT NULL

   ALTER TABLE cliente
ADD CONSTRAINT UQ_RG_Cliente
        UNIQUE (rg)

    ALTER TABLE venda
 ADD CONSTRAINT FK_ID_CLIENTE_Venda#ID_Cliente
    FOREIGN KEY (idCliente)
     REFERENCES cliente (id)

ALTER TABLE cliente
DROP COLUMN endereco

-- DML INSERT

INSERT INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
     VALUES ('Lucas', '2002-07-06', 5516994010193, '50451742826', '606143130', 'M')

-- SELECT * FROM cliente

INSERT INTO produto (dataInclusao, descricao, preco)
     VALUES ('1999-07-12', 'Glock', 15000)

-- SELECT * FROM produto

INSERT INTO venda (idCliente, data)
	 VALUES (1, '2020-03-12')

-- SELECT * FROM venda

INSERT INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
	 VALUES (1, 1, 1, 15000)

-- SELECT * FROM itemVenda

INSERT INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
     VALUES ('Romeu', '1999-12-16', 5091094021904, '67349527863', '213465372', 'M')

INSERT INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
     VALUES ('Augosto', '1998-07-30', 7123985702138, '57643192547', '67346598', 'M')

INSERT INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
     VALUES ('Bernadete', '1972-01-06', 4782394832, '30234952012', '764953824', 'F')

INSERT INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
     VALUES ('Jeremias', '2003-03-09', 490213409329, '10395840234', '673465824', 'M')

INSERT INTO cliente (nome, dataNascimento, telefone, cpf, rg, sexo)
     VALUES ('Alucard', '1935-12-06', 8472137809423, '83920495283', '457682194', 'F')

-- SELECT * FROM cliente

INSERT INTO produto (dataInclusao, descricao, preco)
     VALUES ('2003-04-12', 'Esponja', 12)

INSERT INTO produto (dataInclusao, descricao, preco)
     VALUES ('2009-05-22', 'Sabonete', 20)

INSERT INTO produto (dataInclusao, descricao, preco)
     VALUES ('2009-02-01', 'Cabo de Vassoura', 43)

INSERT INTO produto (dataInclusao, descricao, preco)
     VALUES ('2015-07-11', 'Roupão', 15000)

INSERT INTO produto (dataInclusao, descricao, preco)
     VALUES ('2000-08-15', 'Chinela', 15000)

-- SELECT * FROM produto
	 
INSERT INTO venda (idCliente, data)
	 VALUES (3, '2019-08-15')

INSERT INTO venda (idCliente, data)
	 VALUES (4, '2021-01-22')

INSERT INTO venda (idCliente, data)
	 VALUES (2, '2016-07-29')

INSERT INTO venda (idCliente, data)
	 VALUES (3, '2013-12-04')

INSERT INTO venda (idCliente, data)
	 VALUES (1, '1930-12-23')

-- SELECT * FROM venda

-- SELECT * FROM venda; SELECT * FROM produto

INSERT INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
	 VALUES (4, 3, 9, 321)

INSERT INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
	 VALUES (2, 2, 15, 4132)

INSERT INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
	 VALUES (1, 5, 12, 4123)

INSERT INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
	 VALUES (6, 3, 32, 2343)

INSERT INTO itemVenda (idVenda, idProduto, quantidade, valorTotal)
	 VALUES (5, 2, 4, 423)

-- SELECT * FROM itemVenda

-- DML UPDATE

-- SELECT * FROM cliente

UPDATE cliente
   SET nome = 'Luis Fernando de Oliveira'
 WHERE id = 6

-- SELECT * FROM cliente

UPDATE cliente
   SET dataNascimento = '2000-12-09'
 WHERE id = 2

-- SELECT * FROM cliente

-- SELECT * FROM produto

UPDATE produto
   SET descricao = 'Farinha de Trigo'
 WHERE descricao = 'Glock'

-- SELECT * FROM produto

-- DML DELETE

-- SELECT * FROM venda

DELETE venda
 WHERE id = 3

-- SELECT * FROM venda

-- SELECT * FROM produto

DELETE itemVenda
 WHERE id = 4

DELETE produto
 WHERE id = 5

-- SELECT * FROM produto

-- SELECT * FROM itemVenda

DELETE itemVenda
 WHERE idVenda = 6
   AND idProduto = 3

-- SELECT * FROM itemVenda

-- DML JOIN

SELECT *
  FROM venda v
  JOIN cliente c
    ON c.id = v.idCliente

SELECT *
  FROM venda v
  JOIN cliente c
    ON c.id = v.idCliente
  JOIN itemVenda iv
	ON iv.idVenda = v.id
  JOIN produto p
    ON p.id = iv.idProduto

-- SELECT * FROM cliente

SELECT c.nome AS nomeCliente,
	   p.id AS idProduto,
	   p.dataInclusao AS dataInclusãoProduto,
	   p.descricao AS descriçãoProduto,
	   p.preco AS preçoProduto,
	   it.quantidade AS quantidadeProduto,
	   it.valorTotal AS valorTotalProduto
  FROM cliente c
  JOIN venda v
    ON v.idCliente = c.id
  JOIN itemVenda it
	ON it.idVenda = v.id
  JOIN produto p
    ON p.id = it.idProduto
 WHERE p.id = 1

SELECT c.nome AS nomeCliente,
	   p.id AS idProduto,
	   p.dataInclusao AS dataInclusãoProduto,
	   p.descricao AS descriçãoProduto,
	   p.preco AS preçoProduto,
	   it.quantidade AS quantidadeProduto,
	   it.valorTotal AS valorTotalProduto
  FROM cliente c
  JOIN venda v
    ON v.idCliente = c.id
  JOIN itemVenda it
	ON it.idVenda = v.id
  JOIN produto p
    ON p.id = it.idProduto
 WHERE (SELECT YEAR(v.data)) = 2016

  SELECT MONTH(data) AS mês,
		 COUNT(id) AS quantidadeVendas
    FROM venda
GROUP BY MONTH(data)