using FerreteriaSystem.Consultas;
using FerreteriaSystem.Registros;
using FerreteriaSystem.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios us = new rUsuarios();
            us.Show();
        }

        private void CUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios us = new cUsuarios();
            us.Show();
        }

        private void RepUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoUsuarios us = new repoUsuarios();
            us.Show();
        }

        private void RClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes cli = new rClientes();
            cli.Show();
        }

        private void RProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos pro = new rProductos();
            pro.Show();
        }

        private void REntradaInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaInventario inv = new rEntradaInventario();
            inv.Show();
        }

        private void RepClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoClientes cli = new repoClientes();
            cli.Show();
        }

        private void RepProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoProductos pro = new repoProductos();
            pro.Show();
        }

        private void RepEntradaInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoEntradaInventario inv = new repoEntradaInventario();
            inv.Show();
        }

        private void RVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas ven = new rVentas();
            ven.Show();
        }

        private void CClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes cli = new cClientes();
            cli.Show();
        }

        private void CProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProductos pro = new cProductos();
            pro.Show();
        }

        private void CEntradaInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEntradaInventario inv = new cEntradaInventario();
            inv.Show();
        }
    }
}
