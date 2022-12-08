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
    public partial class Quicksorting : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public Quicksorting()
        {
            InitializeComponent();
        }

        private void Quicksorting_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void quicksort(int[] arreglo, int primero, int ultimo)
        {
            int inicio, final, pivote;
            inicio = primero;
            final = ultimo;
            pivote = arreglo[inicio];
            do
            {
                while (arreglo[inicio] < pivote)
                {
                    inicio++;
                }
                while (arreglo[final] > pivote)
                {
                    final--;
                }
                if (inicio <= final)
                {
                    comparaciones++;
                    if (inicio < final)
                    {
                        int temp = arreglo[inicio];
                        arreglo[inicio] = arreglo[final];
                        arreglo[final] = temp;
                        movimientos++;
                    }
                    inicio++;
                    final--;
                }

            } while (inicio <= final);
            if (primero < final)
            {
                quicksort(arreglo, primero, final);
            }
            if (inicio < ultimo)
            {
                quicksort(arreglo, inicio, ultimo);
            }
        }

        private void quicksortDes(int[] arreglo, int primero, int ultimo)
        {
            int inicio, final, pivote;
            inicio = primero;
            final = ultimo;
            pivote = arreglo[inicio];
            do
            {
                while (arreglo[inicio] > pivote)
                {
                    inicio++;
                }
                while (arreglo[final] < pivote)
                {
                    final--;
                }
                if (inicio <= final)
                {
                    comparaciones++;
                    if (inicio < final)
                    {
                        int temp = arreglo[inicio];
                        arreglo[inicio] = arreglo[final];
                        arreglo[final] = temp;
                        movimientos++;
                    }
                    inicio++;
                    final--;
                }

            } while (inicio <= final);
            if (primero < final)
            {
                quicksortDes(arreglo, primero, final);
            }
            if (inicio < ultimo)
            {
                quicksortDes(arreglo, inicio, ultimo);
            }
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

        private void btnDoDes_Click(object sender, EventArgs e)
        {
            string[] arreglo = txtNum.Text.Split(',');
            numeros = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                numeros[i] = Convert.ToInt32(arreglo[i]);
            }
            tiempo.Start();
            quicksortDes(numeros, 0, (numeros.Length - 1));
            tiempo.Stop();
            Imprimir();
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
            quicksort(numeros, 0, (numeros.Length - 1));
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
