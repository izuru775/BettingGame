using System;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            double odds = 0.75;

            Guy player = new Guy() { Cash = 100, Name = "The player" };



            Console.WriteLine("Welcome to the casino. The odds are 0.75");
            while (player.Cash>0)
            {
                Console.WriteLine("The player has "+ player.Cash +" bucks");
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch,out int amount))
                {
                    player.GiveCash(amount);
                    int pot = amount * 2;
                    double computerNumber = random.NextDouble();

                    if (computerNumber>odds)
                    {
                        Console.WriteLine("You win "+ pot);
                        player.ReceiveCash(pot);
              
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose");
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter a valid amount!");
                }
            }
            Console.WriteLine("The house always wins!");
        }
    }
}
