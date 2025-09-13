using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace OOS.OgrenciOtomasyonSistemi.Blazor.Client;

public class Program
{
    public async static Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        var application = await builder.AddApplicationAsync<OgrenciOtomasyonSistemiBlazorClientModule>(options =>
        {
            options.UseAutofac();
        });

        var host = builder.Build();

        await application.InitializeApplicationAsync(host.Services);

        await host.RunAsync();
    }
}
