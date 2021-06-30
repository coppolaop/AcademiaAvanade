using System;
using System.Collections.Generic;
namespace Projeto_Academia_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Sergio Oliveira";
            funcionario.CorDoCabelo = "Preto";
            funcionario.DataDeNascimento = new DateTime(1973, 03, 02);
            funcionario.Registro = "32153";
            funcionario.DataAdmissao = DateTime.Now;


            FuncionarioComposto funcionarioComposto = new FuncionarioComposto();
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Rapha Anjos";
            pessoa.CorDoCabelo = "Preto";
            pessoa.DataDeNascimento = new DateTime(1982, 12, 11);

            funcionarioComposto.Pessoa = pessoa;
            funcionarioComposto.Registro = "32154";
            funcionarioComposto.DataAdmissao = DateTime.Now;

            Console.WriteLine($"Funcionario: {funcionario.Nome}  - {funcionario.CalcularIdade()}");
            Console.WriteLine($"Funcionario: {funcionarioComposto.Pessoa.Nome}  - {funcionarioComposto.Pessoa.CalcularIdade()}");

            Console.ReadKey();
        }
    }

    //Funcionário Herdado
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    } 

    //Functionario Composto
    public class FuncionarioComposto
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
        public Pessoa Pessoa { get; set; }
    }


    public class Pessoa
    {
        public string CorDoCabelo { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int CalcularIdade()
        {
            DateTime dataHoje = DateTime.Now;
            
            int idade = dataHoje.Year - DataDeNascimento.Year;

            if (dataHoje < DataDeNascimento.AddYears(idade)) idade--;

            return idade; 
        } 
    }
}
