namespace Vidacero
{
    partial class Contenedor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.compras = new System.Windows.Forms.ToolStripMenuItem();
            this.stock = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.Clientes,
            this.ventas,
            this.compras,
            this.stock,
            this.usuarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidoToolStripMenuItem.Image = global::Vidacero.Properties.Resources.Pedido;
            this.pedidoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(118, 54);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // Clientes
            // 
            this.Clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.Image = global::Vidacero.Properties.Resources.Cliente;
            this.Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(124, 54);
            this.Clientes.Text = "Clientes";
            this.Clientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ventas
            // 
            this.ventas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.Image = global::Vidacero.Properties.Resources.Ventas;
            this.ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(116, 54);
            this.ventas.Text = "Ventas";
            this.ventas.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // compras
            // 
            this.compras.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras.Image = global::Vidacero.Properties.Resources.Compras;
            this.compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.compras.Name = "compras";
            this.compras.Size = new System.Drawing.Size(131, 54);
            this.compras.Text = "Compras";
            this.compras.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Image = global::Vidacero.Properties.Resources.Stock;
            this.stock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(108, 54);
            this.stock.Text = "Stock";
            this.stock.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // usuarios
            // 
            this.usuarios.Enabled = false;
            this.usuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios.Image = global::Vidacero.Properties.Resources.UsuarioIcon;
            this.usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(130, 54);
            this.usuarios.Text = "Usuarios";
            this.usuarios.Click += new System.EventHandler(this.usuarios_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talamanga";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem ventas;
        private System.Windows.Forms.ToolStripMenuItem compras;
        private System.Windows.Forms.ToolStripMenuItem stock;
        private System.Windows.Forms.ToolStripMenuItem usuarios;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
    }
}

