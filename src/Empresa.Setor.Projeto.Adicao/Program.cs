using System;

namespace Empresa.Setor.Projeto.Adicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### ADICAO ###");

            Console.Write("Informe o primeiro numero: ");

            string numero1 = Console.ReadLine();

            Console.Write("Informe o segundo numero: ");

            string numero2 = Console.ReadLine();

            Console.Write("");

            try
            {
                Convert.ToInt32(numero1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Numero 1 nao foi possivel ser convertido para inteiro");
            }

            //testar conversao do numero 2


            //exibir mensagem da operacao de adicao



            Console.ReadKey();
        }
    }
}

