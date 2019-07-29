using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace FerreteriaSystem.Registros
{
    public partial class rEntradaInventario : Form
    {
        public rEntradaInventario()
        {
            InitializeComponent();
        }
        private EntradaInventario LlenaClase()
        {
            EntradaInventario inventario = new EntradaInventario();
            inventario.EntradaInventarioId = Convert.ToInt32(EntradaInventarioIdnumericUpDown.Value);
            inventario.Producto = ProductotextBox.Text;
            inventario.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            inventario.Fecha = DateTime.Now;

            return inventario;
        }
        private void LlenaCampo(EntradaInventario inventario)
        {
            EntradaInventarioIdnumericUpDown.Value = inventario.EntradaInventarioId;
            ProductotextBox.Text = inventario.Producto;
            CantidadnumericUpDown.Value = inventario.Cantidad;
            FechadateTimePicker.Value = inventario.Fecha;
        }

        public bool Validar()
        {
            bool paso = true;
            paso = false;
            errorProvider.Clear();

            if (ProductotextBox.Text == string.Empty)
            {
                errorProvider.SetError(ProductotextBox, "Favor LLenar");
                paso = false;
            }
            if (CantidadnumericUpDown.Value > 0)
            {
                errorProvider.SetError(CantidadnumericUpDown, "La cantidad no puede ser cero");
                paso = false;
            }
            return paso;
        }
        private void Limpiar()
        {
            EntradaInventarioIdnumericUpDown.Value = 0;
            ProductotextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<EntradaInventario> dbe = new Repositorio<EntradaInventario>();
            EntradaInventario inventario = dbe.Buscar((int)((int)EntradaInventarioIdnumericUpDown.Value));
            return (inventario != null);
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            bool paso = false;
            Repositorio<EntradaInventario> dbe = new Repositorio<EntradaInventario>();
            EntradaInventario inventario = new EntradaInventario();

            inventario = LlenaClase();


            if (EntradaInventarioIdnumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(inventario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(inventario);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<EntradaInventario> dbe = new Repositorio<EntradaInventario>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar un producto que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            errorProvider.Clear();
            int id;
            int.TryParse(EntradaInventarioIdnumericUpDown.Text, out id);

            Limpiar();

            if (dbe.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(EntradaInventarioIdnumericUpDown, "No se puede eliminar un producto que no existe");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            EntradaInventario inventario = new EntradaInventario();
            Repositorio<EntradaInventario> dbe = new Repositorio<EntradaInventario>();
            int.TryParse(EntradaInventarioIdnumericUpDown.Text, out id);
            Limpiar();
            inventario = dbe.Buscar(id);

            if (inventario != null)
            {
                LlenaCampo(inventario);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }

        private void REntradaInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
