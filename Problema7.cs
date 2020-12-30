using System;
namespace Pool3
{
    public class Problema7
    {
        // Reverse. Se da un vector nu n elemente.
        // Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        public Problema7()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] v = new int[n];
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = random.Next(100);
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(100);
            }

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
            Console.WriteLine("Vectorul inversat este: ");

            reverse(v, a, n);
            v = a;
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

            static void reverse(int[] v, int[] a, int n)
            {
                for (long i = 0; i < n; i++)
                {
                    a[i] = v[n - i - 1];
                }
            }

        }
    }
}
