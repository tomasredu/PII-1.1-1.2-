using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejs1_2
{
    public class Cola : IColeccion
    {
        List<object> cola;

        public Cola() {
            cola = new List<object>();
        }

        public bool estaVacia()
        {
            return !cola.Any();
        }

        public object? primero()
        {
            object? aux = null;
            if(!this.estaVacia()) {
                aux = cola[0];
            }
            return aux;
        }

        public object? extraer()
        {
            object? aux = null;
            if(!this.estaVacia())
            {
                aux = cola[0];
                cola.RemoveAt(0);

            }
            return aux;
        }

        public bool agregar(object obj)
        {
            bool aux = false;

            if(obj != null) { 
                cola.Add(obj);
                aux = true;
            }
            return aux;
        }

        public override string ToString()
        {
            string aux = "";
            foreach(object obj in cola)
            {
                if(obj != null)
                {
                    aux += obj.ToString() + " - ";
                }
            }
            return aux;
        }



    }
}
