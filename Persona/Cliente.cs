using System;
using System.Collections.Generic;
using System.Text;

namespace Persona
{
    public class Cliente : Persona
    {
        

        /// <summary>
        /// Verificar si el cliente recibido existe o si es nuevo
        /// </summary>
        /// <param name="listaClientes">Recibe una lista de clientes.</param>
        /// <param name="cliente">Recibe un cliente para cotejarlo con la de lista de clientes.</param>
        /// <returns>Regresa True si es un cliente nuevo y False si ya existe.</returns>
        public bool newClient(List<Cliente> listaClientes, Cliente cliente)
        {

            foreach (Cliente cliente1 in listaClientes)
            {
                if(cliente.Nombre == cliente1.Nombre)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Valida si el cliente es un miembro de la familia Simpson o no
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Regresa True si es Simpson. Sino, False.</returns>
        public bool validateSimpson(Cliente cliente)
        {

            if (cliente.Apellido == "Simpson")
            {
                return true;
            }
            
            return false;

        }



    }
}
