using ChocoStorageAPI;
using ChocoStorageAPI.Data;
using ChocoStorageAPI.DBContexts;
using ChocoStorageAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

//using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(setupAction =>
{
    setupAction.AddSecurityDefinition("ChocoStorageApiBearerAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme() //Esto va a permitir usar swagger con el token.
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "Bearer",
        Description = "Ac� pegar el token generado al loguearse."
    });

    setupAction.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ChocoStorageApiBearerAuth" } 
                }, new List<string>() }
    });
});

builder.Services.AddSingleton<ProductsData>();
//builder.Services.AddDbContext<ProductsInfoContext>();
builder.Services.AddDbContext<ProductsInfoContext>(dbContextOptions => dbContextOptions.UseSqlite(
    builder.Configuration["ConnectionStrings:ProductsInfoDBConnectionString"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddAuthentication("Bearer") //"Bearer" es el tipo de auntenticaci�n que tenemos que elegir despu�s en PostMan para pasarle el token
    .AddJwtBearer(options => //Ac� definimos la configuraci�n de la autenticaci�n. le decimos qu� cosas queremos comprobar. La fecha de expiraci�n se valida por defecto.
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Authentication:Issuer"],
            ValidAudience = builder.Configuration["Authentication:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Authentication:SecretForKey"]))
        };
    }
);

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

app.UseAuthentication(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
