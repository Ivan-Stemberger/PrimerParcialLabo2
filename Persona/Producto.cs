using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Persona
{
    public class Producto
    {
        string nombre;

        public string Nombre
        {

            get { return nombre; }
            set {this.nombre = value; }

        }

        string precioUnitario;

        public string PrecioUnitario
        {
            get { return precioUnitario; }
            set {
                    if (validarFloat(value))
                    { 
                        this.precioUnitario = value;
                    }
                }
          
        }

        string cantidad;

        public string Cantidad
        {
            get { return cantidad; }
            set { 
                
                    if(validarInt(value))
                    {
                        this.cantidad = value;
                    }
                
                }
              
        }

        public Producto()
        {
            this.nombre = "";
            this.precioUnitario = "";
            this.cantidad = "";

        }

        public Producto(string nombre, string precioUnitario, string cantidad)
        {
            this.nombre = nombre;
            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;

        }
        /// <summary>
        /// Inicializa una Lista de Productos para prueba.
        /// </summary>
        /// <returns>Devuelve una Lista de Productos con 30 items.</returns>
        public List<Producto> inicializarListaProductos()
        {
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto("Hamburguesas", "3,20", "4"));
            productos.Add(new Producto("Helado Frutilla", "3,20", "5"));
            productos.Add(new Producto("Fuegos Artificiales (ACME)", "11,20", "4"));
            productos.Add(new Producto("Desodorante", "5", "6"));
            productos.Add(new Producto("Leche 'Tony el Gordo' ", "2", "150"));
            productos.Add(new Producto("Cerveza Duff", "3", "7"));
            productos.Add(new Producto("Hot Dog", "1,25", "4"));
            productos.Add(new Producto("Manaos", "1,25", "4"));
            productos.Add(new Producto("Coca-cola", "2,25", "4"));
            productos.Add(new Producto("Sprite", "2,25", "4"));
            productos.Add(new Producto("Banderas americanas", "5", "3"));
            productos.Add(new Producto("Revolver .38", "120", "1"));
            productos.Add(new Producto("Alcohól en gel", "24", "12"));
            productos.Add(new Producto("Helado Chocolate", "3", "2"));
            productos.Add(new Producto("Bombon Helado", "3", "2"));
            productos.Add(new Producto("Agua", "3", "6"));
            productos.Add(new Producto("Bebidas energizantes", "5", "7"));
            productos.Add(new Producto("Alcohól en gel", "24", "8"));
            productos.Add(new Producto("Donas", "3", "32"));
            productos.Add(new Producto("Desinfectante", "4", "2"));
            productos.Add(new Producto("Lavandina", "2", "5"));
            productos.Add(new Producto("Esponja", "2,50", "2"));
            productos.Add(new Producto("Servilletas", "2", "12"));
            productos.Add(new Producto("Toallas", "7", "3"));
            productos.Add(new Producto("Papel Higiénico", "2", "6"));
            productos.Add(new Producto("Jabón líquido", "6", "6"));
            productos.Add(new Producto("Escopeta", "122", "1"));
            productos.Add(new Producto("Quita esmalte", "3", "2"));
            productos.Add(new Producto("Crema para Manos", "12", "12"));
            productos.Add(new Producto("Limón para que chupe el doctor", "1,5", "20"));

            return productos;
        }

       /// <summary>
       /// Reduce el stock de producto en función de la cantidad comprada.
       /// </summary>
       /// <param name="producto">El producto comprado.</param>
       /// <param name="productos">Lista con todos los productos.</param>
       /// <param name="cantidadComprada">Cantidad de elementos comprados.</param>
       /// <returns>Devuelve la lista de productos con la actualización de Stock.</returns>
        public List<Producto> reducciónStock(Producto producto, List<Producto> productos, string cantidadComprada)
        {

            int cantidadStock;
            int cantidadCompra = int.Parse(cantidadComprada);
            
            foreach(Producto producto1 in productos)
            {
                if(producto1.nombre == producto.nombre)
                {
                    cantidadStock = int.Parse(producto1.cantidad);
                    
                    producto.cantidad = (cantidadStock - cantidadCompra).ToString(); 

                }

            }

            return productos;
        }
        
        /// <summary>
        /// Valida si los datos ingresados en el campo pueden ser convertidos en tipo float.
        /// </summary>
        /// <param name="string1">El string que será asignado a la propiedad.</param>
        /// <returns>True si el string puede ser convertido en Float. Caso contrario, False.</returns>
        public static bool validarFloat(string string1)
        {
            float aux;

            if(float.TryParse(string1,out aux))
            {
                return true;

            }
            return false;
            

        }

        /// <summary>
        /// Valida si los datos ingresados en el campo pueden ser convertidos en tipo int.
        /// </summary>
        /// <param name="string1">El string que será asignado a la propiedad.</param>
        /// <returns>True si el string puede ser convertido en tnt. Caso contrario, False.</returns>
        public static bool validarInt(string string1)
        {
            int aux;

            if (int.TryParse(string1, out aux))
            {
                return true;

            }
            return false;


        }

    }
}
