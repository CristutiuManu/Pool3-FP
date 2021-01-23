using System;
namespace Pool3
{
    public class Problema18
    {
        // Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
        // Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
        public Problema18()
        {
            Console.WriteLine("Introduceti gradul polinomului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int m;
            for (int i = 0; i < n; i ++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }


            v[0] = 1;
            for (int i = 1; i <= n - 1; i ++)
            {
                m = v[i];
                v[i] = 0;
                for (int j = i; j >= 1; j--)
                    v[j] = v[j] = v[j - 1] * m;
            }
            Console.WriteLine();

            for (int i = 0; i < n; i ++)
            {
                Console.Write(v[i] + " ");
            }



        }
    }
}
