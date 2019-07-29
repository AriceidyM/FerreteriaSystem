namespace FerreteriaSystem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEntradaInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cEntradaInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repEntradaInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rUsuariosToolStripMenuItem,
            this.rClientesToolStripMenuItem,
            this.rProductosToolStripMenuItem,
            this.rEntradaInventarioToolStripMenuItem,
            this.rVentasToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // rUsuariosToolStripMenuItem
            // 
            this.rUsuariosToolStripMenuItem.Name = "rUsuariosToolStripMenuItem";
            this.rUsuariosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rUsuariosToolStripMenuItem.Text = "rUsuarios";
            this.rUsuariosToolStripMenuItem.Click += new System.EventHandler(this.RUsuariosToolStripMenuItem_Click);
            // 
            // rClientesToolStripMenuItem
            // 
            this.rClientesToolStripMenuItem.Name = "rClientesToolStripMenuItem";
            this.rClientesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rClientesToolStripMenuItem.Text = "rClientes";
            this.rClientesToolStripMenuItem.Click += new System.EventHandler(this.RClientesToolStripMenuItem_Click);
            // 
            // rProductosToolStripMenuItem
            // 
            this.rProductosToolStripMenuItem.Name = "rProductosToolStripMenuItem";
            this.rProductosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rProductosToolStripMenuItem.Text = "rProductos";
            this.rProductosToolStripMenuItem.Click += new System.EventHandler(this.RProductosToolStripMenuItem_Click);
            // 
            // rEntradaInventarioToolStripMenuItem
            // 
            this.rEntradaInventarioToolStripMenuItem.Name = "rEntradaInventarioToolStripMenuItem";
            this.rEntradaInventarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rEntradaInventarioToolStripMenuItem.Text = "rEntradaInventario";
            this.rEntradaInventarioToolStripMenuItem.Click += new System.EventHandler(this.REntradaInventarioToolStripMenuItem_Click);
            // 
            // rVentasToolStripMenuItem
            // 
            this.rVentasToolStripMenuItem.Name = "rVentasToolStripMenuItem";
            this.rVentasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rVentasToolStripMenuItem.Text = "rVentas";
            this.rVentasToolStripMenuItem.Click += new System.EventHandler(this.RVentasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUsuariosToolStripMenuItem,
            this.cClientesToolStripMenuItem,
            this.cProductosToolStripMenuItem,
            this.cEntradaInventarioToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cUsuariosToolStripMenuItem
            // 
            this.cUsuariosToolStripMenuItem.Name = "cUsuariosToolStripMenuItem";
            this.cUsuariosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cUsuariosToolStripMenuItem.Text = "cUsuarios";
            this.cUsuariosToolStripMenuItem.Click += new System.EventHandler(this.CUsuariosToolStripMenuItem_Click);
            // 
            // cClientesToolStripMenuItem
            // 
            this.cClientesToolStripMenuItem.Name = "cClientesToolStripMenuItem";
            this.cClientesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cClientesToolStripMenuItem.Text = "cClientes";
            this.cClientesToolStripMenuItem.Click += new System.EventHandler(this.CClientesToolStripMenuItem_Click);
            // 
            // cProductosToolStripMenuItem
            // 
            this.cProductosToolStripMenuItem.Name = "cProductosToolStripMenuItem";
            this.cProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cProductosToolStripMenuItem.Text = "cProductos";
            this.cProductosToolStripMenuItem.Click += new System.EventHandler(this.CProductosToolStripMenuItem_Click);
            // 
            // cEntradaInventarioToolStripMenuItem
            // 
            this.cEntradaInventarioToolStripMenuItem.Name = "cEntradaInventarioToolStripMenuItem";
            this.cEntradaInventarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cEntradaInventarioToolStripMenuItem.Text = "cEntradaInventario";
            this.cEntradaInventarioToolStripMenuItem.Click += new System.EventHandler(this.CEntradaInventarioToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repUsuariosToolStripMenuItem,
            this.repClientesToolStripMenuItem,
            this.repProductosToolStripMenuItem,
            this.repEntradaInventarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // repUsuariosToolStripMenuItem
            // 
            this.repUsuariosToolStripMenuItem.Name = "repUsuariosToolStripMenuItem";
            this.repUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.repUsuariosToolStripMenuItem.Text = "repUsuarios";
            this.repUsuariosToolStripMenuItem.Click += new System.EventHandler(this.RepUsuariosToolStripMenuItem_Click);
            // 
            // repClientesToolStripMenuItem
            // 
            this.repClientesToolStripMenuItem.Name = "repClientesToolStripMenuItem";
            this.repClientesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.repClientesToolStripMenuItem.Text = "repClientes";
            this.repClientesToolStripMenuItem.Click += new System.EventHandler(this.RepClientesToolStripMenuItem_Click);
            // 
            // repProductosToolStripMenuItem
            // 
            this.repProductosToolStripMenuItem.Name = "repProductosToolStripMenuItem";
            this.repProductosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.repProductosToolStripMenuItem.Text = "repProductos";
            this.repProductosToolStripMenuItem.Click += new System.EventHandler(this.RepProductosToolStripMenuItem_Click);
            // 
            // repEntradaInventarioToolStripMenuItem
            // 
            this.repEntradaInventarioToolStripMenuItem.Name = "repEntradaInventarioToolStripMenuItem";
            this.repEntradaInventarioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.repEntradaInventarioToolStripMenuItem.Text = "repEntradaInventario";
            this.repEntradaInventarioToolStripMenuItem.Click += new System.EventHandler(this.RepEntradaInventarioToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FerreteriaSystem.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ferreteria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEntradaInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repEntradaInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cEntradaInventarioToolStripMenuItem;
    }
}

