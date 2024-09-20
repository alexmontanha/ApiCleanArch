using ApiCleanArch.Models;
using ApiCleanArch.Repositories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddSingleton<IReservaRepository, ReservaRepository>();

app.MapGet("/", () => "Hello World!");

app.MapGet("/hello", (string name) =>
{
    var saudacao = DateTime.Now.Hour < 12 ? "Bom dia" : "Boa tarde";
    var retorno = $"{saudacao}, {name}";
    return retorno;
});


app.MapGet("/pessoa", () =>
{
    var pessoa = new Pessoa
    {
        Nome = "Fulano de Tal",
        DataNascimento = new DateTime(1980, 1, 1),
        Email = "fulano@fulano.com",
        Telefone = "11 99999-9999",
        Endereco = "Rua das Flores",
        Cidade = "São Paulo",
        Estado = "SP",
        Pais = "Brasil",
        CEP = "00000-000",
        CPF = "000.000.000-00",
        RG = "00.000.000-0",
        CNH = "00000000000",
    };
    return pessoa;
});


app.Run();
