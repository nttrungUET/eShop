using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MISA.Serilog.Extensions;
using Serilog;
using System;
using System.IO;

namespace MISA.eShop.ProductApi.Host
{
    public class Program
    {
        public static int Main(string[] args)
        {

            //Build đối tượng lưu thông tin config từ file appsetting.json.
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .AddEnvironmentVariables()
                 .Build();
            //Tạo đối tượng serilog từ thông tin config của hệ thống.
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            try
            {

                Log.Information("Starting web host MISA.eShop.ProductApi.Host.");
                Log.Logger.MISATraceInfo("Starting web host MISA.eShop.ProductApi.Host.");
                CreateHostBuilder(args).Build().Run();
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host MISA.eShop.ProductApi.Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseAutofac()
                .UseSerilog();
    }
}