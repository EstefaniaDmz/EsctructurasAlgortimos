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
    public partial class RadixSort : Form
    {
        int[] numeros;
        int movimientos, comparaciones;
        Stopwatch tiempo = new Stopwatch();
        public RadixSort()
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

        private void Ordenar(int[] arreglo)
        {
            int[] tmp = new int[arreglo.Length];
            //verificar si el cambio es mayor que 1 negativo de lo contrario el programa finaliza
            for (int shift = 31; shift > -1; shift--)
            {
                int j = 0;
                //si i es menor que la longitud de la matriz crea una variable booleana
                for (int i = 0; i < arreglo.Length; i++)
                {
                    bool move = (arreglo[i] << shift) >= 0;
                    //si el valor de shift es cero entonces
                    //no queremos mover los datos por que 
                    //el numero esta en la posicion incorrecta
                    if (shift == 0 ? !move : move)
                    {
                        //manejo el cambio
                        arreglo[i - j] = arreglo[i];
                        movimientos++;
                    }
                    else
                    {
                        //esto continua hasta que el valor de shift ya no es
                        //mayor que uno negativo, significa que ya se pasó por todos los digitos de los numeros
                        tmp[j++] = arreglo[i];
                    }
                }
                //copiaremos la matriz
                Array.Copy(tmp, 0, arreglo, arreglo.Length - j, j);
            }
        }

        private void OrdenarDes(int[] arreglo)
        {
            int[] tmp = new int[arreglo.Length];
            for (int shift = 31; shift > -1; shift--)
            {
                int j = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    bool move = (arreglo[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                    {
                        movimientos++;
                        tmp[j++] = arreglo[i];
                    }
                    else
                    {
                        arreglo[i - j] = arreglo[i];
                    }
                }
                Array.Copy(tmp, 0, arreglo, arreglo.Length - j, j);
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
            OrdenarDes(numeros);
            tiempo.Stop();
            Imprimir();
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
