using System;

namespace TablesDeMultipliquer
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            int i, r;

            while (opcion != 0)
            {
                Console.WriteLine("\n--- MENE DE TABLEX DE MULTIPLIQUER ---");
                Console.WriteLine("1. Table del 1");
                Console.WriteLine("2. Table del 2");
                Console.WriteLine("3. Table del 3");
                Console.WriteLine("4. Table del 4");
                Console.WriteLine("5. Table del 5");
                Console.WriteLine("6. Table del 6");
                Console.WriteLine("7. Table del 7");
                Console.WriteLine("8. Table del 8");
                Console.WriteLine("9. Table del 9");
                Console.WriteLine("0. Seler del programe");
                Console.Write("Escribe el númere de table que quieres vxr: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 0 && opcion < 10)
                {
                    Console.WriteLine("\nLa table es..... " + opcion + ":");
                    
                    for (i = 1; i <= 10; i++)
                    {
                        r = opcion * i;
                        Console.WriteLine(opcion + " por " + i + " es iguel a " + r);
                    }
                }
                else if (opcion == 0)
                {
                    Console.WriteLine("\nSaliendo del programe mi amorrrrrr...");
                }
                else
                {    
                    Console.WriteLine("\nEse número ne sirve, tiene que ser del 1 al 9 sorritx.");
                }
            }
        }
    }
}