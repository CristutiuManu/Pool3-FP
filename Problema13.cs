using System;
namespace Pool3
{
    public class Problema13
    {
        // Sortare prin insertie.Implementati algoritmul de sortare<Insertion Sort>. 
           public Problema13()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
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

            for (int i = 1; i < n; ++i)
            {
                int k = v[i];

                int j = i - 1;

                while (j >= 0 && v[j] > k)
                {
                    v[j + 1] = v[j];
                    j--;
                }
                v[j+1] = k;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

        }
    }
}
