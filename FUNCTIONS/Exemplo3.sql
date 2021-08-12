USE Loja_Filipe_Ex2
GO
CREATE FUNCTION vendas_hoje()
RETURNS @vendasHoje TABLE
		(idVenda INT,
		 nomeCliente VARCHAR(150),
		 dataVenda DATETIME)
AS
BEGIN
    DECLARE @hoje DATETIME;
	SELECT @hoje = GETDATE();

	DECLARE @diaHoje DATETIME
	SELECT @diaHoje = DAY(@hoje)

    INSERT @vendasHoje (idVenda, nomeCliente, dataVenda)
    SELECT v.id_venda,
		   c.nome,
		   v.data_venda
	  FROM venda v
	  JOIN cliente c
		ON c.id_cliente = v.id_cliente
	 WHERE DAY(v.data_venda) = @diaHoje
    RETURN
END
GO

INSERT INTO venda(id_cliente, data_venda)
	 VALUES (2, '2021-07-21')

SELECT *
  FROM vendas_hoje()

DROP FUNCTION vendas_hoje