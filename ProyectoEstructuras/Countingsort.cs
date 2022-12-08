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
    public partial class Countingsort : Form
    {
        int[] numeros;
        int movimientos = 0, comparaciones = 0;
        Stopwatch tiempo = new Stopwatch();
        public Countingsort()
        {
            InitializeComponent();
            Limpiar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

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
            CountingSort(numeros);
            tiempo.Stop();
            Imprimir();
        }
        private void CountingSort(int[] array)
        {
            int min = 0;
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < min)
                {
                    min = array[i];
                    comparaciones++;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    comparaciones++;
                }
            }
            int[] count = new int[max - min + 1];
            int z = 0;
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }
            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    array[z] = i;
                    ++z;
                    movimientos++;
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
            CountingSort(numeros);
            tiempo.Stop();
            Array.Reverse(numeros);
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
