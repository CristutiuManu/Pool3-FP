using System;
namespace Pool3
{
    public class Problema15
    {
        // Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
        public Problema15()
        {
            Console.WriteLine("Introduceti N-ul");
           // int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] v = {2,5,6,2,2,8,2};
            int k = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    v[i] = random.Next(100);
            //}

            Console.WriteLine("Vectorul citit este: ");
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i] + " ");
            
            Console.WriteLine();

            int x = v.Length;
            for (int i = 0; i < v.Length; i++)
            {
                while (k < x)
                {
                    if (v[k] == v[i])
                    {
                        v[i] = v[i + 1];
                        x--;
                        i++;
                    }
                    else k++;
                }
                
            }
            

            for (int i = 0; i < x; i++)
                Console.Write(v[i] + " ");
        }
    }
}
