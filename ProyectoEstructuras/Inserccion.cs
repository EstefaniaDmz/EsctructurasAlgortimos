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
    public partial class Inserccion : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public Inserccion()
        {
            InitializeComponent();
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

        private void Limpiar()
        {
            txtResultado.Clear();
            txtNum.Clear();
            movimientos = comparaciones = 0;
            tiempo.Reset();
            numeros = null;
        }
        public void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arreglo[i];
                int j = i - 1;

                while (j >= 0 && arreglo[j] > key)
                {
                    comparaciones++;
                    arreglo[j + 1] = arreglo[j];
                    j = j - 1;
                }
                arreglo[j + 1] = key;
                movimientos++;
            }
        }
        public void OrdenarDes(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arreglo[i];
                int j = i - 1;

                while (j >= 0 && arreglo[j] < key)
                {
                    comparaciones++;
                    arreglo[j + 1] = arreglo[j];
                    j = j - 1;
                }
                arreglo[j + 1] = key;
                movimientos++;
            }
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
            Ordenar(numeros);
            tiempo.Stop();
            Imprimir();
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
            OrdenarDes(numeros);
            tiempo.Stop();
            Imprimir();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Imprimir()
        {
            string cadena = "Arreglo ordenado: ";
            for (int i = 0; i < numeros.Length; i++)
            {
                cadena += numeros[i] + ", ";
            }
            cadena += "\r\nMovimientos: " + movimientos + "\r\nComparaciones: " + comparaciones
                + "\r\nTiempo: " + tiempo.Elapsed.TotalMilliseconds + " milisegundos.";
            txtResultado.Text = cadena;
            movimientos = comparaciones = 0;
            tiempo.Reset();
        }
    }
}
