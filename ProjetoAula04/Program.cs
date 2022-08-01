using ProjetoAula04.Controllers;

namespace ProjetoAula04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mensagemController = new MensagemController();
            mensagemController.EnviarMensagem();
            Console.ReadKey();
        }
    }
}