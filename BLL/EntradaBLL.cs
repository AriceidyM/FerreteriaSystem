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
    public class EntradasBLL
    {
        public bool Guardar(EntradaInventario entrada)
        {
            bool paso = false;

            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                if (contexto.Entrada.Add(entrada) != null)
                {
                    contexto.productos.Find(entrada.ProductoId).Existencia += entrada.Cantidad;

                    contexto.SaveChanges();
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


        public bool Modificar(EntradaInventario entrada)
        {
            bool paso = false;

            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                EntradaInventario EntrAnt = Buscar(entrada.EntradaInventarioId);

                if (EntrAnt.ProductoId != entrada.ProductoId)
                {
                    ModificarBien(entrada, EntrAnt);
                }

                int modificado = entrada.Cantidad - EntrAnt.Cantidad;
                Repositorio<Productos> repositorio = new Repositorio<Productos>();
                var Producto = contexto.productos.Find(entrada.ProductoId);
                Producto.Existencia += modificado;
                repositorio.Modificar(Producto);

                contexto.Entry(entrada).State = EntityState.Modified;
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


        public bool Eliminar(int id)
        {
            bool paso = false;

            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                EntradaInventario entrada = contexto.Entrada.Find(id);

                contexto.productos.Find(entrada.ProductoId).Existencia -= entrada.Cantidad;

                contexto.Entrada.Remove(entrada);

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


        public EntradaInventario Buscar(int id)
        {
            FerreteriaContexto contexto = new FerreteriaContexto();
            EntradaInventario entrada = new EntradaInventario();

            try
            {
                entrada = contexto.Entrada.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entrada;
        }


        public List<EntradaInventario> GetList(Expression<Func<EntradaInventario, bool>> expression)
        {
            List<EntradaInventario> entradas = new List<EntradaInventario>();
            FerreteriaContexto contexto = new FerreteriaContexto();
            try
            {
                entradas = contexto.Entrada.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return entradas;
        }

        public static void ModificarBien(EntradaInventario entradas, EntradaInventario EntradasAnteriores)
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            Repositorio<Productos> repositorioC = new Repositorio<Productos>();
            FerreteriaContexto contexto = new FerreteriaContexto();
            var Producto = contexto.productos.Find(entradas.ProductoId);
            var ProductosAnteriores = contexto.productos.Find(EntradasAnteriores.ProductoId);

            Producto.Existencia += entradas.Cantidad;
            ProductosAnteriores.Existencia -= EntradasAnteriores.Cantidad;
            repositorio.Modificar(Producto);
            repositorioC.Modificar(ProductosAnteriores);
        }

    }
}
