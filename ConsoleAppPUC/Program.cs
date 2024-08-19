using System;

namespace ConsoleAppPUC // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            
            string name = string.Empty;

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("\n Informe seu Nome:");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Bem vindo, {name}");
        }
    }
}