using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YURent.Data
{
    public class YURentContext : DbContext
    {
        public YURentContext(DbContextOptions<YURentContext> options) : base(options)
        {

        }

        public DbSet<utilizadores> Utilizadores { get; set; }
    }
}
