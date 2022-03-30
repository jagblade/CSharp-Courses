using System;

namespace _03._Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            //Входът се чете от конзолата и съдържа 3 реда:
            // Тегло на пратката в килограми – реално число в интервала[0.01... 150.00]
            //Тип услуга –  текст със следните възможности: "standard" или "express"
            //Разстояние в километри – цяло число в интервала[1... 1000]

            double parcel = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double pricePerKm = 0;

            double price = 0;

            if (parcel < 1)
            {
                pricePerKm = 0.03;
            }
            else if (parcel < 10)
            {
                pricePerKm = 0.05;
            }
            else if (parcel < 40)
            {
                pricePerKm = 0.1;
            }
            else if (parcel < 90)
            {
                pricePerKm = 0.15;
            }
            else
            {
                pricePerKm = 0.2;
            }

            switch (type)
            {
                case "standard":
                    price = distance * pricePerKm;
                    break;
                case "express":
                    if (parcel < 1)
                    {
                        price = (distance * pricePerKm) + distance * (0.8 * pricePerKm) * parcel;
                    }
                    else if (parcel < 10)
                    {
                        price = (distance * pricePerKm) + distance * (0.4 * pricePerKm) * parcel;
                    }
                    else if (parcel < 40)
                    {
                        price = (distance * pricePerKm) + distance * (0.05 * pricePerKm) * parcel;
                    }
                    else if (parcel < 90)
                    {
                        price = (distance * pricePerKm) + distance * (0.02 * pricePerKm) * parcel;
                    }
                    else
                    {
                        price = (distance * pricePerKm) + distance * (0.01 * pricePerKm) * parcel;
                    }

                    break;
            }
            

            Console.WriteLine($"The delivery of your shipment with weight of {parcel:f3} kg. would cost {price:f2} lv.");
        }
    }
}
