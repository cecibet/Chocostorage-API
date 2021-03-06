using ChocoStorageAPI;
using ChocoStorageAPI.Data;
using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Services;
using Microsoft.EntityFrameworkCore;

//using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ProductsData>();
//builder.Services.AddDbContext<ProductsInfoContext>();
builder.Services.AddDbContext<ProductsInfoContext>(dbContextOptions => dbContextOptions.UseSqlite(
    builder.Configuration["ConnectionStrings:ProductsInfoDBConnectionString"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IProductsDataRepository, ProductsDataRepository>();
builder.Services.AddScoped<ISellsRepository, SellsRepository>();

builder.Services.AddScoped<ISellServices, SellServices>();
builder.Services.AddScoped<IProductServices, ProductServices>();


// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


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
