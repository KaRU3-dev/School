using System;

namespace _2023_Summer
{
    public class PlayerCore : PlayerSupport
    {
        /// <summary>
        /// Drop dice and show dice
        /// </summary>
        public void UseDice()
        {
            DropDice();

            for(int i = 0; i < AmountOfDice; i++)
            {
                Console.WriteLine($"{i + 1}: {Dice[i]}");
            }
        }

        /// <summary>
        /// Give a dice to other player
        /// </summary>
        /// <param name="pid">int</param>
        /// <returns>int target</returns>
        public void CheckDice(int pid)
        {
            DiceAction(pid, Dice);
        }
    }
}
