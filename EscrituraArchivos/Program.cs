using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            //si el archivo no existe lo creará
            //si ya existe, escribirá en él

            string[] lines = {
            "Esta es la nueva escritura",
            "Esta es la segunda linea",
            "Fin del texto"
            };

            //recorre en el arreglo
            foreach(string line in lines)
            {
                sw.WriteLine(line); //Escribe en el archivo
            }
            sw.Close(); //Siempre se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo.........");
            Console.ReadLine();
        }
    }
}
