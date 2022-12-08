using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class CPila
    {
        private Nodo top;
        public Nodo Top
        {
            get { return top; }
            set { top = value; }
        }

        public CPila()
        {
            top = null;
        }

        public void Push(string dato)
        {
            Nodo n = new Nodo();
            n.Dato = dato;
            n.Siguiente = top;
            top = n;
        }

        public Nodo Pop()
        {
            Nodo regreso = top;
            if (top != null)
            {
                top = top.Siguiente;
            }
            return regreso;
        }
        public override string ToString()
        {
            string stringPila = "";
            Nodo t = top;
            if (t != null)
            {
                stringPila += t.ToString();
                t = t.Siguiente;
                while (t != null)
                {
                    stringPila += "\r\n" + t.ToString();
                    t = t.Siguiente;
                }
                return stringPila;
            }
            else
            {
                return "La pila esta vacia";
            }
        }
    }
}
