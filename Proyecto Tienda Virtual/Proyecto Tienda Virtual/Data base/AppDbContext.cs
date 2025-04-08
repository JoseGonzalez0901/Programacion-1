using Microsoft.EntityFrameworkCore;
using Proyecto_Tienda_Virtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda_Virtual.Data_base
{
    public class AppDbContext : DbContext
    {
        public DbSet<Data_image> Tienda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=tcp:241215.database.windows.net,1433;Database=Central telefonica;Authentication=Active Directory Default;"
            optionsBuilder.UseSqlServer("Server=tcp:tienda-virtual.database.windows.net,1433;Initial Catalog=Tienda Virtual;Persist Security Info=False;User ID=Administrador;Password=SantoDomingo0901!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
);             
        }
    }
}
