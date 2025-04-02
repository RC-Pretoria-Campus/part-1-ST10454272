using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

class CyberSecurityVoiceChatbot
{
    static void Main(string[] args)

    {
        // Define the border size
        int borderWidth = 1;
        string borderChar = "#";

        // Create the border
        Console.WriteLine(new string(borderChar[0], 70)); // Top border
        for (int i = 0; i < borderWidth - 1; i++)
        {
            Console.WriteLine(borderChar + new string(' ', 68) + borderChar); // Padding rows
        }

        // ASCII logo for "Cyber Security" within the border
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{borderChar}  ____       _     _               ____                     _       _                    ");
        Console.WriteLine($"{borderChar} / ___|  ___| |__ (_)_ __   __ _  / ___| ___   __ _ _ __ __| | __ _| |_ ___             ");
        Console.WriteLine($"{borderChar} \\___ \\ / __| '_ \\| | '_ \\ / _` | \\___ \\ / _ \\ / _` | '__/ _` |/ _` | __/ _ \\    ");
        Console.WriteLine($"{borderChar}  ___) | (__| | | | | | | | (_| |  ___) | (_) | (_| | | | (_| | (_| | ||  __/            ");
        Console.WriteLine($"{borderChar} |____/ \\___|_| |_|_|_| |_|\\__, | |____/ \\___/ \\__,_|_|  \\__,_|\\__,_|\\__\\___|   ");
        Console.WriteLine($"{borderChar}                         |___/                                                           ");
        Console.WriteLine($"{borderChar}                  [ Cybersecurity Bot \n                    🔒 Stay Secure!]                                              ");
        Console.ResetColor();
        // Bottom border
        for (int i = 0; i < borderWidth - 1; i++)
        {
            Console.WriteLine(borderChar + new string(' ', 68) + borderChar); // Padding rows
        }
        Console.WriteLine(new string(borderChar[0], 70)); // Bottom border
    

        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.Volume = 100; // set the volume (100-0)
        synthesizer.Rate = 1; // set the speaking rate (-10 to 10)
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Welcome to CyberBot! I am here to help you stay cyber secure.");
        synthesizer.Speak("Welcome to CyberBot! I'm here to help you stay cyber secure. ");
        String userName;
        Console.WriteLine("What is your name");
        synthesizer.Speak("What is your name");
        userName = Console.ReadLine();
       
    }
}
