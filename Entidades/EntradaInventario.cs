using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntradaInventario
    {
        [Key]
        public int EntradaInventarioId { get; set; }
        public string Producto { get; set; }
        public Decimal Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public EntradaInventario()
        {
            EntradaInventarioId = 0;
            Producto = string.Empty;
            Cantidad = 0;
            Fecha = DateTime.Now;

        }
    }
}
