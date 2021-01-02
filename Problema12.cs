using System;
namespace Pool3
{
    public class Problema12
    {
        // Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
        public Problema12()
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


            for (int i = 0; i < n - 1; i++)
            {
                    int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (v[j] < v[min])
                    {
                        min = j;
                    }
                }
                    int aux = v[min];
                    v[min] = v[i];
                    v[i] = aux;
                    
                }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}
