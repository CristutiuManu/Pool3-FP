using System;
namespace Pool3
{
    public class Problema8
    {
        // Rotire. Se da un vector cu n elemente.
        // Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        public Problema8()
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
            Console.WriteLine("Vectorul rotit este: ");
            int x = v[0];
            for (int i = 1; i < n; i++)
            {
                v[i - 1] = v[i];
            }
            v[n-1] = x;

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}
