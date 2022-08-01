using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Entities
{
    /// <summary>
    /// Classe de entidade
    /// </summary>
    public class Mensagem
    {
        #region Propriedades

        public Guid IdMensagem { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public DateTime DataHoraEnvio { get; set; }

        #endregion
    }
}
