using Microsoft.EntityFrameworkCore;

namespace ChallengeSprint2.Models
{
    public class Contexto : DbContext  
    {
        public Contexto(DbContextOptions <Contexto> options): base(options) 
        {

        }   
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Avaliacoes> Avaliacoes { get; set; }
        public DbSet<Produto> Produto { get; set; }


    }
}
