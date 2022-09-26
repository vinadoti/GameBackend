using Microsoft.AspNetCore.Mvc; // Para usar o Controller
using GameBackend.Models; // Usa a classe Game do namespace GameBackend.Models

namespace GameBackend.Controllers // Namespace do projeto
{
    [ApiController] // Define que a classe é um controller, uma API
    [Route("game")] // Define o endereco para acessar o controller

    // Exemplo de chamada: http://localhost:5000/game

    // Recebe toda a requisição, processa e retorna mensagem ao usuário 
    public class GameController : ControllerBase // Define que a classe GameController herda de ControllerBase
    {
        List<Game> lista = new List<Game>(); // Cria uma lista de objetos da classe Game

        [HttpGet] // Define que o método Get é um método HTTP GET
        public ActionResult Read() // Método Get
        {
            Game g1 = new Game(); // Instancia um objeto da classe Game
            g1.gameId = 1; // Define o valor do atributo gameId
            g1.name = "Game 1"; // Define o valor do atributo name
            g1.status = true; // Define o valor do atributo status

            lista.Add(g1); // Adiciona o objeto g1 na lista

            return Ok(lista); // Retorna a lista de objetos da classe Game - Resposta do método HTTP GET (200) - OK
        }

        [HttpPost] // Define que o método Post é um método HTTP POST
        public ActionResult Create(Game game) // Método Post
        {
            // Processa a requisição e retorna mensagem ao usuário

            return Created("", null); // Retorna o objeto game - Resposta do método HTTP POST (201) - Created
        }
    }
}