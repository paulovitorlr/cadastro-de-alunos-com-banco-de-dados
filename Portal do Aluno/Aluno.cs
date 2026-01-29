using System;
using System.Collections.Generic;
using System.Text;

namespace Portal_do_Aluno
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }

        public Aluno()
        {
        }
        public Aluno(string nome, string idade, string curso)
        {


            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            if (string.IsNullOrEmpty(idade)) {
                throw new ArgumentException("A idade não pode ser vazia.");
            }
            if (string.IsNullOrEmpty(curso))
            {
                throw new ArgumentException("O curso não pode ser vazio.");
            }

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }

            
}
}

    
