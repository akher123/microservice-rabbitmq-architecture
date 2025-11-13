using MicroRabbit.Wasm.WebUI;
using MicroRabbit.Wasm.WebUI.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("banking-microservice",client =>
{
    client.BaseAddress = new Uri("http://localhost:5062/");
});
builder.Services.AddHttpClient("transfer-microservice", client =>
{
    client.BaseAddress = new Uri("https://localhost:7040/");
});

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ITransferService, TransferService>();
await builder.Build().RunAsync();
