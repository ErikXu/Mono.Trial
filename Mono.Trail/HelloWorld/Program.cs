using System;
using System.Configuration;
using Microsoft.Owin.Hosting;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            using (WebApp.Start<Startup>(ConfigurationManager.AppSettings["url"]))
            {
                Console.WriteLine("Server is running, Enter q to exit...");
                while (true)
                {
                    if (Console.ReadLine() == "q")
                    {
                        break;
                    }
                }
            }
        }
    }
}
