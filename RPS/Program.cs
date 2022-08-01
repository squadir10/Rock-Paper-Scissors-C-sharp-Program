// See https://aka.ms/new-console-template for more information
using System;

namespace RPS
{
     class Program
    {
        public static void Main(string[] args)
        {
            Random CPU_choice = new Random();
            bool replay = true;
            String player, CPU, answer;
            int player_score, CPU_score;
            
            player_score = 0;
            CPU_score = 0;
            Console.WriteLine("Welcome to Rock, Paper, Scissors! ");
           while (replay)// to keep running the program
           {
               player = "";
               CPU = "";
               answer = "";
               
               
               while (player != "1" && player != "2" && player != "3") //to ensure the player enters the right values
               {

                   Console.WriteLine("Please enter 1 for rock, 2 for paper, or 3 for scissors");
                   player = Console.ReadLine();
                   if (player == "1")
                   {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("you chose rock!");
                       Console.ResetColor();
                   }
                   else if (player == "2")
                   {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("You chose paper!");
                       Console.ResetColor();
                   } 
                   else if (player == "3")
                   {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("You chose scissors!");
                       Console.ResetColor();
                   }
                   else
                   {
                       Console.WriteLine("Very cute, but you cannot fool me. Try again...");
                   }
                  
               }

               switch (CPU_choice.Next(1,4))
               {
                   case 1:
                       Console.ForegroundColor = ConsoleColor.Blue;
                       CPU = "ROCK";
                       break;
                   case 2:
                       Console.ForegroundColor = ConsoleColor.Yellow;
                       CPU = "PAPER";
                       break;
                   case 3:
                       Console.ForegroundColor = ConsoleColor.Red;
                       CPU = "SCISSORS";
                       break;
               }
               Console.WriteLine("Computer chose: " + CPU);
               Console.ResetColor();
               

               switch (player)
               {
                   case "1":
                       if (CPU == "ROCK")
                       {
                           Console.WriteLine("It's a tie!");
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       else if (CPU == "PAPER")
                       {
                           Console.WriteLine("You lose :(");
                           CPU_score += 1;
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);

                       }
                       else
                       {
                           Console.WriteLine("You win! :D");
                           player_score += 1;
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       break;
                   case "2":
                       if (CPU == "ROCK")
                       {
                           Console.WriteLine("You win! :D");
                           player_score += 1;
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                           
                       }
                       else if (CPU == "PAPER")
                       {
                           Console.WriteLine("It's a tie!");
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       else
                       {
                           Console.WriteLine("You lose :( ");
                           CPU_score += 1;
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       break;
                   case "3":
                       if (CPU == "ROCK")
                       {
                           Console.WriteLine("You lose :( ");
                           CPU_score += 1;
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       else if (CPU == "PAPER")
                       {
                           Console.WriteLine("You win! :D");
                           player_score += 1;
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       else
                       {
                           Console.WriteLine("It's a tie!");
                           Console.WriteLine("Scores:");
                           Console.WriteLine("\tWins:\t{0},\tLoses:\t{1}", player_score, CPU_score);
                       }
                       break;
               }
               

              
               
               
               /*
                
               
                
                Console.Write("would you like to play again? (Y/N): ");
               answer = Console.ReadLine();
               answer = answer.ToUpper();

               if (answer == "Y")
               {
                   replay = true;
               }
               else
               {
                   replay = false;
                   
               }*/
               
           }
            Console.WriteLine("Thank you for playing my game! Hope you enjoyed it! :D ");
            Console.ReadKey();
        }
    }
}

