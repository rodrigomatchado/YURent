using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace YURent.Data
{ 
    public class AppDbContext : DbContext
    {
        public DbSet<anuncio> anuncio { get; set; }

        public DbSet<faturacao> faturacao { get; set; }

        public DbSet<guardado> guardado { get; set; }

        public DbSet<mensagem> mensagem { get; set; }

        public DbSet<reservas> reserva { get; set; }

        public DbSet<transacoes> transacoes { get; set; }

        public DbSet<utilizador> utilizador { get; set; }

        public DbSet<verificacao> verificacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=DESKTOP-871D8P9/MSSQLSERVER01");
        }

    }
}

