using System;

namespace Entidades
{
    public class Funcionario
    {
        public int Registro { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Cargo { get; set; }
        public Departamento Departamento { get; set; }
        public decimal Salario { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public int Filhos { get; set; }
        public bool TemFeriasVencidas { get; set; }
        public int Ferias { get; set; }

        //Salario No Ano
        public decimal SalarioAnual()
        {
            return Salario * 13.3m;
        }
        //Tempo de Empresa
        public int TempoEmpresaMeses()
        {
            DateTime dataHoje = DateTime.Now;

            return ((dataHoje.Year - DataAdmissao.Year) * 12) + dataHoje.Month - DataAdmissao.Month;
        }
    }
}
