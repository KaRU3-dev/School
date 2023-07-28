using System;

namespace _2023_Summer
{
    /// <summary>
    /// Game support class
    /// <para>Including variables/voids</para>
    /// </summary>
    public class GameSupport
    {
        /// <summary>
        /// Random class
        /// </summary>
        public Random rnd = new();

        /// <summary>
        /// Target id here
        /// </summary>
        public int target;
        /// <summary>
        /// Movable dice mount here
        /// </summary>
        public int amount;

        /// <summary>
        /// Class PlayerCore
        /// </summary>
        public PlayerCore player1 = new();
        /// <summary>
        /// Class PlayerCore
        /// </summary>
        public PlayerCore player2 = new();
        /// <summary>
        /// Class PlayerCore
        /// </summary>
        public PlayerCore player3 = new();
        /// <summary>
        /// Class PlayerCore
        /// </summary>
        public PlayerCore player4 = new();
        /// <summary>
        /// None supported boolean
        /// </summary>
        /// <value>get; set; default = false</value>
        // public bool onStart {get; set;} = false;
        /// <summary>
        /// Update enable boolean
        /// </summary>
        /// <value>get; set; default = false</value>
        public bool onUpdate {get; set;} = false;

        /// <summary>
        /// Request player's info
        /// </summary>
        public void AskReady4Player()
        {
            // Player1
            player1.AskPlayerInfo(1);
            // Player2
            player2.AskPlayerInfo(2);
            // Player3
            player3.AskPlayerInfo(3);
            // Player4
            player4.AskPlayerInfo(4);
        }
        /// <summary>
        /// Set player's dice amount
        /// </summary>
        public void SetPlayerDiceAmount()
        {
            player1.AmountOfDice = 6;
            player2.AmountOfDice = 6;
            player3.AmountOfDice = 6;
            player4.AmountOfDice = 6;
        }
        /// <summary>
        /// Player1's dice action(drop)
        /// </summary>
        public void Player1DropDice()
        {
            player1.UseDice();
        }
        /// <summary>
        /// Player2's dice action(drop)
        /// </summary>
        public void Player2DropDice()
        {
            player2.UseDice();
        }
        /// <summary>
        /// Player3's dice action(drop)
        /// </summary>
        public void Player3DropDice()
        {
            player3.UseDice();
        }
        /// <summary>
        /// Player4's dice action(drop)
        /// </summary>
        public void Player4DropDice()
        {
            player4.UseDice();
        }

        /// <summary>
        /// Player1's dice action(give or delete to other player)
        /// </summary>
        public void Player1DiceAction()
        {
            player1.CheckDice(1);
        }
        /// <summary>
        /// Player2's dice action(give or delete to other player)
        /// </summary>
        public void Player2DiceAction()
        {
            player2.CheckDice(2);
        }
        /// <summary>
        /// Player3's dice action(give or delete to other player)
        /// </summary>
        public void Player3DiceAction()
        {
            player3.CheckDice(3);
        }
        /// <summary>
        /// Player4's dice action(give or delete to other player)
        /// </summary>
        public void Player4DiceAction()
        {
            player4.CheckDice(4);
        }

        /*
        public void DiceAddToPlayer1(int frompid)
        {
            player1.AmountOfDice += 1;
        }
        public void DiceAddToPlayer2(int frompid)
        {
            player2.AmountOfDice += 1;
        }
        public void DiceAddToPlayer3(int frompid)
        {
            player3.AmountOfDice += 1;
        }
        public void DiceAddToPlayer4(int frompid)
        {
            player4.AmountOfDice += 1;
        }

        public void DiceRemoveFromPlayer1()
        {
            player1.AmountOfDice -= 1;
        }
        public void DiceRemoveFromPlayer2()
        {
            player2.AmountOfDice -= 1;
        }
        public void DiceRemoveFromPlayer3()
        {
            player3.AmountOfDice -= 1;
        }
        public void DiceRemoveFromPlayer4()
        {
            player4.AmountOfDice -= 1;
        }
        */

        public void GiveDice(int target, int amount)
        {
            if(target == 1)
            {
                player1.AmountOfDice += amount;

                Console.WriteLine($"Player1's dice are(is) {player1.AmountOfDice} left");
            }
            else if(target == 2)
            {
                player2.AmountOfDice += amount;

                Console.WriteLine($"Player2's dice are(is) {player2.AmountOfDice} left");
            }
            else if(target == 3)
            {
                player3.AmountOfDice += amount;

                Console.WriteLine($"Player3's dice are(is) {player3.AmountOfDice} left");
            }
            else if(target == 4)
            {
                player4.AmountOfDice += amount;

                Console.WriteLine($"Player4's dice are(is) {player4.AmountOfDice} left");
            }
            else
            {
                //
            }
        }

        public void CheckWins()
        {
            if(player1.AmountOfDice <= 0)
            {
                Console.WriteLine("[WINNER] PLAYER 1'S DICE ARE EMPTY!!!");

                player1.win = true;
                onUpdate = false;
            }
            else if(player2.AmountOfDice <= 0)
            {
                Console.WriteLine("[WINNER] PLAYER 2'S DICE ARE EMPTY!!!");

                player2.win = true;
                onUpdate = false;
            }
            else if(player3.AmountOfDice <= 0)
            {
                Console.WriteLine("[WINNER] PLAYER 3'S DICE ARE EMPTY!!!");

                player3.win = true;
                onUpdate = false;
            }
            else if(player4.AmountOfDice <= 0)
            {
                Console.WriteLine("[WINNER] PLAYER 4'S DICE ARE EMPTY!!!");

                player4.win = true;
                onUpdate = false;
            }
            else
            {
                //
            }
        }
    }
}
