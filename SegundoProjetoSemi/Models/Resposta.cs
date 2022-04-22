using System.ComponentModel.DataAnnotations;
namespace SegundoProjetoSemi.Models
{
    public class Resposta { 

        [Required(ErrorMessage = "Por favor, preencha o Nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por favor, preencha o Email!")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Por favor, preencha a Resposta!")]
        public string Opcao { get; set;}
        [Required(ErrorMessage = "Por favor, preencha o Telefone!")]
        public string Telefone{ get; set;}
        [Required(ErrorMessage = "Por favor, preencha o Sobrenome!")]
        public string Sobrenome{ get; set;}



    }
}
