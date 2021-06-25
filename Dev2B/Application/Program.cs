using Aula1;
using Aula2;
using Aula3;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            EstruturaDeComando estruturaDeComando = new EstruturaDeComando();
            ClasseObjetos classeObjetos = new ClasseObjetos();
            Interfaces interfaces = new Interfaces();
            Heranca heranca = new Heranca();

            estruturaDeComando.Execute();          
            classeObjetos.Execute();
            heranca.Execute();
            interfaces.Execute();
        }
    }
}
