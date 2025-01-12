using Facade;

// Subsystem components
var projector = new Projector();
var soundSystem = new SoundSystem();
var mediaPlayer = new MediaPlayer();

// Facade
var homeTheater = new HomeTheaterFacade(projector, soundSystem, mediaPlayer);

// Client interacts with the facade
homeTheater.WatchMovie("Inception");
Console.WriteLine();
homeTheater.EndMovie();