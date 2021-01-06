using System;
namespace Pool3
{
    public class Problema14
    {
        // Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
        // (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
        public Problema14()
        {


            int[] v = { 1, 2, 4, 0, 0, 43, 50, 23 };
            int n = v.Length;
            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();

            int x = n;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == 0)
                {
                    x--;
                    int aux = v[i];
                    v[i] = v[x];
                    v[x] = aux;
#warning not working as it supposed to 

                }
               // x--;
            }

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

        }
    }
}
