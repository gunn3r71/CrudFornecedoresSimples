using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres",MinimumLength = 4)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000,ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}