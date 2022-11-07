namespace NumberGuesser2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get app info

            GreetUser(); // Ask for user's name and greet

            while (true)
            {

                // Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number.");

                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");

                    }


                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

            // Get and display app version and name
            static void GetAppInfo()
            {
                // Set app vars
                string appName = "Number Guesser";
                string appVersion = "2.0.1";
                string appAuthor = "Brian C.";

                // Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("{0} Version {1} by {2}", appName, appVersion, appAuthor);

                // Reset foreground color
                Console.ResetColor();
            }

            // Get and display user's name and greet
            static void GreetUser()
            {
                // Ask user's name
                Console.WriteLine("What is your name?");

                // Get user input
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, let's play a game...", inputName);
            }

            static void PrintColorMessage(ConsoleColor color, string message)
            {
                // Change text color
                Console.ForegroundColor = color;

                // Tell user not a number
                Console.WriteLine(message);

                // Reset console colors
                Console.ResetColor();
            }

        }

    }
}