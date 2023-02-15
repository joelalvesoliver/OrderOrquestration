using Microsoft.OpenApi.Models;
using OrderOrquestration.Application.Features.Configuration.DependencyInjection;
using OrderOrquestration.Application.Features.OrderOrquestration.DependencyInjection;
using OrderOrquestration.Application.Shared.Context;
using OrderOrquestration.Application.Shared.DependencyInjection;
using OrderOrquestration.Application.Shared.Initializers;
using Serilog;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
                .AddJsonOptions(x =>
                    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.File($"./logs/OrderOrquestration.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddOrderOrquestrationExtensions();
builder.Services.AddOrderConfigurationExtensions();
builder.Services.AddDataBaseExtensions(builder.Configuration);

builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "OrderOrquestration.Api", Version = "v1" });

});


using var scope = builder.Services.BuildServiceProvider().GetRequiredService<ApplicationDbContext>();
DbInitializer.Initialize(scope);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
