using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            bool error = false;

            double comission = 0.0;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                    error = true;
                }

            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                    error = true;
                }

            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                    error = true;
                }

            }

            else
            {
                Console.WriteLine("error");
                error = true;
            }

            if (error == false)
            {
                Console.WriteLine($"{comission:f2}");
            }
        }
    }
}
