using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var iii = list.Top(30);

            Person.SetNewPerson();
            
            Person.listPerson.Top(30, person => person.Age);

        
        }
    }

    public static class MyExtentions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> colection, int value)
        {
            List<T> rezult = new List<T>();
            if (value > 1 && value < 101)
            {
                int collElements = (int)Math.Ceiling((double)colection.Count() / 100 * value);
                rezult = colection.OrderByDescending(x => x).Take(..collElements).ToList();

                Console.WriteLine(string.Join(", ", rezult));
                Console.WriteLine("-----------------");
            }
            else
            {
                throw new ArgumentException();
            }

            return rezult;
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> colection, int value, Func<T,int> func)
        {
            List<T> rezult = new List<T>();
            if (value > 1 && value < 101)
            {
                int collElements = (int)Math.Ceiling((double)colection.Count() / 100 * value);
                rezult = colection.OrderByDescending(func).Take(..collElements).ToList();

                for (int i = 0; i < rezult.Count; i++)
                {
                    var nameProp = typeof(Person).GetProperty("Name");
                    var ageProp = typeof(Person).GetProperty("Age");
                    var name = nameProp?.GetValue(rezult[i]);
                    var age = ageProp?.GetValue(rezult[i]);
                    Console.WriteLine($"{name} - {age}");
                } 
            }
            else
            {
                throw new ArgumentException();
            }

            return rezult;
        }
    }
}