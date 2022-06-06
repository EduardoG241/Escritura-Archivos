using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo 2.txt", true);
            // Si el archivo no existe, lo creará
            // y  si ya es un archivo existente, escribira en el 
            Console.Write("Indica cuantos videojuegos has jugado en este mes:");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Clear();
            
            
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Juego No. " + i);
                Console.WriteLine();
                Console.Write("Ingrese el nombre del videojuego:");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el genero del juego:");
                string genero = Console.ReadLine();
                Console.Write("Ingrese la dificultad del juego:");
                string dificultad = Console.ReadLine();
                sw.WriteLine(nombre + " Genero: " + genero + " Dificultad: " + dificultad);// Escribe en el archivo
                Console.Clear();
                
            }
            sw.Close();//Cierra el archivo

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
