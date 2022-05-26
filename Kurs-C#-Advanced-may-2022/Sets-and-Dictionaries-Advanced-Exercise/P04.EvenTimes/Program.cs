using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //бр. числата

            //запис: ключ -> стойност
            Dictionary<int, int> numbersOcc = new Dictionary<int, int>();
            //число -> бр. пъти

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                //числото да го нямаме
                if (!numbersOcc.ContainsKey(number))
                {
                    //запис
                    numbersOcc.Add(number, 1);
                }
                //числото да го имаме
                else
                {
                    numbersOcc[number]++;
                }
            }

            //число -> пъти 
            /* Console.WriteLine(numbersOcc
                                 .First(entry => entry.Value % 2 == 0) //запис: число -> пъти
                                 .Key); //число*/

            foreach (var entry in numbersOcc)
            {
                if (entry.Value % 2 == 0)
                {
                    Console.WriteLine(entry.Key);
                }
            }
        }
    }
}
