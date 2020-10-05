namespace Stemberger.Ivan
{
    partial class FrmMenú
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
            this.btnCompra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaDeLaHerramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.Black;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompra.Location = new System.Drawing.Point(315, 156);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(190, 45);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "Nueva Compra";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProducto,
            this.pruebaDeLaHerramientaToolStripMenuItem,
            this.controlarStockToolStripMenuItem,
            this.ventaPorEmpleadoToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // agregarProducto
            // 
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(206, 22);
            this.agregarProducto.Text = "Agregar Producto";
            this.agregarProducto.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // pruebaDeLaHerramientaToolStripMenuItem
            // 
            this.pruebaDeLaHerramientaToolStripMenuItem.Name = "pruebaDeLaHerramientaToolStripMenuItem";
            this.pruebaDeLaHerramientaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pruebaDeLaHerramientaToolStripMenuItem.Text = "Prueba de la herramienta";
            this.pruebaDeLaHerramientaToolStripMenuItem.Click += new System.EventHandler(this.pruebaDeLaHerramientaToolStripMenuItem_Click);
            // 
            // controlarStockToolStripMenuItem
            // 
            this.controlarStockToolStripMenuItem.Name = "controlarStockToolStripMenuItem";
            this.controlarStockToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.controlarStockToolStripMenuItem.Text = "Controlar Stock";
            this.controlarStockToolStripMenuItem.Click += new System.EventHandler(this.controlarStockToolStripMenuItem_Click);
            // 
            // ventaPorEmpleadoToolStripMenuItem
            // 
            this.ventaPorEmpleadoToolStripMenuItem.Name = "ventaPorEmpleadoToolStripMenuItem";
            this.ventaPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ventaPorEmpleadoToolStripMenuItem.Text = "Venta por empleado";
            this.ventaPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ventaPorEmpleadoToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(316, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(189, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(280, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 48);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "KWIK E MART";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menú";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProducto;
        private System.Windows.Forms.ToolStripMenuItem pruebaDeLaHerramientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitle;
    }
}