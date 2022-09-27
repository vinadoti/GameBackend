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
        static List<Game> lista = new List<Game>(); // Cria uma lista de objetos da classe Game (static para ser acessada por todos os métodos)

        [HttpGet] // Define que o método Get é um método HTTP GET
        public ActionResult Read() // Método Get
        {
            return Ok(lista); // Retorna a lista de objetos da classe Game - Resposta do método HTTP GET (200) - OK
        }

        [HttpPost] // Define que o método Post é um método HTTP POST
        public ActionResult Create(Game game) // Método Post
        {
            game.GameId = Guid.NewGuid(); // Define o valor do atributo gameId
            lista.Add(game); // Adiciona o objeto game na lista

            return Created(game.GameId.ToString(), game); // Retorna o valor do atributo gameId - Resposta do método HTTP POST (201) - Created
        }

        [HttpPut] // Define que o método Put é um método HTTP PUT
        [Route("{id}")] // Define o endereco para acessar o método Put
        public ActionResult Update(Guid id, Game game) // Método Put
        {
            foreach (Game g in lista) // Percorre a lista de objetos da classe Game
            {
                if (g.GameId == id) // Verifica se o valor do atributo gameId do objeto g é igual ao valor do atributo id
                {
                    g.Name = game.Name; // Define o valor do atributo name
                    g.Status = game.Status; // Define o valor do atributo status
                    return Ok(); // Retorna mensagem de sucesso - Resposta do método HTTP PUT (200) - OK
                }
            }
            return NotFound(); // Retorna mensagem de erro - Resposta do método HTTP PUT (404) - Not Found
        }

        [HttpDelete] // Define que o método Delete é um método HTTP DELETE
        [Route("{id}")] // Define o endereco para acessar o método Delete
        public ActionResult Delete(Guid id) // Método Delete
        {
            foreach (Game game in lista) // Percorre a lista de objetos da classe Game
            {
                if (game.GameId == id) // Verifica se o valor do atributo gameId do objeto game é igual ao valor do atributo id
                {
                    lista.Remove(game); // Remove o objeto game da lista
                    return Ok(); // Retorna mensagem de sucesso - Resposta do método HTTP DELETE (200) - OK
                }
            }
            return NotFound(); // Retorna mensagem de erro - Resposta do método HTTP DELETE (404) - Not Found
        }

    }
}