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

namespace FerreteriaSystem.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> dbe = new Repositorio<Usuarios>();
            Usuarios usuarios = new Usuarios();
            var listado = new List<Usuarios>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = dbe.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = dbe.GetList(p => p.UsuarioId == id);
                        break;

                    case "Nombre":
                        listado = dbe.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                        break;

                    case "Usuario":
                        listado = dbe.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                        break;
                    default:
                        break;
                }
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdedateTimePicker.Value.Date && c.FechaIngreso.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = dbe.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
