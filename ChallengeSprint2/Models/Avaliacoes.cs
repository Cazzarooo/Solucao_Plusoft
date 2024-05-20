using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeSprint2.Models
{
    [Table("tb_avaliacoes")]

    public class Avaliacoes
    {
        [Key]
        public int IdAvaliacoes { get; set; }
        public string Comentario { get; set; }
        public int NotaAvaliacao { get; set; }
        public DateTimeOffset DataAvaliacao { get; set; }
        public string StatusAvaliacao { get; set; }
    }
}
        
   