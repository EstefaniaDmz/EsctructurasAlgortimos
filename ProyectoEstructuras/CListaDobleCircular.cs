using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class CListaDobleCircular
    {
        private NodoAD head;
        public CListaDobleCircular()
        {
            head = null;
        }
        public void Agregar(string dato)
        {
            NodoAD nuevo = new NodoAD();
            nuevo.Dato = dato;
            if(head == null)
            {
                head = nuevo;
                head.Anterior = head;
                head.Siguiente = head;
                return;
            }
            if (nuevo.Dato.CompareTo(head.Dato) < 0)
            {
                head.Anterior.Siguiente = nuevo;
                nuevo.Anterior = head.Anterior;
                nuevo.Siguiente = head;
                head.Anterior = nuevo;
                head = nuevo;
                return;
            }
            NodoAD h = head;
            while (h.Siguiente != head)
            {
                if (h.Siguiente.Dato.CompareTo(nuevo.Dato) > 0)
                {
                    break;
                }
                h = h.Siguiente;
            }
            h.Siguiente.Anterior = nuevo;
            nuevo.Anterior = h;
            nuevo.Siguiente = h.Siguiente;
            h.Siguiente = nuevo;
        }
        public bool Buscar(string dato)
        {
            NodoAD h = head;
            if (head != null)
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
            NodoAD h = head;
            while (h.Siguiente != head)
            {
                if (h.Dato == dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
            h.Anterior.Siguiente = h.Siguiente;
            h.Siguiente.Anterior = h.Anterior;
            if (h == head)
            {
                head = head.Siguiente;
            }
        }
        public override string ToString()
        {
            NodoAD h = head;
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
