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
    public partial class FrmMenú : Form
    {

        List<Producto> productos;
        List<Empleado> empleados;
        List<Compra> compras;
        Compra compra;
        Producto producto;
        Empleado empleado;
        FrmCompras frmCompras;
        



        FrmAgregarProducto frmAgregarProducto;
        public FrmMenú()
        {
            InitializeComponent();
            productos = new List<Producto>();
            empleados = new List<Empleado>();
            compras = new List<Compra>();
            producto = new Producto();
            empleado = new Empleado();
            compra = new Compra();
            frmAgregarProducto = new FrmAgregarProducto();
            frmCompras = new FrmCompras();


        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmAgregarProducto.receive(productos);
            frmAgregarProducto.Show();
                        
        }

        private void pruebaDeLaHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos.AddRange(producto.inicializarListaProductos());
            empleados.AddRange(empleado.prueba(empleados));
            frmCompras.receiveEmpleados(empleados);
            compras.AddRange(compra.inicializarListaDeCompras());

            MessageBox.Show("Se han cargado 2 empleados, 30 productos y 50 compras");
            
        }

        private void controlarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();

            productos.AddRange(frmAgregarProducto.sendList());
            frmStock.cargaStock(productos);
            frmStock.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmCompras.receive(productos);

            frmCompras.Show();

        }
        /// <summary>
        /// Recibe una lista de Empleados para ser utilzada en este formulario.
        /// </summary>
        /// <param name="listaEmpleados">Lista de Empleados recibida.</param>
        public void recibirEmpleados(List<Empleado> listaEmpleados)
        {
            empleados = listaEmpleados;

        }

        
        private void ventaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentaEmpleado ventaEmpleado = new FrmVentaEmpleado();

            compras.AddRange(frmCompras.sendCompra());
            ventaEmpleado.cargaVentas(compras);
            ventaEmpleado.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        
    }
}
