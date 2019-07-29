using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CleanProvider()
        {
            errorProvider.Clear();
        }
        private void Ingresarbutton_Click(object sender, EventArgs e)
        {
            bool paso = true;
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            List<Usuarios> user = new List<Usuarios>();
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();

            //Repositorio<Usuarios> db = new Repositorio<Usuarios>(new DAL.FerreteriaContexto());
            var lista = new List<Usuarios>();

            CleanProvider();
            if (UsuariotextBox.Text == string.Empty)
            {
                paso = false;
                errorProvider.SetError(UsuariotextBox, "Incorrecto");

            }
            if (ClavetextBox.Text == string.Empty)
            {
                paso = false;
                errorProvider.SetError(ClavetextBox, "Incorrecto");

            }
            if (paso == false)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }
            if ((UsuariotextBox.Text == "Admin") && (ClavetextBox.Text == "*Admin123"))
            {
                this.Hide();
                MainForm ver = new MainForm();
                ver.Show();
            }
            else
            {
                filtrar = t => t.Usuario.Equals(UsuariotextBox.Text);
                user = db.GetList(filtrar);

                if (user.Exists(x => x.Nombres == UsuariotextBox.Text) && user.Exists(x => x.Clave == ClavetextBox.Text))
                {
                    this.Hide();
                    MainForm ver = new MainForm();
                    ver.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecta!!");
                    errorProvider.SetError(ClavetextBox, "Incorrecto");
                    errorProvider.SetError(UsuariotextBox, "Incorrecto");
                }
            }
        }
    }
    
}
