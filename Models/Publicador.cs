using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace relatorio.Models
{
    public class Publicador
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80, ErrorMessage = "Este campo deve conter entre 3 e 80 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int GrupoId { get; set; }

        public Grupo Grupo { get; set; }

        public string Sexo { get; set; }

        public bool PublicadorBatizado { get; set; }

        public bool Anciao { get; set; }
        
        public bool ServoMinisterial { get; set; }
        
        public bool PioneiroRegular { get; set; }
        
        public bool PioneiroAuxiliar { get; set; }

        public bool Ativo { get; set; }

    }
}
