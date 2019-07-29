using BLL;
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

namespace FerreteriaSystem.Consultas
{
    public partial class cVentas : Form
    {
        public cVentas()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            Ventas usuarios = new Ventas();
            var listado = new List<Ventas>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = dbe.GetList(p => true);
                        break;

                    case "ClienteId":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = dbe.GetList(p => p.ClienteId == id);
                        break;
                    default:
                        break;
                }
                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
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
