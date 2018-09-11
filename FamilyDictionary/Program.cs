using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() {
                {"name", "Kristina" },
                {"age", "30" }
            });

            myFamily.Add("dad", new Dictionary<string, string>() {
                {"name", "John Boy" },
                {"age", "50" }
            });

            myFamily.Add("mom", new Dictionary<string, string>() {
                {"name", "Lisa" },
                {"age", "49" }
            });

            string relation;
            string name;
            string age;

            foreach(KeyValuePair<string, Dictionary<string, string>> person in myFamily)
            {
                relation = person.Key;
                name = person.Value["name"];
                age = person.Value["age"];
                Console.WriteLine($"{name} is my {relation} and is {age} years old");
            }


            Console.ReadLine();
        }
    }
}
