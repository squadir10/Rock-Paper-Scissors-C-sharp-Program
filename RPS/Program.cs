// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;

namespace RPS
{
    class Program
    {
        public static void game() {
            Random CPU_choice = new Random();
            bool replay = true;
            bool repeat = true;
            String player, CPU, answer;
            int player_score, CPU_score;
            int rounds = 0;
            
            player_score = 0;
            CPU_score = 0;
            
            Console.WriteLine("Welcome to Rock, Paper, Scissors! ");
            
            while (replay) {
                // to keep running the program
                player = "";
                CPU = "";
                answer = "";
                
                
                rounds += 1;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("***ROUND " + rounds + "***");


                while (player != "1" && player != "2" && player != "3") {
                    Console.WriteLine("Please enter 1 for ROCK, 2 for PAPER, or 3 for SCISSORS: ");
                    player = Console.ReadLine();
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
                    }
                }

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

                

                if (rounds == 10) {
                    while (answer != "Y" && answer != "N") {
                        Console.Write("Would you like to play again? (Y/N): \n");
                        answer = Console.ReadLine();
                        answer = answer.ToUpper();
                        if (answer == "Y") {
                            replay = true;
                            Console.WriteLine("***RESULTS THUS FAR***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);
                            
                            if (player_score > CPU_score) {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Congratulations you win!!! Onto the next match!");
                                rounds = 0;
                            } else if (CPU_score == player_score) {
                                replay = true;
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
                            replay = false;
                            Console.WriteLine("\n");
                            Console.WriteLine("***RESULTS***");
                            Console.WriteLine("\tPlayer: {0},\tComputer: {1}", player_score, CPU_score);

                            if (player_score > CPU_score) {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Congratulations you win!!!");
                            } else if (CPU_score == player_score) {
                                replay = false;
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
            
            Console.WriteLine("Thank you for playing my game! :D ");
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            game();
        }
    }
}