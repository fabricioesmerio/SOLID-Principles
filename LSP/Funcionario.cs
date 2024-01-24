
namespace LSP
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public virtual void RealizarTarefa()
        {
            Console.WriteLine($"{Nome} está realizando uma tarefa genérica  :)");
        }
    }
}
