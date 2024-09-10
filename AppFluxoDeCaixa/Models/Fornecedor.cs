using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Fornecedor
    {
        public Guid FornecedorId { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Limite do campo é de 100 Caracteres!")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter, no mínimo, 3 Caracters")]
        public string Nome { get; set; }



        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "O Campo CNPJ é Obrigatório!")]
        [MaxLength(14, ErrorMessage = "O Máximo de caracteres são 14!")]
        public string CNPJ { get; set; }


        
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail é Obrigatório!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O Telefone é obrigatório!")]
        [MinLength(10, ErrorMessage = "O número deve ter no mínimo 10 dígitos!")]
        [MaxLength(11, ErrorMessage = "O número deve ter no máximo 11 dígitos!")]
        public string Telefone { get; set; }


        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O Campo Data de Cadastro é Obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

    }
}
