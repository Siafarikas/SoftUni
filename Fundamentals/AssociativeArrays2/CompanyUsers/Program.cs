using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] parts = input.Split(" -> ");
                string companyName = parts[0];
                string employeeId = parts[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string> { employeeId });
                }
                else
                {
                    if (!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }

            }

            companies = companies
                .OrderBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
