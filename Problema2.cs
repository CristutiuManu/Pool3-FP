using System;
namespace Pool3
{
    public class Problema2
    {
        // Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.

        public Problema2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i;
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Vectorul citit este: ");

            for ( i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            int k = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (v[i] != k)
                {
                    Console.WriteLine("Elementul se afla pe pozitia: " + i);
                    break;
                }
                else Console.WriteLine("-1");

            }

#warning De revizuit
        }
    }
}
