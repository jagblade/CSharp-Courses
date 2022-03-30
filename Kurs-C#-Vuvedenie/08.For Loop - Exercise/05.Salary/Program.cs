using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n = int.Parse(Console.ReadLine());
                int salary = int.Parse(Console.ReadLine());

                double penalty = 0;

                for (int i = 1; i <= n; i++)
                {
                    string site = Console.ReadLine();

                    if (site == "Facebook")
                    {
                        penalty = penalty + 150;
                    }
                    else if (site == "Instagram")
                    {
                        penalty = penalty + 100;
                    }
                    else if (site == "Reddit")
                    {
                        penalty = penalty + 50;
                    }

                    if (penalty >= salary)
                    {
                        break;
                    }
                }

                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                }
                else
                {
                    Console.WriteLine(salary - penalty);
                }
            }
        }
    }