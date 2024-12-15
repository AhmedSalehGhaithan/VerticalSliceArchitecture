using VerticalSliceArchitecture.src.Feature.Category;
using VerticalSliceArchitecture.src.Feature.Product;
using VerticalSliceArchitecture.src.Infrastructure.DependencyInjections;
using Scalar.AspNetCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddAppService(builder.Configuration);

var app = builder.Build();

app.UseExceptionHandler(_ => { });
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapScalarApiReference();

app.MapControllers();

app.MapProductEndpoints();

app.MapCategoryEndpoint();

app.Run();
