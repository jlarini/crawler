using Database;
using Api.BackgroundServices;
using WebCrawler.Esportal;
using WebCrawler.Esportal.Services;
using Api.Configuration;
using Services.Steam;
using Services.Faceit;
using Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration
    .AddEnvironmentVariables();

// Dependency Injection
builder.Services
    .AddTransient<EsportalCrawler>()
    .AddTransient<EsportalSteamIdCrawler>()
    .AddTransient<EsportalProfileService>()
    .AddTransient<ISteamService, SteamService>()
    .AddTransient<IFaceitService, FaceitService>()
    .AddTransient<IQueryService, QueryService>()
    .AddSingleton<IDevConfigurationReader, DevConfigurationReader>();

// config
builder.Services
    .AddSingleton<IDatabaseConfiguration, AppConfiguration>()
    .AddSingleton<ISteamIdConfiguration, AppConfiguration>()
    .AddSingleton<ISteamServiceConfiguration, AppConfiguration>()
    .AddSingleton<IFaceitConfiguration, AppConfiguration>();


builder.Services.AddDbContext<DataContext>();

builder.Services.AddHostedService<EsportalBackgroundService>();
builder.Services.AddHostedService<EsportalSteamIdBackgroundService>();

builder.Services.AddHttpClient<EsportalBackgroundService>();
builder.Services.AddHttpClient<SteamService>();
builder.Services.AddHttpClient<FaceitService>();

builder.Services.AddMemoryCache();
builder.Services.AddHealthChecks();
var app = builder.Build();

app.MapHealthChecks("/health");

// Configure the HTTP request pipeline.
//app.Environment.IsDevelopment()

// keep swagger in prod (for now)
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "/Swagger";
});

//app.UseHttpsRedirection(); not ready for this yet

app.UseAuthorization();

app.MapControllers();

app.Run();