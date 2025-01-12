namespace Adopter;

// Target Interface
public interface IMediaPlayer
{
    void Play(string audioType, string fileName);
}

// Concrete Target: Default Media Player
public class MediaPlayer : IMediaPlayer
{
    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Playing MP3 file: {fileName}");
        }
        else
        {
            Console.WriteLine($"Unsupported format: {audioType}");
        }
    }
}

// Adaptee: Advanced Media Player
public interface IAdvancedMediaPlayer
{
    void PlayMP4(string fileName);
    void PlayAVI(string fileName);
}

public class AdvancedMediaPlayer : IAdvancedMediaPlayer
{
    public void PlayMP4(string fileName)
    {
        Console.WriteLine($"Playing MP4 file: {fileName}");
    }

    public void PlayAVI(string fileName)
    {
        Console.WriteLine($"Playing AVI file: {fileName}");
    }
}

// Adapter: Makes AdvancedMediaPlayer compatible with IMediaPlayer
public class MediaAdapter : IMediaPlayer
{
    private readonly IAdvancedMediaPlayer _advancedMediaPlayer;

    public MediaAdapter(string audioType)
    {
        _advancedMediaPlayer = audioType.ToLower() switch
        {
            "mp4" => new AdvancedMediaPlayer(),
            "avi" => new AdvancedMediaPlayer(),
            _ => throw new NotSupportedException("Unsupported format")
        };
    }

    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            _advancedMediaPlayer.PlayMP4(fileName);
        }
        else if (audioType.Equals("avi", StringComparison.OrdinalIgnoreCase))
        {
            _advancedMediaPlayer.PlayAVI(fileName);
        }
    }
}

