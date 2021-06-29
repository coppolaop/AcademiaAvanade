using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ListaCustomizada<TipoEntidade> where TipoEntidade : IPessoa
    {
        private List<TipoEntidade> _lista;

        public ListaCustomizada()
        {
            _lista = new List<TipoEntidade>();        
        }

        public void Add(TipoEntidade entidade)
        {
            _lista.Add(entidade);
        }

        public void Remover(TipoEntidade entidade)
        {
            _lista.Remove(entidade);
        }

        public TValor GetValor<TValor>(string texto)
        {
            return default;
        }
    }
}
