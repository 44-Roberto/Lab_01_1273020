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
      
        public string name { get; set; }
        public string dpi { get; set; }
        public string dateBirth { get; set; }
        public string address { get; set; }

    }
    
    internal class Program 
    {
        
        static void Main(string[] args)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Roberto Moya\Desktop\Lab1-E2\Lab_01_1273020\Lab_01_1273020\bin\Debug\Prueba.csv"));
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            Lista<Persona> listaJSon = new Lista<Persona>();

            int a = 0;
            int b = 0;
            while (!reader.EndOfStream)
            {
                var lines = reader.ReadLine();
                var values = lines.Split(';');

                string jsonString = values[1];
                Persona personaN = JsonSerializer.Deserialize<Persona>(jsonString);

                if ("INSERT" == values[0])
                {
                    a++;
                    listaJSon.Add_Lista(personaN.name, personaN.dpi,personaN.dateBirth,personaN.address, personaN);
                }
                else if ("PATCH" == values[0])
                {

                }
                else if ("DELETE" == values[0])
                {
                    b++;
                    listaJSon.delete(personaN.name,personaN.dpi);
                }
                else
                {
                    Console.WriteLine("nada xd");
                }


               // list.Add(values[0]);//Accion
               // list2.Add(values[1]);//

               
                
                //listaJSon.Add_Lista(personaN);

            }


            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(listaJSon.GetItem("pablo", "54136137918").name);
            //Console.WriteLine(listaJSon.Get(1).name);

            for (int i = 0; i < 278; i++)
            {
                Console.WriteLine(listaJSon.Get(i).name+"  "+ listaJSon.Get(i).dpi);
                

            }

            









            Console.ReadKey();
        }
    }
}
