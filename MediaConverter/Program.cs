

using NReco.VideoConverter;

public class Program
{
    static void Main(string[] args)
    {
        var ffmpeg = new NReco.VideoConverter.FFMpegConverter();
        ffmpeg.ConvertMedia(
            "input.avi", null, 
            "output.mp4", null, 
            new ConvertSettings());
    }
}