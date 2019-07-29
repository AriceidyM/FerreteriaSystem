using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaID { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public int SubTotal { get; set; }
        public int ITBIS { get; set; }
        public int Total { get; set; }
        public virtual ICollection<VentasDetalle> Detalle { get; set; }

        public Ventas()
        {
            this.Detalle = new List<VentasDetalle>();
            VentaID = 0;
            Fecha = DateTime.Now;
            ClienteId = 0;
            ProductoId = 0;
           

          

    }

       public void AgregarDetalle(int ID, int VentasID, int ClienteId, int ProductoId, int Precio, int Cantidad,int importe)
        {
            this.Detalle.Add(new VentasDetalle(ID, VentasID, ClienteId, ProductoId,Precio,Cantidad,importe));
        }

    }
}
