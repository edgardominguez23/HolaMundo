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
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");

            if (string.IsNullOrEmpty(txtContrasenaUno.Text) && 
               string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }

            if (!txtContrasenaUno.Text.Equals(txtContrasenaDos.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }

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
