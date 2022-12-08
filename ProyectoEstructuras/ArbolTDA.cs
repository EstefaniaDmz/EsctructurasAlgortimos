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
    public partial class ArbolTDA : Form
    {
        string r = "";
        string[] arreglo;
        int Dato = 0;
        int massimo = 0;
        int minino = 0;
        ArbolBinario MiArbol = new ArbolBinario();
        Graphics g;
        int enc = 0;
        int multiplo = 0;
        bool iden = false;
        bool enor = false;
        bool preor = false;
        bool posor = false;
        bool alt = false;
        public ArbolTDA()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNodo.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor ");
            }
            else
            {
                Dato = int.Parse(txtNodo.Text);
                r += Dato.ToString() + " ";
                if (massimo == 0)
                {
                    massimo = Dato;
                    minino = Dato;
                }
                else
                {
                    if (massimo < Dato)
                    {
                        massimo = Dato;
                    }
                    if (minino > Dato)
                    {
                        minino = Dato;
                    }
                }
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    MiArbol.Insertar(Dato);
                    txtNodo.Clear();
                    txtNodo.Focus();

                    enc = 0;
                    Refresh();
                    Refresh();
                }
            }
        }

        private void ArbolTDA_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

            if (enor == true || posor == true || preor == true)
            {
                MiArbol.Colorear(g, this.Font, Brushes.DarkBlue, Brushes.White, Pens.White, MiArbol.RaizArbol(), enor, preor, posor);
            }
            else if (iden == true)
            {
                MiArbol.DibujarArbol(g, this.Font, Brushes.DarkBlue, Brushes.White, Pens.Black, Brushes.Black, enc, multiplo, massimo, minino);
            }
            else if (alt == true)
            {
                MessageBox.Show("Altura: " + (MiArbol.altura));
            }
            else
            {
                MiArbol.DibujarArbol(g, this.Font, Brushes.DarkBlue, Brushes.White, Pens.Black, Brushes.Black, enc, multiplo, 0, 0);
            }

            preor = false;
            enor = false;
            posor = false;
            iden = false;
            alt = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNodo.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor ");
            }
            else
            {
                Dato = int.Parse(txtNodo.Text);
                MiArbol.Eliminar(Dato);
                txtNodo.Clear();
                txtNodo.Focus();

                enc = 0;
                Refresh();
                Refresh();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNodo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtNodo.Text);
                enc = Dato;
                MiArbol.Buscar(Dato);
                txtNodo.Clear();
                txtNodo.Focus();
                Refresh();
                Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamano = (r.Length) / 2;

            arreglo = r.Split(' ');

            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                abo.Insertar(arreglo[i]);
            }

            if (rbtnOrden.Checked == true)
            {
                preor = true;
                abo.PreOrden();
            }

            else if (rbtnPreOrden.Checked == true)
            {
                posor = true;
                abo.PostOrden();
            }
            else if (rbtnPostOrden.Checked == true)
            {
                enor = true;
                abo.EnOrden();
            }
            Refresh();
            Refresh();
        }

        private void btnIdentif_Click(object sender, EventArgs e)
        {
            iden = true;
            Refresh();
        }

        private void btnDetAlt_Click(object sender, EventArgs e)
        {
            alt = true;
        }
    }
}
