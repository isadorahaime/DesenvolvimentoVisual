using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace Aula5.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required(ErrorMessage = "Email é obrigatorio!")]
        public string email { get; set; }
        [Required(ErrorMessage = "Senha é obrigatoria!")]
        public string senha { get; set; }
    }
}
