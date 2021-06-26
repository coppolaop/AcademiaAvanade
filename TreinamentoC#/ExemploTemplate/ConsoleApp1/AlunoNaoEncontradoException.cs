using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AlunoNaoEncontradoException : Exception
    {
        public int Matricula { get; set; }

        public AlunoNaoEncontradoException() : base("Aluno Não Encontrado!")
        { }

        public AlunoNaoEncontradoException(int matricula) : base($"Aluno Matricula {matricula} não encontrado!")
        { }
    }
}
