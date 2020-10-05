using Persona;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stemberger.Ivan
{
    public partial class FrmStock : FrmMenú
    {
        List<Producto> listaDeProductos;
        public FrmStock()
        {
            InitializeComponent();
            listaDeProductos = new List<Producto>();

        }
        /// <summary>
        /// Carga el DataGrid View con los datos de la lista de productos.
        /// </summary>
        /// <param name="productos">Lista de productos.</param>
        public void cargaStock (List<Producto> productos)
        {
            listaDeProductos = productos;
            this.dtgvStock.DataSource = null;
            this.dtgvStock.DataSource = productos;

        }

        private void btnStockAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        private void btnFiltrarProducto_Click(object sender, EventArgs e)
        {
            List<Producto> listaAux = new List<Producto>();

            foreach(Producto producto in listaDeProductos)
            {
                if(int.Parse(producto.Cantidad) < 10)
                {
                    listaAux.Add(producto);
                }

            }

            this.dtgvStock.DataSource = null;
            this.dtgvStock.DataSource = listaAux;
        }

        private void btnDeshacerFiltro_Click(object sender, EventArgs e)
        {
            cargaStock(listaDeProductos);
        }
    }
}
