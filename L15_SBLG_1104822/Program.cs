using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_SBLG_1104822
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;


            Console.WriteLine("Bienvenido al menú, seleccione una opción:");
            Console.WriteLine("Presione 1: ------>  Edad y nombre de estudiantes ");
            Console.WriteLine("Presione 2: ------>  Notas ");
            Console.WriteLine("Presione 3: ------>  Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    string[] nombres = new string[5];
                    int[] edades = new int[5];
                    int suma = 0;


                    for (int a = 0; a < 5; a++)
                    {
                        Console.WriteLine("Ingrese el nombre del estudiante #" + (a + 1));
                        nombres[a] = Console.ReadLine();

                        Console.WriteLine("Ingrese la edad del estudiante " + nombres[a]);
                        edades[a] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int a = 0; a < 5; a++)
                    {
                        Console.WriteLine("El total de las edades ingresadas es de: ");
                        Console.WriteLine(edades[a]);
                        suma = suma + edades[a];
                    }
                    Console.WriteLine("Los mayores de edad son: ");
                    for (int a = 0; a < 5; a++)
                    {
                        if (edades[a] >= 18)
                        {
                            Console.WriteLine(nombres[a] + "de " + edades[a]);
                        }
                    }
                    Console.WriteLine("El promedio de las edades es de: " + suma / 5);

                    break;

                case 2:
                    string[] nombre = new string[5];
                    string[] apellido = new string[5];
                    int[] notas = new int[5];
                    nombres = new string[5];
                    edades = new int[5];
                    for (int p = 0; p < nombres.Length; p++)
                    {
                        Console.WriteLine("Ingrese el nombre");
                        nombre[p] = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido: ");
                        apellido[p] = Console.ReadLine();
                        Console.WriteLine("Ingrese la nota: ");
                        notas[p] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Lista de notas");
                    for (int p = 0; p < 5; p++)
                    {
                        if (notas[p] >= 71)
                        {
                            Console.WriteLine("Aprobado" + nombre[p] + apellido[p] + "con " + notas[p]);

                        }
                        else
                        {
                            if (notas[p] <= 71)
                            {
                                Console.WriteLine("Reprobado " + nombre[p] + apellido[p] + "con " + notas[p]);
                            }

                        }

                    }
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

            }

            Console.ReadKey();
        }
    }
}

