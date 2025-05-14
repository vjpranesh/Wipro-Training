using System;

interface IMusicPlayer
{
    void Play();
    void Pause();
    void Stop();
}

class SpotifyPlayer : IMusicPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing [song] on Spotify");
    }
    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }
}
class AppleMusicPlayer : IMusicPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing [song] on Apple Music");
    }
    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }
}

class Program
{
    static void Main()
    {
        IMusicPlayer spotify = new SpotifyPlayer();
        IMusicPlayer appleMusic = new AppleMusicPlayer();

        spotify.Play();
        spotify.Pause();
        spotify.Stop();

        Console.WriteLine();

        appleMusic.Play();
        appleMusic.Pause();
        appleMusic.Stop();
    }
}