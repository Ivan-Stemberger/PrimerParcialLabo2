namespace Stemberger.Ivan
{
    partial class FrmVentaEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvVenta = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeshacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVenta
            // 
            this.dtgvVenta.AllowUserToAddRows = false;
            this.dtgvVenta.AllowUserToDeleteRows = false;
            this.dtgvVenta.AllowUserToResizeColumns = false;
            this.dtgvVenta.AllowUserToResizeRows = false;
            this.dtgvVenta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvVenta.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvVenta.GridColor = System.Drawing.SystemColors.ControlText;
            this.dtgvVenta.Location = new System.Drawing.Point(244, 56);
            this.dtgvVenta.Name = "dtgvVenta";
            this.dtgvVenta.RowTemplate.ReadOnly = true;
            this.dtgvVenta.Size = new System.Drawing.Size(517, 178);
            this.dtgvVenta.TabIndex = 0;
            this.dtgvVenta.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(610, 261);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 67);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(12, 76);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(177, 20);
            this.txtEmpleado.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Black;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrar.Location = new System.Drawing.Point(244, 261);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(151, 67);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro por empleado";
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.Color.Black;
            this.btnDeshacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeshacer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeshacer.Location = new System.Drawing.Point(428, 261);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(151, 67);
            this.btnDeshacer.TabIndex = 3;
            this.btnDeshacer.Text = "Deshacer Filtro";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // VentaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgvVenta);
            this.Name = "VentaEmpleado";
            this.Text = "VentaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVenta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeshacer;
    }
}