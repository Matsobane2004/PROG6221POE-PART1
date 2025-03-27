using System.Collections.Concurrent;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Speech;
using System.Speech.Synthesis;
using System.Runtime.ConstrainedExecution;


internal class Program
{
    static SpeechSynthesizer synthesizer = new SpeechSynthesizer();

    private static async Task Main(string[] args)
    {
        //this boolean hepls me to keep looping th program until the user has no more questions 
        bool loop = true;
        
        char a = (char)47;//"/"
        char b = (char)92;//"\"
        char c = (char)45;//"-"
        char d = (char)124;//"|"
        char e = (char)111;//"o"
        char f = (char)94;//"^"
        char g = (char)126;
        char h = (char)95;//"_"

        String question;
        String userName;


        //BOT QUESTIONS 
        String a1 = "1.What makes a strong password?";
        String b1 = "2.Is it safe to use the same multiple password for multiple accounts?";
        String c1 = "3.What is two-factor authentication (2AF), and why is it important?";
        String d1 = "4.what is the best way to store your password securely?";
        String e1 = "5.What is phishing?";
        String f1 = "6.How can you tell if an email is a phishing attempt?";
        String g1 = "\nENTER ANY OF THE NUMBERS LISTED TO ASK OR TYPE 'MORE' IF YOU WANT ME TO GENERATE MORE \n OR YOU COULD JUST TYPE YOUR OWN QUESTION ";
        String h1 = "7.What should you do if you recieve a suspicious email?";
        String i1 = "8.What is the best way to avoid phishing scams?";
        String j1 = "9.What does https in a website URL mean?";
        String k1 = "10.What should you do before downloading from the internet?";
        String l1 = "11.What is a common sign of a fake or malicious website?";
        String m1 = "12.Why should I aviod using public wi-fi for sensitive transections";

        

        for (int i = 0; i < 1; i++)
        {
            
            Console.WriteLine(" "+ "CYBER SECURITY AWARENESS BOT");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t" + a +  a + a + c + b + b + b + "\n");
            Console.Write("\t" + d +" "+ f + " " + f + " " + d + "\n");
            Console.WriteLine("       "+ a + d + " " + e + " " + e + " " + d + b);
            Console.WriteLine("       "+ b + d + "  " + f + "  " + d + a);
            Console.WriteLine("\t" + d + "  " + g + "  " + d);
            Console.WriteLine("\t" +" "+ b + h + h + h + a);
            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();
        }

        await Task.Delay(500);
        VoiceGreeting();

        Console.ForegroundColor = ConsoleColor.Green;
        userName = Console.ReadLine();
        Console.ResetColor();

        while (String.IsNullOrEmpty(userName)) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PLEASE ENTER A NAME!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            userName = Console.ReadLine();
            Console.ResetColor();

        }

        Console.WriteLine();

        await Task.Delay(500);
        String outputAns = ("NICE TO MEET YOU "+ userName.ToUpper() + " <3\n");
        await TypeTextAsync(outputAns);
        Console.ResetColor();

        await Task.Delay(200);
        Console.WriteLine("WHAT QUESTIONS DO YOU HAVE ABOUT CYBER SECURITY, PHISHING OR SAFE BROWSING,\n I CAN ALSO SUGGEST IF YOU'D LIKE, JUST TYPE 'suggest'");
        Console.ForegroundColor = ConsoleColor.Green;
        question = Console.ReadLine();
        Console.ResetColor();

        while (true)
        {

            if (String.Equals(question, "How are you", (StringComparison.OrdinalIgnoreCase)) | String.Equals(question, "How are you?", (StringComparison.OrdinalIgnoreCase)))
            {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t" + a +  a + a + c + b + b + b + "\n");
            Console.Write("\t" + d +" "+ f + " " + f + " " + d + "\n");
            Console.WriteLine("       "+ a + d + " " + e + " " + e + " " + d + b);
            Console.WriteLine("       "+ b + d + "  " + f + "  " + d + a);
            Console.WriteLine("\t" + d +" "+ b + h + a +" " + d);
            Console.WriteLine("\t" +" "+ b + h + h + h + a);
            Console.WriteLine();
            Console.ResetColor();

                String imOkay = ("I'M ALREADY,THANKS FOR ASKING! ");
            
                await TypeTextAsync(imOkay);

                await Task.Delay(300);
                Console.WriteLine("\nWHAT QUESTIONS DO YOU HAVE ABOUT CYBER SECURITY, PHISHING OR SAFE BROWSING,\n I CAN ALSO SUGGEST IF YOU'D LIKE, JUST TYPE 'suggest'");
                Console.ForegroundColor = ConsoleColor.Green;
                question = Console.ReadLine();
                Console.ResetColor();
            }
            try
            {
                if (String.Equals(question, "whats your purpose", (StringComparison.OrdinalIgnoreCase)) | String.Equals(question, "what's your purpose", (StringComparison.OrdinalIgnoreCase)) |
                    String.Equals(question, "whats your purpose?", (StringComparison.OrdinalIgnoreCase)) | String.Equals(question, "whats your purpose", (StringComparison.OrdinalIgnoreCase)))
                {
                    purposeQ = question;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\t" + a + a + a + c + b + b + b + "\n");
                    Console.Write("\t" + d + " " + f + " " + f + " " + d + "\n");
                    Console.WriteLine("       " + a + d + " " + e + " " + e + " " + d + b);
                    Console.WriteLine("       " + b + d + g + " " + f + " " + g + d + a);
                    Console.WriteLine("\t" + d + " " + b + h + a + " " + d);
                    Console.WriteLine("\t" + " " + b + h + h + h + a);
                    Console.WriteLine();
                    Console.ResetColor();

                    String purpose = ("MY PURPOSE IS TO HELP YOU STAY SAFE AND AWARE ONLINE <3");

                    await TypeTextAsync(purpose);

                    await Task.Delay(300);
                    Console.WriteLine("\nWHAT QUESTIONS DO YOU HAVE ABOUT CYBER SECURITY, PHISHING OR SAFE BROWSING,\n I CAN ALSO SUGGEST IF YOU'D LIKE, JUST TYPE 'suggest'");
                    Console.ForegroundColor = ConsoleColor.Green;
                    question = Console.ReadLine();
                    Console.ResetColor();
                }

                while (String.IsNullOrEmpty(question))
                {
                    Console.WriteLine("*PLEASE ASK A QUESTION\n I CAN SUGGEST ONES FOR YOU IF YOU DONT HAVE ANY ON YOUR MIND RIGHT NOW \n JUST TYPE 'SUGGEST'");
                    question = Console.ReadLine();
                }


                while (String.Equals(question, "suggest", StringComparison.OrdinalIgnoreCase) | (String.Equals(question, "What can I ask you?", StringComparison.OrdinalIgnoreCase)))
                {
                    await Task.Delay(1000);
                    Console.WriteLine("\nThinking...");
                    await Task.Delay(1000);
                    Console.WriteLine();
                    await TypeTextAsync(a1);
                    await TypeTextAsync(b1);
                    await TypeTextAsync(c1);
                    await TypeTextAsync(d1);
                    await TypeTextAsync(e1);
                    await TypeTextAsync(f1);

                    Console.WriteLine(g1);

                    Console.WriteLine("\nWHAT WILL IT BE " + userName.ToUpper() + " :\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    question = Console.ReadLine();
                    Console.ResetColor();
                }

                if (question.Contains("yes"))
                {

                    Console.WriteLine("\nWhats the question :-)  : \n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    question = Console.ReadLine();
                    Console.ResetColor();
 
                }
                if (question == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans1 = ("\nAnswer : At least 8 characters, with a mix of letters, numbers, and symbols. \n Example 'Obah#244166B'");
                    await TypeTextAsync(ans1);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)\n");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans2 = ("\nAnswer : No, it increases the risk of security breach.");
                    await TypeTextAsync(ans2);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans3 = ("\nAnswer : An extra layer of security that required a second step to verify your identity.");
                    await TypeTextAsync(ans3);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans4 = ("\nAnswer : Save then in a secure password folder.");
                    await TypeTextAsync(ans4);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "5")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans5 = ("\nAnswer : A scam where hackers tick you into giving your personal information.");
                    await TypeTextAsync(ans5);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "6")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans6 = ("\nAnswer :Suspicious emails often ask for sensitive information, contain spelling errors, or have a suspicious sender address.");
                    await TypeTextAsync(ans6);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }

                if ((String.Equals(question, "more", StringComparison.OrdinalIgnoreCase)))
                {

                    Console.WriteLine();
                    await Task.Delay(1000);
                    Console.WriteLine("\nThinking...");
                    await Task.Delay(1000);
                    Console.WriteLine();
                    await TypeTextAsync(h1);
                    await TypeTextAsync(i1);
                    await TypeTextAsync(j1);
                    await TypeTextAsync(k1);
                    await TypeTextAsync(l1);
                    await TypeTextAsync(m1);

                    Console.WriteLine("\nWHAT WILL IT BE " + userName.ToUpper() + " :");
                    Console.ForegroundColor = ConsoleColor.Green;
                    question = Console.ReadLine();
                    Console.ResetColor();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }

                }

                if (question == "7")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans7 = ("\nAnswer : Report it to your IT department or email provider.");
                    await TypeTextAsync(ans7);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "8")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans8 = ("\nAnswer : Be cautious of links, enable spam filters, and verify email senders.");
                    await TypeTextAsync(ans8);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "9")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans9 = ("\nAnswer : The website is secure and encrypts data.");
                    await TypeTextAsync(ans9);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "10")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans10 = ("\nAnswer : Check if the source is tested.");
                    await TypeTextAsync(ans10);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "11")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans11 = ("\nAnswer : Malicious websites often have bad design, random URLs and too-good-to-be-true offers.");
                    await TypeTextAsync(ans11);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }
                if (question == "12")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String ans12 = ("\nAnswer : Hackers can intercept your data.");
                    await TypeTextAsync(ans12);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you have another question for me? (yes or no)");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }


                String[] keywords = new string[] { "Cyber Security", "Phishing", "Safe Browsing","cybersecurity","safebrowsing" };


                if (question.Contains(keywords[0], StringComparison.OrdinalIgnoreCase) |  question.Contains(keywords[3], StringComparison.OrdinalIgnoreCase))
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    String cyber = ("\n Answer : Cybersecurity involves protecting systems, networks, and data from cyber threats. Use firewalls and antivirus software to stay protected.");
                    await TypeTextAsync(cyber);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you another question for me ? (yes or no) ");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }

                if (question.Contains(keywords[1], StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String phishing = ("\n Answer : Phishing is a type of cyber attack where scammers trick people into giving away sensitive information, such as passwords, credit card details, or personal data.\n This is usually done through fake emails, websites, or messages that appear to be from legitimate sources like banks, social media platforms, or government agencies.");
                    await TypeTextAsync(phishing);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you another question for me ? (yes or no) ");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO")
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }

                }


                if (question.Contains(keywords[2], StringComparison.OrdinalIgnoreCase) | question.Contains(keywords[4], StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    String safeBrowsing = ("\n Answer : Safe browsing means protectiong yourself from online threats like malware, phishing scams, and malicious websites. ");
                    await TypeTextAsync(safeBrowsing);
                    Console.ResetColor();
                    Console.WriteLine("\nDo you another question for me ? (yes or no) ");
                    question = Console.ReadLine();

                    while (question != "Yes" | question != "yes" | question != "YES" | question != "no" | question != "No" | question != "NO" ) 
                    {
                     
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPLEASE ENTER ONLY A NO OR YES ANSWER!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        question = Console.ReadLine();
                        Console.ResetColor();
                    }
                }

                if (question == "no" | question == "No" | question == "NO")
                {
                    String goodbye = ("\nThanks for using smiloAI, goodbye!");
                    await TypeTextAsync(goodbye);
                    Environment.Exit(0);
                }
            }
            catch 
            {
                Console.WriteLine("Sorry, I couldnt undrstand that could you try rephrasing");
                question = Console.ReadLine();
            }

            loop = false;
            }


    }

    static async Task TypeTextAsync(string output1)
    {
        foreach (char c in output1)
        {
            Console.Write(c); // Print the character without a newline
            await Task.Delay(50); // Delay between characters (100 ms here)
        }

        Console.WriteLine(); // Move to the next line after the message
    }

    static void VoiceGreeting()
    {
        
        string greet = "HI I'M SMILO, HERE TO HELP YOU STAY AWARE ONLINE, BUT BEFORE ALL THAT, CAN I GET YOUR NAME";
        Console.WriteLine(greet);

        try
        {
            synthesizer.Speak(greet);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry, Voice couldnt run due to technical difficulties");
        }
    }
}