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

            static void Main()
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

                Console.WriteLine("\nModo consulta activado. Introduce un numero para ver la cadena en esa posicion.");
                Console.WriteLine("Presiona 0 para salir.");

                while (true)
                {
                    Console.Write("Numero (0 para salir): ");
                    string numeroStr = Console.ReadLine();

                    if (int.TryParse(numeroStr, out int numero))
                    {
                        if (numero == 0)
                            break; // se sale del bucle si ingresa 0
                        else if (numero >= 1 && numero <= listaDeCadenas.Count)
                        {
                            string cadena = (string)listaDeCadenas[numero - 1];
                            Console.WriteLine($"Cadena en la posicion {numero}: {cadena}");
                        }
                        else
                        {
                            Console.WriteLine("Numero fuera de rango. Introduce un valor valido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no valida. Introduce un numero entero.");
                    }
                }

                Console.WriteLine("\nFIN");
            }
        }
    }
