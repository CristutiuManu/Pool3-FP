using System;
namespace Pool3
{
    public class Problema17
    {
        // Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
        public Problema17()
        {
            int i, j, k;
            Console.WriteLine("Introduceti N-ul");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti baza ls care doriti sa se converteasca numarul");

            int b = int.Parse(Console.ReadLine());

            int conversieInitiala = 0;
            
            while (n % b != 0)
            {
                int rest = n % b;
                conversieInitiala += rest;
                conversieInitiala *= 10;
                n = n / b;
            }

            if (conversieInitiala % 10 == 0)
                conversieInitiala /= 10;

            int conversieFinala = 0;
            while (conversieInitiala != 0)
            {
                conversieFinala = conversieFinala * 10 + conversieInitiala % 10;
                conversieInitiala /= 10;
            }

            Console.WriteLine("Numarul convertit este egal cu: " + conversieFinala);



        }
    }
}
