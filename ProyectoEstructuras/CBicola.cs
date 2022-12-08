using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class CBicola
    {
        private NodoAD head;
        private NodoAD tail;
        public CBicola()
        {
            head = tail = null;
        }
        public void AgregarFrente(string dato)
        {
            NodoAD nuevo = new NodoAD();
            nuevo.Dato = dato;
            if (EstaVacia())
            {
                head = tail = nuevo;
                return;
            }
            head.Anterior = nuevo;
            nuevo.Siguiente = head;
            head = nuevo;
        }
        public void AgregarFinal(string dato)
        {
            NodoAD nuevo = new NodoAD();
            nuevo.Dato = dato;
            if (EstaVacia())
            {
                head = tail = nuevo;
                return;
            }
            tail.Siguiente = nuevo;
            nuevo.Anterior = tail;
            tail = nuevo;
        }
        public void EliminarFrente()
        {
            if (EstaVacia())
            {
                return;
            }
            if (head.Siguiente == null)
            {
                head = tail = null;
                return;
            }
            head = head.Siguiente;
            head.Anterior = null;
        }
        public void EliminarFinal()
        {
            if (EstaVacia())
            {
                return;
            }
            if (head.Siguiente == null)
            {
                head = tail = null;
                return;
            }
            tail = tail.Anterior;
            tail.Siguiente = null;
        }
        public bool EstaVacia()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string cadena = "";
            NodoAD h = head;
            if (EstaVacia() == false)
            {
                cadena += h.ToString();
                h = h.Siguiente;
                while (h != null)
                {
                    cadena += ", " + h.ToString();
                    h = h.Siguiente;
                }
                return cadena;
            }
            else
            {
                return "La cola está vacía.";
            }
        }
    }
}
