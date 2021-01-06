using System;
namespace Pool3
{
    public class Problema17
    {
        // Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
        public Problema17()
        {
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                v[i] = random.Next(50);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();



        }
    }
}
