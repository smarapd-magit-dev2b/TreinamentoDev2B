using Aula3.Classes.ClassesExe01;
using System;

namespace Aula3 {

    public class ExercicioAula03 {
        public void Executar() {
            Exercicio1();
        }
        private void Exercicio1() {

            Console.WriteLine("---------FICHA CLIENTE--------");

            Console.Write("Nome do Cliente: ");
            var nome = Console.ReadLine();

            Console.Write("CPF do Cliente: ");
            var cpf = int.Parse(Console.ReadLine());

            Console.Write("Telefone do Cliente: ");
            var telefone = int.Parse(Console.ReadLine());

            Console.Write("Celular do Cliente: ");
            var celular = int.Parse(Console.ReadLine());

            Console.Write("RG do Cliente: ");
            var rg = int.Parse(Console.ReadLine());

            Console.Write("Endereço do Cliente: ");
            var endereco = Console.ReadLine();

            Console.Write("Quantidade de Filhos: ");
            var qntfilhos = int.Parse(Console.ReadLine());

            Console.Write("Estado Civil: ");
            var estadocivil = Console.ReadLine();

            Cliente cliente = new Cliente(nome, endereco, telefone, rg, cpf, qntfilhos, estadocivil);

            Console.Clear();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("---------FICHA FUNCINARIO--------");

            Console.Write("Nome do Funcionario: ");
            nome = Console.ReadLine();

            Console.Write("CPF do Funcionario: ");
            cpf = int.Parse(Console.ReadLine());

            Console.Write("Telefone do Funcionario: ");
            telefone = int.Parse(Console.ReadLine());

            Console.Write("Celular do Funcionario: ");
            celular = int.Parse(Console.ReadLine());

            Console.Write("RG do Funcionario: ");
            rg = int.Parse(Console.ReadLine());

            Console.Write("Endereço do Funcionario: ");
            endereco = Console.ReadLine();

            Console.Write("Quantidade de Filhos: ");
            qntfilhos = int.Parse(Console.ReadLine());

            Console.Write("Estado Civil: ");
            estadocivil = Console.ReadLine();

            Console.Write("Data de Adimissão: ");
            var dataadm = DateTime.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            var salario = decimal.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, endereco, telefone, rg, cpf, qntfilhos, estadocivil, dataadm, salario);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();

            Console.WriteLine("---------FICHA FORNECEDOR--------");

            Console.Write("Nome do Fornecedor: ");
            nome = Console.ReadLine();

            Console.Write("CPF do Fornecedor: ");
            cpf = int.Parse(Console.ReadLine());

            Console.Write("Endereço do Fornecedor: ");
            endereco = Console.ReadLine();

            Console.Write("Telefone do Fornecedor: ");
            telefone = int.Parse(Console.ReadLine());

            Console.Write("CNPJ do Fornecedor: ");
            var cnpj = int.Parse(Console.ReadLine());

            Console.Write("Segmento do Fornecedor: ");
            var segmento = Console.ReadLine();

            Console.Write("Produto do Fornecedor: ");
            var produto = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nome, endereco, telefone, cnpj, segmento, produto);

            //////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();

            // Mostrando os resultados
            Console.WriteLine("Cliente");
            cliente.MostrarInformacoes();

            Console.WriteLine("\nFuncionario");
            funcionario.MostrarInformacoes();

            Console.WriteLine("\nFornecedor");
            fornecedor.MostrarInformacoes();

        }

    }
}
