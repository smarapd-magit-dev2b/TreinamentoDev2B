namespace Aula2
{
    public class ItemVenda
    {
        private int Numero { get; set; }
        private string Descricao { get; set; }
        private int QtdCompra { get; set; }
        private decimal PrecoUnitario { get; set; }

        public ItemVenda(int numero, string descricao, int qtdCompra, decimal precoUnitario)
        {
            Numero = numero;
            Descricao = descricao;
            if (qtdCompra < 0)
                QtdCompra = 0;
            else
                QtdCompra = qtdCompra;
            if (precoUnitario < 0)
                PrecoUnitario = 0;
            else
                PrecoUnitario = precoUnitario;
        }
        public decimal CalcularValorTotal()
        {
            return PrecoUnitario * QtdCompra;
        }
    }
}
