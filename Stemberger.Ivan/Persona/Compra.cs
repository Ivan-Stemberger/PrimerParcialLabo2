using System;
using System.Collections.Generic;
using System.Text;

namespace Persona
{
    public class Compra : Producto
    {
        float precioFinal;
        public float PrecioFinal { get; set; }

        string empleado;

        public string Empleado { get; set; }

        public Compra()
        {
            Nombre = "";
            Cantidad = "0";
            PrecioUnitario = "0";
            PrecioFinal = 0;
            Empleado = "";
            
        }

        public Compra(string Nombre, string PrecioUnitario, string Cantidad, float precioFinal,string empleado)
        {
            this.Nombre = Nombre;
            this.PrecioUnitario = PrecioUnitario;
            this.Cantidad = Cantidad;
            this.PrecioFinal = precioFinal;
            this.Empleado = empleado;
        }


        /// <summary>
        /// Calcula el precio final de una compra
        /// </summary>
        /// <param name="cantidad">Cantidad de producto vendido en la compra.</param>
        /// <param name="precioUnitario">Precio de cada unidad de producto.</param>
        /// <returns>Devuelve el resultante de la multiplicación de los dos parámentros.</returns>
        public float calcularPrecioFinal(string cantidad, string precioUnitario)
        {
            float cantidad1 = float.Parse(cantidad);
            float precio = float.Parse(precioUnitario);
            float precioFinal;

            precioFinal = cantidad1 * precio;

            return precioFinal;
        }
        
        
        /// <summary>
        /// Inicializa una lista de compras con 50 compras para pruebas.
        /// </summary>
        /// <returns>Lista de compras con 50 items.</returns>
        public List<Compra> inicializarListaDeCompras()
        {
            List<Compra> listaDeCompras = new List<Compra>();

            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "4",calcularPrecioFinal("4","3,20"),"Apu"));
            listaDeCompras.Add(new Compra("Helado Frutilla", "3,20", "5", calcularPrecioFinal("5", "3,20"), "Apu"));
            listaDeCompras.Add(new Compra("Fuegos Artificiales (ACME)", "11,20", "4", calcularPrecioFinal("1", "11,20"), "Apu"));
            listaDeCompras.Add(new Compra("Desodorante", "5", "6", calcularPrecioFinal("6", "5"), "Apu"));
            listaDeCompras.Add(new Compra("Leche 'Tony el Gordo' ", "2", "150", calcularPrecioFinal("150", "2"), "Apu"));
            listaDeCompras.Add(new Compra("Cerveza Duff", "3", "7", calcularPrecioFinal("7", "3"), "Apu"));
            listaDeCompras.Add(new Compra("Hot Dog", "1,25", "4", calcularPrecioFinal("4", "1,25"), "Apu"));
            listaDeCompras.Add(new Compra("Manaos", "1,25", "4", calcularPrecioFinal("4", "1,25"), "Apu"));
            listaDeCompras.Add(new Compra("Coca-cola", "2,25", "4", calcularPrecioFinal("4", "2,25"), "Apu"));
            listaDeCompras.Add(new Compra("Sprite", "2,25", "4", calcularPrecioFinal("4", "2,25"), "Apu"));
            listaDeCompras.Add(new Compra("Banderas americanas", "5", "3", calcularPrecioFinal("3", "5"), "Apu"));
            listaDeCompras.Add(new Compra("Revolver .38", "120", "1", calcularPrecioFinal("1", "120"), "Apu"));
            listaDeCompras.Add(new Compra("Alcohól en gel", "24", "12", calcularPrecioFinal("12", "24"), "Apu"));
            listaDeCompras.Add(new Compra("Helado Chocolate", "3", "2", calcularPrecioFinal("2", "3"), "Apu"));
            listaDeCompras.Add(new Compra("Bombon Helado", "3", "2", calcularPrecioFinal("2", "3"), "Apu"));
            listaDeCompras.Add(new Compra("Agua", "3", "6", calcularPrecioFinal("6", "3"), "Apu"));
            listaDeCompras.Add(new Compra("Bebidas energizantes", "5", "7", calcularPrecioFinal("7", "5"), "Apu"));
            listaDeCompras.Add(new Compra("Alcohól en gel", "24", "8", calcularPrecioFinal("8", "24"), "Apu"));
            listaDeCompras.Add(new Compra("Donas", "3", "32", calcularPrecioFinal("32", "3"), "Apu"));
            listaDeCompras.Add(new Compra("Desinfectante", "4", "2", calcularPrecioFinal("2", "4"), "Apu"));
            listaDeCompras.Add(new Compra("Lavandina", "2", "5", calcularPrecioFinal("5", "2"), "José"));
            listaDeCompras.Add(new Compra("Esponja", "2,50", "2", calcularPrecioFinal("2", "2,50"), "José"));
            listaDeCompras.Add(new Compra("Servilletas", "2", "12", calcularPrecioFinal("12", "2"), "José"));
            listaDeCompras.Add(new Compra("Toallas", "7", "3", calcularPrecioFinal("3", "7"), "José"));
            listaDeCompras.Add(new Compra("Papel Higiénico", "2", "6", calcularPrecioFinal("6", "2"), "José"));
            listaDeCompras.Add(new Compra("Jabón líquido", "6", "6", calcularPrecioFinal("6", "6"), "José"));
            listaDeCompras.Add(new Compra("Alcohól en gel", "24", "18", calcularPrecioFinal("24", "18"), "Apu"));
            listaDeCompras.Add(new Compra("Crema para Manos", "12", "12", calcularPrecioFinal("12", "12"), "José"));
            listaDeCompras.Add(new Compra("Alcohól en gel", "24", "12", calcularPrecioFinal("12", "24"), "José"));
            listaDeCompras.Add(new Compra("Quita esmalte", "3", "2", calcularPrecioFinal("2", "3"), "José"));
            listaDeCompras.Add(new Compra("Alcohól en gel", "24", "5", calcularPrecioFinal("5", "24"), "José"));
            listaDeCompras.Add(new Compra("Escopeta", "122", "1", calcularPrecioFinal("1", "122"), "José"));
            listaDeCompras.Add(new Compra("Alcohól en gel", "24", "11", calcularPrecioFinal("11", "24"), "José"));
            listaDeCompras.Add(new Compra("Quita esmalte", "3", "2", calcularPrecioFinal("2", "3"), "José"));
            listaDeCompras.Add(new Compra("Coca-cola", "2,25", "4", calcularPrecioFinal("4", "3,20"), "José"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "5", calcularPrecioFinal("5", "3,20"), "José"));
            listaDeCompras.Add(new Compra("Papel Higiénico", "2", "6", calcularPrecioFinal("6", "3,20"), "José"));
            listaDeCompras.Add(new Compra("Coca-cola", "2,25", "2", calcularPrecioFinal("2", "3,20"), "José"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "7", calcularPrecioFinal("7", "3,20"), "José"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "12", calcularPrecioFinal("12", "3,20"), "José"));
            listaDeCompras.Add(new Compra("Coca-cola", "2,25", "2", calcularPrecioFinal("2", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Quita esmalte", "3", "5", calcularPrecioFinal("5", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "15", calcularPrecioFinal("15", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Papel Higiénico", "2", "12", calcularPrecioFinal("12", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "1", calcularPrecioFinal("1", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Coca-cola", "2,25", "2", calcularPrecioFinal("2", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "4", calcularPrecioFinal("4", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "4", calcularPrecioFinal("4", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Papel Higiénico", "2", "4", calcularPrecioFinal("4", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "4", calcularPrecioFinal("4", "3,20"), "Pepe"));
            listaDeCompras.Add(new Compra("Hamburguesas", "3,20", "4", calcularPrecioFinal("4", "3,20"), "Pepe"));

            return listaDeCompras;

        }

        
               
    }
}
