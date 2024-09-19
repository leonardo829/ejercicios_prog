using System;
using System.Collections;
using System.Collections.Generic;


namespace e_77
{
     class sortedList
    {

        static void Main()
        {
            SortedList<string,string> diccionario = new SortedList<string, string>();
            diccionario.Add("hello", "Hola");
            diccionario.Add("bye","Adios");
            diccionario.Add("dog", "Perro");
            diccionario.Add("cat", "Gato");
            diccionario.Add("apple", "Manzana");
            diccionario.Add("flower", "Flor");
            diccionario.Add("mouse", "Raton");
            diccionario.Add("orange", "Naranja");
            diccionario.Add("lemon", "limón");
            diccionario.Add("house", "casa");

            Console.WriteLine("Palabras disponibles para traducir:");
            foreach (var palabras in diccionario.Keys)
            {
                Console.WriteLine($"- {palabras}");
            }
            while (true)
            {
                Console.WriteLine("Escribe una de las palabras disponibles para traducir o 0 para terminar");
                string PIng = Console.ReadLine().ToLower();

                if (PIng == "0")
                {
                    break;
                }


                // Buscar la traduccion y la muestra
                if (diccionario.ContainsKey(PIng))
                {
                    string PTrad = diccionario[PIng];
                    Console.WriteLine($"La traducción de '{PIng}' es '{PTrad}'.");
                }
                else
                {
                    Console.WriteLine($"No se encontro una traducción para '{PIng}'.");
                }
            }
        }
    }
}
