using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Service;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Notes
{
    static class Program
    {
        static Config config = new Config();

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (StreamReader sr = new StreamReader("config.json"))
                config = JsonSerializer.Deserialize<Config>(sr.ReadToEnd())!;

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<NoteForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddFurnitureService();
                    services.AddGenericRepository();
                    services.AddDbContext<DataContext>(options =>
                    {
                        options.UseSqlServer(config.ConnectionString);
                    });
                    services.AddTransient<NoteForm>();
                });
        }
    }
}
