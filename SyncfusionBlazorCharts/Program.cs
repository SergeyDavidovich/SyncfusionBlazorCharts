using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using SyncfusionBlazorCharts;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Njg3MDkwQDMyMzAyZTMyMmUzMFdLZVVRTFA4Y2xJU3JyWFdmNXNnVW9wbDB4UzVsRWlNZlVkVkd1RUlXRG89");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
