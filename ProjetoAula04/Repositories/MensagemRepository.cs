using Dapper;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Repositories
{
    public class MensagemRepository : IMensagemFactory
    {
        //atributo
        private readonly string _connectionString;

        //construtor -> ctor + 2x[tab]
        public MensagemRepository()
        {
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                  Initial Catalog=BDProjetoAula04;  
                                  Integrated Security=True; 
                                  Connect Timeout=30;
                                  Encrypt=False;    
                                  TrustServerCertificate=False; 
                                  ApplicationIntent=ReadWrite;
                                  MultiSubnetFailover=False";
        }

        public void Create(Mensagem mensagem)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute("SP_INSERIR_MENSAGEM",
                new
                {
                    @EMAIL = mensagem.Email,
                    @ASSUNTO = mensagem.Assunto,
                    @TEXTO = mensagem.Texto
                },
               commandType: CommandType.StoredProcedure);
            }
        }
    }
}
