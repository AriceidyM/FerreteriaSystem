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
        public rVentas()
        {
            InitializeComponent();
            LLenarClientes();
            ClientecomboBox.Text = null;
            LLenarProducto();
            ProductocomboBox.Text = null;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }

        private void Anadir()
        {
            List<VentasDetalle> detalle = new List<VentasDetalle>();

            if (VentasdataGridView.DataSource != null)
            {
                detalle = (List<VentasDetalle>)VentasdataGridView.DataSource;
            }
            decimal Total = 0;
            decimal ITBIS = 0;
            decimal Subtotal = 0;
            foreach (var item in detalle)
            {
                Total += item.importe;
            }
            ITBIS = Total * 0.18m;
            Subtotal = Total - ITBIS;
            SubtotalnumericUpDown.Value = Subtotal;
            ITBISnumericUpDown.Value = ITBIS;
            TotalnumericUpDown.Value = Total;
        }
        private bool Validar()
        {
            bool paso = true;
            paso = false;
            errorProvider.Clear();

            if (ClientecomboBox.Text == string.Empty)
            {
                errorProvider.SetError(ClientecomboBox, "Favor LLenar, Campo no puede estar vacio");
                paso = false;
            }
            if (ProductocomboBox.Text == string.Empty)
            {
                errorProvider.SetError(ProductocomboBox, "Favor LLenar, Campo no puede estar vacio");
                paso = false;
            }
            if (CantidadnumericUpDown.Value == 0)
            {
                errorProvider.SetError(CantidadnumericUpDown, "Favor LLenar, Campo no puede estar vacio");
                paso = false;
            }
            return paso;
        }

        /*public void CalcularItbis()
         {
             double itbis = 0;
             foreach (var item in Detalle)
             {
                 itbis += item.Itbis;
             }
             ITBISnumericUpDown.Value = ITBIS
         }

         public void CalcularTotal()
         {
             double total = 0;
             foreach (var item in Detalle)
             {
                 total += (item.Importe) + item.Itbis;
             }
             TotalTextBox.Text = total.ToString();
         }

         public void CalcularSubtotal()
         {
             double subtotal = 0;
             foreach (var item in Detalle)
             {
                 subtotal += item.Importe;
             }
             SubTotalTextBox.Text = subtotal.ToString();
         }*/

        private void LlenaImporte()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            decimal cantidad = 0;
            decimal precio = 0;

            cantidad = CantidadnumericUpDown.Value;
            precio =PrecionumericUpDown.Value;
            //ImportetextBox.Text = repositorio.Importe(cantidad, precio).ToString();
        }
        private void LlenarPrecio()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            List<Productos> lista = repositorio.GetList(c => c.Descripcion == ProductocomboBox.Text);
            foreach (var item in lista)
            {
                PrecionumericUpDown.Value = item.Precio;
            }
        }
        private void LLenarClientes()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>(new DAL.FerreteriaContexto());
            var lista = new List<Clientes>();
            lista = db.GetList(l => true);
            ClientecomboBox.DataSource = lista;
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";
        }

        private void LLenarProducto()
        {
            Repositorio<Productos> db = new Repositorio<Productos>(new DAL.FerreteriaContexto());
            var lista = new List<Productos>();
            lista = db.GetList(l => true);
            ProductocomboBox.DataSource = lista;
            ProductocomboBox.DisplayMember = "Descripcion";
            ProductocomboBox.ValueMember = "ProductoId";
        }
        private void LlenaCampos(Ventas ventas)
        {
            VentasDetalle detalle = new VentasDetalle();

            IdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportetextBox.Clear();


            IdnumericUpDown.Value = ventas.VentaID;
            FechadateTimePicker.Value = ventas.Fecha;
            SubtotalnumericUpDown.Value = ventas.SubTotal;
            ITBISnumericUpDown.Value = ventas.ITBIS;
            TotalnumericUpDown.Value = ventas.Total;


            //Cargar el detalle al Grid
            VentasdataGridView.DataSource = ventas.Detalle;

            VentasdataGridView.Columns["ID"].Visible = false;
            VentasdataGridView.Columns["VentasID"].Visible = false;
            VentasdataGridView.Columns["ClienteId"].Visible = false;
            VentasdataGridView.Columns["ProductoId"].Visible = false;
        }

        private Ventas LlenaClase()
        {
            Ventas ventas = new Ventas();
            ventas.VentaID = Convert.ToInt32(IdnumericUpDown.Value);
            ventas.ClienteId = Convert.ToInt32(ClientecomboBox.SelectedValue);
            ventas.ProductoId = Convert.ToInt32(ProductocomboBox.SelectedValue);
            ventas.SubTotal = Convert.ToInt32(SubtotalnumericUpDown.Value);
            ventas.ITBIS = Convert.ToInt32(ITBISnumericUpDown.Value);
            ventas.Total = Convert.ToInt32(TotalnumericUpDown.Value);

            foreach (DataGridViewRow item in VentasdataGridView.Rows)
            {
                ventas.AgregarDetalle
                    (ToInt(item.Cells["ID"].Value),
                Convert.ToInt32(item.Cells["VentasID"].Value),
                Convert.ToInt32(item.Cells["ClienteId"].Value),
                Convert.ToInt32(item.Cells["ProductoId"].Value),
                Convert.ToInt32(item.Cells["Precio"].Value),
                Convert.ToInt32(item.Cells["Cantidad"].Value),
                Convert.ToInt32(item.Cells["importe"].Value)
                );
            }
            Anadir();
            return ventas;
            
        }
        private void RVentas_Load(object sender, EventArgs e)
        {

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
                    new VentasDetalle(iD: 0,
                    ventasID: (int)Convert.ToInt32(IdnumericUpDown.Value),
                    clienteId: (int)ClientecomboBox.SelectedValue,
                    productoId: (int)ProductocomboBox.SelectedValue,


                        cantidad: Convert.ToInt32(CantidadnumericUpDown.Value),
                        precio: Convert.ToInt32(PrecionumericUpDown.Value),
                        importe: Convert.ToInt32(ImportetextBox.Text)

                    ));

                VentasdataGridView.DataSource = null;
                VentasdataGridView.DataSource = detalle;

                VentasdataGridView.Columns["VentasID"].Visible = false;
                VentasdataGridView.Columns["ClienteId"].Visible = false;
                VentasdataGridView.Columns["ProductoId"].Visible = false;


                int subtotal = 0;
                int total = 0;
                foreach (var item in detalle)
                {
                    subtotal += item.importe;
                }

                SubtotalnumericUpDown.Text = subtotal.ToString();

                total += subtotal;

                TotalnumericUpDown.Text = total.ToString();
            }
        }

        private void Quitarbutton_Click(object sender, EventArgs e)
        {
            if (VentasdataGridView.Rows.Count > 0
              && VentasdataGridView.CurrentRow != null)
            {

                List<VentasDetalle> detalle = (List<VentasDetalle>)VentasdataGridView.DataSource;

                detalle.RemoveAt(VentasdataGridView.CurrentRow.Index);


                int subtotal = 0;
                int total = 0;

                foreach (var item in detalle)
                {
                    subtotal += item.importe;
                }

                SubtotalnumericUpDown.Text = subtotal.ToString();

                total += Convert.ToInt32(SubtotalnumericUpDown.Text);

                TotalnumericUpDown.Text = total.ToString();

                VentasdataGridView.DataSource = null;
                VentasdataGridView.DataSource = detalle;


                VentasdataGridView.Columns["VentasID"].Visible = false;
                VentasdataGridView.Columns["ClienteId"].Visible = false;
                VentasdataGridView.Columns["ProductoId"].Visible = false;
            }
        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            ClientecomboBox.Text = string.Empty;
            ProductocomboBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            CantidadnumericUpDown.Value = 0;
            ImportetextBox.Text = string.Empty;
            SubtotalnumericUpDown.Value = 0;
            ITBISnumericUpDown.Value = 0;
            TotalnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();
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
            if (!Validar())
                return;

            bool paso = false;
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            Ventas ventas = new Ventas();

            ventas = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(ventas);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(ventas);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se puede Eliminar un usuario que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            errorProvider.Clear();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            if (dbe.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider.SetError(IdnumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Ventas ventas = new Ventas();
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();
            ventas = dbe.Buscar(id);

            if (ventas != null)
            {
                LlenaCampos(ventas);
            }
            else
                MessageBox.Show("Usuario no encontrado");
        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            rClientes cli = new rClientes();
            cli.ShowDialog();
            LLenarClientes();
        }

        private void ProductocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarPrecio();
            if (CantidadnumericUpDown.Text != "0")
            {
                LlenarImporte();
            }
            LlenarPrecio();
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {

                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Repositorio<Productos> db = new Repositorio<Productos>(new DAL.FerreteriaContexto());
            var lista = new List<Productos>();
            foreach (var item in lista)
            {
                PrecionumericUpDown.Value = item.Precio;
                //PreciotextBox.Text = item.Precio.ToString();
            }
        }
        private void LlenarImporte()
        {
            Repositorio<Productos> db = new Repositorio<Productos>(new DAL.FerreteriaContexto());
            decimal cantidad = 0;
            decimal precio = 0;

            //cantidad = ToDecimal(CantidadnumericUpDown.Value);
            //precio = ToDecimal(PreciotextBox.Text);
            //ImportetextBox.Text = db.Importe(cantidad, precio).ToString();
        }

        private void PrecionumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
