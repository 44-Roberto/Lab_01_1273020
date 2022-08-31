using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_1273020
{



    class Lista<T> //where T : IComparable<T>
    {

        public class nodo : Persona
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


        public void Add_Lista(string Name, string Dpi, string BD, string Address, T value)
        {
            nodo nuevoNodo = new nodo();
            nodo Temp = Header;

            nuevoNodo.valor = value;
            nuevoNodo.name=Name;
            nuevoNodo.dpi = Dpi;
            nuevoNodo.address=Address;
            nuevoNodo.dateBirth = BD;

            if (Header == null)
            {
                Header = nuevoNodo;
                
                return;
            }
            else
            {
                while (Temp.siguiente != null)
                {
                    Temp = Temp.siguiente;
                }
                Temp.siguiente = nuevoNodo;
                return;
            }

        }

        public T Get(int pos)
        {
            nodo Temp = Header;
            int auxPos = 0;
            while (Temp.siguiente != null)
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

        public T GetItem(string Name, string Dpi)
        {
            nodo Temp = Header;
           
            while (Temp.siguiente != null)
            {
                if ((Temp.name == Name)&& (Temp.dpi == Dpi))
                {
                    return Temp.valor;
                }
                else
                {
                    Temp = Temp.siguiente;
                    
                }
            }

            return Temp.valor;
        }

        public void delete(string Name, string Dpi)
        {

            nodo Temp = Header;
            nodo aux = new nodo();
            Persona personaaux = new Persona();

            while(Temp!= null)
            {
                if( (Temp.name == Name)&&(Temp.dpi == Dpi))
                {
                    aux.siguiente = Temp.siguiente;
                    return;
                }
                else
                {
                    aux = Temp;
                    Temp= Temp.siguiente;
                }
            }
            
            

        }


    }

}
