using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaLoja.Models
{
    public class Customizar
    {
        [Key]
        public int CustomizarId { get; set; }
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 30 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 30 caracteres")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 18 caracteres")]
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Documento { get; set; }


        [Display(Name = "Tipo de documento")]
        public int TipoDocumentoId { get; set; }


        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}