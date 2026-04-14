using System;
using System.Drawing;
using System.IO;
using System.Media;

public class AudioPlayer
{
    private string baseDir = AppDomain.CurrentDomain.BaseDirectory;

    public AudioPlayer()
    {
        // Keep constructor clean
    }

    public void PlayGreeting()
    {
        PlaySound();
    }

    public void DisplayLogo()
    {
        ShowAsciiImage();
    }

    private void PlaySound()
    {
        string soundPath = Path.Combine(baseDir, "greeting.wav");

        if (!File.Exists(soundPath))
        {
            Console.WriteLine("⚠️ Greeting sound not found.");
            return;
        }

        try
        {
            using (SoundPlayer greet = new SoundPlayer(soundPath))
            {
                greet.PlaySync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Sound error: {ex.Message}");
        }
    }

    private void ShowAsciiImage()
    {
        string imagePath = Path.Combine(baseDir, "Logo1.png");

        if (!File.Exists(imagePath))
        {
            Console.WriteLine("⚠️ Logo image not found.");
            return;
        }

        try
        {
            using (Bitmap image = new Bitmap(imagePath))
            using (Bitmap resized = new Bitmap(image, new Size(150, 70)))
            {
                string asciiChars = "@#S%?*+;:,. ";

                for (int y = 0; y < resized.Height; y++)
                {
                    for (int x = 0; x < resized.Width; x++)
                    {
                        Color pixel = resized.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        int index = (gray * (asciiChars.Length - 1)) / 255;

                        Console.Write(asciiChars[index]);
                    }
                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Image error: {ex.Message}");
        }
    }
}