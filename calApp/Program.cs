using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using calApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddLogging(logging =>
            {
                logging.SetMinimumLevel(LogLevel.Debug); // Set the minimum level for browser console

                // You could potentially add custom providers here
                // logging.AddProvider(new MyCustomBrowserLoggerProvider());
            });
await builder.Build().RunAsync();
