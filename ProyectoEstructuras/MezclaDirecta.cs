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
    public partial class MezclaDirecta : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public MezclaDirecta()
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
            numeros = MergeSort(numeros);
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
            numeros = MergeSortDes(numeros);
            tiempo.Stop();
            Imprimir();
        }

        private int[] MergeSort(int[] arreglo)
        {
            if(arreglo.Length > 1)
            {
                int i, j, k;
                int nElementosIzq = arreglo.Length / 2;
                int nElementosDer = arreglo.Length - nElementosIzq;
                int[] arregloIzq = new int[nElementosIzq];
                int[] arregloDer = new int[nElementosDer];

                //copiado de elementos al arreglo izquierdo
                for (i = 0; i < nElementosIzq; i++)
                {
                    arregloIzq[i] = arreglo[i];
                    comparaciones++;
                }
                //copiado de elementos al arreglo derecho
                for (i = nElementosIzq; i < (nElementosIzq + nElementosDer); i++)
                {
                    arregloDer[i - nElementosIzq] = arreglo[i];
                    comparaciones++;
                }
                //Recursividad
                arregloIzq = MergeSort(arregloIzq);
                arregloDer = MergeSort(arregloDer);
                i = 0; j = 0; k = 0;

                while (arregloIzq.Length != j && arregloDer.Length != k)
                {
                    if (arregloIzq[j] < arregloDer[k])
                    {
                        arreglo[i] = arregloIzq[j];
                        i++; j++;
                        movimientos++;
                    }
                    else
                    {
                        arreglo[i] = arregloDer[k];
                        i++; k++;
                        movimientos++;
                    }
                }

                //Arreglo final
                while (arregloIzq.Length != j)
                {
                    arreglo[i] = arregloIzq[j];
                    i++; j++;
                }
                while (arregloDer.Length != k)
                {
                    arreglo[i] = arregloDer[k];
                    i++; k++;
                }
            }
            return arreglo;
        }

        private int[] MergeSortDes(int[] arreglo)
        {
            if (arreglo.Length > 1)
            {
                int i, j, k;
                int nElementosIzq = arreglo.Length / 2;
                int nElementosDer = arreglo.Length - nElementosIzq;
                int[] arregloIzq = new int[nElementosIzq];
                int[] arregloDer = new int[nElementosDer];

                //copiado de elementos al arreglo izquierdo
                for (i = 0; i < nElementosIzq; i++)
                {
                    arregloIzq[i] = arreglo[i];
                    comparaciones++;
                }
                //copiado de elementos al arreglo derecho
                for (i = nElementosIzq; i < (nElementosIzq + nElementosDer); i++)
                {
                    arregloDer[i - nElementosIzq] = arreglo[i];
                    comparaciones++;
                }
                //Recursividad
                arregloIzq = MergeSortDes(arregloIzq);
                arregloDer = MergeSortDes(arregloDer);
                i = 0; j = 0; k = 0;

                while (arregloIzq.Length != j && arregloDer.Length != k)
                {
                    if (arregloIzq[j] > arregloDer[k])
                    {
                        arreglo[i] = arregloIzq[j];
                        i++; j++;
                        movimientos++;
                    }
                    else
                    {
                        arreglo[i] = arregloDer[k];
                        i++; k++;
                        movimientos++;
                    }
                }

                //Arreglo final
                while (arregloIzq.Length != j)
                {
                    arreglo[i] = arregloIzq[j];
                    i++; j++;
                }
                while (arregloDer.Length != k)
                {
                    arreglo[i] = arregloDer[k];
                    i++; k++;
                }
            }
            return arreglo;
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
