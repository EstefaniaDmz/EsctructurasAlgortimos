using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuras
{
    public partial class OrdenamientoABcs : Form
    {
        int[] numeros;
        string ordenado;
        int movimientos, comparaciones;
        COrdenamientoAB arbol;
        Stopwatch tiempo = new Stopwatch();
        public OrdenamientoABcs()
        {
            InitializeComponent();
            Limpiar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            Random r = new Random();
            int tamaño = r.Next(3, 25);
            string cadena = "";
            for (int i = 0; i < tamaño; i++)
            {
                cadena += r.Next(-99, 99).ToString() + ",";
            }
            cadena += r.Next(-99, 99).ToString();
            txtNum.Text = cadena;
        }

        private void btnDoAsc_Click(object sender, EventArgs e)
        {
            string[] arreglo = txtNum.Text.Split(',');
            numeros = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                numeros[i] = Convert.ToInt32(arreglo[i]);
            }
            tiempo.Start();
            for (int i = 0; i < numeros.Length; i++)
            {
                arbol.Insertar(numeros[i], false);
            }
            tiempo.Stop();
            ordenado = arbol.Inorden();
            Imprimir();
        }

        private void Limpiar()
        {
            txtResultado.Clear();
            txtNum.Clear();
            movimientos = comparaciones = 0;
            tiempo.Reset();
            numeros = null;
            ordenado = null;
            arbol = new COrdenamientoAB();
        }

        private void btnDoDes_Click(object sender, EventArgs e)
        {
            string[] arreglo = txtNum.Text.Split(',');
            numeros = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                numeros[i] = Convert.ToInt32(arreglo[i]);
            }
            tiempo.Start();
            for (int i = 0; i < numeros.Length; i++)
            {
                arbol.Insertar(numeros[i], true);
            }
            tiempo.Stop();
            ordenado = arbol.Inorden();
            Imprimir();
        }

        private void Imprimir()
        {
            string cadena = "Arreglo ordenado: " + ordenado + "\r\nMovimientos: " + movimientos + "\r\nComparaciones: " + comparaciones
                + "\r\nTiempo: " + tiempo.Elapsed.TotalMilliseconds + " milisegundos.";
            txtResultado.Text = cadena;
            movimientos = comparaciones = 0;
            tiempo.Reset();
            ordenado = null;
            arbol = new COrdenamientoAB();
        }
    }
}
