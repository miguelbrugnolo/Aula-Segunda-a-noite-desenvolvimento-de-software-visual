var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>
{
     new Produto { Nome = "Notebook Lenovo" },
    new Produto { Nome = "Mouse Logitech" },
    new Produto { Nome = "Teclado Mecânico" },
    new Produto { Nome = "Monitor Samsung 24" },
    new Produto { Nome = "Headset HyperX" },
    new Produto { Nome = "Webcam Logitech" },
    new Produto { Nome = "Pen Drive 64GB" },
    new Produto { Nome = "HD Externo 1TB" },
    new Produto { Nome = "Cadeira Gamer" },
    new Produto { Nome = "Smartphone Samsung Galaxy" }
};


//FUNCIONALIDADES - EndPoints
//Requisições
//Métodos HTTP
//URL
//Resposta
// -dado/informação

app.MapGet("/", () => "API ECOMMERCE");

app.MapGet("/api/produto/listar", () =>
{
    return produtos;
});

app.Run();