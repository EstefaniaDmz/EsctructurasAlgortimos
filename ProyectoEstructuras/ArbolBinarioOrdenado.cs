using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras
{
    internal class ArbolBinarioOrdenado
    {
        public string pre_orden;
        public string post_orden;
        public string en_orden;

        NodoAD raiz;
        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }

        public void Insertar(string dato)
        {
            NodoAD nuevo;
            nuevo = new NodoAD();
            nuevo.Dato = dato;
            nuevo.Anterior = null;
            nuevo.Siguiente = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                NodoAD anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (Convert.ToInt32(dato) < Convert.ToInt32(reco.Dato))
                        reco = reco.Anterior;
                    else
                        reco = reco.Siguiente;
                }
                if (Convert.ToInt32(dato) < Convert.ToInt32(anterior.Dato))
                    anterior.Anterior = nuevo;
                else
                    anterior.Siguiente = nuevo;
            }
        }

        private void PostOrden(NodoAD reco)
        {
            if (reco != null)
            {
                post_orden += reco.Dato + " ";
                PostOrden(reco.Anterior);
                PostOrden(reco.Siguiente);
            }
        }

        public void PostOrden()
        {
            PostOrden(raiz);

        }

        private void PreOrden(NodoAD reco)
        {
            if (reco != null)
            {
                PreOrden(reco.Anterior);
                pre_orden += reco.Dato + " ";
                PreOrden(reco.Siguiente);
            }
        }

        public void PreOrden()
        {
            PreOrden(raiz);

        }


        private void EnOrden(NodoAD reco)
        {
            if (reco != null)
            {
                EnOrden(reco.Anterior);
                EnOrden(reco.Siguiente);
                en_orden += reco.Dato + " ";
            }
        }

        public void EnOrden()
        {
            EnOrden(raiz);

        }
    }
}
