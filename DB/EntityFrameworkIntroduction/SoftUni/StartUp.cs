using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var db = new SoftUniContext();
            string result = RemoveTown(db);
            Console.WriteLine(result);
        }


        //Problem 01 & 02 - Import SoftUni Db & DbFirst

        //Problem 03
        public static string GetEmployeesFullInformation(SoftUniContext db)
        {
            var employees = db.Employees
                .OrderBy(x => x.EmployeeId);
            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }
            return sb.ToString();
        }

        //Problem 04
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext db)
        {
            var employees = db
                .Employees
                .Where(x => x.Salary > 50000)
                .OrderBy(x => x.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .ToArray();
            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        //Problem 05
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext db)
        {
            var employees = db
                .Employees
                .Where(x => x.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        //Problem 06
        public static string AddNewAddressToEmployee(SoftUniContext db)
        {
            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };
            db.Addresses.Add(newAddress);

            Employee nakovEmployee = db
                .Employees
                .First(e => e.LastName == "Nakov");
            nakovEmployee.Address = newAddress;
            db.SaveChanges();

            var employeesAdresses = db
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToArray();

            return String.Join(Environment.NewLine, employeesAdresses);
        }

        //Problem 07
        public static string GetEmployeesInPeriod(SoftUniContext db)
        {
            var employees = db
                .Employees
                .Include(x => x.EmployeesProjects)
                .Include(x => x.Manager)
                .Where(x => x.EmployeesProjects.Any(e => e.Project.StartDate.Year >= 2001))
                .Take(10)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.Manager.FirstName} {e.Manager.LastName}");
                var projectsOfEmployee = db
                    .EmployeesProjects
                    .Where(x => x.Employee.LastName == e.LastName)
                    .Select(x => new
                    {
                        ProjectName = x.Project.Name,
                        StartDate = x.Project.StartDate,
                        EndDate = x.Project.EndDate
                    })
                    .ToList();
                foreach (var p in projectsOfEmployee)
                {
                    if (p.EndDate.HasValue)
                    {
                        sb.AppendLine($"--{p.ProjectName} - {p.StartDate} - {p.EndDate}");
                    }
                    else
                    {
                        sb.AppendLine($"--{p.ProjectName} - {p.StartDate} - not finished");
                    }
                }
            }

            return sb.ToString();
        }

        //Problem 08
        public static string GetAddressesByTown(SoftUniContext db)
        {
            var addresses = db
                .Addresses
                .Include(x => x.Town)
                .Include(x => x.Employees)
                .OrderByDescending(x => x.Employees.Count)
                .ThenBy(x => x.Town.Name)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var a in addresses)
            {
                sb.AppendLine($"{a.AddressText}, {a.Town.Name} - {a.Employees.Count} employees");
            }
            return sb.ToString();
        }

        //Problem 09
        public static string GetEmployee147(SoftUniContext db)
        {
            Employee employee = db
                .Employees
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Where(x => x.EmployeeId == 147)
                .FirstOrDefault();

            var sb = new StringBuilder();
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            var projects = employee.EmployeesProjects
                .OrderBy(x => x.Project.Name);
            foreach (var p in projects)
            {
                sb.AppendLine($"{p.Project.Name}");
            }

            return sb.ToString();
        }

        //Problem 10
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext db)
        {
            var departments = db
                .Departments.Include(x=>x.Employees)
                .Where(x => x.Employees.Count > 5)
                .OrderBy(x => x.Employees.Count)
                .ThenBy(x => x.Name)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var d in departments)
            {
                sb.AppendLine($"{d.Name} - {d.Manager.FirstName} {d.Manager.LastName}");
                var employees = d
                    .Employees
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToArray();
                foreach (var e in employees)
                {
                    sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }
            }
            return sb.ToString();
        }

        //Problem 11
        public static string GetLatestProjects(SoftUniContext db)
        {
            var projects = db
                .Projects
                .OrderByDescending(x => x.StartDate)
                .Take(10)
                .OrderBy(x => x.Name)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var p in projects)
            {
                sb.AppendLine($"{p.Name}");
                sb.AppendLine($"{p.Description}");
                sb.AppendLine($"{p.StartDate}");
            }

            return sb.ToString();
            
        }

        //Problem 12
        public static string IncreaseSalaries(SoftUniContext db)
        {
            var employees = db
                .Employees
                .Include(x => x.Department)
                .Where(e => e.Department.Name == "Engineering" ||
                            e.Department.Name == "Tool Design" ||
                            e.Department.Name == "Marketing" ||
                            e.Department.Name == "Information Services");

            foreach (var employee in employees)
            {
                employee.Salary += employee.Salary * 0.12m;
            }
            db.SaveChanges();
            var employeesOutput = employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var e in employeesOutput)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }
            return sb.ToString();
        }

        //Problem 13
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext db)
        {
            string chars = "Sa";
            var employees = db
                .Employees
                .Where(e => e.FirstName.StartsWith(chars))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();

            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }

            return sb.ToString();
        }

        //Problem 14
        public static string DeleteProjectById(SoftUniContext db)
        {
            var project = db
                .Projects
                .Find(2);

            var employeesWithProject = db
                .EmployeesProjects
                .Where(e => e.ProjectId == 2);
            db.EmployeesProjects.RemoveRange(employeesWithProject);
            db.SaveChanges();
                
            db.Projects.Remove(project);
            db.SaveChanges();

            var sb = new StringBuilder();
            var output = db
                .Projects
                .Take(10)
                .ToArray();
            foreach (var p in output)
            {
                sb.AppendLine(p.Name);
            }
            return sb.ToString();
        }

        //Problem 15
        public static string RemoveTown(SoftUniContext db) 
        {
            var seattleAddresses = db
                .Addresses
                .Where(x => x.Town.Name == "Seattle")
                .ToArray();

            var employeesInSeattle = db
                .Employees
                .ToArray()
                .Where(e => seattleAddresses.Any(a => a.AddressId == e.AddressId))
                .ToArray();

            foreach (var e in employeesInSeattle)
            {
                e.AddressId = null;
            }
            db.Addresses.RemoveRange(seattleAddresses);
            Town seattle = db
                .Towns
                .First(t => t.Name == "Seattle");
            db.Towns.Remove(seattle);
            db.SaveChanges();
            return $"{seattleAddresses.Length} addresses in Seattle were deleted";
        }

    }
}
