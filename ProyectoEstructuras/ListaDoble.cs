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
    public partial class ListaDoble : Form
    {
        CListaDoble lista;
        public ListaDoble()
        {
            InitializeComponent();
            txtDato.Clear();
            txtLista.Clear();
            lista = new CListaDoble();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
            {
                MessageBox.Show("El dato ya existe en la lista");
                return;
            }
            lista.Agregar(txtDato.Text);
            txtLista.Text = lista.ToString();
            txtDato.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
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
            if (lista.Buscar(txtDato.Text))
            {
                lista.Eliminar(txtDato.Text);
                txtLista.Text = lista.ToString();
                txtDato.Clear();
                return;
            }
            MessageBox.Show("El dato no existe en la lista");
            txtDato.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lista = new CListaDoble();
            txtDato.Clear();
            txtLista.Clear();
        }
    }
}
