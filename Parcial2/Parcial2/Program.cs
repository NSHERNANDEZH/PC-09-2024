using System;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            int[] notas = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();

                while (true)
                {
                    Console.Write($"Ingrese la nota del estudiante {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out notas[i]) && notas[i] >= 0 && notas[i] <= 100)
                    {
                        break; // Salir del bucle si la nota es válida
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese un valor numérico entre 0 y 100.");
                    }
                }

            
            }

          
            

            int opcion;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1) Mostrar nombre y nota de alumnos que aprobaron el curso.");
                Console.WriteLine("2) Mostrar nombre y nota de alumnos que no aprobaron el curso.");
                Console.WriteLine("3) Mostrar el promedio de notas del grupo.");
                Console.WriteLine("4) Salir del programa.");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Por favor ingrese un número entre 1 y 4.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        MostrarAprobados(nombres, notas);
                        break;
                    case 2:
                        MostrarNoAprobados(nombres, notas);
                        break;
                    case 3:
                        MostrarPromedio(notas);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                }
            }
        }

        static void MostrarAprobados(string[] nombres, int[] notas)
        {
            Console.WriteLine("Alumnos que aprobaron el curso:");
            for (int i = 0; i < 10; i++)
            {
                if (notas[i] >= 60)
                {
                    Console.WriteLine($"Nombre: {nombres[i]}, Nota: {notas[i]}");
                }
            }
        }

        static void MostrarNoAprobados(string[] nombres, int[] notas)
        {
            Console.WriteLine("Alumnos que no aprobaron el curso:");
            for (int i = 0; i < 10; i++)
            {
                if (notas[i] < 60)
                {
                    Console.WriteLine($"Nombre: {nombres[i]}, Nota: {notas[i]}");
                }
            }
        }

        static void MostrarPromedio(int[] notas)
        { 
            double promedio = 0;
            foreach (int nota in notas)
            promedio += nota; 
            promedio /= notas.Length;

            Console.WriteLine($"el promedio final es + {promedio}");






            
            /*double promedio = 0;
            foreach (int nota in notas)
                promedio += nota;
            promedio /= notas.Length;
            Console.WriteLine($"El promedio de notas del grupo es: {promedio}");*/
        }
    }
}
