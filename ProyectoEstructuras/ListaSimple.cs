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
    public partial class ListaSimple : Form
    {
        CListaSimple lista;
        public ListaSimple()
        {
            InitializeComponent();
        }

        private void ListaSimple_Load(object sender, EventArgs e)
        {
            lista = new CListaSimple();
            txtLista.Clear();
            txtDato.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lista.Encontrado(txtDato.Text))
            {
                MessageBox.Show("El dato ya existe en la lista");
                return;
            }
            lista.Insertar(txtDato.Text);
            txtLista.Text = lista.ToString();
            txtDato.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(lista.Encontrado(txtDato.Text))
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
            if (lista.Encontrado(txtDato.Text))
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
            lista = new CListaSimple();
            txtDato.Clear();
            txtLista.Clear();
        }
    }
}
