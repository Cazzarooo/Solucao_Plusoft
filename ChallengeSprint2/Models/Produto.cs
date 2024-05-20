using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChallengeSprint2.Models
{
    [Table("tb_produto")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int PrecoProduto { get; set; }
        public string TipoProduto { get; set; }
        public string DescricaoProduto { get; set; }
    }
}
