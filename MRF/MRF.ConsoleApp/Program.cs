using System;
using MRF.Data;

namespace MRF.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Initializing MRF Database...");

            DataContext context = new DataContext();
            context.Database.Initialize(true);

            Console.WriteLine("Done...");
            Console.ReadLine();
        }
    }
}
