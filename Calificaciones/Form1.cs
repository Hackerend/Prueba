using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTotal.Visible = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtTotal.Text = "";
            double sueldo = double.Parse(txtSueldo.Text);
            double total;
            if (sueldo >= 1500.00)
            {
                total = sueldo * 0.17;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Text = sueldo.ToString();
            }
            txtTotal.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtSueldo.Text = "";
            txtTotal.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
