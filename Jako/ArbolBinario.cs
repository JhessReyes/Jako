using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jako
{
    class ArbolBinario
    {
        public Nodo raiz;
        public bool aux;


        public ArbolBinario() {
            raiz = null;

        }

        public void insertarNodo(Nodo origen, string n, Nodo dad) 
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo(n, dad);
                raiz = nuevo;
            }
            else {
                aux = false;
                if (aux == true)
                {
                    insertarNodo(raiz.hizq, n, raiz);
                }
                else {
                    insertarNodo(raiz.hder, n, raiz);
                }
            }
        
        }

        public void Imprimirarbol(Nodo Raiz, int cnt) {
            if (raiz == null)
            {
                return;
            }
            else {
                Imprimirarbol(raiz.hder, cnt + 1);
                for (int i = 0; i< cnt; i++) {
                    Console.WriteLine("  ");
                }
                Console.WriteLine(raiz.dato + "\n");
                Imprimirarbol(raiz.hizq, cnt + 1);
            }

        }


        public void PreOrden(Nodo Raiz) {
            if (raiz == null)
            {
                return;
            }
            else {
                Console.WriteLine(raiz.dato + " - ");
                PreOrden(raiz.hizq);
                PreOrden(raiz.hder);

            }
        }


 
    }
}