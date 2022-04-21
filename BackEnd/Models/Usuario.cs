using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Usuario")]
    public class Usuario : EntidadeBase
    {
        [Required(ErrorMessage ="Digite seu nome")]
        [StringLength(50)]
        private string Nome { get; set; }
        [Required(ErrorMessage = "Digite seu E-mail")]
        [StringLength(100)]
        private string Email { get; set; }
        [Required(ErrorMessage = "Digite seu |Hobbie")]
        [StringLength(100)]
        private string Hobbie { get; set; }
        [Required(ErrorMessage = "Digite uma breve descrição sobre seu hobbie")]
        [StringLength(500)]
        private string Descricao { get; set; }
        [Required(ErrorMessage = "Cole ou digite a url da foto do seu hobbie")]
        [StringLength(200)]
        private string UrlFoto { get; set; }

        public Usuario()
        {

        }

        public Usuario(int id,string nome, string email, string hobbie, string descricao, string UrlFoto )
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email; 
            this.Hobbie = hobbie;
            this.Descricao = descricao;
            this.UrlFoto = UrlFoto;
        }
    }
}
