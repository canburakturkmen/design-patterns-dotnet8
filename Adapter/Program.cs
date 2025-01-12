using Adopter;

IMediaPlayer player = new MediaPlayer();
player.Play("mp3", "song.mp3"); // Default behavior

// Using Adapter for MP4
player = new MediaAdapter("mp4");
player.Play("mp4", "video.mp4");

// Using Adapter for AVI
player = new MediaAdapter("avi");
player.Play("avi", "movie.avi");