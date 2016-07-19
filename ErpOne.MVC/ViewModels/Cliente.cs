using System;
using System.ComponentModel.DataAnnotations;

namespace ErpOne.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public string ClienteID { get; set; }
        [Required(ErrorMessage = "Campo nome obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo nome obrigatório")]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "Campo nome obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]

        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}