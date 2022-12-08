using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class CListaDoble
    {
        private NodoAD head;
        public CListaDoble()
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
                return;
            }
            if(nuevo.Dato.CompareTo(head.Dato) < 0)
            {
                nuevo.Siguiente = head;
                head.Anterior = nuevo;
                head = nuevo;
                return;
            }
            NodoAD h = head;
            while(h.Siguiente != null)
            {
                if(nuevo.Dato.CompareTo(h.Siguiente.Dato) < 0)
                {
                    break;
                }
                h = h.Siguiente;
            }
            nuevo.Siguiente = h.Siguiente;
            nuevo.Anterior = h;
            if (h.Siguiente != null)
            {
                h.Siguiente.Anterior = nuevo;
            }
            h.Siguiente = nuevo;
        }

        public void Eliminar(string dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {

                    head = head.Siguiente;
                    head.Anterior = null;
                    return;
                }
                NodoAD h = head;

                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        break;
                    }
                    h = h.Siguiente;
                }
                if (h.Siguiente.Siguiente == null)
                {
                    h.Siguiente = null;
                }
                else
                {
                    h.Siguiente = h.Siguiente.Siguiente;
                    h.Siguiente.Anterior = h;

                }
            }
        }
        public bool Buscar(string dato)
        {
            NodoAD h = head;
            if (h != null)
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
        public override string ToString()
        {
            NodoAD h = head;
            string cadena = "";
            if (h != null)
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
