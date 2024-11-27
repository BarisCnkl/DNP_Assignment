using BlazorApp.Components;
using BlazorApp.Services;  // Add this namespace for services
using ApiContracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<HttpClient>(sp => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration["ApiBaseUrl\": \"https://localhost:5001/api"])
});

builder.Services.AddScoped<IAuthService, HttpAuthService>();
builder.Services.AddScoped<SimpleAuthService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();