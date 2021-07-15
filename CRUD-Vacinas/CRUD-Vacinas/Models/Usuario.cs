using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Models
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public IList<string> Permissoes { get; set; }
    }
}
