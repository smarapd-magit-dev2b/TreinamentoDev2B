USE Loja_Filipe_Ex2

GO
CREATE FUNCTION clientes_mesmo_sexo(@sexo CHAR)
RETURNS TABLE
AS
RETURN(SELECT *
	     FROM cliente c
		WHERE c.sexo = @sexo)
GO

INSERT INTO cliente(nome, data_nascimento, telefone, cpf, rg, sexo)
	 VALUES ('Ana', '11/18/1996 00:00:00', '44444-4444', '222.333.111-11', '99.111.111-1', 'F')

SELECT *
  FROM clientes_mesmo_sexo('F')

DROP FUNCTION clientes_mesmo_sexo