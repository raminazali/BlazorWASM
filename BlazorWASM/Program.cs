using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWASM;
using BlazorWasm.Data.Configurations;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


#region Places that we dealing with it

string domain = "https://localhost:7513/api/v1";


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(domain) });
builder.Services.AddDataLayer();

#endregion


await builder.Build().RunAsync();
