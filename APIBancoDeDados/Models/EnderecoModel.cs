using System.ComponentModel.DataAnnotations;

namespace APIBancoDeDados.Models
{
    public class EnderecoModel
    {
        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "O logradouro é obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Logradouro deve ter no minimo 20 a 50 caracteres")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O Número é obrigatório")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Número deve ter no minimo 1 a 20 caracteres")]
        public string Numero { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Complemneto deve ter no minimo 50 caracteres")]
        public string? Complemento { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O Cidade é obrigatório")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Cidade deve ter no minimo 5 caracteres")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O Estado é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Estado deve ter no minimo 2 caracteres")]
        public string Estado { get; set; }
    }
}
