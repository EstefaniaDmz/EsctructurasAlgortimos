using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class NodoP
    {
        private string dato;
        private NodoP siguiente;
        private int prioridad;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoP Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        public NodoP()
        {
            dato = "";
            prioridad = 0;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
