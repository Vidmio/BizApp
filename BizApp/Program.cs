using BizApp.Components;
using BizApp.Components.Model;
using BizApp.Components.Repository.Interface;
using BizApp.Components.Repository;
using Radzen;
using Microsoft.EntityFrameworkCore;
using JsonFlatFileDataStore;

//// Initialize the data store with a JSON file path (creates a new file if one doesn’t exist)
//var store = new DataStore("data.json");
//var collection = store.GetCollection<Student>();
//var student = new Student { LastName = "Vidicki", FirstName = "Miodrag" };
//await collection.InsertOneAsync(student);


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add authentication options //DODATO 
builder.Services.AddAuthentication("Auth")
    .AddCookie("Auth", options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
        options.LoginPath = "/login";
    });
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<IGenericRepository<Error>, GenericRepository<Error>>();
builder.Services.AddScoped<IGenericRepository<Student>, GenericRepository<Student>>();
builder.Services.AddScoped<IGenericRepository<GrupaProizvod>, GenericRepository<GrupaProizvod>>();
builder.Services.AddScoped<IGenericRepository<Klijent>, GenericRepository<Klijent>>();
builder.Services.AddScoped<IGenericRepository<Faktura>, FakturaRepository>();//ovo je za GET sa include
builder.Services.AddScoped<IGenericRepository<Proizvod>, ProizvodRepository>();//ovo je za GET sa include
builder.Services.AddScoped<IGenericRepository<Stavka>, StavkaRepository>();
builder.Services.AddScoped<IStudentJson, GenericRepositoryJson>();
builder.Services.AddScoped<IGenericRepository<Lager>, LagerRepository>();
builder.Services.AddScoped<IGenericRepository<Vozilo>, GenericRepository<Vozilo>>();

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

//DODATO 
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
//app.MapControllerRoute("default", "{controller}/{action}");
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute("default", "{controller}/{action}");
//});

app.Run();
