using System;
namespace Pool3
{
    public class Problema9
    {
        // Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
        public Problema9()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = random.Next(100);
            }

            Console.WriteLine();

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Vectorul rotit este: ");
            int x = v[0];
            for (int i = k; i < n; i++)
            {
                v[i - k] = v[i];
            }
            v[n-k] = x;

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}
