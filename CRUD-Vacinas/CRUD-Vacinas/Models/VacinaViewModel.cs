using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Models
{
    public class VacinaViewModel
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string FABRICANTE { get; set; }
        public int NUMDOSES { get; set; }
        public int INTERVALODOSE { get; set; }
    }
}
