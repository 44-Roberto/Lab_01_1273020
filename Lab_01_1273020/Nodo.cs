using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_1273020
{
    public class Nodo<T> where T : IComparable<T>
    {
        public Nodo<T> Izquierdo { get; set; }
        public Nodo<T> Derecho { get; set; }
        public T Valor { get; set; }

        // Persona
        public String Nombre;
        public int DPI;
        public String fechaC;
        public String pais;


        //Para el AVL
        public int FE { get; set; }

    }
}
