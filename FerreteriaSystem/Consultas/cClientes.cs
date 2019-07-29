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

namespace FerreteriaSystem.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Clientes> dbe = new Repositorio<Clientes>();
            Clientes clientes = new Clientes();
            var listado = new List<Clientes>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = dbe.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = dbe.GetList(p => p.ClienteId == id);
                        break;

                    case "Nombres":
                        listado = dbe.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                        break;

                    case "Email":
                        listado = dbe.GetList(p => p.Email.Contains(CriteriotextBox.Text));
                        break;

                    case "Direccion":
                        listado = dbe.GetList(p => p.Direccion.Contains(CriteriotextBox.Text));
                        break;

                    case "Telefono":
                        listado = dbe.GetList(p => p.Telefono.Contains(CriteriotextBox.Text));
                        break;

                    case "Celular":
                        listado = dbe.GetList(p => p.Celular.Contains(CriteriotextBox.Text));
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

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("No se puede imprimir");
                return;
            }
            else
            {
                
            }
        }

        private void Quitarbutton_Click(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
