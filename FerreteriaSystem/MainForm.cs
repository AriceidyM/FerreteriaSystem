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
    }
}
