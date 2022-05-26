using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvancedMay2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.
            //влогър -> списък с последователи (followers)
            //влогър -> списък със следващи (following)

            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();
            //спрямо брой на последователи
            followers.OrderBy(entry => entry.Value.Count);


            Dictionary<string, List<string>> following = new Dictionary<string, List<string>>();
            //сортираме във низходящ ред спрямо брой последованите -> сортираме по име (a - z)
            //Иван ->  {Петър, Георги, Тишо} 3
            //Георги ->  {Петър, Иван, Тишо, Мартин} 4
            //Мартин ->  {Петър, Иван, Тишо} 3
            following
                .OrderByDescending(entry => entry.Value.Count) //1. Георги   2. Иван    3.Мартин
                .ThenBy(entry => entry.Key);                   //1. Георги   2. Иван   3. Мартин

            //descending (намаляващ ред): z -> a; 10 -> 0
            //ascending (нарастващ ред): a -> z; 0 -> 10

            //8. 
            //студент: (курс -> точки)
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            //1. име на студентите (нарастващ ред)
            //2. намаляващ ред на точките

            students
                .OrderBy(entry => entry.Key); //entry => key: име на студент, value: речник с курсове

            foreach (var studentEntry in students)
            {
                //studentEntry:  key: име на студент, value: речник с курсове
                Dictionary<string, int> courses = studentEntry.Value;
                //key: курс, value: точки от курса
                courses.OrderByDescending(entry => entry.Value);
            }

        }
    }
}
