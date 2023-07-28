using System;

namespace _2023_Summer
{
    public class GameEngine : GameSupport
    {
        public void Start()
        {
            // Ask player info
            AskReady4Player();

            // Set player dice amount
            SetPlayerDiceAmount();
        }

        public void Update()
        {
            // Set update loop status
            onUpdate = true;

            // Game loop here
            while (onUpdate)
            {
                // Player1 faze
                Player1DropDice(); // Drop dice
                Player1DiceAction(); // Check dice and action
                // Get deletable dice and givable dice amount
                var (deletable1, givable1) = player1.DiceAction(1, player1.Dice);
                if (deletable1 > 0)
                {
                    player1.DeleteDice(1, deletable1);
                }

                if (givable1 > 0)
                {
                    player1.AmountOfDice -= givable1;

                    target = player1.GiveDiceToOtherPlayer(1);

                    GiveDice(target, givable1);
                }

                player1.ResetDice();

                // Player1 faze
                Player2DropDice(); // Drop dice
                Player2DiceAction(); // Check dice and action
                // Get deletable dice and givable dice amount
                var (deletable2, givable2) = player2.DiceAction(2, player2.Dice);
                if (deletable2 > 0)
                {
                    player2.DeleteDice(2, deletable2);
                }

                if (givable2 > 0)
                {
                    player2.AmountOfDice -= givable2;

                    target = player2.GiveDiceToOtherPlayer(1);

                    GiveDice(target, givable2);
                }

                player2.ResetDice();

                // Player1 faze
                Player3DropDice(); // Drop dice
                Player3DiceAction(); // Check dice and action
                // Get deletable dice and givable dice amount
                var (deletable3, givable3) = player3.DiceAction(3, player3.Dice);
                if (deletable3 > 0)
                {
                    player3.DeleteDice(3, deletable3);
                }

                if (givable3 > 0)
                {
                    player3.AmountOfDice -= givable3;

                    target = player3.GiveDiceToOtherPlayer(1);

                    GiveDice(target, givable3);
                }

                player3.ResetDice();

                // Player1 faze
                Player4DropDice(); // Drop dice
                Player4DiceAction(); // Check dice and action
                // Get deletable dice and givable dice amount
                var (deletable4, givable4) = player4.DiceAction(4, player4.Dice);
                if (deletable4 > 0)
                {
                    player4.DeleteDice(4, deletable4);
                }

                if (givable4 > 0)
                {
                    player4.AmountOfDice -= givable4;

                    target = player4.GiveDiceToOtherPlayer(1);

                    GiveDice(target, givable4);
                }

                player4.ResetDice();

                CheckWins();
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
            if(player1.win)
            {
                Console.WriteLine($"{player1.name} win");
            }
            else if(player2.win)
            {
                Console.WriteLine($"{player2.name} win");
            }
            else if(player3.win)
            {
                Console.WriteLine($"{player3.name} win");
            }
            else if(player4.win)
            {
                Console.WriteLine($"{player4.name} win");
            }
            else
            {
                Console.WriteLine("Nanikano error death★");
            }
        }
    }
}
