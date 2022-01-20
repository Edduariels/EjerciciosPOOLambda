using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp5
{
    class Program
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("****************************LISTA ESTUDIANTES****************************");
                // List with eah element of type Student 
                List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };
                //1
                Console.WriteLine("1. Muestre por pantalla los nombres de los estudiantes");
                List<String> Nombres = (from Nombrea in details
                                      orderby Nombrea.Nombre
                                      select Nombrea.Nombre).ToList();
                Console.WriteLine(string.Join("\n", Nombres));
               
                Console.WriteLine("");
                Console.WriteLine("");
                //2
                Console.WriteLine("2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor");
                List<String> Promedio = (from promedioestudiante in details
                                        orderby promedioestudiante.Promedio descending
                                         select promedioestudiante.Nombre+" "+ promedioestudiante.Apellido+" "+ promedioestudiante.Promedio ).ToList();
                Console.WriteLine(string.Join("\n", Promedio));
                Console.WriteLine("");
                Console.WriteLine("");
                //3
                Console.WriteLine("3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente");
                List<String> Apellido = (from Apellidoestudiante in details
                                         orderby Apellidoestudiante.Apellido ascending
                                         select  Apellidoestudiante.Apellido) .ToList();
               
                    Console.WriteLine(string.Join("\n", Apellido));
                
                Console.WriteLine("");
                Console.WriteLine("");
                //4
                Console.WriteLine("4. Muestre por pantalla los datos del estudiante mas joven");
                var estujoven = details.Min(edad => edad.Edad + " Años  " + edad.Nombre + " " + edad.Apellido + " Promedio: " + edad.Promedio);
                Console.WriteLine(estujoven);
                Console.WriteLine("");
                Console.WriteLine("");

                //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
                //1. Muestre por pantalla los nombres de los estudiantes
                //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
                //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
                //4. Muestre por pantalla los datos del estudiante mas joven

                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("****************************LISTA NUMEROS****************************");
                //1
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1. Muestre por pantalla el cuadrado de los números");
                var cuadrado = list.Select(x => x * x);
                Console.WriteLine(string.Join(" ", cuadrado));


                //2 
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("2. Muestre por pantalla los números pares");
                List<int> pares = list.FindAll(x => x % 2 == 0);
                Console.WriteLine(string.Join(" ", pares));
                Console.WriteLine("");


                //3
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares");
                List<int> numeroimpar = list.FindAll(x => x % 2 != 0);
                var numero5 = numeroimpar.Select(x => x * 5);

                Console.WriteLine(string.Join(" ", numero5));




                //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:

                //1. Muestre por pantalla el cuadrado de los números
                //2. Muestre por pantalla los números pares
                //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            }
        }
    }
}
