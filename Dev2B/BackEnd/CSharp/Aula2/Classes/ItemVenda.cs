namespace Aula2.Classes
{
    public class ItemVenda
    {
        public int _qtdCompra;
        private decimal _precoUnitario;
        public int Numero { get; }
        public string Descricao { get; }
        public int QtdCompra {
            get { return _qtdCompra; } 
            set {
                if (value < 0)
                    _qtdCompra = 0;
                else
                    _qtdCompra = value;
            }
        }
        public decimal PrecoUnitario {
            get { return _precoUnitario; }
            set {
                if (value < 0)
                    _precoUnitario = 0;
                else
                    _precoUnitario = value;
            }
        }

        public ItemVenda(int numero, string descricao, int qtdCompra, decimal precoUnitario)
        {
            Numero = numero;
            Descricao = descricao;
            _qtdCompra = qtdCompra;
            _precoUnitario = precoUnitario;
        }

        public decimal CalcularValorTotal() => _precoUnitario * _qtdCompra;
    }
}
