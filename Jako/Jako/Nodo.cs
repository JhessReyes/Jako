using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jako
{
    class Nodo {
        public string dato;
        public Nodo hizq;
        public Nodo hder;
        public Nodo padre;


        public Nodo(string n, Nodo dad) {
            this.dato = n;
            this.hder = null;
            this.hizq = null;
            this.padre = dad;

        }
    }

}