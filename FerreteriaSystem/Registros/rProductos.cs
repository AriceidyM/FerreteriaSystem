﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLL.BLL;

namespace FerreteriaSystem.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private Productos LlenaClase()
        {
            Productos productos = new Productos();
            productos.ProductoId = Convert.ToInt32(ProductoIdnumericUpDown.Value);
            productos.Descripcion = DescripciontextBox.Text;
            productos.Existencia = ExistenciatextBox.Text;
            productos.Precio = PreciotextBox.Text;
            productos.Fecha = DateTime.Now;

            return productos;
        }
        private void LlenaCampo(Productos productos)
        {
            ProductoIdnumericUpDown.Value = productos.ProductoId;
            DescripciontextBox.Text = productos.Descripcion;
            ExistenciatextBox.Text = productos.Existencia;
            PreciotextBox.Text = productos.Precio;
            FechadateTimePicker.Value = productos.Fecha;
        }

        public bool Validar()
        {
            bool paso = true;
            paso = false;
            errorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DescripciontextBox, "Favor LLenar");
                paso = false;
            }
            if (ExistenciatextBox.Text == string.Empty)
            {
                errorProvider.SetError(ExistenciatextBox, "Favor LLenar");
                paso = false;
            }
            if (PreciotextBox.Text == string.Empty)
            {
                errorProvider.SetError(PreciotextBox, "Favor Llenar");
                paso = false;
            }
            return paso;
        }
        private void Limpiar()
        {
            ProductoIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistenciatextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
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