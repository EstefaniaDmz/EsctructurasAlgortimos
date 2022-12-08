using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuras
{
    public partial class Bicola : Form
    {
        public Bicola()
        {
            InitializeComponent();
        }
        CBicola bicola;
        private void Bicola_Load(object sender, EventArgs e)
        {
            bicola = new CBicola();
            txtCola.Clear();
            txtDato.Clear();
        }

        private void btnAddH_Click(object sender, EventArgs e)
        {
            bicola.AgregarFrente(txtDato.Text);
            txtDato.Clear();
            txtCola.Text = bicola.ToString();
        }

        private void btnAddT_Click(object sender, EventArgs e)
        {
            bicola.AgregarFinal(txtDato.Text);
            txtDato.Clear();
            txtCola.Text = bicola.ToString();
        }

        private void btnDelH_Click(object sender, EventArgs e)
        {
            bicola.EliminarFrente();
            txtCola.Text = bicola.ToString();
        }

        private void btnDelT_Click(object sender, EventArgs e)
        {
            bicola.EliminarFinal();
            txtCola.Text = bicola.ToString();
        }
    }
}
