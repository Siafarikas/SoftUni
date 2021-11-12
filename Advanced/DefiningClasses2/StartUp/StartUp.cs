using System;
using System.Linq;
using System.Collections.Generic;
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person currentPerson = new Person(info[0], int.Parse(info[1]));
                family.AddMember(currentPerson);
            }

            HashSet<Person> over30 = family.GetAllPeopleOver30();

            foreach (var person in over30)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }

        }
    }
}
