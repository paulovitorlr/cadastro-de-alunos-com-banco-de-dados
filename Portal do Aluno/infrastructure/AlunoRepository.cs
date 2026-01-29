using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace Portal_do_Aluno.infrastructure
{
    public class AlunoRepository
    {
        public bool Add(Aluno aluno)
        {
            // Lógica para adicionar o aluno ao repositório (banco de dados, arquivo, etc.)
            // Retorna true se a adição for bem-sucedida, caso contrário, false.

            //o using faz com que a conexão seja fechada automaticamente após o uso
            using var conn = new Dbconection();


            //comando sql para inserir o aluno na tabela alunos
            string query = @"
                            INSERT INTO public.alunos (nome, idade, curso)
                            VALUES (@Nome, @Idade, @Curso);
                            ";


            //chamando o conn, passando o comando sql e o objeto aluno como parâmetro
            var result = conn.Connection.Execute(sql: query, param: aluno);

            return result == 1;
        }

        public List<Aluno> Get()
        {

            using var conn = new Dbconection();

            string query = @"SELECT * FROM alunos;";

            //executando a query e mapeando o resultado para a classe Aluno
            var alunos = conn.Connection.Query<Aluno>(sql: query);

            //convertendo o resultado para uma lista e retornando
            return alunos.ToList();
        }

        
    }
}
