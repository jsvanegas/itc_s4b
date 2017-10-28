using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taller1 taller = new Taller1();
            ////ejercicio 1
            //int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ejercicio 1: " + taller.ejercicio1(numero));

            var random = new Random();
            var lista = new List<Persona>();
            //var persona = new Persona()
            //{
            //    Nombre = "Camila",
            //    Edad = 27,
            //    Pais = "Colombia",
            //    Correo = "camila.col@gmail.com"
            //};
            //lista.Add(persona);

            for (int i = 0; i < 100; i++)
            {
                lista.Add(new Persona() {
                    Nombre = "Persona " + i,
                    Edad = random.Next(10, 100)
                });
            }


            foreach (var item in lista)
            {
                Console.WriteLine("Nombre: " + item.Nombre + " Edad: " + item.Edad);
            }

            Console.ReadKey();


            var q = from f in lista
                    where f.Edad > 50
                    orderby f.Edad descending
                    select f;

            foreach (var persona in q)
            {
                Console.WriteLine(persona.Nombre + "-- " + persona.Edad);
            }
            Console.ReadKey();
        }
    }
}
