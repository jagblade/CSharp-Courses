using System;

namespace _8._OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            //Превръщаме минутите и часовете само в минути:
            // examMinutes += examHour * 60;
            examMinutes = examMinutes + examHour * 60;

            //Превръщаме минутите и часовете само в минути:
            //arivalMinutes += arivalHour * 60;
            arrivalMinutes = arrivalMinutes + arrivalHour * 60;

            //Правим 3 проверки: дали закъснява/подранява или е на време за изпита:

            //“Late”, ако студентът пристига по-късно от часа на изпита.
            if (examMinutes < arrivalMinutes)
            {
                Console.WriteLine("Late");

                int difference = arrivalMinutes - examMinutes;
                int lateHours = difference / 60;
                int lateMinutes = difference % 60;

                //Ако студентът закъснява правим 2 вътрешни проверки, дали закъснява с повече или по-малко от час:
                if (lateHours >= 1)
                {
                    //Ако студентът закъснява с повече от час правим 2 по-вътрешни проверки, дали закъснява с < или > от 10мин.: 
                    if (lateMinutes < 10)
                    {
                        Console.WriteLine($"{lateHours}:0{lateMinutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{lateHours}:{lateMinutes} hours after the start");
                    }

                }
                //проверяваме дали закъснява с поне 1 мин:
                else if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
            }

            //“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            if ((examMinutes >= arrivalMinutes) && (examMinutes - arrivalMinutes <= 30))
            {
                Console.WriteLine("On time");
                int onTimeMinutes = examMinutes - arrivalMinutes;

                if (examMinutes - arrivalMinutes > 0)
                {
                    Console.WriteLine($"{onTimeMinutes} minutes before the start");
                }
            }

            //“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            if ((examMinutes >= arrivalMinutes) && (examMinutes - arrivalMinutes > 30))
            {
                Console.WriteLine("Early");

                int difference = examMinutes - arrivalMinutes;
                int earliHours = difference / 60;
                int earlyMinutes = difference % 60;

                //Ако студентът подранява правим 2 вътрешни проверки, дали закъснява с повече или по-малко от час:
                if (earliHours >= 1)
                {
                    //Ако студентът закъснява с повече от час правим 2 по-вътрешни проверки, дали закъснява с < или > от 10мин.: 
                    if (earlyMinutes < 10)
                    {
                        Console.WriteLine($"{earliHours}:0{earlyMinutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{earliHours}:{earlyMinutes} hours before the start");
                    }
                }
                else if (earliHours <= 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
        }
    }
}
