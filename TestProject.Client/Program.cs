using System;

namespace TestProject.Client
{
    class Program
    {
        private static void Main(string[] args)
        {
            var record = new Record();
            record.Create();
            record.Post();

            Console.ReadLine();
        }
    }
}
