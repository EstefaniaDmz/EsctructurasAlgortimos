using System;
using System.Collections;
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
    public partial class ListaDobleCircular : Form
    {
        CListaDobleCircular doble;
        public ListaDobleCircular()
        {
            InitializeComponent();
            doble = new CListaDobleCircular();
            txtLista.Clear();
            txtDato.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (doble.Buscar(txtDato.Text))
            {
                MessageBox.Show("El dato ya existe en la lista");
                return;
            }
            doble.Agregar(txtDato.Text);
            txtLista.Text = doble.ToString();
            txtDato.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (doble.Buscar(txtDato.Text))
            {
                MessageBox.Show("El dato " + txtDato.Text + " sí existe en la lista");
            }
            else
            {
                MessageBox.Show("El dato no existe en la lista");
            }
            txtDato.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (doble.Buscar(txtDato.Text))
            {
                doble.Eliminar(txtDato.Text);
                txtLista.Text = doble.ToString();
                txtDato.Clear();
                return;
            }
            MessageBox.Show("El dato no existe en la lista");
            txtDato.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            doble = new CListaDobleCircular();
            txtDato.Clear();
            txtLista.Clear();
        }
    }
}
