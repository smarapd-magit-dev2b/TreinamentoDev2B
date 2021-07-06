namespace Aula8
{
    //Princípio Aberto e Fechado (OCP)
    public abstract class Dispositivo : IStatus
    {
        public bool Status { get; set; }

        public Dispositivo() => Status = false;
    }
}