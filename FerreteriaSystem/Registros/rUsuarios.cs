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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(UsuarioIDnumericUpDown.Value);
            usuarios.Nombres = NombrestextBox.Text;
            usuarios.Email = EmailstextBox.Text;
            usuarios.NivelUsuario = NivelUsuariotextBox.Text;
            usuarios.Usuario = UsuariotextBox.Text;
            usuarios.Clave = ClavetextBox.Text;
            usuarios.FechaIngreso = DateTime.Now;

            return usuarios;
        }
        private void LlenaCampo(Usuarios usuarios)
        {
            UsuarioIDnumericUpDown.Value = usuarios.UsuarioId;
            NombrestextBox.Text = usuarios.Nombres;
            EmailstextBox.Text = usuarios.Email;
            NivelUsuariotextBox.Text = usuarios.Usuario;
            UsuariotextBox.Text = usuarios.Usuario;
            ClavetextBox.Text = usuarios.Clave;
            FechaIngresodateTimePicker.Value = usuarios.FechaIngreso;
        }

            public bool Validar()
            {

            bool paso = true;
            errorProvider.Clear();

            if (NombrestextBox.Text == String.Empty)
            {
                errorProvider.SetError(NombrestextBox, "El campo Nombre no puede estar vacio");
                NombrestextBox.Focus();
                paso = false;
            }

            if (EmailstextBox.Text == String.Empty)
            {
                errorProvider.SetError(EmailstextBox, "El campo Email no puede estar vacio");
                EmailstextBox.Focus();
                paso = false;
            } 
            
            if (NivelUsuariotextBox.Text == string.Empty)
            {
                errorProvider.SetError(NivelUsuariotextBox, "Favor Llenar, el campo no puede estar vacio");
                paso = false;
            }
            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider.SetError(UsuariotextBox, "Favor Llenar, el campo no puede estar vacio");
                paso = false;
            }
            if (ClavetextBox.Text == string.Empty)
            {
                errorProvider.SetError(ClavetextBox, "Favor Llenar, el campo no puede estar vacio");
                paso = false;
            }

            if (ConfirmaciontextBox.Text != ClavetextBox.Text)
            {
                errorProvider.SetError(ConfirmaciontextBox, "La contraseña no coincide");
                paso = false;
            }
            return paso;
        }
        private void Limpiar()
        {
            UsuarioIDnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            EmailstextBox.Text = string.Empty;
            NivelUsuariotextBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            FechaIngresodateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Usuarios> dbe = new Repositorio<Usuarios>();
            Usuarios usuario = dbe.Buscar((int)((int)UsuarioIDnumericUpDown.Value));
            return (usuario != null);

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> dbe = new Repositorio<Usuarios>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            errorProvider.Clear();
            int id;
            int.TryParse(UsuarioIDnumericUpDown.Text, out id);

            Limpiar();

            if (dbe.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(UsuarioIDnumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuarios = new Usuarios();
            Repositorio<Usuarios> dbe = new Repositorio<Usuarios>();
            int.TryParse(UsuarioIDnumericUpDown.Text, out id);
            Limpiar();
            usuarios = dbe.Buscar(id);

            if (usuarios != null)
            {
                LlenaCampo(usuarios);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {


            bool paso = false;
            Repositorio<Usuarios> dbe = new Repositorio<Usuarios>();
            Usuarios usuarios = new Usuarios();

            if (!Validar())
                return;
       
            usuarios = LlenaClase();


            if (UsuarioIDnumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(usuarios);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(usuarios);
            }
            if (!ExisteEnLaBaseDeDatos())
            {
                if (paso)
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (paso)
                    MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void ClavetextBox_TextChanged(object sender, EventArgs e)
        {
            //txtEncrypt.Text = Eramake.eCryptography.Encrypt(txtValue.Text);
        }
    }
}
