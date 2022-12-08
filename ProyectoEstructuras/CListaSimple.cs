using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuras
{
    internal class CListaSimple
    {
        private Nodo head = new Nodo();

        public CListaSimple()
        {
            head = null;
        }

        public void Insertar(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            if (head == null)
            {
                head = nuevo;
                return;
            }
            if (nuevo.Dato.CompareTo(head.Dato) < 0)
            {
                nuevo.Siguiente = head;
                head = nuevo;
                return;
            }

            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato.CompareTo(nuevo.Dato) > 0)
                {
                    break;
                }
                h = h.Siguiente;
            }
            nuevo.Siguiente = h.Siguiente;
            h.Siguiente = nuevo;
        }

        public bool Encontrado(string dato)
        {
            Nodo h = new Nodo();
            h = head;
            if (head != null)
            {
                while (h != null)
                {
                    if (h.Dato == dato)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                }
            }
            return false;
        }

        public void Eliminar(string dato)
        {
            if (head.Dato == dato)
            {
                head = head.Siguiente;
            }
            else
            {
                Nodo h = head;
                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                    }
                    else
                    {
                        h = h.Siguiente;
                    }
                }
            }
        }

        public void Vaciar()
        {
            head = null;
        }

        public override string ToString()
        {
            Nodo h = head;
            string cadena = "";
            if(h != null)
            {
                cadena += h.ToString() + "\r\n";
                h = h.Siguiente;
                while (h != null)
                {
                    cadena += h.ToString() + "\r\n";
                    h = h.Siguiente;
                }
                return cadena;
            }
            return "La lista está vacía";
        }
    }
}
