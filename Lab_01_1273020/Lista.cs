using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_1273020
{



    class Lista<T>
    {

        public class nodo
        {
            public T valor;
            public nodo siguiente;
            
        }

        //declaro mi primer Nodo "Head"

        nodo Header = new nodo();
        

        public Lista()
      {
             Header = null;
            
      }

      
        public void Add_Lista(T Value)
        {
            nodo nuevoNodo =new nodo();
            nodo Temp = Header;
           
            nuevoNodo.valor = Value;

            if (Header == null)
            {
                Header=nuevoNodo;
                return;
            }
            else
            {
                while(Temp.siguiente!= null)
                {
                    Temp= Temp.siguiente;
                }
                Temp.siguiente=nuevoNodo;
                return;
            }
          
        }

       public T Get(int pos)
        {
            nodo Temp = Header;
            int auxPos = 0;
            while(Temp!= null)
            {
                if (pos == auxPos)
                {
                    return Temp.valor;
                }
                else
                {
                    Temp = Temp.siguiente;
                    auxPos++;
                }
            }
            return Temp.valor;
        }

        public void delete(int value)
        {
          


        }


    }

}
