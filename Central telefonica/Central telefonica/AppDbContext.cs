using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_telefonica
{
    public class AppDbContext : DbContext
    {
        public DbSet<Llamada> Centralita { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:241215.database.windows.net,1433;Database=Central telefonica;Authentication=Active Directory Default;"
);
        }
    }
}
