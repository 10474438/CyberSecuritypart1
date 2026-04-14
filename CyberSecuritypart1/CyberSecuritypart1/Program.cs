
using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ShowLogo();
        PlayWelcomeGreeting();

        ChatBot bot = new ChatBot();
        bot.Start();
    }

    private static void ShowLogo()
    {
        AudioPlayer logo = new AudioPlayer();
        logo.DisplayLogo();
    }

    private static void PlayWelcomeGreeting()
    {
        AudioPlayer player = new AudioPlayer();
        Task.Run(() => player.PlayGreeting()); // play asynchronously
    }
}