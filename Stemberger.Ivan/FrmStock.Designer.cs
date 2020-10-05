namespace Stemberger.Ivan
{
    partial class FrmStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvStock = new System.Windows.Forms.DataGridView();
            this.btnStockAceptar = new System.Windows.Forms.Button();
            this.btnFiltrarProducto = new System.Windows.Forms.Button();
            this.btnDeshacerFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvStock
            // 
            this.dtgvStock.AllowUserToAddRows = false;
            this.dtgvStock.AllowUserToDeleteRows = false;
            this.dtgvStock.AllowUserToResizeColumns = false;
            this.dtgvStock.AllowUserToResizeRows = false;
            this.dtgvStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvStock.Location = new System.Drawing.Point(202, 27);
            this.dtgvStock.Name = "dtgvStock";
            this.dtgvStock.Size = new System.Drawing.Size(445, 240);
            this.dtgvStock.TabIndex = 0;
            // 
            // btnStockAceptar
            // 
            this.btnStockAceptar.BackColor = System.Drawing.Color.Black;
            this.btnStockAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStockAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStockAceptar.Location = new System.Drawing.Point(525, 273);
            this.btnStockAceptar.Name = "btnStockAceptar";
            this.btnStockAceptar.Size = new System.Drawing.Size(122, 60);
            this.btnStockAceptar.TabIndex = 3;
            this.btnStockAceptar.Text = "Aceptar";
            this.btnStockAceptar.UseVisualStyleBackColor = false;
            this.btnStockAceptar.Click += new System.EventHandler(this.btnStockAceptar_Click);
            // 
            // btnFiltrarProducto
            // 
            this.btnFiltrarProducto.BackColor = System.Drawing.Color.Black;
            this.btnFiltrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFiltrarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrarProducto.Location = new System.Drawing.Point(366, 273);
            this.btnFiltrarProducto.Name = "btnFiltrarProducto";
            this.btnFiltrarProducto.Size = new System.Drawing.Size(122, 60);
            this.btnFiltrarProducto.TabIndex = 2;
            this.btnFiltrarProducto.Text = "Menos de 10 Unidades";
            this.btnFiltrarProducto.UseVisualStyleBackColor = false;
            this.btnFiltrarProducto.Click += new System.EventHandler(this.btnFiltrarProducto_Click);
            // 
            // btnDeshacerFiltro
            // 
            this.btnDeshacerFiltro.BackColor = System.Drawing.Color.Black;
            this.btnDeshacerFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeshacerFiltro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeshacerFiltro.Location = new System.Drawing.Point(202, 273);
            this.btnDeshacerFiltro.Name = "btnDeshacerFiltro";
            this.btnDeshacerFiltro.Size = new System.Drawing.Size(122, 60);
            this.btnDeshacerFiltro.TabIndex = 1;
            this.btnDeshacerFiltro.Text = "Deshacer Filtro";
            this.btnDeshacerFiltro.UseCompatibleTextRendering = true;
            this.btnDeshacerFiltro.UseVisualStyleBackColor = false;
            this.btnDeshacerFiltro.Click += new System.EventHandler(this.btnDeshacerFiltro_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeshacerFiltro);
            this.Controls.Add(this.btnFiltrarProducto);
            this.Controls.Add(this.btnStockAceptar);
            this.Controls.Add(this.dtgvStock);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Controls.SetChildIndex(this.dtgvStock, 0);
            this.Controls.SetChildIndex(this.btnStockAceptar, 0);
            this.Controls.SetChildIndex(this.btnFiltrarProducto, 0);
            this.Controls.SetChildIndex(this.btnDeshacerFiltro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvStock;
        private System.Windows.Forms.Button btnStockAceptar;
        private System.Windows.Forms.Button btnFiltrarProducto;
        private System.Windows.Forms.Button btnDeshacerFiltro;
    }
}