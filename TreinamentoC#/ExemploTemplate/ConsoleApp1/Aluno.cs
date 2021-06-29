using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Alunos
{
    public class Aluno : IPessoa
    {
        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public int Matricula { get; set; }

        public DiaSemana DiaNatacao { get; set; }

        public DadosFisico DadosFisicosAluno { get; set; }

        public void Andar()
        {
            Console.WriteLine($"Aluno {Nome} andou!");
        }

        public string Escrever(string texto)
        {
            var textoFinal = $"Aluno {Nome} escreveu o seguinte texto {texto}!";
            Console.WriteLine(textoFinal);
            return textoFinal;
        }
    }


    public class OpcoesDia
    {
        private DiaSemana[] _opcaoDia;

        public DiaSemana this[int index]
        {
            get { return _opcaoDia[index]; }
            set { _opcaoDia[index] = value; }
        }

        public OpcoesDia(DiaSemana[] opcaoDia)
        {
            _opcaoDia = opcaoDia;
        }
    }
}
