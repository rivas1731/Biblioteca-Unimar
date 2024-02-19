using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class Nodo
    {
        public int valor;
        public Nodo siguiente;
        public Nodo(int valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }

        //getters y setters
        public int getValor()
        {
            return this.valor;
        }
        public void setValor(int valor)
        {
            this.valor = valor;
        }
        public Nodo getSiguiente()
        {
            return this.siguiente;
        }
        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }


    }

    class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            this.cabeza = null;
        }
        public Boolean estaVacia()
        {
            return this.cabeza == null;
        }
        public void insertar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (this.estaVacia())
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevoNodo;
            }
        }

        public void eliminar(int valor)
        {
            if (!this.estaVacia())
            {
                if (cabeza.valor == valor)
                {
                    cabeza = cabeza.siguiente;
                }
                else
                {
                    Nodo actual = cabeza;
                    while (actual.siguiente != null && actual.siguiente.valor != valor)
                    {
                        actual = actual.siguiente;
                    }
                    if (actual.siguiente != null)
                    {
                        actual.siguiente = actual.siguiente.siguiente;
                    }
                }
            }
        }

        public void imprimir()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine(actual.valor);
                actual = actual.siguiente;
            }
        }

        public int buscar(int valor)
        {
            Nodo actual = cabeza;
            int contador = 0;
            while (actual != null)
            {
                if (actual.valor == valor)
                {
                    return contador;
                }
                actual = actual.siguiente;
                contador++;
            }
            return -1;
        }

        public int contar()
        {
            Nodo actual = cabeza;
            int contador = 0;
            while (actual != null)
            {
                contador++;
                actual = actual.siguiente;
            }
            return contador;
        }

        public Boolean existe(int valor)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.valor == valor)
                {
                    return true;
                }
                actual = actual.siguiente;
            }
            return false;
        }
    }
}
