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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            ExistenciatextBox.Text = 0.ToString(); 
        }

        private Productos LlenaClase()
        {
            Productos productos = new Productos();
            productos.ProductoId = Convert.ToInt32(ProductoIdnumericUpDown.Value);
            productos.Descripcion = DescripciontextBox.Text;
            productos.Existencia = 0;
            productos.Precio = PrecionumericUpDown.Value;
            productos.Fecha = DateTime.Now;

            return productos;
        }
        private void LlenaCampo(Productos productos)
        {
            ProductoIdnumericUpDown.Value = productos.ProductoId;
            DescripciontextBox.Text = productos.Descripcion;
            ExistenciatextBox.Text = productos.Existencia.ToString();
            PrecionumericUpDown.Value = productos.Precio;
            FechadateTimePicker.Value = productos.Fecha;
        }

        private bool Validar()
        {
            bool paso = true;
            
            errorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox, "Favor LLenar");
                paso = false;
            }
            /*if (PrecionumericUpDown.Value ==0)
            {
                errorProvider.SetError(PrecionumericUpDown, "Favor LLenar");
                paso = false;
            }*/
            return paso;
        }
        private void Limpiar()
        {
            ProductoIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistenciatextBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Productos> dbe = new Repositorio<Productos>();
            Productos productos = dbe.Buscar((int)((int)ProductoIdnumericUpDown.Value));
            return (productos != null);
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
            Repositorio<Productos> dbe = new Repositorio<Productos>();
            Productos productos = new Productos();

            productos = LlenaClase();


            if (ProductoIdnumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(productos);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(productos);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Productos> dbe = new Repositorio<Productos>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            errorProvider.Clear();
            int id;
            int.TryParse(ProductoIdnumericUpDown.Text, out id);

            Limpiar();

            if (dbe.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(ProductoIdnumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Productos productos = new Productos();
            Repositorio<Productos> dbe = new Repositorio<Productos>();
            int.TryParse(ProductoIdnumericUpDown.Text, out id);
            Limpiar();
            productos = dbe.Buscar(id);

            if (productos != null)
            {
                LlenaCampo(productos);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }
    }
}
