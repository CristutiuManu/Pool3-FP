using System;
namespace Pool3
{
    public class Problema3
    {
        // Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
        // Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
        public Problema3()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul citit este: ");
            for (i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            int pozMin = v[0];
            int pozMax = v[0];
            for (i = 1; i < n; i++)
            {
                if (pozMax < v[i])
                    pozMax = i;

                if (pozMin > v[i])
                    pozMin = i;
                
            }

            Console.WriteLine($"Pozitia minima este: {pozMin}, pozitia maxima este {pozMax}. ");

        }
    }
}
