// See https://aka.ms/new-console-template for more information


bool playing = true;
int userPoints = 0;
int computerPoints = 0;

while (playing)
{
    Console.Clear();
    Console.WriteLine(@"

______           _     ______                       _____      _                        
| ___ \         | |    | ___ \                     /  ___|    (_)                       
| |_/ /___   ___| | __ | |_/ __ _ _ __   ___ _ __  \ `--.  ___ _ ___ ___  ___  _ __ ___ 
|    // _ \ / __| |/ / |  __/ _` | '_ \ / _ | '__|  `--. \/ __| / __/ __|/ _ \| '__/ __|
| |\ | (_) | (__|   <  | | | (_| | |_) |  __| |    /\__/ | (__| \__ \__ | (_) | |  \__ \
\_| \_\___/ \___|_|\_\ \_|  \__,_| .__/ \___|_|    \____/ \___|_|___|___/\___/|_|  |___/
                                 | |                                                    
                                 |_|                                                    
                                                                                                                                                                                
");
    Console.WriteLine("Choose your fate");
    Console.WriteLine("1.Rock");
    Console.WriteLine("2.Paper");
    Console.WriteLine("3.Scissors");

    string? userChoice = Console.ReadLine();
    Random randomChoice = new Random();
    int computerChoice = randomChoice.Next(1, 4);

    switch (computerChoice)
    {
        case 1: //computer chose rock
            if (userChoice == "1")
            {
                //this is a tie
                Console.WriteLine("User chose Rock");
                Console.WriteLine("Computer chose Rock");
                Console.WriteLine("It is a tie.");
            }

            else if (userChoice == "2")
            {
                //user wins
                Console.WriteLine("User chose Paper");
                Console.WriteLine("Computer chose Rock");
                Console.WriteLine("User wins");
                userPoints++;
            }
            else if (userChoice == "3")
            {
                //computer wins
                Console.WriteLine("User chose Scissors");
                Console.WriteLine("Computer chose Rock");
                Console.WriteLine("Computer wins");
                computerPoints++;
            }
            break;
        case 2: //computer chose paper
            if (userChoice == "1")
            {
                // computer wins
                Console.WriteLine("User chose Rock");
                Console.WriteLine("Computer chose Paper");
                Console.WriteLine("Computer wins");
                computerPoints++;
            }

            else if (userChoice == "2")
            {
                //this is a tie
                Console.WriteLine("User chose Paper");
                Console.WriteLine("Computer chose Paper");
                Console.WriteLine("It is a tie");
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("User chose Scissors");
                Console.WriteLine("Computer chose Paper");
                Console.WriteLine("User wins");
                userPoints++;

            }
            break;
        case 3: //computer chose scissors
            if (userChoice == "1")
            {
                //user wins
                Console.WriteLine("User chose Rock");
                Console.WriteLine("Computer chose Scissors");
                Console.WriteLine("User wins.");
                userPoints++;
            }

            else if (userChoice == "2")
            {
                //computer wins
                Console.WriteLine("User chose Paper");
                Console.WriteLine("Computer chose Scissors");
                Console.WriteLine("Computer wins");
                computerPoints++;
            }
            else if (userChoice == "3")
            {
                //this is a tie
                Console.WriteLine("User chose Scissors");
                Console.WriteLine("Computer chose Scissors");
                Console.WriteLine("It is a tie");
            }
            break;
    }

    Console.WriteLine("Do you wish to play again?");
    Console.WriteLine("Enter Y or N");
    string? playAgain = Console.ReadLine();
    if (playAgain == "N" || playAgain == "n" || playAgain == "no")
    {
        playing = false;
        Console.WriteLine($"User has {userPoints} points - Computer has {computerPoints} points");
    }
}