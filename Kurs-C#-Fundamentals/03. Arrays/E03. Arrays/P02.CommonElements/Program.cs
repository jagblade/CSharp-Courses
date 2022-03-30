using System;

namespace P02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            for (int f = 0; f < secondArray.Length; f++)
            {
                string elementChecked = secondArray[f];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (elementChecked == firstArray[i])
                    {
                        Console.Write(elementChecked + " ");
                    }

                }

            }
        }
    }
}
