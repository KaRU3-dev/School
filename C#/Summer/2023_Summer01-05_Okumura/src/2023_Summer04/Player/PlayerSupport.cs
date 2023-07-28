using System.Collections.Generic;
using System;

namespace _2023_Summer
{
    public class PlayerSupport
    {
        /// <summary>
        /// Player's name
        /// </summary>
        /// <value>get; set; default = Player</value>
        public string name {get; set;} = "Player";
        /// <summary>
        /// Player's win or lose
        /// </summary>
        public bool win;
        /// <summary>
        /// Player's dice amount
        /// </summary>
        /// <value>get; set; default = 6</value>
        public int AmountOfDice {get; set;} = 6;
        /// <summary>
        /// Random class
        /// </summary>
        /// <returns>new System.Random</returns>
        protected Random rnd = new();
        /// <summary>
        /// Dice list(contain int 1 to 6 number)
        /// </summary>
        /// <typeparam name="int">list</typeparam>
        public List<int> Dice = new List<int>();
        /// <summary>
        /// If no action to other player, return this
        /// </summary>
        // public int NoAction = 0;

        /// <summary>
        /// Show player's name
        /// <para>Old function</para>
        /// </summary>
        /// <param name="pid">int</param>
        /// <param name="pname">string</param>
        protected void ShowPlayerInfo(int pid, string pname)
        {
            Console.WriteLine($"Player{pid}'s name: {pname}");
        }
        /// <summary>
        /// Ask to name for player
        /// </summary>
        /// <param name="pid"></param>
        public void AskPlayerInfo(int pid)
        {
            Console.WriteLine($"\nPlayer {pid}'s turn -----------------------------------");

            Console.Write($"Please enter name: ");
            name = Console.ReadLine();
            while(name == "")
            {
                Console.Write($"You must include 1+ character!\nPlease enter name: ");
                name = Console.ReadLine();
            }
        }

        /// <summary>
        /// Drop dice 6 times
        /// </summary>
        /// <returns>List Dice</returns>
        protected List<int> DropDice()
        {
            for (int i = 0; i < AmountOfDice; i++)
            {
                int tmp = rnd.Next(1, AmountOfDice + 1);
                Dice.Add(tmp);
            }

            return Dice;
        }
        public void ResetDice()
        {
            Dice.Clear();
        }
        /// <summary>
        /// Player's dice action(give to other player)
        /// </summary>
        /// <param name="pid">int</param>
        /// <returns>target</returns>
        public int GiveDiceToOtherPlayer(int pid)
        {
            int target = rnd.Next(1, 5);

            while (target == pid)
            {
                target = rnd.Next(1, 5);
            }

            return target;
        }
        /// <summary>
        /// If player got dice(1), delete a dice
        /// </summary>
        /// <param name="pid">int</param>
        /// <param name="dice">List</param>
        /// <param name="diceAmount">int</param>
        /// <returns>dice amount</returns>
        public void DeleteDice(int pid, int amount)
        {
            AmountOfDice -= amount;

            Console.WriteLine($"Player{pid}'s dice are(is) {AmountOfDice} left");
        }
        /// <summary>
        /// Check the List of dice.
        /// <para>If dice is 1, void DeleteDice()</para>
        /// <para>If dice is 6, void GiveDice()</para>
        /// <para>If dice is not 1 or 6, continue</para>
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="dice"></param>
        public (int DeletableDiceAmount, int GivableDiceAmount) DiceAction(int pid, List<int> dice)
        {
            int DeletableDiceAmount = 0;
            int GivableDiceAmount = 0;

            // Create loop 6 time
            for (int i = 0; i < AmountOfDice; i++)
            {
                // Check dice list
                if (dice[i] == 1)
                {
                    DeletableDiceAmount += 1;
                }
                else if (dice[i] == 6)
                {
                    GivableDiceAmount += 1;
                }
                else
                {
                    continue;
                }
            }

            return (DeletableDiceAmount, GivableDiceAmount);
        }
    }
}
