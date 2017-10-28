using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var personas = new[] {
                new { Id=1, Nombre="Andres", Pais="Colombia", Edad=35 },
                new { Id=2, Nombre="Diana", Pais="Peru", Edad=35 },
                new { Id=3, Nombre="Camilo", Pais="colombia", Edad=35 },
                new { Id=4, Nombre="Angie", Pais="colombia", Edad=35 },
                new { Id=5, Nombre="Miguel", Pais="Venezuela", Edad=35 },
                new { Id=6, Nombre="Marcela", Pais="Venezuela", Edad=35 },
                new { Id=7, Nombre="Sebastian", Pais="Argentina", Edad=35 },
                new { Id=8, Nombre="Laura", Pais="Uruguay", Edad=35 },
                new { Id=9, Nombre="Javier", Pais="Mexico", Edad=35 },
            };

            //for (int i = 0; i < personas.Length; i++)
            //{
            //    var persona = personas[i];
            //    if (persona.Pais.ToUpper().Equals("COLOMBIA") && persona.Nombre.ToUpper().StartsWith("A"))
            //    {
            //        Console.WriteLine("Nombre: {0}({1}), Nacionalidad: {2}", persona.Nombre, persona.Id, persona.Pais);
            //    }
            //}


            //var personasColombia = from p in personas
            //                       where p.Pais.ToUpper().Equals("COLOMBIA")
            //                            && p.Nombre.ToUpper().StartsWith("A")
            //                       orderby p.Id descending
            //                       select p;


            var personasColombia = from p in personas
                                   where p.Pais.ToUpper().Equals("COLOMBIA")
                                        && p.Nombre.ToUpper().StartsWith("A")
                                   orderby p.Id descending
                                   select new {
                                        p.Nombre,
                                        Pais = p.Pais.Substring(0, 3).ToUpper(),
                                        Id = p.Id + 1000
                                   };

            foreach (var item in personasColombia)
            {
                //Console.WriteLine("Nombre: {0}({1}), Nacionalidad: {2}", item.Nombre, item.Id, item.Pais);
                Console.WriteLine("{2} - Nombre: {0} ({1})", item.Nombre, item.Pais, item.Id);
            }

            Console.ReadKey();


        }
    }
}
