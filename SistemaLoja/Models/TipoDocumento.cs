using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLoja.Models
{
    public class TipoDocumento
    {
        [Key]
        [Display(Name = "Tipo de documento")]
        public int TipoDocumentoId { get; set; }
        [Required(ErrorMessage ="Informe o {0}")]
        [Display(Name = "Tipo de documento")]
        public string Descricao { get; set; }

        public virtual ICollection<Funcionario>Funcionarios { get; set; }
        public virtual ICollection<Customizar> Customizacao { get; set; }


    }
}