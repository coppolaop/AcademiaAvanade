using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Professor : IPessoa 
    {
        private static DateTime _dataNascimento;

        public string Nome { get; set; }

        public int Idade 
        {
            get 
            {
                return DateTime.Today.Year - _dataNascimento.Year;
            }
        }


        public Professor()
        {
            _dataNascimento = new DateTime(1980, 1, 1);
        }

        public Professor(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
        }

        public static void DarAula()
        {
            Console.WriteLine($"Ultima data de nascimento cadastrada {_dataNascimento}");
        }

        public void Andar()
        {
            Console.WriteLine($"Professor {Nome} andou!");
        }

        public string Escrever(string texto)
        {
            var textoFinal = $"Professor {Nome} escreveu o seguinte texto {texto}!";
            Console.WriteLine(textoFinal);
            return textoFinal;
        }

    }
}
