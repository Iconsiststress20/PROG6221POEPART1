using System;
using System.Media;

namespace CyberSecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ShowAsciiArt();
            PlayGreeting();


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            Console.WriteLine($"\nHello, {name}! Welcome to the Cybersecurity Awareness Bot.");
            Console.WriteLine("Type 'help' to see a list of topics you can ask about.");
            Console.WriteLine("Type 'exit' anytime to quit the application.\n");
            ShowTopics();

            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine().ToLower();
                // input validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter something.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }
                Respond(input);
            }

        }

        //plays recorded wav file
        static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Welcome.wav");
                player.Play();
            }
            catch
            {
                Console.WriteLine("(Audio failed to play)");
            }
        }

        static void ShowAsciiArt()
        {
            Console.WriteLine("  ____ _                 _   ____                      _   _             ");
            Console.WriteLine(" / ___| | ___  _   _  __| | / ___|  ___  __ _ _ __ __| | (_) ___  ___  ");
            Console.WriteLine("| |   | |/ _ \\| | | |/ _` | \\___ \\ / _ \\/ _` | '__/ _` | | |/ _ \\/ _ \\ ");
            Console.WriteLine("| |___| | (_) | |_| | (_| |  ___) | (_) | (_| | | | (_| | |_| (_) \\ (_) |");
            Console.WriteLine(" \\____|_|\\___/ \\__,_|\\__,_| |____/ \\___/ \\__,_|_|  \\__,_|\\__\\___/ \\___/ ");
            Console.WriteLine();
        }

        // show available topics
        static void ShowTopics()
        {
            Console.WriteLine("Topics you can ask about:");
            Console.WriteLine("- How are you?");
            Console.WriteLine("- How to create a strong password");
            Console.WriteLine("- What is phishing?");
            Console.WriteLine("- What is ransomware?");
            Console.WriteLine("- Safe browsing tips");
            Console.WriteLine();
        }

        static void Respond(string input)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I'm just code, but I,m here to help you stay safe!");
            }

            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong passwords with numbers , symbols, and  avoid personal information. Consider using a password manager to generate and store complex passwords.");
            }

            else if(input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a cyber attack where attackers impersonate legitimate entities to trick individuals into providing sensitive information, such as passwords or credit card numbers. Always verify the source of emails and links before clicking.");
            }
            else if(input.Contains("ransomware"))
            {
                Console.WriteLine("Bot: Ransomware is a type of malicious software that encrypts a victim's files and demands payment in exchange for the decryption key. To protect yourself, regularly back up your data and avoid clicking on suspicious links or downloading unknown attachments.");
            }

            else if(input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Safe browsing involves being cautious about the websites you visit and the links you click. Always look for 'https' in the URL, avoid clicking on pop-ups, and use a reputable antivirus program to protect against malicious sites.");
            }
            
            else
            {
                Console.WriteLine("Bot: I'm sorry, I don't have information on that topic. Please ask about cybersecurity-related topics!");
            }
        }
    }
}

