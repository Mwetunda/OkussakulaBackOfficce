using Microsoft.Extensions.DependencyInjection;
using Okussakula.Model.Interface;
using Okussakula.Service.Services;
using System;
using System.Windows.Forms;

namespace Okussakula.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Form1>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            services.AddSingleton<Form1>();

            services.AddScoped<ISpeciality, SpecialityServices>();
        }
    }
}
