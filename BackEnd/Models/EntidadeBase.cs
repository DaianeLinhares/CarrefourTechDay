using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public abstract class EntidadeBase
    {
        [Key]
        public int Id { get; protected set; }
    }
}
