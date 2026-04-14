using System;

class Response
{
    public static string GetResponse(string input, string name)
    {
        input = input.ToLower();

        if (input.Contains("how are you"))
            return $"I'm just code, {name}, but I'm here and ready to help! 😊";

        else if (input.Contains("purpose"))
            return "My purpose is to help you stay safe online.";

        else if (input.Contains("what can i ask"))
            return "You can ask about password safety, phishing, and safe browsing.";

        else if (input.Contains("password"))
            return "Use strong passwords with a mix of letters, numbers, and symbols.";

        else if (input.Contains("phishing"))
            return "Phishing scams try to trick you into giving personal info. Always verify emails.";

        else if (input.Contains("browsing"))
            return "Always check website security (https://) before entering personal data.";

        else
            return "I didn't quite understand that. Could you rephrase?";
    }
}