using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLoja.Models
{
    public class OrdemDetalhe
    {
        [Key]
        public int OrdemDetalheId { get; set; }
        public int OrdemId { get; set; }
        public int ProdutoId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 30 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Valor { get; set; }

        [Display(Name = "Quantidade")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Quantidade { get; set; }

        public virtual Ordem Ordem { get; set; }

        public virtual Produto Produto { get; set; }

    }
}