﻿using System;
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
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public EntradaInventario()
        {
            EntradaInventarioId = 0;
            ProductoId = 0;
            Cantidad = 0;
            Fecha = DateTime.Now;

        }
    }
}
