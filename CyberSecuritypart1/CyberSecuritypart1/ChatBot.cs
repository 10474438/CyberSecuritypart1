using System;

class ChatBot
{
    private string userName;

    public void Start()
    {
        UIHELPERS.DisplayHeader();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter your name: ");
        Console.ResetColor();

        userName = Console.ReadLine();

        // Input validation
        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Name cannot be empty. Please enter your name: ");
            userName = Console.ReadLine();
        }

        UIHELPERS.TypingEffect($"\nWelcome, {userName}! I'm your Cybersecurity Awareness Bot.\n");

        RunChat();
    }

    private void RunChat()
    {
        string input;

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            input = Console.ReadLine();

            // Validation
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠️ Please enter something.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("👋 Goodbye! Stay safe online.");
                break;
            }

            string response = Response.GetResponse(input, userName);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Bot: ");
            Console.ResetColor();

            UIHELPERS.TypingEffect(response);
        }
    }
}