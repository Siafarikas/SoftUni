using System;
using System.Linq;
namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var num in numbers)
            {
                if (!num.All(char.IsDigit))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                ICallable phone;
                if (num.Length== 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }
                phone.Call(num);
            }
            string[] sites = Console.ReadLine().Split(" ");
            foreach (var site in sites)
            {
                Smartphone smartphone = new Smartphone();
                if (site.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                smartphone.Browse(site);
            }
        }
    }
}
