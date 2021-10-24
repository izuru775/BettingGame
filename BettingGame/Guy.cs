using System;
namespace BettingGame
{
    public class Guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// Write my name and the amount of cash I have to the console
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }
        /// <summary>
        /// Give some of my cash, removing it from my wallet(or
        /// printing a message if I don't have enough cash)
        /// </summary>
        /// <param name="amount">Amount of cash to give</param>
        /// <returns>
        /// The amount of cash removed from my wallet, or 0 if I don't
        /// have enough cash(or if the amount is invalid)
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says:" + amount + "isn't a valid amount");
                return 0;
            }
            if (amount > Cash )
            {
                Console.WriteLine(Name + " Says:" + "I don't have enough cash to give you "+ amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name +" says:" +amount+" Isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
