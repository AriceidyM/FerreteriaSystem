using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentasBLL
    {
        public static bool Guardar(Ventas venta)
        {
            bool paso = false;
            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                if (contexto.ventas.Add(venta) != null)

                    foreach (var item in venta.Detalle)
                    {
                        contexto.productos.Find(item.ProductoId).Existencia -= item.Cantidad;
                    }

                contexto.clientes.Find(venta.ClienteId).Deuda += venta.Total;

                contexto.SaveChanges();
                paso = true;

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Ventas venta)
        {
            bool paso = false;
            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                contexto.Entry(venta).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                Ventas venta = contexto.ventas.Find(id);

                foreach (var item in venta.Detalle)
                {
                    var EliminInventario = contexto.productos.Find(item.ProductoId);
                    EliminInventario.Existencia += item.Cantidad;
                }

                contexto.clientes.Find(venta.ClienteId).Deuda -= venta.Total;

                contexto.ventas.Remove(venta);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static Ventas Buscar(int id)
        {
            FerreteriaContexto contexto = new FerreteriaContexto();
            Ventas venta = new Ventas();
            try
            {
                venta = contexto.ventas.Find(id);

                if (venta != null)
                {
                    venta.Detalle.Count();

                    foreach (var item in venta.Detalle)
                    {
                        string s = item.Producto.Descripcion;
                        string ss = item.Venta.VentaId.ToString();
                    }
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return venta;
        }


        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> expression)
        {
            List<Ventas> lista = new List<Ventas>();
            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                lista = contexto.ventas.Where(expression).ToList();

                foreach (var item in lista)
                {
                    item.Detalle.Count();
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public static double Importe(int cantidad, int precio)
        {
            double CalImporte = 0;
            CalImporte = cantidad * precio;

            return CalImporte;
        }
    }
}
