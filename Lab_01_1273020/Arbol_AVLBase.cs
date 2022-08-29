using System;

namespace Lab_01_1273020.Clase
{
    public class Arbol_AVLBase
    {

        public void Add(T value)
        {
            Inser(value);
        }
        public Nodo<T> CrearNodoAVL(T valor)
        {
            Nodo<T> nodo = new Nodo<T>();
            nodo.Valor = valor;
            nodo.FE = 0;
            nodo.Izquierdo = new Nodo<T>();
            nodo.Derecho = new Nodo<T>();
            return nodo;

        }
        protected override void Delete(Nodo<T> nodo)
        {
            if (nodo.Izquierdo.Valor == null && nodo.Derecho.Valor == null) // Caso 1
            {
                nodo.Valor = nodo.Derecho.Valor;
            }
            else if (nodo.Derecho.Valor == null) // Caso 2
            {
                nodo.Valor = nodo.Izquierdo.Valor;
                nodo.Derecho = nodo.Izquierdo.Derecho;
                nodo.Izquierdo = nodo.Izquierdo.Izquierdo;
            }
            else // Caso 3
            {
                if (nodo.Izquierdo.Valor != null)
                {
                    temp = Derecha(nodo.Izquierdo);
                }
                else
                {
                    temp = Derecha(nodo);
                }
                nodo.Valor = temp.Valor;
            }

        }
        protected override Nodo<T> Get(Nodo<T> nodo, T value)
        {
            if (value.CompareTo(nodo.Valor) == 0)
            {
                return nodo;
            }
            else if (value.CompareTo(nodo.Valor) == -1)
            {
                if (nodo.Izquierdo.Valor == null)
                {
                    return null;
                }
                else
                {
                    return Get(nodo.Izquierdo, value);
                }
            }
            else
            {
                if (nodo.Derecho.Valor == null)
                {
                    return null;
                }
                else
                {
                    return Get(nodo.Derecho, value);
                }
            }
        }

        private override Nodo<T> Insert(Nodo<T> nodo, T value)
        {
            try
            {
                Nodo<T> nuevo = CrearNodoAVL(value);

                if (nodo == null)
                {
                    nodo = nuevo;
                }
                else
                {
                    nodo = InsertarAVL(nuevo, nodo);

                }
                return nodo;

            }
            catch
            {
                throw;
            }
        }
    }
}