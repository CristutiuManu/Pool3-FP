using System;
namespace Pool3
{
    public class Problema16
    {
        // Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.

        public Problema16()
        {
            int CMMDC(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else { b -= a; }
                }
                return a;
            }


            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i = 0, b = 0;
            Random random = new Random();

            for(i = 0; i < n; i++)
            {
                v[i] = random.Next(50);
            }

            for (i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            //int cmmdc = v[0];
            //for (i = 1; i < n; i++)
            //{
            //    int x = v[i];
            //    while (x != cmmdc)
            //    {
            //        if (x > cmmdc)
            //            x = x - cmmdc;
            //        else if (x < cmmdc)
            //            cmmdc = cmmdc - x;
            //    }
            //}

            for (i = 1; i < n; i++)
                if (i == 1)
                    b = CMMDC(v[i - 1], v[i]);
                else
                    b = CMMDC(b, v[i]);

            Console.WriteLine("Cmmdc este " + b);

            
            // Cred ca ceva nu merge cum ar trebui
        }
    }
}
