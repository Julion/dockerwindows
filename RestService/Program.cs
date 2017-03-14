using Microsoft.Owin.Hosting;
using System;

namespace RestService
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
