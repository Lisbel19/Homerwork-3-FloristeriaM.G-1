using Microsoft.EntityFrameworkCore;
using Floristeria.Application.Contract;    
using Floristeria.Application.Services;       
using Floristeria.Domain.Interfaces;          
using Floristeria.Infrastructure.Context;      
using Floristeria.Infrastructure.Repositories; 

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.

//DATABASE CONFIGURATION (INFRASTRUCTURE) 

//Retrieve the connection string 'ConexionFloristeria' from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("ConexionFloristeria");

//Register the Database Context for Entity Framework Core

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
);


//DEPENDENCY INJECTION REGISTRATION (ALL LAYERS) 
// All registrations use AddScoped as the standard lifecycle.

//Repository Registration (Infrastructure implements Domain Interface)
builder.Services.AddScoped<IProductRepository, ProductRepository>(); 

//Service Registration (Application implements Contract Interface)
builder.Services.AddScoped<IProductService, ProductService>(); 

//API CONFIGURATION (Boilerplate) 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();