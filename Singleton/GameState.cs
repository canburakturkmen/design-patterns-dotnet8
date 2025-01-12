namespace Singleton;
public class GameState

{
    private static readonly Lazy<GameState> _instance = new(() => new GameState());
    private int _level = 0;

    private GameState() { }

    public static GameState Instance => _instance.Value;

    public int CurrentLevel() => _level;

    //other useful methods here
}
