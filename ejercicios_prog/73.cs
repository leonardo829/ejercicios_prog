using System;
using System.Collections.Generic;

namespace ejercicios_prog
{
    public class _73
    {
        class Program
        {
            static void Main(string[] args)
            {
                Queue<string> colaDeCadenas = new Queue<string>();

                Console.WriteLine("Bienvenido al programa de manejo de colas de cadenas.");
                Console.WriteLine("Introduce tantas cadenas como desees. Presiona Enter sin escribir nada para finalizar.");

                while (true)
                {
                    Console.Write("Ingresa una cadena (o presiona Enter para salir): ");
                    string entrada = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada))
                        break; //si la cadena está vacía o contiene solo espacios salimos de el bucle

                    colaDeCadenas.Enqueue(entrada);
                }

                Console.WriteLine("\nCadenas ingresadas hasta el momento:");
                while (colaDeCadenas.Count > 0)
                {
                    string cadena = colaDeCadenas.Dequeue();
                    Console.WriteLine(cadena);
                }

                Console.WriteLine("\n¡Hasta luego!");
            }
        }
    }
}
