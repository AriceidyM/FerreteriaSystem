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
    public partial class cEntradaInventario : Form
    {
        public cEntradaInventario()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<EntradaInventario> dbe = new Repositorio<EntradaInventario>();
            EntradaInventario inventario = new EntradaInventario();
            var listado = new List<EntradaInventario>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = dbe.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = dbe.GetList(p => p.EntradaInventarioId == id);
                        break;

                    case "Producto":
                        listado = dbe.GetList(p => p.Producto.Contains(CriteriotextBox.Text));
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
