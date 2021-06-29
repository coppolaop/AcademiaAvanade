using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ConsoleApp1.Alunos;
using ConsoleColorful = Colorful.Console;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void AcabouComida(string nomeComida, int quantidadeDisponivel);


        static void Main(string[] args)
        {
            Dia1();
            Dia2();
            Dia3();
            Dia4();
        }

        private static void Dia1()
        {
            //tipos de dados básicos
            ushort diasDaSemana = 7;
            string poema = "Batatinha quando nasce, se esparrama pelo chão!";
            char inicialNome = 'A';
            DateTime hoje = DateTime.Now;
            uint numeroRegistros = 3550392000;
            double valorCoquinha = Convert.ToDouble(6.56);
            float valorBala = (float)0.39;
            decimal valorCarro = 45000.54m;
            bool valido = true;

            //Declaração de variáveis
            var qualquerVariavel = 10;
            Console.WriteLine(qualquerVariavel);
            qualquerVariavel = 100;
            Console.WriteLine(qualquerVariavel);
            qualquerVariavel = -100;
            Console.WriteLine(qualquerVariavel);
            var color = new Color();

            //Expressões e operadores.
            var somaSubtracao = (diasDaSemana - 6) + numeroRegistros;
            Console.WriteLine(somaSubtracao);
            var divisao = 10 / 3; //3
            Console.WriteLine(divisao);
            var restoDivisao = 10 % 3;
            Console.WriteLine(restoDivisao);

            //Concatenação de textos
            var nome = "Alexandre";
            var sobrenome = "Daccas";
            var nomeCompleto = nome + " " + sobrenome + " não é legal concatenação.";
            Console.WriteLine(nomeCompleto);
            nomeCompleto = $"{nome} {sobrenome} \r\n é legal interpolação.";
            Console.WriteLine(nomeCompleto);
            nomeCompleto = $@"{nome} {sobrenome}
é legal mais de uma linha.";
            Console.WriteLine(nomeCompleto);

            var construtorTexto = new StringBuilder();
            construtorTexto.Append(nome);
            construtorTexto.Append(" ");
            construtorTexto.Append(sobrenome);
            construtorTexto.Append(" não é legal concatenação.");
            Console.WriteLine(construtorTexto.ToString());



            //Acessando membros de classes
            var aluno = new Aluno()
            {
                Nome = "Alexandre Daccas",
                Matricula = 1234,
                Nascimento = new DateTime(2000, 06, 23)
            };


            aluno.Nome = "Alexandre Daccas";
            aluno.Matricula = 1234;
            aluno.Nascimento = new DateTime(2000, 06, 23);


            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {DateTime.Today.Year - aluno.Nascimento.Year}");
            Console.WriteLine($"Matricula: {aluno.Matricula}");


            ConsoleColorful.WriteLine("Hello World!", Color.Red);
            Console.WriteLine("HelloWorld 2!");
        }

        private static void Dia2()
        {
            // Logica condicional
            var numero = 3;

            if (numero == 2 && numero > 0)
            {
                Console.WriteLine("Sim, o número é igual a 2.");
            }
            else if (numero == 3 && numero > 0)
            {
                Console.WriteLine("Sim, o número é igual a 3.");
            }
            else
            {
                Console.WriteLine("Sim, o número é diferente de 2 e 3.");
            }

            numero = 2;

            switch (numero)
            {
                case 2:
                    Console.WriteLine("Sim, o número é igual a 2.");
                    break;
                case 3:
                    Console.WriteLine("Sim, o número é igual a 3.");
                    break;
                default:
                    Console.WriteLine("Sim, o número é diferente de 2 e 3.");
                    break;
            }
            Console.WriteLine("Final Lógica condicional.");


            //Lógicas de iteração ou looping
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"O valor do contador é {i}.");
            }

            var nomes = new string[10];
            nomes[0] = "Alexandre";
            nomes[1] = "Maria";
            nomes[2] = "João";
            nomes[3] = "Carlos";
            nomes[4] = "Joana";
            nomes[5] = "André";
            nomes[6] = "Silvana";
            nomes[7] = "Joaquim";
            nomes[8] = "Felipe";
            nomes[9] = "Thais";

            for (int j = 0; j < nomes.Length; j++)
            {
                Console.WriteLine($"O nome da posição {j} é {nomes[j]}");
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine($"O nome é {nome}");
            }

            int x = 0;
            while (x < nomes.Length)
            {
                Console.WriteLine($"O nome da posição {x} é {nomes[x]}");
                x++;
            }

            x = 0;
            do
            {

                Console.WriteLine($"O nome da posição {x} é {nomes[x]}");
                x++;
            } while (x < nomes.Length);

            //Usando Métodos
            int primeiroNumero = 1;
            int segundoNumero = 4;

            Console.WriteLine($"O resultado da conta é {SomarNumero(primeiroNumero, segundoNumero)}");

            Console.WriteLine($"O valor do segundo numero é {segundoNumero}");


            var aluno = new Aluno() { Nome = "José" };

            var resultadoMatricula = MatricularAluno(aluno);

            aluno = MatricularAluno("João");

            Console.WriteLine($"Resultado Matricula: {resultadoMatricula}, Número da matricula: {aluno.Matricula}");

            var resultadoOpcional = SomarNumero(2);
            Console.WriteLine($"Resultado é {resultadoOpcional}");

            //Parametros nomeados
            var resultadoNomeado = SomarNumero(terceiroNumero: 2, primeiroNumero: 3);

            //Parametro Out

            if (VerificaSeNumero("1234a", out var numeroVerificado))
            {
                Console.WriteLine($"O número {numeroVerificado} está correto.");
            }
            else
            {
                Console.WriteLine("Não foi possível converter o número.");
            }

        }

        private static void Dia3()
        {
            //Exceções
            try
            {

                var x = 0;
                var y = 1;
                var resultado = y / x;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Não é permitido dividir por 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o erro {ex}");
            }

            //lançamento de exceção customizado
            try
            {
                var aluno = EncontrarAluno(5000); // Está correto
                //aluno = EncontrarAluno(-1); //Erro
                aluno = EncontrarAluno(12); //Erro
            }
            catch (AlunoNaoEncontradoException ex)
            {
                Console.WriteLine($"Erro sistema: {ex.Message}");
            }


            //Usando Enums
            var alunoComNatacao = new Aluno()
            {
                Nome = "Alexandre",
                Nascimento = new DateTime(1990, 1, 5),
                Matricula = 1234,
                DiaNatacao = DiaSemana.SextaFeira
            };


            alunoComNatacao.DiaNatacao = (DiaSemana)4;
            alunoComNatacao.DiaNatacao =
                (DiaSemana)Enum.Parse(typeof(DiaSemana), "SegundaFeira");

            switch (alunoComNatacao.DiaNatacao)
            {
                case DiaSemana.Domingo:
                case DiaSemana.Sabado:
                    Console.WriteLine("Final de Semana!");
                    break;
                default:
                    Console.WriteLine("Dia útil!");
                    break;
            }

            var opcoesDias = new OpcoesDia(new DiaSemana[]
            { DiaSemana.Domingo, DiaSemana.SextaFeira, DiaSemana.Sabado });

            //Usando indexadores
            var opcaoDiaSelecionado = opcoesDias[1];


            //Usando Collections
            var alunos = new ArrayList();
            alunos.Add(new Aluno());
            alunos.Add(1);
            alunos.Add("alunos");

            var alunos2 = new List<Aluno>();
            alunos2.Add(alunoComNatacao);
            alunos2.Add(EncontrarAluno(5000));
            alunos2.Add(alunoComNatacao);
            var resultadoPesquisa = alunos2.Where(a => a.Nome.StartsWith("A"));
            var primeiroAluno = alunos2.FirstOrDefault(a => a.Nome.StartsWith("A"));

            var alunos3 = new Dictionary<string, Aluno>();
            alunos3.Add("Alexandre", alunoComNatacao);
            alunos3.Add("José", alunoComNatacao);
            var teste = alunos3["Alexandre"];
            foreach (var aluno in alunos3)
            {
                Console.WriteLine($"Aluno nome {aluno.Value.Nome} e chave {aluno.Key}");
            }

            AcabouComida evento = TratarComida;
            evento("feijão", 0);
            evento("arroz", 0);

            evento = AumentarComida;
            evento("feijão", 10);
            evento("arroz", 5);

        }

        private static void Dia4()
        {
            // Exemplo construtor de classes.
            var professor = new Professor();
            var professor2 = new Professor(new DateTime(1990, 1, 1));


            // Exemplo tipo referencia.
            var professor3 = new Professor();
            professor3.Nome = "Girafales";
            var professor4 = professor3;
            professor4.Nome = "Salsicha";
            Console.WriteLine($"O nome do professor3 é {professor3.Nome} e o nome do professor4 é {professor4.Nome}");


            // Exemplo construtor de classes usando static em um membro interno.
            var professor5 = new Professor(new DateTime(1995, 5, 10));
            var professor6 = new Professor(new DateTime(1999, 10, 30));

            Console.WriteLine($"A idade estática do professor é {professor2.Idade}");

            Professor.DarAula();

            //Usando Interfaces
            IPessoa pessoa = new Professor() { Nome = "José" };
            pessoa.Escrever("Treinamento legal!");
            pessoa.Andar();

            pessoa = new Aluno() { Nome = "Eloá" };
            pessoa.Escrever("Treinamento legal!");
            pessoa.Andar();


            //Classes Tipadas Genéricas
            var listaCustomizadaAlunos = new ListaCustomizada<Aluno>();
            listaCustomizadaAlunos.Add(new Aluno());

            var listaCustomizadaProfessores = new ListaCustomizada<Professor>();
            listaCustomizadaProfessores.Add(new Professor());


            //IDictionary
            IDictionary<string, Aluno> alunos = new SortedDictionary<string, Aluno>();
            alunos.Add("Zezinho", new Aluno() { Nome = "Zezinho" });
            alunos.Add("Abreu", new Aluno() { Nome = "Abreu" });
            alunos.Add("João2", new Aluno() { Nome = "João2" });
            alunos.Add("João1", new Aluno() { Nome = "João1" });
            alunos.Add("Marlene", new Aluno() { Nome = "Marlene" });

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome do aluno é {aluno.Value.Nome}, e nome da chave é {aluno.Key}");
            }

            var primeiroAluno = new Aluno() { Nome = "João" };
            var quantidadeFaltas = new Dictionary<Aluno, int>();
            quantidadeFaltas.Add(primeiroAluno, 2);
            quantidadeFaltas.Add(new Aluno() { Nome = "Maria" }, 4);
            
        }


        private static void TratarComida(string nomeComida, int quantidadeDisponivel)
        {
            Console.WriteLine($"Acabou a comida {nomeComida}. Quantidade atual {quantidadeDisponivel}");
        }

        private static void AumentarComida(string nomeComida, int quantidadeDisponivel)
        {
            Console.WriteLine($"A comida {nomeComida} voltou. Foram adicionados {quantidadeDisponivel} itens.");
        }





        private static Aluno EncontrarAluno(int matricula)
        {
            try
            {
                if (matricula < 0)
                {
                    throw new AlunoNaoEncontradoException();
                }
                else if (matricula.ToString().Length < 4)
                {
                    throw new AlunoNaoEncontradoException(matricula);
                }
                var aluno = new Aluno() { Matricula = matricula };
                return aluno;
            }
            finally
            {
                Console.WriteLine("Passou Finally!");
            }


        }

        private static int SomarNumero(int primeiroNumero, int segundoNumero = 0, int terceiroNumero = 0)
        {
            var resultado = primeiroNumero + segundoNumero;
            return resultado;
        }

        private static bool VerificaSeNumero(string texto, out int numeroSaida)
        {
            var resultado = int.TryParse(texto, out numeroSaida);
            return resultado;
        }

        private static bool MatricularAluno(Aluno aluno)
        {
            if (aluno.Nascimento > DateTime.Today)
            {
                return false;
            }

            aluno.Matricula = 1234;
            return true;
        }

        private static Aluno MatricularAluno(string nomeAluno)
        {
            var aluno = new Aluno() { Nome = nomeAluno };
            var resultado = MatricularAluno(aluno);
            return aluno;
        }
    }
}
