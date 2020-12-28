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
            Random rnd = new Random();
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(99);
            }

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            int maxim = v[0];
            int minim = v[0];
            int contorMinim = 0;
            int contorMaxim = 0;
            int contorTotal = 0;
            for(int i = 0; i < n; i++)
            {
                 if (maxim < v[i])
                    maxim = v[i];

                 if (minim > v[i])
                    minim = v[i];

               // De revizuit


            }
            contorTotal = contorMinim + contorMaxim;
            Console.WriteLine($"Maximul este {maxim}, minimul este {minim}, iar numarul de aparitii pentru maxim si minim este: {contorMaxim}, respectiv {contorMinim}");
            Console.WriteLine($"Numarul total de aparitii al celor doua este: {contorTotal}");
            

            
        }
    }
}
