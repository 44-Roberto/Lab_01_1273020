using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;

namespace Lab_01_1273020
{
   public class Persona
    {
        public string Act { get; set; }
        public string name { get; set; }
        public int dpi { get; set; }
        public DateTime dateBirth { get; set; }
        public string address { get; set; }

    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //string NombreArchivo = "Prueba.csv";
           // string jsonString = File.ReadAllText(NombreArchivo);
            Lista<Persona> listado = new Lista<Persona>();

           
           

            Console.ReadKey();
        }
    }
}
