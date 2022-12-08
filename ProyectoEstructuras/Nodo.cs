using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class Nodo
    {
        private string dato;
        private Nodo siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo()
        {
            dato = null;
            siguiente = null;
        }

        public Nodo(string dato, Nodo siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato;
        }
    }
}
