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
            StreamWriter sw = new StreamWriter("ejemplo.txt" , true);
            // Si el archivo no existe, lo creará
            // y  si ya es un archivo existente, escribira en el 

            string[] lines =
            {"Primera Linea"
            , "Segunda Linea" 
            , "Tercera Linea"};

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
