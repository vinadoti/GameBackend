namespace GameBackend; // Definindo o namespace do projeto

public class Program // Classe principal do projeto
{
    public static void Main(string[] args) // Método principal do projeto
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args); // Criando o builder do projeto

        // Definindo os serviços a serem usados no projeto
        builder.Services.AddControllers(); // Adicionando o serviço de controllers
        builder.Services.AddEndpointsApiExplorer(); // Adicionando o serviço de API Explorer
        builder.Services.AddSwaggerGen(); // Adicionando o serviço de documentação Swagger

        WebApplication app = builder.Build(); // Criando o projeto

        // Adicionando o middleware de documentação Swagger ao projeto se estiver em desenvolvimento (IsDevelopment)
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Adicionando os controllers ao projeto
        app.MapControllers(); 

        app.Run(); // Executando o projeto
    }
}