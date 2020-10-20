using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona;

namespace Stemberger.Ivan
{
    public partial class FrmVentaEmpleado : Form
    {
        List<Compra> listaCompras;
        public FrmVentaEmpleado()
        {
            InitializeComponent();
            listaCompras = new List<Compra>();
        }
        /// <summary>
        /// Carga el DataGrid View con la lista de Compras.
        /// </summary>
        /// <param name="compras">Lista de Compras</param>
        public void cargaVentas(List<Compra> compras)
        {
            listaCompras = compras;
            this.dtgvVenta.DataSource = null;
            this.dtgvVenta.DataSource = compras;
            ConfiguracionDatagrid();
        }
        /// <summary>
        /// Configura el DataGrid View para que las celdas se ajusten al texto.
        /// </summary>
        private void ConfiguracionDatagrid()
        {

            
            this.dtgvVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Compra> filtroCompras = new List<Compra>();
            this.dtgvVenta.DataSource = null;
            

            foreach (Compra compra in listaCompras)
            {
                if(compra.Empleado == txtEmpleado.Text || txtEmpleado.Text.Contains(compra.Empleado))
                {
                    filtroCompras.Add(compra);

                }
            }
            this.dtgvVenta.DataSource = filtroCompras;
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            cargaVentas(listaCompras);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }

    
}
