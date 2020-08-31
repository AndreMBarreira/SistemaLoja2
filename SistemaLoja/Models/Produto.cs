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
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        [Display(Name = "Última Compra")]
        public DateTime UltimaCompra { get; set; }
        public float Quantidade { get; set; }


        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }

    }
}