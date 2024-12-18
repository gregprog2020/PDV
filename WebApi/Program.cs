using Microsoft.EntityFrameworkCore;
using PDV.Domain.Interfaces.Generic;
using PDV.Domain.Interfaces.InterfaceServicos;
using PDV.Domain.Services;
using PDV.Infra.Context;
using PDV.Infra.Repositorio.Generics;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PdvDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));

// INTERFACE E REPOSITORIO
builder.Services.AddSingleton(typeof(InterfaceGeneric<>), typeof(RepositorioGenerics<>));

// SERVIÇO DOMINIO
builder.Services.AddSingleton<IProdutoServices, ProdutoServices>();

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
