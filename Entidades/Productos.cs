using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public string Existencia { get; set; }
        public string Precio { get; set; }
        public DateTime Fecha { get; set; }


        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = string.Empty;
            Precio = string.Empty;
            Fecha = DateTime.Now;

        }
    }
}
