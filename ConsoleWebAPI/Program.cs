using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace ConsoleWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var host = new WebHostBuilder()
            .UseUrls("http://localhost:6002","http://127.0.0.1:6007")
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }
    }
}
