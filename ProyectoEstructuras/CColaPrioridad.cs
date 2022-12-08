using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class CColaPrioridad
    {
        private NodoP[] prioridades;
        private int frente;
        private int final;
        public CColaPrioridad()
        {
            prioridades = null;
            frente = final = -1;
        }
        public void CrearArreglo(int num)
        {
            prioridades = new NodoP[num];
        }
        public void Agregar(NodoP nuevo)
        {
            if (frente == -1)
            {
                frente = final = 0;
                prioridades[0] = nuevo;
                return;
            }
            if (prioridades[nuevo.Prioridad] == null)
            {
                final = nuevo.Prioridad;
                prioridades[nuevo.Prioridad] = nuevo;
                return;
            }
            NodoP h = prioridades[nuevo.Prioridad];
            while (h.Siguiente != null)
            {
                h = h.Siguiente;
            }
            h.Siguiente = nuevo;
        }
        public void Eliminar()
        {
            if (frente == -1)
            {
                return;
            }
            if (frente == final)
            {
                if (prioridades[frente].Siguiente == null)
                {
                    prioridades[frente] = null;
                    frente = final = -1;
                }
                else
                {
                    prioridades[frente] = prioridades[frente].Siguiente;
                }
                return;
            }
            if (prioridades[frente].Siguiente != null)
            {
                prioridades[frente] = prioridades[frente].Siguiente;
                return;
            }
            if (prioridades[frente].Siguiente == null)
            {
                if (frente == prioridades.Length - 1)
                {
                    prioridades[frente] = null;
                    frente = 0;
                }
                else
                {
                    prioridades[frente] = null;
                    frente++;
                }
                return;
            }
        }
        public override string ToString()
        {
            string cadena = "";
            if (frente != -1)
            {
                for (int i = frente; i < prioridades.Length; i++)
                {
                    if (prioridades[i] == null)
                    {
                        return cadena += "";
                    }
                    cadena += prioridades[i].ToString();
                    NodoP h = prioridades[i];
                    if (h == null)
                    {
                        cadena += "";
                    }
                    else
                    {
                        while (h.Siguiente != null)
                        {
                            cadena += ", " + h.Siguiente.ToString();
                            h = h.Siguiente;
                        }
                    }
                    cadena += "\r\n";
                }
                return cadena;
            }
            else
            {
                return "Cola vacía";
            }
        }
    }
}
