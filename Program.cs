using Microsoft.EntityFrameworkCore;
using FuncionariosCRUD.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Adiciono no meu builder o banco e digo a ele o tipo de uso, no caso "Use In Memory"
builder.Services.AddDbContext<FuncDbContext>(opt => opt.UseInMemoryDatabase("Funcs"));

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
