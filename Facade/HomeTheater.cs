namespace Facade;
using System;

// Subsystems
public class Projector
{
    public void On() => Console.WriteLine("Projector is now ON.");
    public void Off() => Console.WriteLine("Projector is now OFF.");
    public void SetInput(string source) => Console.WriteLine($"Projector input set to {source}.");
}

public class SoundSystem
{
    public void On() => Console.WriteLine("Sound System is now ON.");
    public void Off() => Console.WriteLine("Sound System is now OFF.");
    public void SetVolume(int level) => Console.WriteLine($"Sound System volume set to {level}.");
}

public class MediaPlayer
{
    public void On() => Console.WriteLine("Media Player is now ON.");
    public void Off() => Console.WriteLine("Media Player is now OFF.");
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
}

// Facade
public class HomeTheaterFacade
{
    private readonly Projector _projector;
    private readonly SoundSystem _soundSystem;
    private readonly MediaPlayer _mediaPlayer;

    public HomeTheaterFacade(Projector projector, SoundSystem soundSystem, MediaPlayer mediaPlayer)
    {
        _projector = projector;
        _soundSystem = soundSystem;
        _mediaPlayer = mediaPlayer;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Preparing to watch a movie...");
        _projector.On();
        _projector.SetInput("HDMI");
        _soundSystem.On();
        _soundSystem.SetVolume(50);
        _mediaPlayer.On();
        _mediaPlayer.Play(movie);
        Console.WriteLine("Movie is playing. Enjoy!");
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the home theater...");
        _mediaPlayer.Off();
        _soundSystem.Off();
        _projector.Off();
        Console.WriteLine("Home theater is now off.");
    }
}

