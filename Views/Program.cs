using Applicacion.Interfaces.IRepositories;
using Applicacion.Interfaces.IServices;
using Applicacion.UseCase.Maquinas;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Views
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services = new ServiceCollection()
            .AddDbContext<TryOutContext>(options =>
            options.UseSqlite("Data Source=D:\\TryOut\\Infrastructure\\Db\\TryOut.db"))
            .AddTransient<IMaquinaRepository, MaquinaRepository>()
            .AddTransient<IMaquinaService, MaquinaService>()
            .AddTransient<Home>() // Registra el formulario Home
            .BuildServiceProvider();


            var form = services.GetRequiredService<Home>();
            Application.Run(form);


        }
    }
}