using System;
using System.Threading;

class UIHELPERS
{
    public static void DisplayHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("===============================================");
        Console.WriteLine(@"
   _____       _                     ____        _  
  / ____|     | |                   |  _ \      | |  
 | |     _   _| |__   ___ _ __ ___  | |_) | ___ | |_
 | |    | | | | '_ \ / _ \ '__/ __| |  _ < / _ \| __|
 | |____| |_| | |_) |  __/ |  \__ \ | |_) | (_) | |_
  \_____|\__, |_.__/ \___|_|  |___/ |____/ \___/ \__|
          __/ |                                    
         |___/                                      
");
        Console.WriteLine("=== Cybersecurity Awareness Bot ===");
        Console.WriteLine("===============================================\n");

        Console.ResetColor();
    }

    public static void TypingEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }
}