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
    public partial class ColaPrioridad : Form
    {
        public ColaPrioridad()
        {
            InitializeComponent();
        }
        CColaPrioridad prio;
        private void btnNum_Click(object sender, EventArgs e)
        {
            prio.CrearArreglo(int.Parse(txtNum.Text));
            grbFirst.Visible = false;
            grbSec.Visible = true;
        }

        private void ColaPrioridad_Load(object sender, EventArgs e)
        {
            prio = new CColaPrioridad();
            grbFirst.Visible = true;
            grbSec.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NodoP nuevo = new NodoP();
            nuevo.Dato = txtDato.Text;
            nuevo.Prioridad = int.Parse(txtPri.Text);
            prio.Agregar(nuevo);
            txtDato.Text = "";
            txtPri.Text = "";
            txtCola.Text = prio.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            prio.Eliminar();
            txtCola.Text = prio.ToString();
        }
    }
}
