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
using static BLL.BLL;

namespace FerreteriaSystem.Registros
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }
        private Clientes LlenaClase()
        {
            Clientes clientes = new Clientes();
            clientes.ClienteId = Convert.ToInt32(ClienteIdnumericUpDown.Value);
            clientes.Nombres = NombrestextBox.Text;
            clientes.Email = EmailtextBox.Text;
            clientes.Direccion = DirecciontextBox.Text;
            clientes.Telefono = TelefonotextBox.Text;
            clientes.Celular = CelulartextBox.Text;
            clientes.Fecha = DateTime.Now;

            return clientes;
        }
        private void LlenaCampo(Clientes clientes)
        {
            ClienteIdnumericUpDown.Value = clientes.ClienteId;
            NombrestextBox.Text = clientes.Nombres;
            EmailtextBox.Text = clientes.Email;
            DirecciontextBox.Text = clientes.Direccion;
            TelefonotextBox.Text = clientes.Telefono;
            CelulartextBox.Text = clientes.Celular;
            FechadateTimePicker.Value = clientes.Fecha;
        }

        public bool Validar()
        {
            bool paso = true;
            paso = false;
            errorProvider.Clear();

            if (NombrestextBox.Text == string.Empty)
            {
                errorProvider.SetError(NombrestextBox, "Favor LLenar");
                paso = false;
            }
            if (EmailtextBox.Text == string.Empty)
            {
                errorProvider.SetError(EmailtextBox, "Favor LLenar");
                paso = false;
            }
            if (DirecciontextBox.Text == string.Empty)
            {
                errorProvider.SetError(DirecciontextBox, "Favor Llenar");
                paso = false;
            }
            if (TelefonotextBox.Text == string.Empty)
            {
                errorProvider.SetError(TelefonotextBox, "Favor Llenar");
                paso = false;
            }
            if (CelulartextBox.Text == string.Empty)
            {
                errorProvider.SetError(CelulartextBox, "Favor Llenar");
                paso = false;
            }
            return paso;
        }
        private void Limpiar()
        {
            ClienteIdnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            TelefonotextBox.Text = string.Empty;
            CelulartextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Clientes> dbe = new Repositorio<Clientes>();
            Clientes clientes = dbe.Buscar((int)((int)ClienteIdnumericUpDown.Value));
            return (clientes != null);

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Repositorio<Clientes> dbe = new Repositorio<Clientes>();
            Clientes clientes = new Clientes();

            clientes = LlenaClase();


            if (ClienteIdnumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(clientes);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(clientes);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Clientes> dbe = new Repositorio<Clientes>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar un cliente que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            errorProvider.Clear();
            int id;
            int.TryParse(ClienteIdnumericUpDown.Text, out id);

            Limpiar();

            if (dbe.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(ClienteIdnumericUpDown, "No se puede eliminar un cliente que no existe");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Clientes clientes = new Clientes();
            Repositorio<Clientes> dbe = new Repositorio<Clientes>();
            int.TryParse(ClienteIdnumericUpDown.Text, out id);
            Limpiar();
            clientes = dbe.Buscar(id);

            if (clientes != null)
            {
                LlenaCampo(clientes);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }
    }
}
