using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Expresión regular para validar cadenas con al menos una mayúscula, minúscula, número y carácter especial.
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");

            // Verifica si los campos de contraseña uno y contraseña dos están vacíos.
            if (string.IsNullOrEmpty(txtContrasenaUno.Text) && 
               string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }

            // Verifica si los campos de contraseña uno y contraseña dos son iguales.
            if (!txtContrasenaUno.Text.Equals(txtContrasenaDos.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }

            // Verifica el campo contraseña uno es valido por medio de la expresión regular.
            if (validacion.IsMatch(txtContrasenaUno.Text))
            {
                MessageBox.Show("La contraseña es valida");
                return;
            }
            else
            {
                MessageBox.Show("La contraseña no es valida");
                return;
            }
        }
    }
}
