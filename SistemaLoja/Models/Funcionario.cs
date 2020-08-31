using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaLoja.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 30 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 30 caracteres")]

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Precisa informar o {0}")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Salario { get; set; }
        
        [Required(ErrorMessage = "Precisa informar a porcentagem da {0}")]
        [Display(Name = "Comissão")]
        [DisplayFormat(DataFormatString = "{0:P1}", ApplyFormatInEditMode = false)]
        public decimal Comissao { get; set; }
        
        [Required(ErrorMessage = "Precisa informar a {0}")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Precisa informar a {0}")]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Cadastro { get; set; }

        [NotMapped]
        public int Idade { get { return DateTime.Now.Year - Nascimento.Year; } }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Tipo de documento")]
        public int TipoDocumentoId { get; set; }


        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}