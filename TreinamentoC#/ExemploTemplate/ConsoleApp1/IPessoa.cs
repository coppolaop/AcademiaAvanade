using ConsoleApp1.Alunos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPessoa
    {
        void Andar();

        string Escrever(string texto);
    }
}
