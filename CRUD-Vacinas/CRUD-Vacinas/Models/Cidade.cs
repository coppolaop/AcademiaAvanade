using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace CRUD_Vacinas.Models
{
    public class Cidade
    {
        [Key]
        public int CodCidade;

        [Required]
        [StringLength(33)]
        public string Nome;

        public int Populacao;

        public Estado NomeEstado;

        public DateTime Aniversario;

    }
}
