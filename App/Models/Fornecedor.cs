using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using App.Models.Enums;

namespace App.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        [Display(Name="Tipo de fornecedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}