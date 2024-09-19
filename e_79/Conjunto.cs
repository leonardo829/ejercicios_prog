using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_79
{
    class Conjunto
    {

        static void Main()
        {
            HashSet<string> NFrases = new HashSet<string>();

            Console.WriteLine("Ingresa una frase (deja vacio para salir):");

            while (true)
            {
                Console.Write("Frase: ");
                string frase = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(frase))
                    break; // salida del bucle al introducir valor vacio

                //consultamos si la frase existe, sino la guardamos
                if (NFrases.Contains(frase))
                {
                    Console.WriteLine("esta frase ya existe");
                }
                else
                {
                    NFrases.Add(frase);
                    Console.WriteLine("Frase registrada correctamente.");
                }
            }

            Console.WriteLine("Hasta luego");
        }
    }
}
