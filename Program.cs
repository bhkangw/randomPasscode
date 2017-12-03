using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace randomPasscode
{
    public class Program
    {
        // public static string GeneratePasscode()
        // {
        //     Random random = new Random();
        //     string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        //     string result = "";
        //     for (int i = 0; i < 14; i++)
        //     {
        //         result.Append(characters[random.Next(characters.Length)]);
        //     }
        //     return result.ToString();
        // }
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
