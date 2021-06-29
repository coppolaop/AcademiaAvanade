using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExemploTemplateBiblioteca
{
    public class Calculadora
    {

        public int Somar(int x, int y)
        {
            return x + y;
        }

        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Dividir(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }

            return x / y;
        }

        
    }
}
