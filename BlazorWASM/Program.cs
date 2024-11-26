using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWASM;
using BlazorWasm.Data.Configurations;
using Blazored.Toast;

#region project Code
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
#endregion

string domain = "http://localhost:5121/api/";






builder.Services.AddBlazoredToast();
builder.Services.AddDataLayer(domain);


#region App Section
await builder.Build().RunAsync();

#endregion
