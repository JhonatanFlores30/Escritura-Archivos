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
        class person
        {
            public string name;
            public int age;
            public string moviefav;
            public long numbertelef;


            public person(string nAme, int Age, string mOviefav, long nUmbertelf)
            {
                this.name = nAme;
                this.age = Age;
                this.moviefav = mOviefav;
                this.numbertelef = nUmbertelf;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archivo no existe lo creará
            //si ya existe, escribirá en él
            //true es para agregar y no para sobreescribir

            string name, moviefav;
            int age;
            long numbertelef;

            Console.Write("Ingrese un nombre: ");
            name = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su pelicula favorita: ");
            moviefav = Console.ReadLine();

            Console.Write("Ingresa tu numero de telefono: ");
            numbertelef = long.Parse(Console.ReadLine());

            person per = new person(name, age, moviefav, numbertelef);

            sw.WriteLine(per.name + "  " + per.age + "  " + per.moviefav + "  " + per.numbertelef);

            sw.Close(); //Siempre se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo.........");
            Console.ReadLine();
        }
    }
}
