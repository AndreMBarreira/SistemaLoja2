using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaLoja.Models
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }
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
        public string Email { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }
    }
}