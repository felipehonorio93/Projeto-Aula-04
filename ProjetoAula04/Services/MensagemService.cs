using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Services
{
    public class MensagemService : IMensagemFactory
    {
        //atributos
        private readonly string _conta;
        private readonly string _senha;
        private readonly string _smtp;
        private readonly int _porta;
        //construtor -> [ctor] + 2x[tab]
        public MensagemService()
        {
            _conta = "cotinaoresponda@outlook.com";
            _senha = "@Admin123456";
            _smtp = "smtp-mail.outlook.com";
            _porta = 587;
        }
        public void Create(Mensagem mensagem)
        {
            #region Criando o email
            var mailMessage = new MailMessage(_conta, mensagem.Email);
            mailMessage.Subject = mensagem.Assunto;
            mailMessage.Body = mensagem.Texto;

            #endregion
            #region Enviando o email
            var smtpClient = new SmtpClient(_smtp, _porta);
            smtpClient.Credentials = new NetworkCredential(_conta, _senha);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
            #endregion
        }
    }
}