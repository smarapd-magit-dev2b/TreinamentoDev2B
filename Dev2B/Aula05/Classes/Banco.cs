using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Classes
{
    class Banco
    {
        public List<Conta> ListaContas { get; set; }


        public void CadastrarConta()
        {
            Console.WriteLine("Digite o número da conta: ");
            string numero = Console.ReadLine();
            decimal saldo = 0.0m;

            Console.WriteLine("A Conta é Especical ? S ou N: ");
            string contaEspecial = Console.ReadLine();

            bool especial;
            if(contaEspecial == "s")
            {
                especial = true;
            }
            else
            {
                especial = false;
            }
            decimal limite = 500;
            ListaContas.Add(new Conta(numero, saldo, especial, limite));
        }
        public void ExcluirConta()
        {
            Console.WriteLine("Qual o número da conta para excluir: ");
            var numero = Console.ReadLine();
            var idConta = ListaContas.Where(conta => conta.Numero == numero).FirstOrDefault();
            ListaContas.Remove(idConta);
        }
        public void Saque()
        {
            Console.WriteLine("Qual o núimero da conta para saque: ");
            var contaSaque = Console.ReadLine();
            var contaSelected = ListaContas.Where(conta => conta.Numero == contaSaque).FirstOrDefault();

            Console.WriteLine("Informe o valor do saque: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine());

            if(contaSelected.Saldo > 0 && valorSaque <= contaSelected.Saldo && valorSaque <= contaSelected.Limite)
            {
                contaSelected.Saldo = contaSelected.Saldo - valorSaque;
                valorSaque -= valorSaque;
                contaSelected.ListaMovimentacao.Add(new Movimentacao()
                {
                    Descricao = "Saque",
                    Valor = valorSaque.ToString("C"),
                    Credido = false
                });
            }
        }

        public void Deposito()
        {
            Console.WriteLine("Informe o número da conta para depósito: ");
            var contaDeposito = Console.ReadLine();

            var contaSelected = ListaContas.Where(conta => conta.Numero == contaDeposito).FirstOrDefault();
            
            Console.WriteLine("Valor do depósito: ");
            decimal valorDeposito = decimal.Parse(Console.ReadLine()); 

            if(valorDeposito != null && valorDeposito > 0)
            {
                contaSelected.Saldo = contaSelected.Saldo + valorDeposito;
                contaSelected.ListaMovimentacao.Add(new Movimentacao
                {
                    Descricao = "Deposito",
                    Valor = valorDeposito.ToString("C"),
                    Credido = true
                });
            }
        }

        public void Saldo()
        {
            Console.WriteLine("Informe o número da conta: ");
            var idContaSaldo = Console.ReadLine();

            var contaSaldo = ListaContas.Where(conta => conta.Numero == idContaSaldo).FirstOrDefault();

            if(contaSaldo != null)
            {
                Console.WriteLine($"O Saldo da conta: {contaSaldo.Saldo}");
            }else
            {
                Console.WriteLine("Conta não encontrada, verifique o número da conta");
            }
        }

        public void EmitirExtrato()
        {
            Console.WriteLine("Informe o número da conta para exibir o extrato: ");
            var contaExtrato = Console.ReadLine();

            var contaSelected = ListaContas.Where(conta => conta.Numero == contaExtrato).FirstOrDefault();
            Console.WriteLine(contaSelected.ListaMovimentacao.ToString());
        }

        public void Transferencia()
        {
            Console.WriteLine("Informe o número da conta: ");
            string contraTransfereValor = Console.ReadLine();
            var contaSelected = ListaContas.Where(conta => conta.Numero == contraTransfereValor).FirstOrDefault();
            decimal valorTransferencia = decimal.Parse(Console.ReadLine());
            if(contaSelected.Saldo > 0 && valorTransferencia <= contaSelected.Saldo && valorTransferencia <= contaSelected.Limite)
            {
                contaSelected.Saldo -= valorTransferencia;
                valorTransferencia -= valorTransferencia;
                contaSelected.ListaMovimentacao.Add(new Movimentacao()
                {
                    Descricao = "Transferência",
                    Valor = valorTransferencia.ToString("C"),
                    Credido = false
                });
                
                Console.WriteLine("Informe a conta que irá receber o dinnheiro: ");
                string contaRecebeTransferencia = Console.ReadLine();

                var contaDeposito = ListaContas.Where(conta => conta.Numero == contaRecebeTransferencia).FirstOrDefault();
                decimal valorDeposito =- valorTransferencia;
                if(valorDeposito != null && valorDeposito > 0)
                {
                    contaDeposito.Saldo += valorDeposito;
                    contaDeposito.ListaMovimentacao.Add(new Movimentacao
                    {
                        Descricao = "Recebendo Transferência",
                        Valor = valorDeposito.ToString("C"),
                        Credido = true
                    });
                }
            }
        }
    }
}
