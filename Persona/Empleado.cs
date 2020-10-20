using System;
using System.Collections.Generic;
using System.Text;

namespace Persona
{
    public class Empleado : Persona
    {
        string edad;

        public string Edad
        {
            get { return edad; }
            set { this.edad = value; }
        }

        string legajo;

        public string Legajo
        {
            get { return legajo; }
            set { this.legajo = value; }
        }

        public bool IsActive;

        string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { this.contraseña = value; }
        }


        public Empleado()
        {
            this.Nombre = " ";
            this.Apellido = " ";
            this.Edad = " ";
            this.Legajo = " ";
            this.IsActive = false;
            this.Contraseña = " ";
        }

        public Empleado(string nombre, string apellido, string edad, string legajo,bool isActive, string contraseña)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Legajo = legajo;
            this.IsActive = false;
            this.Contraseña = contraseña;
        }

        /// <summary>
        /// Crea el primer empleado para poder loggearse por primera vez a la aplicación.
        /// </summary>
        /// <returns>Regresa un empleado ya creado.</returns>
        public Empleado inicializarEmpleado()
        {
            Empleado empleado = new Empleado();
            
            empleado.Nombre = "Apu";
            empleado.Apellido = "Nahasapeemapetilon";
            empleado.Edad = "45";
            empleado.Legajo = "1";
            empleado.IsActive = false;
            empleado.Contraseña = empleado.Legajo;

            return empleado;
        }

        /// <summary>
        /// Verifica que la contraseña ingresada coincida con la contraseña del usuario.
        /// </summary>
        /// <param name="empleados">Lista de todos los empleados</param>
        /// <param name="nombre">nombre del empleado ingresado en el login</param>
        /// <param name="contraseña">contraseña ingresada en el login.</param>
        /// <returns>Regresa True si la contraseña y usuario coinciden. De lo contrario, False.</returns>
        public bool confirmarContraseña (List<Empleado> empleados, string nombre, string contraseña)
        {
            bool flag = false;
            
            foreach(Empleado empleado in empleados)
            {
                if(empleado.contraseña == contraseña && empleado.Nombre == nombre)
                {
                    flag = true;
                    empleado.IsActive = true;
                }
                
            }
            return flag;
        }

        /// <summary>
        /// Genera dos usuarios como prueba.
        /// </summary>
        /// <param name="empleados">Lista de empleados que recibe para agregar los usuarios creados.</param>
        /// <returns>Regresa la lista de empleados con las nuevas creaciones.</returns>
        public List<Empleado> prueba(List<Empleado> empleados)
        {
            empleados.Add(new Empleado("José", "Gonzalez", "25", "2", false, "2"));
            empleados.Add(new Empleado("Pepe", "Fernandez", "23", "3", false, "3"));

            return empleados;
        }


    }

    
}
