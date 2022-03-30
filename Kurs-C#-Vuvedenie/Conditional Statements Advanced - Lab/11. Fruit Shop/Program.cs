using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;


            if (weekDay == "Saturday" || weekDay == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.7;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else
                {
                    Console.WriteLine("error"); 
                }



            }
            else if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday")
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                    double total = price * quantity;
                    Console.WriteLine($"{total:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }   

            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
