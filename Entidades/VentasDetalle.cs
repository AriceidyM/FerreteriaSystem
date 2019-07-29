using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class VentasDetalle
    {
        public int ID { get; set; }
        public int  VentasID { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }

        public int precio { get; set; }
        public int cantidad { get; set; }

        public int importe { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Productos Productos { get; set; }

        public VentasDetalle()
        {
            ID = 0;
            VentasID = 0;
        }

        public VentasDetalle(int iD, int ventasID, int clienteId, int productoId, int precio, int cantidad, int importe)
        {
            this.ID = iD;
            this.VentasID = ventasID;
            this.ClienteId = clienteId;
            this.ProductoId = productoId;
            this.precio = precio;
            this.cantidad = cantidad;
            this.importe = importe;
        }
    }

    
}
