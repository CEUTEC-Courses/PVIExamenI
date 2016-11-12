using System;
using ExamenPIV.Data;

namespace ExamenPIV.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ProyectoPivContext("Proyecto"))
            {
                Console.WriteLine("Hola mundo");
                Console.ReadKey();
            }   
        }
    }
}
