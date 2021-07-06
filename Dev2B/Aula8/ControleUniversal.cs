namespace Aula8
{
    public static class ControleUniversal
    {
        //Princípio de Substituição de Liskov
        public static void Ligar(Dispositivo dispositivo) => dispositivo.Status = true;
        public static void Desligar(Dispositivo dispositivo) => dispositivo.Status = false;
    }
}
