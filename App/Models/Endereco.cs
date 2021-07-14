using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(minimum: 1,maximum:4, ErrorMessage = "O campo {0} deve ter o valor entre {1} e {2}")]
        public int Numero  { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(15, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 2)]
        public string Complemento { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(9, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 9)]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(70, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 4)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}