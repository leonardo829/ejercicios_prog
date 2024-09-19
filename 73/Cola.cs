using System;
using System.Collections.Generic;

namespace e_73
{
    public class Cola
    {
        static void Main()
        {
            Queue<string> colaDeCadenas = new Queue<string>();

            Console.WriteLine("programa de manejo de colas.");
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

            Console.WriteLine("\nFin");
        }
    }
}   
