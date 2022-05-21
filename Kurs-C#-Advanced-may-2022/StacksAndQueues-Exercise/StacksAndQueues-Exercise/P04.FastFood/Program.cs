using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine()); //налична храна
            List<int> ordersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Queue<int> ordersQueue = new Queue<int>(ordersList); //54 30 16 7 9
            Console.WriteLine(ordersQueue.Max()); //максималната поръчка в списъка

            //започваме изпълнението на поръчките
            int countOrders = ordersQueue.Count; //бр. поръчки
            for (int order = 1; order <= countOrders; order++)
            {
                //проверка дали налична храна ще покрие поръчката
                if (quantityFood >= ordersQueue.Peek())
                {
                    //изпълнявам поръчката
                    quantityFood -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    //нямаме налична храна
                    break;
                }
            }

            //да сме изпълнили всички поръчки
            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                //да не сме изпълнили всички поръчки
                Console.WriteLine("Orders left: " + string.Join(" ", ordersQueue));
            }
        }
    }
}