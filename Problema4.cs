using System;
namespace Pool3
{
    public class Problema4
    {
        // Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.

        public Problema4()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int aparitiiMinim = 0;
            int aparitiiMaxim = 0;
            int contorTotal = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }

            int maxim = v[0];
            int minim = v[0];

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    aparitiiMaxim = 1;
                }
                else if (v[i] == maxim)
                    aparitiiMaxim++;

                if (minim > v[i])
                {
                    minim = v[i];
                    aparitiiMinim = 1;
                }
                else if (v[i] == minim)
                    aparitiiMinim++;
            }

            contorTotal = aparitiiMinim + aparitiiMaxim;
            Console.WriteLine($"Maximul este {maxim}, minimul este {minim}, iar numarul de aparitii pentru maxim si minim este: {aparitiiMaxim}, respectiv {aparitiiMinim}");
            Console.WriteLine($"Numarul total de aparitii al celor doua este: {contorTotal}");
        }
    }
}
