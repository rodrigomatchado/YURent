using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        public DbSet<anuncio> Anuncio { get; set; }
        public DbSet<faturacao> Faturacao{ get; set; }
        public DbSet<guardado> Guardado { get; set; }
        public DbSet<mensagem> Mensagem { get; set; }
        public DbSet<reservas> Reservas { get; set; }
        public DbSet<transacoes> Transacoes { get; set; }
        public DbSet<utilizador> Utilizador { get; set; }
        public DbSet<verificacao> Verificacao { get; set; }



    }
}
