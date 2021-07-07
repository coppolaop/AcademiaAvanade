using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Vacinas.Models
{
    public class Estado
    {
        [Key]
        public int CodEstado;

        [Required]
        [StringLength(25)]
        public string Nome;

        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string Sigla;

        public int Populacao;
        public DateTime Fundacao;

        public List<Cidade> Cidades;
    }
}
