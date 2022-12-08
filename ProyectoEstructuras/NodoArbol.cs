using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuras
{
    internal class NodoArbol
    {
        private int info;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoArbol Izquierdo;
        public NodoArbol Derecho;
        public NodoArbol Padre;
        public int altura;
        public int nivel;
        public int suma = 0;
        private ArbolBinario arbol;
        public NodoArbol()
        {
        }
        public ArbolBinario Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        public NodoArbol(int nueva_info, NodoArbol izquierdo, NodoArbol derecho, NodoArbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }


        public NodoArbol Insertar(int x, NodoArbol t, ref int Level)
        {

            if (t == null)
            {
                t = new NodoArbol(x, null, null, null);

                t.nivel = Level;
                t.altura = Alturas(t);
            }
            else if (x < t.info)
            {
                Level++;
                t.Izquierdo = Insertar(x, t.Izquierdo, ref Level);

            }
            else if (x > t.info)
            {
                Level++;
                t.Derecho = Insertar(x, t.Derecho, ref Level);//

            }
            else
            {
                MessageBox.Show("Dato Existente en el Árbol", "Error de Ingreso");
            }

            return t;
        }

        private static int Alturas(NodoArbol t)
        {
            return t == null ? -1 : t.altura;
        }


        public void Eliminar(int x, ref NodoArbol t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x > t.info)
                    {
                        Eliminar(x, ref t.Derecho);
                    }
                    else
                    {
                        NodoArbol NodoEliminar = t;
                        if (NodoEliminar.Derecho == null)
                        {
                            t = NodoEliminar.Izquierdo;
                        }
                        else
                        {
                            if (NodoEliminar.Izquierdo == null)
                            {
                                t = NodoEliminar.Derecho;
                            }
                            else
                            {

                                if ((Alturas(t.Izquierdo) - Alturas(t.Derecho)) > 0)
                                {
                                    NodoArbol AuxiliarNodo = null;
                                    NodoArbol Auxiliar = t.Izquierdo;
                                    bool Bandera = false;
                                    while (Auxiliar.Derecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Derecho;
                                        Bandera = true;
                                    }
                                    t.info = Auxiliar.info;
                                    NodoEliminar = Auxiliar;
                                    if (Bandera == true)
                                    {
                                        AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                    }
                                    else
                                    {
                                        t.Izquierdo = Auxiliar.Izquierdo;
                                    }
                                }
                                else
                                {
                                    if ((Alturas(t.Derecho) - Alturas(t.Izquierdo)) > 0)
                                    {
                                        NodoArbol AuxiliarNodo = null;
                                        NodoArbol Auxiliar = t.Derecho;
                                        bool Bandera = false;
                                        while (Auxiliar.Izquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Izquierdo;
                                            Bandera = true;
                                        }
                                        t.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;
                                        if (Bandera == true)
                                        {
                                            AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                                        }
                                        else
                                        {
                                            t.Derecho = Auxiliar.Derecho;
                                        }
                                    }
                                    else
                                    {
                                        if (Alturas(t.Derecho) - Alturas(t.Izquierdo) == 0)
                                        {
                                            NodoArbol AuxiliarNodo = null;
                                            NodoArbol Auxiliar = t.Izquierdo;
                                            bool Bandera = false;
                                            while (Auxiliar.Derecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.Derecho;
                                                Bandera = true;
                                            }
                                            t.info = Auxiliar.info;
                                            NodoEliminar = Auxiliar;
                                            if (Bandera == true)
                                            {
                                                AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                            }
                                            else
                                            {
                                                t.Izquierdo = Auxiliar.Izquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO Existente en el Árbol", "Error de Eliminación");
            }
        }
        public NodoArbol buscar(int x, ref NodoArbol t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    buscar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x > t.info)
                    {
                        buscar(x, ref t.Derecho);
                    }
                    else
                    {
                        return t;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO Encontrado en el Árbol", " Error de Búsqueda");

            }
            return null;
        }


        private const int Radio = 30;
        private const int DistanciaH = 80;
        private const int DistanciaV = 10;
        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            if (Izquierdo != null)
            {
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((Izquierdo != null) && (Derecho != null))
            {
                xmin += DistanciaH;
            }

            if (Derecho != null)
            {
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if (Izquierdo != null && Derecho != null)
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            else if (Izquierdo != null)
            {
                aux1 = Izquierdo.CoordenadaX;
                Izquierdo.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (Derecho != null)
            {
                aux2 = Derecho.CoordenadaX;

                Derecho.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (Izquierdo != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX,
                Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (Derecho != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX,
                Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, Lapiz);
            }
        }


        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro, int i, int m, int max, int min)
        {

            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);

            if (max == info)
            {
                grafo.FillEllipse(Brushes.Green, rect);
            }
            else if (min == info)
            {
                grafo.FillEllipse(Brushes.Red, rect);
            }
            else if (i == info)
            {
                grafo.FillEllipse(encuentro, rect);
            }
            else if (m != 0)
            {
                if (info % m == 0)
                {
                    grafo.FillEllipse(Brushes.Red, rect);
                    suma = suma + info;
                }
                else
                {
                    grafo.FillEllipse(Relleno, rect);
                }
            }
            else
            {
                grafo.FillEllipse(Relleno, rect);
            }
            grafo.DrawEllipse(Lapiz, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX,
            CoordenadaY, formato);

            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro, i, m, max, min);
            }
            if (Derecho != null)
            {
                Derecho.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro, i, m, max, min);
            }
        }


        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            Rectangle prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX,
            CoordenadaY, formato);
        }
    }
}
