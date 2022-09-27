namespace GameBackend.Models 
{ 
    public class Game // Classe Game
    {
        // Atributos da classe Game
        private Guid gameId; // Id do jogo (Guid é um tipo de dado que representa um identificador único (uuid))  
        private string name;
        private bool status;

        // propriedades da classe Game (Getters e Setters) 
        public Guid GameId { 
            get { return gameId; } // Retorna o valor do atributo gameId
            set { gameId = value; } // Define o valor do atributo gameId
        }

        public string Name { 
            get { return name; } // Retorna o valor do atributo name
            set { name = value; } // Define o valor do atributo name
        }

        public bool Status { 
            get { return status; } // Retorna o valor do atributo status
            set { status = value; } // Define o valor do atributo status
        }

        // antes
        // Game g1 = new Game(); // Instancia um objeto da classe Game
        // g1.GameId = 1; // Define o valor do atributo gameId
        // g1.Name = "Game 1"; // Define o valor do atributo name
        // g1.Status = true; / Define o valor do atributo status 


    }
}