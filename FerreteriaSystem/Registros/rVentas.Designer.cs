namespace FerreteriaSystem.Registros
{
    partial class rVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.VentasdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.ItbistextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Quitarbutton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.Totallabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(35, 11);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.IdnumericUpDown.TabIndex = 3;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(412, 26);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.FechadateTimePicker.TabIndex = 4;
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(235, 18);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(115, 21);
            this.ClientecomboBox.TabIndex = 5;
            this.ClientecomboBox.SelectedIndexChanged += new System.EventHandler(this.ClientecomboBox_SelectedIndexChanged);
            // 
            // VentasdataGridView
            // 
            this.VentasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasdataGridView.Location = new System.Drawing.Point(15, 81);
            this.VentasdataGridView.Name = "VentasdataGridView";
            this.VentasdataGridView.Size = new System.Drawing.Size(447, 184);
            this.VentasdataGridView.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubTotaltextBox);
            this.groupBox1.Controls.Add(this.ItbistextBox);
            this.groupBox1.Controls.Add(this.TotaltextBox);
            this.groupBox1.Controls.Add(this.PrecioTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ImportetextBox);
            this.groupBox1.Controls.Add(this.ProductocomboBox);
            this.groupBox1.Controls.Add(this.CantidadnumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ClientecomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Quitarbutton);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.Totallabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VentasdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 341);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Location = new System.Drawing.Point(397, 266);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.ReadOnly = true;
            this.SubTotaltextBox.Size = new System.Drawing.Size(66, 20);
            this.SubTotaltextBox.TabIndex = 27;
            // 
            // ItbistextBox
            // 
            this.ItbistextBox.Location = new System.Drawing.Point(397, 289);
            this.ItbistextBox.Name = "ItbistextBox";
            this.ItbistextBox.ReadOnly = true;
            this.ItbistextBox.Size = new System.Drawing.Size(66, 20);
            this.ItbistextBox.TabIndex = 26;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(397, 311);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(66, 20);
            this.TotaltextBox.TabIndex = 25;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(182, 53);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.ReadOnly = true;
            this.PrecioTextBox.Size = new System.Drawing.Size(66, 20);
            this.PrecioTextBox.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(298, 54);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 23;
            this.ImportetextBox.TextChanged += new System.EventHandler(this.ImportetextBox_TextChanged);
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(68, 18);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(115, 21);
            this.ProductocomboBox.TabIndex = 12;
            this.ProductocomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductocomboBox_SelectedIndexChanged);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(75, 55);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.CantidadnumericUpDown.TabIndex = 21;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Importe";
            // 
            // Quitarbutton
            // 
            this.Quitarbutton.Image = global::FerreteriaSystem.Properties.Resources.Close_icon;
            this.Quitarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Quitarbutton.Location = new System.Drawing.Point(15, 265);
            this.Quitarbutton.Name = "Quitarbutton";
            this.Quitarbutton.Size = new System.Drawing.Size(81, 28);
            this.Quitarbutton.TabIndex = 8;
            this.Quitarbutton.Text = "Quitar";
            this.Quitarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Quitarbutton.UseVisualStyleBackColor = true;
            this.Quitarbutton.Click += new System.EventHandler(this.Quitarbutton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(404, 53);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(58, 23);
            this.AgregarButton.TabIndex = 11;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(350, 318);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(31, 13);
            this.Totallabel.TabIndex = 16;
            this.Totallabel.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "ITBIS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SubTotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::FerreteriaSystem.Properties.Resources.delete_file_icon;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(397, 431);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(81, 32);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::FerreteriaSystem.Properties.Resources.Save_icon1;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(231, 431);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(81, 32);
            this.Guardarbutton.TabIndex = 10;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::FerreteriaSystem.Properties.Resources.new_file_icon;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(67, 431);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(81, 32);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::FerreteriaSystem.Properties.Resources.search_black_icon;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(118, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(71, 35);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FerreteriaSystem.Properties.Resources.ventas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 477);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rVentas";
            this.Text = "Registro de ventas";
            this.Load += new System.EventHandler(this.RVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.DataGridView VentasdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Quitarbutton;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.TextBox ItbistextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
    }
}