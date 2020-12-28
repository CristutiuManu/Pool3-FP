using System;
namespace Pool3
{
    public class Problema1
    {
        // Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        public Problema1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Vectorul citit este: ");

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                sum += v[i];
            }

            Console.Write("Rezultatul este: " + sum + " ");
        }
    }
}
