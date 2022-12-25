using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;

            while (playAgain ) 
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") 
                {
                    Console.WriteLine("<------------------------------>");
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS:");
                    Console.WriteLine("<------------------------------>");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }
              
                switch (random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        
                        break;
                    case 3:
                        computer = "SCISSORS";
                        
                        break;
                }
                Console.WriteLine("Player:" + player);
                Console.WriteLine("--------------");
                Console.WriteLine("Computer:" + computer);
                Console.WriteLine("--------------");


                switch (player) 
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a Draw");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        else 
                        {
                            Console.WriteLine("You Win!!");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                       break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!!!");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a Draw");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!!");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("It's a Draw");
                            Console.WriteLine("<--------------------------->");
                            Console.WriteLine("PRESS ANY KEY TO PLAY AGAIN");
                            Console.WriteLine("<--------------------------->");
                            Console.ReadKey();
                        }
                        break;
                       forground
                }
            }


            Console.ReadKey();
        }
    }
}
