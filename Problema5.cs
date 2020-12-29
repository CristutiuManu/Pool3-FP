using System;
namespace Pool3
{
    public class Problema5
    {
        // Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
        // Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
        public Problema5()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            int e;
            int k;
            Random random = new Random();
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = random.Next(100);
            }

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
            Console.WriteLine("Introdu valoarea e: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu pozitia unde se va afla valoarea e");
            k = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < k; i++)
            {
                v[i] = v[i + 1];
            }
            n++;

            v[k] = e;

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

        }
    }
}
