using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<CLUHelper>();

builder.Configuration.AddJsonFile("appsettings.json", optional: false);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// POST endpoint to analyze text input
app.MapPost("/analyze", async (string input, CLUHelper cluHelper) =>
{
    var result = await cluHelper.ExtractUserDetailsAsync(input);   
    return Results.Json(result);
});

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();