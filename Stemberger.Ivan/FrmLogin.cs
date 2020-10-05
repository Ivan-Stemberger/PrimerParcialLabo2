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
    public partial class FrmLogin : Form
    {

        List<Empleado> empleados;
        Empleado empleado;
        FrmMenú menú;
        public FrmLogin()
        {
            InitializeComponent();
            empleados = new List<Empleado>();
            empleado = new Empleado();
            empleados.Add(empleado.inicializarEmpleado());
            menú = new FrmMenú();
            
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(empleado.confirmarContraseña(empleados,this.txtUsuario.Text,this.txtContraseña.Text))
            {
               
                menú.recibirEmpleados(empleados);
                clear();
                menú.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
            

        }
        /// <summary>
        /// Elimina los ingresado en los campos en este formulario.
        /// </summary>
        private void clear()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";

        }

        private void btnLoginSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Primer ingreso: \n Usuario: Apu \n Contraseña: 1");
        }
    }
}
