using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeSprint2.Models
{
    [Table("tb_cliente")]

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}
