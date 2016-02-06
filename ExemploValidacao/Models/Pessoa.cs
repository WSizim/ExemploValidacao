using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {

        [Required(ErrorMessage = "nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50,MinimumLength = 5,ErrorMessage = "A observação deve ter entre 5 e 50 caracteres" )]
        [Required(ErrorMessage ="Preencha a Observação")]
        public string Observacao { get; set; }

        [Range(18,50, ErrorMessage = "A Idade da pessoa deve ser entre 18 e 50 anos")]
        [Required(ErrorMessage = "Preencha a Idade")]
        public int Idade { get; set; }

        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        [Required(ErrorMessage = "Email não informado")]
        public string Email { get; set; }

        [StringLength(15, MinimumLength = 5, ErrorMessage = "Login deve possuir letras e deve ter de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O Login deve ser preenchido")]
        public string Login { get; set; }

        [StringLength(16, MinimumLength = 5, ErrorMessage = "A senha deve ter entre 5 e 16 caracteres")]
        [RegularExpression(@"[a-zA-Z0-9]*", ErrorMessage = "Na senha somente são permitidos caracteres alfanuméricos")]
        [Required(ErrorMessage= "A senha deve ser informada")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}