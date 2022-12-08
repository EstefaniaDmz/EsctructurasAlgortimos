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
    public partial class ShellSort : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public ShellSort()
        {
            InitializeComponent();
            Limpiar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void OrdenarArreglo(int[] arreglo)
        {
            int salto = 0;
            int sw = 0;
            int auxiliar = 0;
            int e = 0;
            salto = arreglo.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (arreglo.Length - salto))
                    {
                        if (arreglo[e - 1] > arreglo[(e - 1) + salto])
                        {
                            auxiliar = arreglo[(e - 1) + salto];
                            arreglo[(e - 1) + salto] = arreglo[e - 1];
                            arreglo[e - 1] = auxiliar;
                            sw = 1;
                            comparaciones++;
                        }
                        e++;
                        movimientos++;
                    }
                }
                salto = salto / 2;
            }
        }

        public void OrdenarDes(int[] arreglo)
        {
            int salto = 0;
            int sw = 0;
            int auxiliar = 0;
            int e = 0;
            salto = arreglo.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (arreglo.Length - salto))
                    {
                        if (arreglo[e - 1] < arreglo[(e - 1) + salto])
                        {
                            auxiliar = arreglo[(e - 1) + salto];
                            arreglo[(e - 1) + salto] = arreglo[e - 1];
                            arreglo[e - 1] = auxiliar;
                            sw = 1;
                            comparaciones++;
                        }
                        e++;
                        movimientos++;
                    }
                }
                salto = salto / 2;
            }
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
            OrdenarArreglo(numeros);
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
