using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class COrdenamientoAB
    {
        private NodoAD raiz = new NodoAD();
        public COrdenamientoAB()
        {
            raiz = null;
        }
        public void Insertar(int nuevoDato, bool invertido)
        {
            if (invertido)
            {
                raiz = InsertarInvertido(raiz, nuevoDato);
                return;
            }
            raiz = Insertar(raiz, nuevoDato);
        }

        private NodoAD Insertar(NodoAD raiz, int nuevoDato)
        {
            string dato = nuevoDato.ToString();
            if (raiz == null)
            {
                raiz = new NodoAD(dato);
                return raiz;
            }
            if (Convert.ToInt32(raiz.Dato) > nuevoDato)
            {
                raiz.Anterior = Insertar(raiz.Anterior, nuevoDato);
                return raiz;
            }
            if (Convert.ToInt32(raiz.Dato) < nuevoDato)
            {
                raiz.Siguiente = Insertar(raiz.Siguiente, nuevoDato);
                return raiz;
            }
            return raiz;
        }
        private NodoAD InsertarInvertido(NodoAD raiz, int nuevoDato)
        {
            string dato = nuevoDato.ToString();
            if (raiz == null)
            {
                raiz = new NodoAD(dato);
                return raiz;
            }
            if (Convert.ToInt32(raiz.Dato) < nuevoDato)
            {
                raiz.Anterior = Insertar(raiz.Siguiente, nuevoDato);
                return raiz;
            }
            if (Convert.ToInt32(raiz.Dato) > nuevoDato)
            {
                raiz.Siguiente = Insertar(raiz.Anterior, nuevoDato);
                return raiz;
            }
            return raiz;
        }

        //Ordenamiento en In-Orden
        public string Inorden()
        {
            string cadena = "";
            return Inorden(this.raiz, ref cadena);
        }

        private string Inorden(NodoAD rama, ref string cadena)
        {
            if (rama != null)
            {
                Inorden(rama.Anterior, ref cadena);
                cadena += ", " + rama.Dato;
                Inorden(rama.Siguiente, ref cadena);
            }
            return cadena;
        }
    }
}
