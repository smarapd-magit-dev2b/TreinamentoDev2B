namespace Aula8
{
    public static class ControleUniversal
    {
        //Princípio de Substituição de Liskov
        public static void Ligar(Dispositivo unidade) => unidade.Status = true;
        public static void Desligar(Dispositivo unidade) => unidade.Status = false;
    }
}
