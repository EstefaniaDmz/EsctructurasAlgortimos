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
    public partial class Pila : Form
    {
        CPila pilita;
        public Pila()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pilita.Push(txtDato.Text);
            txtCola.Text = pilita.ToString();
            txtDato.Clear();
        }

        private void Pila_Load(object sender, EventArgs e)
        {
            txtCola.Clear();
            txtDato.Clear();
            pilita = new CPila();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pilita.Pop();
            txtCola.Text = pilita.ToString();
        }
    }
}
