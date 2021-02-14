using Employee_Salary_Haidar.DataContext;
using Employee_Salary_Haidar.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Employee_Salary_Haidar
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
            
            using (var scope = host.Services.CreateScope())
            {               
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<HRPayrollDBContext>();

                DataGenerator.Initialize(services);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
