namespace Aula8
{
    public static class ControleUniversal
    {
        //Princípio de Substituição de Liskov
        public static void Ligar(IStatus unidade) => unidade.Status = true;
        public static void Desligar(IStatus unidade) => unidade.Status = false;
    }
}
