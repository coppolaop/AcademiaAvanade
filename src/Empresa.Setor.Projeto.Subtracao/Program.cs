using System;

namespace Empresa.Setor.Projeto.Subtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### SUBTRACAO ###");


            Console.Write("Informe o primeiro numero: ");

            string numero1 = Console.ReadLine();

            Console.Write("Informe o segundo numero: ");

            string numero2 = Console.ReadLine();

            Console.Write("");

            Console.WriteLine("A subtração é: " + (Convert.ToInt32(numero1) - Convert.ToInt32(numero2)));

            Console.ReadKey();
        }
    }
}
