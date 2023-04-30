using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_13
{
    public class Person
    {
        public static List<Person> listPerson = new List<Person>();

        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age) 
        {
            Age = age;
            Name = name;
            listPerson.Add(this);
        }

        public static void SetNewPerson()
        {
            int nom = 0;
            for (int i = 18; i < 26; i++)
            {
                nom++;
                var name = "person" + nom;
                var age = i;
                new Person(name, age);

            }
        }
    }
}
