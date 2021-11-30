using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data;
using System;

namespace P03_FootballBetting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            FootballBettingContext db = new FootballBettingContext();

            db.Database.Migrate();

            Console.WriteLine("Db created successfully");

        }
    }
}
