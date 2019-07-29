using DAL;
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
    public partial class rVentas : Form
    {
        public List<VentasDetalle> Detalle { get; set; }
        public rVentas()
        {
            InitializeComponent();
            this.Detalle = new List<VentasDetalle>();
            LlenarComboBox();
        }
        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        private void LlenarPrecio()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            List<Productos> lista = repositorio.GetList(c => c.Descripcion == ProductocomboBox.Text);
            foreach (var item in lista)
            {
                PrecioTextBox.Text = item.Precio.ToString();
            }
        }

        private void LlenarComboBox()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>(new DAL.FerreteriaContexto());
            Repositorio<Productos> dbp = new Repositorio<Productos>(new DAL.FerreteriaContexto());
            ClientecomboBox.DataSource = db.GetList(c => true);
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombres";
            ProductocomboBox.DataSource = dbp.GetList(c => true);
            ProductocomboBox.ValueMember = "ProductoId";
            ProductocomboBox.DisplayMember = "Descripcion";
        }

        private void LlenaCampos(Ventas ventas)
        {

            VentasDetalle detalle = new VentasDetalle();
            IdnumericUpDown.Value = ventas.VentaId;
            FechadateTimePicker.Value = ventas.Fecha; ;
            FechadateTimePicker.Value = ventas.Fecha;
            SubTotaltextBox.Text = ventas.SubTotal.ToString();
            ItbistextBox.Text = ventas.ITBIS.ToString();
            TotaltextBox.Text = ventas.Total.ToString();

            //Cargar el detalle al Grid
            VentasdataGridView.DataSource = ventas.Detalle;

            VentasdataGridView.Columns["Id"].Visible = false;
            VentasdataGridView.Columns["VentasId"].Visible = false;
            VentasdataGridView.Columns["ClienteId"].Visible = false;
            VentasdataGridView.Columns["ProductoId"].Visible = false;
        }

        private Ventas LlenaClase()
        {
            Ventas ventas = new Ventas();
            ventas.VentaId = Convert.ToInt32(IdnumericUpDown.Value);
            ventas.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            ventas.Fecha = FechadateTimePicker.Value;
            ventas.SubTotal = Convert.ToInt32(SubTotaltextBox.Text);
            ventas.ITBIS = Convert.ToInt32(ItbistextBox.Text);
            ventas.Total = Convert.ToInt32(TotaltextBox.Text);

            foreach (DataGridViewRow item in VentasdataGridView.Rows)
            {
                ventas.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["VentaId"].Value),
                    ToInt(item.Cells["ProductoId"].Value),
                    item.Cells["Descripcion"].ToString(),
                    ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["Cantidad"].Value),
                    ToInt(item.Cells["Importe"].Value)
                );
            }

            return ventas;
        }
        private void RVentas_Load(object sender, EventArgs e)
        {

        }

        private void LlenarValores()
        {
            List<VentasDetalle> detalle = new List<VentasDetalle>();

            if (VentasdataGridView.DataSource != null)
            {
                detalle = (List<VentasDetalle>)VentasdataGridView.DataSource;
            }
            int Total = 0;
            int Itbis = 0;
            int SubTotal = 0;
            foreach (var item in detalle)
            {
                Total += item.Importe;
            }
            Itbis = (Total * 18)/100;
            SubTotal = Total - Itbis;
            SubTotaltextBox.Text = SubTotal.ToString();
            ItbistextBox.Text = Itbis.ToString();
            TotaltextBox.Text = Total.ToString();
        }

        private void RebajarValores()
        {
            List<VentasDetalle> detalle = new List<VentasDetalle>();

            if (VentasdataGridView.DataSource != null)
            {
                detalle = (List<VentasDetalle>)VentasdataGridView.DataSource;
            }
            int Total = 0;
            int Itbis = 0;
            int SubTotal = 0;
            foreach (var item in detalle)
            {
                Total -= item.Importe;
            }
            Total *= (-1);
            Itbis = (Total * 18) /100;
            SubTotal = Total - Itbis;
            SubTotaltextBox.Text = SubTotal.ToString();
            ItbistextBox.Text = Itbis.ToString();
            TotaltextBox.Text = Total.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<VentasDetalle> detalle = new List<VentasDetalle>();

            if (VentasdataGridView.DataSource != null)
            {
                detalle = (List<VentasDetalle>)VentasdataGridView.DataSource;
            }

            if (string.IsNullOrEmpty(ImportetextBox.Text))
            {
                MessageBox.Show("Importe esta vacio , Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                detalle.Add(
                    new VentasDetalle(
                       id: 0,
                       ventaId: (int)IdnumericUpDown.Value,
                       productoId: (int)ProductocomboBox.SelectedValue,
                       descripcion: ProductocomboBox.Text,
                       cantidad: ToInt(CantidadnumericUpDown.Value),
                       precio: ToInt(PrecioTextBox.Text),
                       importe: ToInt(ImportetextBox.Text)

                    ));

                VentasdataGridView.DataSource = null;
                VentasdataGridView.DataSource = detalle;
                LlenarValores();
            }
        }


        private void Quitarbutton_Click(object sender, EventArgs e)
        {
            if (VentasdataGridView.Rows.Count > 0 && VentasdataGridView.CurrentRow != null)
            {
                List<VentasDetalle> detalle = (List<VentasDetalle>)VentasdataGridView.DataSource;

                detalle.RemoveAt(VentasdataGridView.CurrentRow.Index);

                VentasdataGridView.DataSource = null;
                VentasdataGridView.DataSource = detalle;
                RebajarValores();
            }
        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            ClientecomboBox.Text = string.Empty;
            ProductocomboBox.Text = string.Empty;
            PrecioTextBox.Clear();
            CantidadnumericUpDown.Value = 0;
            ImportetextBox.Text = string.Empty;
            SubTotaltextBox.Clear();
            ItbistextBox.Clear();
            TotaltextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            VentasdataGridView.DataSource = string.Empty;
            errorProvider.Clear();
        }

        private bool Validar()
        {
            bool estado = false;

            if (VentasdataGridView.RowCount == 0)
            {
                errorProvider.SetError(VentasdataGridView,
                    "Debe Agregar");
                estado = true;
            }

            return estado;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            Ventas ventas = dbe.Buscar((int)((int)IdnumericUpDown.Value));
            return (ventas != null);
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ventas venta;
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            venta = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                Paso = VentasBLL.Guardar(venta);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Ventas fac = VentasBLL.Buscar(id);

                if (fac != null)
                {
                    Paso = VentasBLL.Modificar(venta);
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            Ventas venta = VentasBLL.Buscar(id);

            if (venta != null)
            {
                if (VentasBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Ventas venta = VentasBLL.Buscar(id);

            if (venta != null)
            {
                LlenaCampos(venta);
            }
            else
                MessageBox.Show("No se encontró!!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            rClientes cli = new rClientes();
            cli.ShowDialog();
            LlenarComboBox();
        }

        private void ProductocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarPrecio();
            if (CantidadnumericUpDown.Value != 0)
            {
                LlenarImporte();
            }
            LlenarPrecio();
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Repositorio<Productos> db = new Repositorio<Productos>(new DAL.FerreteriaContexto());
            var lista = new List<Productos>();
            foreach (var item in lista)
            {
                PrecioTextBox.Text = item.Precio.ToString();
                //PreciotextBox.Text = item.Precio.ToString();
            }
        }
        private void LlenarImporte()
        {
            int cantidad = 0;
            int precio = 0;
            int resultado = 0;
            cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            precio = ToInt(PrecioTextBox.Text);
            resultado = cantidad * precio;
            ImportetextBox.Text = PrecioTextBox.Text;
        }

        private void PrecionumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            LlenarPrecio();
            LlenarImporte();
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LlenarPrecio();
            LlenarImporte();
        }
        private void ImportetextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
