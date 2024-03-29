﻿namespace FerreteriaSystem.Registros
{
    partial class rProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Costolabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.ProductoIdlabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.Existencialabel = new System.Windows.Forms.Label();
            this.ProductoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(88, 56);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(158, 20);
            this.DescripciontextBox.TabIndex = 23;
            // 
            // Costolabel
            // 
            this.Costolabel.AutoSize = true;
            this.Costolabel.Location = new System.Drawing.Point(12, 95);
            this.Costolabel.Name = "Costolabel";
            this.Costolabel.Size = new System.Drawing.Size(37, 13);
            this.Costolabel.TabIndex = 20;
            this.Costolabel.Text = "Precio";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(12, 56);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 18;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // ProductoIdlabel
            // 
            this.ProductoIdlabel.AutoSize = true;
            this.ProductoIdlabel.Location = new System.Drawing.Point(12, 21);
            this.ProductoIdlabel.Name = "ProductoIdlabel";
            this.ProductoIdlabel.Size = new System.Drawing.Size(59, 13);
            this.ProductoIdlabel.TabIndex = 17;
            this.ProductoIdlabel.Text = "ProductoId";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(88, 129);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.FechadateTimePicker.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fecha ";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(172, 201);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(78, 34);
            this.Eliminarbutton.TabIndex = 35;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(89, 201);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(77, 34);
            this.Guardarbutton.TabIndex = 34;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(4, 201);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(79, 34);
            this.Nuevobutton.TabIndex = 33;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(171, 10);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 34);
            this.Buscarbutton.TabIndex = 36;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(88, 165);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.ReadOnly = true;
            this.ExistenciatextBox.Size = new System.Drawing.Size(158, 20);
            this.ExistenciatextBox.TabIndex = 38;
            // 
            // Existencialabel
            // 
            this.Existencialabel.AutoSize = true;
            this.Existencialabel.Location = new System.Drawing.Point(12, 165);
            this.Existencialabel.Name = "Existencialabel";
            this.Existencialabel.Size = new System.Drawing.Size(55, 13);
            this.Existencialabel.TabIndex = 37;
            this.Existencialabel.Text = "Existencia";
            // 
            // ProductoIdnumericUpDown
            // 
            this.ProductoIdnumericUpDown.Location = new System.Drawing.Point(88, 21);
            this.ProductoIdnumericUpDown.Name = "ProductoIdnumericUpDown";
            this.ProductoIdnumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.ProductoIdnumericUpDown.TabIndex = 22;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(89, 95);
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(157, 20);
            this.PrecionumericUpDown.TabIndex = 39;
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FerreteriaSystem.Properties.Resources.productos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(258, 245);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.Existencialabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.ProductoIdnumericUpDown);
            this.Controls.Add(this.Costolabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.ProductoIdlabel);
            this.Name = "rProductos";
            this.Text = "rProductos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label Costolabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label ProductoIdlabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label Existencialabel;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.NumericUpDown ProductoIdnumericUpDown;
    }
}