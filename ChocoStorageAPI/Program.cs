using ChocoStorageAPI;
using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Services;
using Microsoft.EntityFrameworkCore;
//using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ProductsData>();
builder.Services.AddScoped<IProductsDataRepository, ProductsDataRepository>();

builder.Services.AddDbContext<ProductsInfoContext>();
builder.Services.AddDbContext<ProductsInfoContext>(dbContextOptions => dbContextOptions.UseSqlite(builder.Configuration["ConnectionStrings:ProductsInfoDBConnectionString"]));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
