using ProjetoAula04.Entities;
using ProjetoAula04.Repositories;
using ProjetoAula04.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Controllers
{
    /// <summary>
    /// Classe para executar o fluxo de entrada de dados
    /// </summary>
    public class MensagemController
    {
        public void EnviarMensagem()
        {
            try
            {
                Console.WriteLine("\n *** ENVIO DE MENSAGENS ***\n");
                var mensagem = new Mensagem();
                Console.Write("Informe o email do destinatário....: ");
                mensagem.Email = Console.ReadLine();
                Console.Write("Informe o assunto da mensagem......: ");
                mensagem.Assunto = Console.ReadLine();
                Console.Write("Informe o texto da mensagem........: ");
                mensagem.Texto = Console.ReadLine();
                #region Enviando a mensagem por email
                var mensagemService = new MensagemService();
                mensagemService.Create(mensagem);
                #endregion
                #region Gravando a mensagem no banco de dados
                var mensagemRepository = new MensagemRepository();
                mensagemRepository.Create(mensagem);
                #endregion
                Console.WriteLine("\nMENSAGEM ENVIADA COM SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine
               ($"\nFalha ao enviar mensagem: {e.Message}");
            }
        }
    }
}
