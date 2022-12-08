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
    public partial class Selectionsort : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public Selectionsort()
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
        private void btnDoAsc_Click(object sender, EventArgs e)
        {
            string[] arreglo = txtNum.Text.Split(',');
            numeros = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                numeros[i] = Convert.ToInt32(arreglo[i]);
            }
            tiempo.Start();
            SelectionSort(numeros);
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
            SelectionSortDes(numeros);
            tiempo.Stop();
            Imprimir();
        }

        public void SelectionSort(int[] datos)
        {
            int tamaño = datos.Length;
            int minimo = 0;
            int aux = 0;
            for (int i = 0; i < tamaño; i++)
            {
                minimo = i;
                for (int j = i + 1; j < tamaño; j++)
                {
                    comparaciones++;
                    if (datos[j] < datos[minimo])
                    {
                        minimo = j;
                    }
                }
                aux = datos[i];
                datos[i] = datos[minimo];
                datos[minimo] = aux;
                movimientos++;
            }
        }

        public void SelectionSortDes(int[] datos)
        {
            int tamaño = datos.Length;
            int minimo = 0;
            int aux = 0;
            for (int i = 0; i < tamaño; i++)
            {
                minimo = i;
                for (int j = i + 1; j < tamaño; j++)
                {
                    comparaciones++;
                    if (datos[j] > datos[minimo])
                    {
                        minimo = j;
                    }
                }
                aux = datos[i];
                datos[i] = datos[minimo];
                datos[minimo] = aux;
                movimientos++;
            }
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

        private void Limpiar()
        {
            txtResultado.Clear();
            txtNum.Clear();
            movimientos = comparaciones = 0;
            tiempo.Reset();
            numeros = null;
        }
    }
}
