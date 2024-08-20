using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejs1_2
{
    public class Pila : IColeccion
    {
        private object?[] pila;
        private int ultimo;

        public Pila()
        {
            pila = new object?[10];
            ultimo = -1;
        }

        public Pila(int size)
        {
            pila = new object?[size];
            ultimo = -1;
        }

        public bool estaVacia()
        {
            bool aux = false;
            if(ultimo == -1) aux = true;
            return aux;
        }

        public object? extraer()
        {
            object? aux = primero();
            if(aux != null)
            {
                pila[ultimo] = null;
                ultimo--;
            }
            return aux;
            /*

            object? aux = null;
            if(!this.estaVacia())
            {
                aux = pila[ultimo];
                pila[ultimo] = null;
                ultimo--;
            }
            return aux;
            */
        }

        public object? primero()
        {
            object? aux = null;
            if (!this.estaVacia())
            {
                aux = pila[ultimo];
            }
            return aux;
        }

        public bool agregar(object obj)
        {
            bool aux = false;
            if(ultimo >= -1 && ultimo < this.pila.Length - 1 && obj != null)
            {
                pila[ultimo+1] = obj;
                ultimo++;
                aux = true;
            }
            return aux;
            
        }

        public override string ToString()
        {
            string aux = "";
            foreach(object? obj in pila)
            {
                if(obj != null)
                {
                    aux += obj.ToString() + " - ";
                }
                
            }
            return aux;
        }

        public void print()
        {
            Console.WriteLine(ToString());
        }

    }
}
