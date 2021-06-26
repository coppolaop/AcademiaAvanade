using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DadosFisico
    {
        private double _peso;

        public double Altura { get; private set; }

        public double PesoEmKg
        {
            get 
            {
                return _peso;
            }
            set
            {
                _peso = value;
            }
        }

        public double PesoEmLibras
        {
            get
            {
                return _peso * 2.54;
            }
        }

        public DadosFisico(int altura, int peso)
        {
            Altura = altura;
            _peso = peso;
        }

    }
}
