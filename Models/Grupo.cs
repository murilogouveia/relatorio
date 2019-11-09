using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace relatorio.Models
{
    public class Grupo
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Este campo é obrigatório")]
        public int NumeroGrupo { get; set; }

        [MaxLength(80, ErrorMessage = "Este campo deve conter entre 3 e 80 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 80 caracteres")]
        public string Responsavel { get; set; }
    }
}
