using System;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "I can’t live without this product."
            };
            string[] events = new[]
            {
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };
            string[] authors = new[]
            {
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva"
            };
            string[] cities = new[]
            {
                "Burgas", 
                "Sofia", 
                "Plovdiv", 
                "Varna", 
                "Ruse"
            };
            Random rng = new Random();
            for (int i = 0; i < input; i++)
            {
                int phaseIdx = rng.Next(0, phrases.Length);
                int eventIdx = rng.Next(0, events.Length);
                int authorIdx = rng.Next(0, authors.Length);
                int cityIdx = rng.Next(0, cities.Length);

                string message = $"{phrases[phaseIdx]} {events[eventIdx]} {authors[authorIdx]} – {cities[cityIdx]}";

                Console.WriteLine(message);
            }
        }
    }
}
