using System;
namespace Pool3
{
    public class Problema10
    {
        // Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
        // Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        public Problema10()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] v = new int[n];
            int left = 0;
            int k;
            int right = n - 1;
            int mid;
            for (int i = 0; i < n; i++)
            {
                v[i] = random.Next(100);
            }

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            Console.WriteLine("Insereaza elementul k");
            k = int.Parse(Console.ReadLine());

            while (left <= right)
            {
                if (right >= 1)
                {
                    mid = left + (right - left) / 2;

                    if (v[mid] > k)
                    {
                        right = mid - 1;
                    }
                    else if (v[mid] < k)
                    {
                        left = mid + 1;
                    }
                    else if (k == v[mid])
                    {
                        Console.WriteLine($"Elementul {k} se afla pe pozitia {mid}");
                        break;
                    }
                }

            }
          

        }
    }
}
