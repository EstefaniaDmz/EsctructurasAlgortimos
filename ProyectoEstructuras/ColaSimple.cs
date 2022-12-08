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
    public partial class ColaSimple : Form
    {
        public ColaSimple()
        {
            InitializeComponent();
        }
        CCola simple;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            simple.Agregar(txtDato.Text);
            txtCola.Text = simple.ToString();
            txtDato.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            simple.Eliminar();
            txtCola.Text = simple.ToString();
        }

        private void colasimple_Load(object sender, EventArgs e)
        {
            txtDato.Clear();
            txtCola.Clear();
            simple = new CCola();
        }
    }
}
