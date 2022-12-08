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
    public partial class Burbuja : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public Burbuja()
        {
            InitializeComponent();
            Limpiar();
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
            BubbleSort(numeros);
            tiempo.Stop();
            Imprimir();
        }

        private void BubbleSort(int[] arreglo)
        {
            for (int recorrido = 1; recorrido < arreglo.Length; recorrido++)
            {   
                for (int actual = 0; actual < arreglo.Length - recorrido; actual++)
                {
                    if (arreglo[actual] > arreglo[actual + 1])
                    {
                        int aux = arreglo[actual];
                        arreglo[actual] = arreglo[actual + 1];
                        arreglo[actual + 1] = aux;
                        movimientos++;
                        comparaciones++;
                    }
                }
            }
        }
        private void BubbleSortDes(int[] arreglo)
        { 
            for (int recorrido = 1; recorrido < arreglo.Length; recorrido++)
            {
                for (int actual = 0; actual < arreglo.Length - recorrido; actual++)
                {
                    if (arreglo[actual] < arreglo[actual + 1])
                    {
                        int aux = arreglo[actual];
                        arreglo[actual] = arreglo[actual + 1];
                        arreglo[actual + 1] = aux;
                        movimientos++;
                        comparaciones++;
                    }
                }
            }
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
            BubbleSortDes(numeros);
            tiempo.Stop();
            Imprimir();
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
