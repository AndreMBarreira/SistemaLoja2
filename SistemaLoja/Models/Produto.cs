using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace SistemaLoja.Models
{
    public class Produto
    {
        //Enable-Migration -ContextTypeName SistemaLojaContext
        [Key]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [StringLength(30, ErrorMessage = "Campo com limite de 1 a 30 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Precisa informar o {0}")]
        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Valor { get; set; }

        [Display(Name = "Última Compra")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date)]
        public DateTime UltimaCompra { get; set; }

        [Required(ErrorMessage = "Precisa informar a {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public float Quantidade { get; set; }


        [Display(Name ="Comentário")]
        [DataType(DataType.MultilineText)]
        public string Comentario { get; set; }



        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }

    }
}