using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_74
{
    public class Pila
    {
            static void Main()
            {
                Stack<string> pilaDeCadenas = new Stack<string>();

                Console.WriteLine("programa de manejo de pilas.");
                Console.WriteLine("Introduce tantas cadenas como quieras. Presiona Enter sin escribir nada para finalizar.");

                while (true)
                {
                    Console.Write("Ingresa una cadena (o presiona Enter para salir): ");
                    string entrada = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada))
                        break; // Salimos del bucle si la cadena está vacía o contiene solo espacios

                    pilaDeCadenas.Push(entrada);
                }

                Console.WriteLine("\nCadenas ingresadas hasta el momento:");
                while (pilaDeCadenas.Count > 0)
                {
                    string cadena = pilaDeCadenas.Pop();
                    Console.WriteLine(cadena);
                }

                Console.WriteLine("\nFin");
            }
    }
}
