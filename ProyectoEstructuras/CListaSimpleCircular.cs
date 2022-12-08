using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class CListaSimpleCircular
    {
        private Nodo head;
        public CListaSimpleCircular()
        {
            head = null;
        }
        public void Agregar(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            if(head == null)
            {
                nuevo.Siguiente = nuevo;
                head = nuevo;
                return;
            }
            Nodo h = head;
            if (nuevo.Dato.CompareTo(head.Dato) < 0)
            {
                while(h.Siguiente != head)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = nuevo;
                nuevo.Siguiente = head;
                head = nuevo;
                return;
            }
            while(h.Siguiente != head)
            {
                if (nuevo.Dato.CompareTo(h.Siguiente.Dato) < 0)
                {
                    break;
                }
                h = h.Siguiente;
            }
            nuevo.Siguiente = h.Siguiente;
            h.Siguiente = nuevo;
        }
        public bool Buscar(string dato)
        {
            Nodo h = head;
            if (h != null)
            {
                do
                {
                    if (h.Dato == dato)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                } while (h != head);
            }
            return false;
        }
        public void Eliminar(string dato)
        {
            if (head != null)
            {
                Nodo h = head;
                if(head.Dato == dato)
                {
                    while (h.Siguiente != head)
                    {
                        h = h.Siguiente;
                    }
                    if (head.Siguiente == head)
                    {
                        head = null;
                        return;
                    }
                    head = head.Siguiente;
                    h.Siguiente = head;
                    return;
                }
                while(h.Siguiente.Dato != dato)
                {
                    h = h.Siguiente;
                }
                h.Siguiente = h.Siguiente.Siguiente;
            }
        }
        public override string ToString()
        {
            Nodo h = head;
            string cadena = "";
            if (h != null)
            {
                cadena += h.ToString() + "\r\n";
                h = h.Siguiente;
                while (h != head)
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
