using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using weComponentDeployment.Wrapper;
using Microsoft.AspNetCore.Components.Web.Extensions;
using weComponentDeployment;
using weComponentDeployment.Pages;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Zorg ervoor dat de component volledig gekwalificeerd is, bijvoorbeeld:
// builder.RootComponents.Add<Wrapper.CounterElement>("counter-element");

await builder.Build().RunAsync();