namespace Stemberger.Ivan
{
    partial class FrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtProductoCompra = new System.Windows.Forms.TextBox();
            this.txtCantidadCompra = new System.Windows.Forms.TextBox();
            this.dtgvCompra = new System.Windows.Forms.DataGridView();
            this.btnAddCompra = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoCompra
            // 
            this.txtProductoCompra.Location = new System.Drawing.Point(124, 51);
            this.txtProductoCompra.Name = "txtProductoCompra";
            this.txtProductoCompra.Size = new System.Drawing.Size(183, 20);
            this.txtProductoCompra.TabIndex = 0;
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Location = new System.Drawing.Point(124, 130);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(183, 20);
            this.txtCantidadCompra.TabIndex = 1;
            // 
            // dtgvCompra
            // 
            this.dtgvCompra.AllowUserToAddRows = false;
            this.dtgvCompra.AllowUserToDeleteRows = false;
            this.dtgvCompra.AllowUserToResizeColumns = false;
            this.dtgvCompra.AllowUserToResizeRows = false;
            this.dtgvCompra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCompra.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvCompra.Location = new System.Drawing.Point(345, 51);
            this.dtgvCompra.Name = "dtgvCompra";
            this.dtgvCompra.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvCompra.RowTemplate.ReadOnly = true;
            this.dtgvCompra.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCompra.Size = new System.Drawing.Size(443, 195);
            this.dtgvCompra.TabIndex = 2;
            this.dtgvCompra.TabStop = false;
            // 
            // btnAddCompra
            // 
            this.btnAddCompra.BackColor = System.Drawing.Color.Black;
            this.btnAddCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCompra.Location = new System.Drawing.Point(104, 296);
            this.btnAddCompra.Name = "btnAddCompra";
            this.btnAddCompra.Size = new System.Drawing.Size(130, 44);
            this.btnAddCompra.TabIndex = 4;
            this.btnAddCompra.Text = "Agregar";
            this.btnAddCompra.UseVisualStyleBackColor = false;
            this.btnAddCompra.Click += new System.EventHandler(this.btnAddCompra_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Black;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFinalizarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(658, 296);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(130, 44);
            this.btnFinalizarCompra.TabIndex = 5;
            this.btnFinalizarCompra.Text = "Finalizar";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(633, 256);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(154, 20);
            this.txtPrecioTotal.TabIndex = 5;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(124, 178);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(183, 20);
            this.txtClienteNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(1, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre cliente";
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(124, 226);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(183, 20);
            this.txtClienteApellido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido cliente";
            // 
            // cbxTipoProducto
            // 
            this.cbxTipoProducto.FormattingEnabled = true;
            this.cbxTipoProducto.Items.AddRange(new object[] {
            "Arma",
            "Bebida",
            "Hamburguesa",
            "Lacteo",
            "Limpieza"});
            this.cbxTipoProducto.Location = new System.Drawing.Point(124, 89);
            this.cbxTipoProducto.Name = "cbxTipoProducto";
            this.cbxTipoProducto.Size = new System.Drawing.Size(183, 21);
            this.cbxTipoProducto.TabIndex = 12;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoProducto.Location = new System.Drawing.Point(1, 93);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(117, 17);
            this.lblTipoProducto.TabIndex = 13;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.cbxTipoProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClienteApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAddCompra);
            this.Controls.Add(this.dtgvCompra);
            this.Controls.Add(this.txtCantidadCompra);
            this.Controls.Add(this.txtProductoCompra);
            this.Name = "FrmCompras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductoCompra;
        private System.Windows.Forms.TextBox txtCantidadCompra;
        private System.Windows.Forms.DataGridView dtgvCompra;
        private System.Windows.Forms.Button btnAddCompra;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
    }
}