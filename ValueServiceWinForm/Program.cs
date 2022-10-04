using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ServiceProcess;
using ValueServiceLibrary;

namespace ValueServiceWinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var builder = Host.CreateDefaultBuilder();
            builder.ConfigureServices(services => services.AddSingleton<IValueService, ValueService>());
            var host = builder.Build();
            var form = new Main(host.Services.GetRequiredService<IValueService>());
            Application.Run(form);
        }
    }
}