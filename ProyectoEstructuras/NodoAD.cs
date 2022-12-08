using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class NodoAD
    {
        private string dato;
        private NodoAD siguiente;
        private NodoAD anterior;
        public NodoAD(string hola)
        {
            Dato = hola;
            Siguiente = null;
            Anterior = null;
        }
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoAD Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoAD Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public NodoAD()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
