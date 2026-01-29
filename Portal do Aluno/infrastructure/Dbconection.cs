using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace Portal_do_Aluno.infrastructure
{
    internal class Dbconection : IDisposable //IDisposable para garantir que a conexão seja fechada corretamente
    {
        public NpgsqlConnection Connection { get; set; }

        //Construtor da classe Dbconection que inicializa a conexão com o banco de dados PostgreSQL
        public Dbconection()
        {
            Connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=portal_do_aluno;User Id=postgres;Password=12631785703;");
            Connection.Open();
        }

        //Implementação do método Dispose para fechar a conexão com o banco de dados
        public void Dispose()
            {
                Connection.Close();
            }


    }
}
