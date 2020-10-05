using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona;


namespace Stemberger.Ivan
{
    public partial class FrmCompras : Form
    {

        List<Compra> listaCompra;
        List<Producto> listaDeProductos;
        List<Empleado> listaEmpleados;
        List<Cliente> listaClientes;
        List<Compra> compras;
        Compra compra;
        public FrmCompras()
        {
            InitializeComponent();
            compra = new Compra();
            listaDeProductos = new List<Producto>();
            listaCompra = new List<Compra>();
            listaClientes = new List<Cliente>();
            compras = new List<Compra>();
        }

        private void btnAddCompra_Click(object sender, EventArgs e)
        {
            bool flag = false;
            float cantidad;
            float precio;
            float precioCompra = 0;
            Cliente cliente = new Cliente();
            
            
            compra.Nombre = txtProductoCompra.Text;
            compra.Cantidad = txtCantidadCompra.Text;
            cliente.Nombre = txtClienteNombre.Text;
            cliente.Apellido = txtClienteApellido.Text;

            if(cliente.newClient(listaClientes,cliente))
            {
                DialogResult dialogResult = MessageBox.Show("¿El cliente no existe. Desea agregarlo a la lista de clientes?", "Cliente no encontrado", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    listaClientes.Add(cliente);
                }
                
            }
             

            foreach (Producto producto in listaDeProductos)
            {


                if (producto.Nombre == compra.Nombre)
                {
                    compra.PrecioUnitario = producto.PrecioUnitario;
                    flag = true;
                    break;
                }

            }

            if (flag)
            {
                precio = float.Parse(compra.PrecioUnitario);
                cantidad = float.Parse(compra.Cantidad);


                foreach (Empleado empleado in listaEmpleados)
                {
                    if (empleado.IsActive)
                    {
                        compra.Empleado = empleado.Nombre;

                    }
                }


                compra.PrecioFinal = cantidad * precio;
                
                
                compras.Add(new Compra(compra.Nombre, compra.PrecioUnitario, compra.Cantidad, compra.PrecioFinal,compra.Empleado));


                foreach (Compra compra in compras)
                {
                    precioCompra = precioCompra + compra.PrecioFinal;

                }

                if (cliente.validateSimpson(cliente))
                {
                    precioCompra = precioCompra * 87 / 100;
                }

                this.dtgvCompra.DataSource = null;
                this.dtgvCompra.DataSource = compras;

                foreach(Compra compra in compras)
                {
                    listaCompra.Add(compra);
                }
                
                

                this.txtPrecioTotal.Text = precioCompra.ToString();

            }
            else
            {
                MessageBox.Show("No existe el producto");

            }
        }
        /// <summary>
        /// Recibe una lista de productos para ser utilizada en este formulario
        /// </summary>
        /// <param name="listaProductos">Lista de productos recibida.</param>
        public void receive(List<Producto> listaProductos)
        {
            listaDeProductos.AddRange(listaProductos);

        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            if (compras.Count != 0)
            {
                crearTxt();
                foreach (Compra compra in compras)
                {
                    producto.Nombre = compra.Nombre;

                    listaDeProductos = producto.reducciónStock(producto, listaDeProductos, compra.Cantidad);

                }


                MessageBox.Show("Gracias!! Vuelva prontosss");                
            }

            
            compras.Clear();
            clear();

            this.Hide();
        
        }
        /// <summary>
        /// Crea un archivo .txt que sirve como Ticket de compra.
        /// </summary>
        private void crearTxt()
        {
            string fileName = @"D:\Ticket.txt";

            try
            {
                   
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Producto" + " " + "Precio Unitario" + " " + "Precio Total");

                    foreach (Compra compra in compras)
                    
                    
                    sw.WriteLine(compra.Nombre +" " + compra.PrecioUnitario + " " + compra.PrecioFinal);
                    
                }

                
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }


        }

        /// <summary>
        /// Vacía todos los campos de este formulario.
        /// </summary>
        private void clear()
        {
            txtProductoCompra.Text = "";
            txtCantidadCompra.Text = "";
            txtClienteNombre.Text = "";
            txtClienteApellido.Text = "";
            txtPrecioTotal.Text = "";
            dtgvCompra.DataSource = null;
        }
        /// <summary>
        /// Envía una lista de compras a donde sea que se requiera.
        /// </summary>
        /// <returns>Retorna una lista de compras.</returns>
        public List<Compra> sendCompra()
        {
            return listaCompra;

        }
        /// <summary>
        /// Recive una lista de empleados para ser utilizados en este formulario.
        /// </summary>
        /// <param name="empleados">Lista de empleados.</param>
        public void receiveEmpleados(List<Empleado> empleados)
        {
            listaEmpleados = empleados;

        }

        
    }
}
