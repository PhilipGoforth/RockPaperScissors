using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerScore = 0;
            int playerScore = 0;
            bool playAgain = true;
            while (playAgain)
            {
                while (playerScore < 3 && computerScore < 3)
                {

                    Console.WriteLine("Choose rock, paper or scissors:");
                    string userInput = Console.ReadLine();
                    Random random = new Random();
                    int randomNumber = random.Next(0, 4);
                    string computerInput;


                    switch (randomNumber)
                    {

                        case 1:
                            computerInput = "rock";
                            Console.WriteLine("Computer chooses rock!");
                            if (userInput == "rock")
                            {
                                Console.WriteLine("draw");
                            }
                            else if (userInput == "paper")
                            {
                                Console.WriteLine("paper beats rock!");
                                playerScore++;
                            }
                            else if (userInput == "scissors")
                            {
                                Console.WriteLine("rock beats scissors!");
                                computerScore++;
                            }

                            break;
                        case 2:
                            computerInput = "paper";
                            Console.WriteLine("Computer chooses paper!");
                            if (userInput == "rock")
                            {
                                Console.WriteLine("paper beats rock!");
                                computerScore++;
                            }
                            else if (userInput == "paper")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (userInput == "scissors")
                            {
                                Console.WriteLine("scissors beats paper!");
                                playerScore++;
                            }
                            break;
                        case 3:
                            computerInput = "scissors";
                            Console.WriteLine("Computer chooses scissors!");
                            if (userInput == "rock")
                            {
                                Console.WriteLine("rock beats scissors!");
                                playerScore++;
                            }
                            else if (userInput == "paper")
                            {
                                Console.WriteLine("scissors beats paper!");
                                computerScore++;
                            }
                            else if (userInput == "scissors")
                            {
                                Console.WriteLine("draw");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;

                    }
                    Console.WriteLine("\n\nScores:\tPlayer:\t{0}\tComputer:\t{1}",playerScore, computerScore);
                }
                if (playerScore == 3)
                {
                    Console.WriteLine("Player wins!");
                }
                else if (computerScore == 3)
                {
                    Console.WriteLine("Computer wins!");
                }
                Console.WriteLine("Play Again? (y/n)");
                string anotherPlay = Console.ReadLine();
                if (anotherPlay == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (anotherPlay == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}

        
    

