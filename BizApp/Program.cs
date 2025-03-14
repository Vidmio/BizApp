using BizApp.Components;
using BizApp.Components.Model;
using BizApp.Components.Repository.Interface;
using BizApp.Components.Repository;
using Radzen;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<IGenericRepository<Error>, GenericRepository<Error>>();
builder.Services.AddScoped<IGenericRepository<Student>, GenericRepository<Student>>();
builder.Services.AddScoped<IGenericRepository<GrupaProizvod>, GenericRepository<GrupaProizvod>>();
builder.Services.AddScoped<IGenericRepository<Klijent>, GenericRepository<Klijent>>();
builder.Services.AddScoped<IGenericRepository<Faktura>, FakturaRepository>();//ovo je za GET sa include
builder.Services.AddScoped<IGenericRepository<Proizvod>, ProizvodRepository>();//ovo je za GET sa include
builder.Services.AddScoped<IGenericRepository<Konstrukcija>, GenericRepository<Konstrukcija>>();
builder.Services.AddScoped<IGenericRepository<FakturaKonstrukcija>, FakturaKonstrukcijaRepository>();//ovo je za GET sa include
builder.Services.AddScoped<IGenericRepository<Stavka>, StavkaRepository>();

builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DataConnectionString"), sqlServerOptions => sqlServerOptions.CommandTimeout(120)),
            ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
