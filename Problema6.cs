using System;
namespace Pool3
{
    public class Problema6
    {
        // Se da un vector cu n elemente si o pozitie din vector k.
        // Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
        public Problema6()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
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

            Console.WriteLine("Introdu pozitia de unde se va sterge elementul");
            k = int.Parse(Console.ReadLine());

            for (int i = k; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            n--;

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

        }
    }
}
