﻿using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members;


        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
        public Person GetOldestMember()
        {
            Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;
        }

        public HashSet<Person> GetAllPeopleOver30()
        {
           return this.members.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToHashSet();
        }
    }
}
