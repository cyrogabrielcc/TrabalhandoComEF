using TrabalhandoComEF.context;
using Microsoft.EntityFrameworkCore;
using System;

// ...


// Use a variável 'minhaSenha' na Connection String ou em qualquer outra parte que precise da senha.

var builder = WebApplication.CreateBuilder(args);
string connectionString = Environment.GetEnvironmentVariable("ConexaoPadrao");

// Add services to the container.
builder
    .Services
    .AddDbContext<AgendaContext>(options => 
                    options.UseSqlServer(builder.Configuration
                           .GetConnectionString(connectionString)));
    


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
