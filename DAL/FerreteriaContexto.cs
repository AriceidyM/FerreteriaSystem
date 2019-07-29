using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FerreteriaContexto : DbContext
    {
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<EntradaInventario> Entrada { get; set; }
        public DbSet<Ventas> ventas { get; set; }
        public FerreteriaContexto() : base("ConStr")
        { }
    }
}
