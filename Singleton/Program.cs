using Singleton;

var gameState = GameState.Instance;
Console.WriteLine($"Current level is {gameState.CurrentLevel}");
