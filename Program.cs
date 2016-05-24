using System;
using Microsoft.AspNetCore.Hosting;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://0.0.0.0:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();            
        }
    }
}
