// See https://aka.ms/new-console-template for more information



/*Author: Sabrina Quadir 
 *Date: 8/1/2022
 * Description: a simple program about the classic game: Rock, Paper, Scissors - in which the player plays against
 * the computer. The program prompts the user to enter a value signifying its specific option and the computer
 * randomly chooses an option. After 10 rounds, the user has the option to continue playing or quit the game. The game
 * will repeat the matches as much as the user wants to play. 
 */
namespace RPS
{
    class Program
    {
        // testing my knowledge on methods/functions in C#
        public static void Game() {
            //call out the variables first
            Random CPU_choice = new Random();
            bool replay_game = true;
            String player, CPU;
            string? answer;
            int player_score, CPU_score;
            int rounds = 0;
            
            player_score = 0;
            CPU_score = 0;
            
            Console.WriteLine("Welcome to Rock, Paper, Scissors! ");
            
            while (replay_game) {  // to keep running the game
                player = "";
                CPU = "";
                answer = "";
                
                //to keep track of the number of rounds
                rounds += 1;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("***ROUND " + rounds + "***");

                // this while loop makes sure that the user chooses the right option between rock, paper, and scissors
                // if user presses something completely random, the menu will repeat itself again
                while (player != "1" && player != "2" && player != "3") {
                    Console.WriteLine("Please enter 1 for ROCK, 2 for PAPER, or 3 for SCISSORS: ");
                    player = Console.ReadLine();
                    // ReSharper disable once ConvertIfStatementToSwitchStatement
                    if (player == "1") {
                        Console.WriteLine();
                    }
                    else if (player == "2") {
                        Console.WriteLine();
                    }
                    else if (player == "3") {
                        Console.WriteLine();
                    }
                    else {
                        Console.WriteLine("How daring, but you cannot fool me. Try again...");
                        // and then the menu repeats itself. Pretty cool!
                    }
                }
                // switch statement to support and understand the randomizer that chooses rock, paper, or scissors
                // for the computer.
                switch (CPU_choice.Next(1, 4)) {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        CPU = "ROCK";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        CPU = "PAPER";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        CPU = "SCISSORS";
                        break;
                }

                Console.WriteLine("Computer chose: " + CPU);
                Console.ResetColor();

                // switch statement to compare the player's and computer's selection
                // between rock, paper, and scissors. If it is a tie then no points are 
                // added. if player wins, it will add one point. If computer wins, it will add one point.
                switch (player) {
                    case "1":
                        if (CPU == "ROCK") {
                            
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("It's a tie!");
                           
                        } else if (CPU == "PAPER") {
                            
                            CPU_score += 1;
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("You lose :(");
                            
                        } else {
                            
                            player_score += 1;
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("You win! :D");
                            
                        }
                        break;
                    case "2":

                        if (CPU == "ROCK") {
                            
                            player_score += 1;
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("You win! :D");
                            
                        } else if (CPU == "PAPER") {
                            
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("It's a tie!");
                            
                        }
                        else {
                            
                            CPU_score += 1;
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("You lose :( ");
                            
                        }

                        break;
                    case "3":

                        if (CPU == "ROCK") {
                            
                            CPU_score += 1;
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("You lose :( ");
                            
                        } else if (CPU == "PAPER") {
                            
                            player_score += 1;
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("You win! :D");
                            
                        } else {
                           
                            Console.WriteLine("***SCORES***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            Console.WriteLine("It's a tie!");
                            
                        }
                        break;
                    
                }

                
                // one match lasts for 10 rounds. After 10 rounds, the player can choose whether they want to 
                // continue playing or stop playing. If player chooses "y" the score will display the results from the 
                // last match and will continue keeping track of score until the user decides to exit off the game.
                if (rounds == 10) {
                    //while loop to make sure the user does not mistakingly hit the wrong key. If wrong key is hit
                    // the user will be asked again if they want to play or not.
                    // this was the trickiest part of the program
                    // in order to make sure the right menus would repeat and that the game
                    // would keep going without breaking or displaying the wrong things. 
                    while (answer != "Y" && answer != "N") {
                        Console.Write("Would you like to play again? (Y/N): \n");
                        answer = Console.ReadLine();
                        answer = answer.ToUpper();
                        if (answer == "Y") {
                            replay_game = true;
                            Console.WriteLine("***RESULTS THUS FAR***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            
                            if (player_score > CPU_score) {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Congratulations you win!!! Onto the next match!");
                                rounds = 0;
                            } else if (CPU_score == player_score) {
                                replay_game = true;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("It was a tie! No winner! Onto the next match!");
                                rounds = 0;

                            } else {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("You did not win. Restarting match... ");
                                rounds = 0;
                            }
                        }
                        else if (answer == "N") {
                            replay_game = false;
                            Console.WriteLine("\n");
                            Console.WriteLine("***RESULTS***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);

                            if (player_score > CPU_score) {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Congratulations you win!!!");
                            } else if (CPU_score == player_score) {
                                replay_game = false;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("It was a tie! No winner!");
                                
                            } else {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("You did not win. Better luck next time! ");
                            }
                        } else {
                            Console.WriteLine("invalid entry. Please try again!");
                        }
                    }
                }
            }
            // if user does not want to continue playing, this nice message will appear bidding the player good-bye.
            Console.WriteLine("Thank you for playing my game! :D ");
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            //game function to be called in the main
            Game();
        }
    }
}