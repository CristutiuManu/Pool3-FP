using System;
namespace Pool3
{
    public class Problema11
    {
        // Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).

        public Problema11()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            int[] nrPrime = new int[n];
            bool[] sieve = new bool[101];
            int sol = 0;

            //Console.WriteLine("Vectorul citit este: ");
            //for (int i = 0; i < n; i++)
            //    Console.Write(v[i] + " ");

            //Console.WriteLine();

            //for (int i = 0; i < n; i++)
            //    Console.Write(sieve[i] + " ");

            //Console.WriteLine();

            sieve[0] = sieve[1] = true;

            for (int i = 2; i * i <= n; i++)
            {
                if (!sieve[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        sieve[j] = true;
                    }
                }
            }

            nrPrime[sol++] = 2;
            for (int i = 3; i <= n; i += 2)
                if (!sieve[i])
                    nrPrime[sol++] = i;

            Console.WriteLine("Numarul de numere prime mai mici sau egale cu N este: " + sol);
            Console.WriteLine("Numerele prime sunt: ");
            for (int i = 0; i < sol; i++)
                Console.Write(nrPrime[i] + " ");
        }
    }
}
