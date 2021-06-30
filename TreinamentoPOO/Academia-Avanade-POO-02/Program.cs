using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Avanade_POO_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafeteira cafeteira = new Cafeteira();
            cafeteira.Ligar();
            Console.ReadKey();
        }
    }
    public class Cafeteira : Eletrodomestico
    {
        public Cafeteira():base("Nespresso", 110)
        {

        }
        ~Cafeteira()
        {
            GC.SuppressFinalize(this);
        }
        public override void Desligar()
        {
            Console.WriteLine("Tirando a tomada");
        }

        public override void Ligar()
        {
            Console.WriteLine("Colocar na Tomada");
            Console.WriteLine("Apertar o Botão");
            PreparaCafe();
        }

        private void PreparaCafe()
        {
            Console.WriteLine("Coloca água no reservatório");
            Console.WriteLine("Tritura o grão");
            Console.WriteLine("Gera o Café");
        }
    }

    public abstract class Eletrodomestico
    {
        private int Voltagem { get; set; }
        private string Nome { get; set; }
        public Eletrodomestico(string nome, int voltagem)
        {
            Voltagem = voltagem;
            Nome = nome;
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Sempre que tivermos um método virtual, o mesmo terá código implementado e não será obrigatório a implementação
        // Caso tenha necessidade de modificação, o comportamento será igual ao abstrato
        //-------------------------------------------------------------------------------------------------------------------
        public virtual void Ligar() 
        {
            Console.WriteLine("Ligar na tomada");
        }
        // --------------------------------------------------------------------------
        //Sempre que tiver um metodo abstrato, serei obrigado a implementar o mesmo
        // --------------------------------------------------------------------------
        public abstract void Desligar();



    }

}
