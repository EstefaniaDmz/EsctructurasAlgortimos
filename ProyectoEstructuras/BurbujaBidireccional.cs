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
    public partial class BurbujaBidireccional : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public BurbujaBidireccional()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
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
            Bubble(numeros);
            tiempo.Stop();
            Imprimir();
        }

        public void Bubble(int[] arreglo)
        {
            bool bandera = true;
            int inicio = 0;
            int fin = arreglo.Length;

            while (bandera == true)
            {
                bandera = false;
                for (int i = inicio; i < fin - 1; ++i)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        comparaciones++;
                        movimientos++;
                        int temp = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = temp;
                        bandera = true;
                    }
                }
                if (bandera == false)
                {
                    break;
                }
                bandera = false;
                fin = fin - 1;
                for (int i = fin - 1; i >= inicio; i--)
                {
                    if (arreglo[i] > arreglo[i + 1])
                    {
                        comparaciones++;
                        movimientos++;
                        int temp = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = temp;
                        bandera = true;
                    }
                }
                inicio += 1;
            }
        }

        public void BubbleDes(int[] arreglo)
        {
            bool bandera = true;
            int inicio = 0;
            int fin = arreglo.Length;

            while (bandera == true)
            {
                bandera = false;
                for (int i = inicio; i < fin - 1; ++i)
                {
                    if (arreglo[i] < arreglo[i + 1])
                    {
                        comparaciones++;
                        movimientos++;
                        int temp = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = temp;
                        bandera = true;
                    }
                }
                if (bandera == false)
                {
                    break;
                }
                bandera = false;
                fin = fin - 1;
                for (int i = fin - 1; i >= inicio; i--)
                {
                    if (arreglo[i] < arreglo[i + 1])
                    {
                        comparaciones++;
                        movimientos++;
                        int temp = arreglo[i];
                        arreglo[i] = arreglo[i + 1];
                        arreglo[i + 1] = temp;
                        bandera = true;
                    }
                }
                inicio += 1;
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
            BubbleDes(numeros);
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
