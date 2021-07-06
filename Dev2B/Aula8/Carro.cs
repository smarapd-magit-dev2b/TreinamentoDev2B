namespace Aula8
{
    public class Carro : IStatus
    {
        public bool Status { get; set; }
        public Carro() => Status = false;
    }
}
