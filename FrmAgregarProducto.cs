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
    public partial class FrmAgregarProducto : Form
    {
        List<Producto> productos;

        public FrmAgregarProducto()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(cbxTipoProducto.Text)
            {
                case "Arma":
                    {
                        productos.Add(new Arma(txtNombreProducto.Text, txtPrecioUnitario.Text, txtCantidad.Text));

                        break;
                    }
                case "Bebida":
                    {
                        productos.Add(new Bebida(txtNombreProducto.Text, txtPrecioUnitario.Text, txtCantidad.Text));

                        break;
                    }
                case "Hamburguesa":
                    {
                        productos.Add(new Hamburguesa(txtNombreProducto.Text, txtPrecioUnitario.Text, txtCantidad.Text));

                        break;
                    }
                case "Lacteo":
                    {
                        productos.Add(new Lacteo(txtNombreProducto.Text, txtPrecioUnitario.Text, txtCantidad.Text));

                        break;
                    }
                case "Limpieza":
                    {
                        productos.Add(new Limpieza(txtNombreProducto.Text, txtPrecioUnitario.Text, txtCantidad.Text));

                        break;
                    }

            }

            Clear();

        }
        /// <summary>
        /// Recibe una lista de productos para ser usada en este formulario.
        /// </summary>
        /// <param name="listaProductos">Lista de Productos recibida.</param>
        public void receive (List<Producto> listaProductos)
        {
            
            productos.AddRange(listaProductos);

        }
        /// <summary>
        /// Envía la lista de productos de donde se la llame.
        /// </summary>
        /// <returns>Retorna una lista de productos.</returns>
        public List<Producto> sendList()
        {
            return productos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
        }
        /// <summary>
        /// Vacía todos los campos del formulario.
        /// </summary>
        private void Clear()
        {
            txtNombreProducto.Text = "";
            cbxTipoProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioUnitario.Text = "";
        }

        
    }
}
