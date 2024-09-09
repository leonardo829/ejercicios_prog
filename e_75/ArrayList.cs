using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_75
{
    class arrayList
    {

            static void Main(string[] args)
            {
                ArrayList listaDeCadenas = new ArrayList();

                Console.WriteLine("Programa de manejo de cadenas con ArrayList.");
                Console.WriteLine("Introduce tantas cadenas como desees. Presiona Entr sin escribir nada para pasar al modo consulta.");

                while (true)
                {
                    Console.Write("Ingresa una cadena (o presiona Enter para consultar): ");
                    string entrada = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entrada))
                        break; // se sale del bule si no ingesa un valor 

                    listaDeCadenas.Add(entrada);
                }

                Console.WriteLine("\nModo consulta activado. Introduce un número para ver la cadena en esa posición.");
                Console.WriteLine("Presiona 0 para salir.");

                while (true)
                {
                    Console.Write("Número (0 para salir): ");
                    string numeroStr = Console.ReadLine();

                    if (int.TryParse(numeroStr, out int numero))
                    {
                        if (numero == 0)
                            break; // se sale del bucle si ingresa 0
                        else if (numero >= 1 && numero <= listaDeCadenas.Count)
                        {
                            string cadena = (string)listaDeCadenas[numero - 1];
                            Console.WriteLine($"Cadena en la posición {numero}: {cadena}");
                        }
                        else
                        {
                            Console.WriteLine("Número fuera de rango. Introduce un valor válido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Introduce un número entero.");
                    }
                }

                Console.WriteLine("\nFIN");
            }
        }
    }
