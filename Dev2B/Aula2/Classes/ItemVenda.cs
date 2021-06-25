namespace Aula2
{
    public class ItemVenda
    {
        public int Numero { get; }

        public string Descricao { get; }

        private int QtdCompra {
            get { return QtdCompra; } 
            set {
                if (value < 0)
                    QtdCompra = 0;
                else
                    QtdCompra = value;
            }
        }

        private decimal PrecoUnitario {
            get { return PrecoUnitario; }
            set {
                if (value < 0)
                    PrecoUnitario = 0;
                else
                    PrecoUnitario = value;
            }
        }

        public ItemVenda(int numero, string descricao, int qtdCompra, decimal precoUnitario)
        {
            Numero = numero;
            Descricao = descricao;
            QtdCompra = qtdCompra;
            PrecoUnitario = precoUnitario;
        }

        public decimal CalcularValorTotal()
        {
            return PrecoUnitario * QtdCompra;
        }
    }
}
