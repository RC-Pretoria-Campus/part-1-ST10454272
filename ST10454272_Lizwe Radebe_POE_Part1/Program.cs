using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

class CyberSecurityVoiceChatbot
{
    static void Main(string[] args)

    {
        // Define the border size
        int borderWidth = 1;
        string borderChar = "=";

        // Create the border
        Console.WriteLine(new string(borderChar[0], 80)); // Top border
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
        Console.WriteLine($"{borderChar}                  [ Cybersecurity Bot] \n                  🔒 [Stay Secure!]                                              ");
        Console.ResetColor();
        // Bottom border
        for (int i = 0; i < borderWidth - 1; i++)
        {
            Console.WriteLine(borderChar + new string(' ', 68) + borderChar); // Padding rows
        }
        Console.WriteLine(new string(borderChar[0], 80)); // Bottom border
    

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


        Dictionary<string, string> responses = new Dictionary<string, string>()
        {
            { "password safty", "Password safety is the foundation of protecting your personal, financial, and professional digital identity in an era where cyber threats are increasingly sophisticated. It ensures that your private information remains inaccessible to malicious actors, guarding against potential financial loss, identity theft, and reputational harm." },
            { "phishing", "Phishing is a type of cyberattack where attackers impersonate legitimate entities to deceive individuals into sharing sensitive information, such as passwords, credit card numbers, or personal details. They often use deceptive methods like fake emails, messages, or websites that appear to be from trustworthy organizations, such as banks or government agencies." },
            { "safe browsing", "Safe browsing refers to the practice of using the internet in a way that protects your personal information, devices, and overall digital well-being from threats like malware, phishing, and other cyberattacks. It involves being cautious about the websites you visit, avoiding clicking on suspicious links or downloading files from untrusted sources," },
            { "how are you","I'm feeling ready to assist and curious about what’s on your mind! How about you?." },
            { "whats your purpose", "My purpose is to empower users with knowledge, guidance, and real-time assistance to enhance digital safety and mitigate cyber threats." },
            { "what can i ask you about", "You can ask me about these three topics based on cyber security. \n1 Password safty. \n2 Phishing. \n3 Safe browsing. \nor type exit to leave chat " },

        };

        while (true)
        {

            
            Console.Write(userName + ":");
            string userInput = Console.ReadLine()?.ToLower();
           



            if (userInput == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                string goodbyeMessage = "Goodbye! Stay safe online.";
                Console.WriteLine("\nCyberBot: " + goodbyeMessage);
                synthesizer.Speak(goodbyeMessage);
                break;
            }

            bool foundResponse = false;
            foreach (var key in responses.Keys)
            {
                if (userInput.Contains(key))
                {
                   
                    string response = responses[key];
                    Console.WriteLine("CyberBot: " + response);
                    synthesizer.Speak(response);
                    foundResponse = true;
                    break;
                }
            }

            if (!foundResponse)
            {
                string defaultResponse = "I didn't quite understand that. Could you rephrase your question";
                Console.WriteLine("CyberBot: " + defaultResponse);
                synthesizer.Speak(defaultResponse);
            }
        }
    }
}
       
    
