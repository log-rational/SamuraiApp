using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static readonly SamuraiContext context = new SamuraiContext();
        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurai();
            GetSamurais("After Add:");
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }

        private static void GetSamurais(string text)
        {
            
            List<Samurai> samurais = context.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is {samurais.Count()}");
            foreach(var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Umesh" };
            context.Samurais.Add(samurai);
            context.SaveChanges();

           
        }
    }
}
