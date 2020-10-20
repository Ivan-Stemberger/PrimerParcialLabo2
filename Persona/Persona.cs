using System;
using System.Collections.Generic;

namespace Persona
{
    public abstract class Persona
    {
        string nombre;

        public string Nombre
        {
                       
            get {return nombre; }
            set {
                
                    if(validarString(this.Nombre))
                    { 
                        this.nombre = value;
                    }
                }

        }
        string apellido;

        public string Apellido
        {

            get { return apellido; }
            set
            {

                if (validarString(this.apellido))
                {
                    this.apellido = value;
                }
            }

        }
        /// <summary>
        /// Valida si el dato ingresado contiene solo letras.
        /// </summary>
        /// <param name="string1">String que será asignado a la propiedad.</param>
        /// <returns>True si se trata solo de Letras. Caso contrario, false.</returns>
        public static bool validarString(string string1)
        {
            List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "1","2","3","4","5","6","7","8","9","0" };

            if(string1 != null)
            {
                foreach (string s in invalidChars)
                {
                    if (string1.Contains(s))
                    {
                        return false;
                    }
                }

            }
            
            return true;

        }
    }
}
