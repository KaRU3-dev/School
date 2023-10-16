using System;
using _20231016_Task02_Okumura.src.sys;
using Microsoft.VisualBasic;

namespace _20231016_Task02_Okumura{
    public class Game : Support{
        // Init
        private bool start = false;
        private Player player;
        private Computer computer;

        // Start game
        public void Start(){
            // Start game
            start = true;
            // Create player
            player = new Player("Player");
            // Create computer
            computer = new Computer();

            // Do game
            Update();
        }

        // Game loop
        public void Update(){
            do {
                // Gen and give card
                for (int i = 0; i < 2; i++){
                    player.Card[i] = generator.GenCard();
                    computer.Card[i] = generator.GenCard();
                }

                // Show card
                Console.WriteLine("Your card: " + player.Card[0] + ", " + player.Card[1]);
                // Ask for add card
                Console.WriteLine("Do you want to add card? (y/n)");
                string addCard = Console.ReadLine();
                if (addCard == "y"){
                    player.AddCard = true;
                    player.Card[2] = generator.GenCard();
                }
                // Show card
                Console.WriteLine("Your card: " + player.Card[0] + ", " + player.Card[1] + ", " + player.Card[2]);
                // Bet coin
                int bet = 0; // Bet Amount
                bool validBet = false; // Valid Bet
                do {
                    Console.WriteLine("Please enter a number between 1 and 50: ");
                    string input = Console.ReadLine();
                    validBet = int.TryParse(input, out bet) && bet >= 1 && bet <= 50;
                } while (!validBet);
                // Drop coin
                player.DropCoin = bet;
                player.Coin -= player.DropCoin;

                // Computer card show
                Console.WriteLine("Computer card: " + computer.Card[0] + ", " + computer.Card[1]);
                // Computer (if card0+card1 <= 50 )add card
                if (computer.Card[0] + computer.Card[1] <= 50){
                    computer.Card[2] = generator.GenCard();
                }
                // Computer card show
                Console.WriteLine("Computer card: " + computer.Card[0] + ", " + computer.Card[1] + ", " + computer.Card[2]);
                // Computer drop coin
                int computerDropCoin = 0;
                if (computer.Card[0] + computer.Card[1] + computer.Card[2] <= 50){
                    computerDropCoin = 50;
                } else if (computer.Card[0] + computer.Card[1] + computer.Card[2] <= 100){
                    computerDropCoin = 30;
                } else if (computer.Card[0] + computer.Card[1] + computer.Card[2] <= 150){
                    computerDropCoin = 10;
                } else if (computer.Card[0] + computer.Card[1] + computer.Card[2] <= 200){
                    computerDropCoin = 5;
                } else if (computer.Card[0] + computer.Card[1] + computer.Card[2] <= 250){
                    computerDropCoin = 3;
                } else if (computer.Card[0] + computer.Card[1] + computer.Card[2] <= 300){
                    computerDropCoin = 1;
                }
                computer.DropCoin = computerDropCoin;
                computer.Coin -= computer.DropCoin;

                // Which one is bigger (if just 100, coin * 5 & if +- 10, coin * 3 & if +- 20, coin * 2 & other, coin * 1)
                if (Math.Abs(player.Card[0] + player.Card[1] + player.Card[2] - computer.Card[0] + computer.Card[1] + computer.Card[2]) == 100){
                    player.Coin += player.DropCoin * 5;
                } else if (Math.Abs(player.Card[0] + player.Card[1] + player.Card[2] - computer.Card[0] + computer.Card[1] + computer.Card[2]) <= 10){
                    player.Coin += player.DropCoin * 3;
                } else if (Math.Abs(player.Card[0] + player.Card[1] + player.Card[2] - computer.Card[0] + computer.Card[1] + computer.Card[2]) <= 20){
                    player.Coin += player.DropCoin * 2;
                } else{
                    player.Coin += player.DropCoin * 1;
                }
                // If player card is bigger than computer card, player win
                if (player.Card[0] + player.Card[1] + player.Card[2] > computer.Card[0] + computer.Card[1] + computer.Card[2]){
                    // Player win log and show coin and card
                    Console.WriteLine("You win!");
                    Console.WriteLine("Your coin: " + player.Coin);
                    Console.WriteLine("Your card: " + player.Card[0] + ", " + player.Card[1] + ", " + player.Card[2]);
                } else{
                    // Player lose log and show computer's coin and card
                    Console.WriteLine("You lose!");
                    Console.WriteLine("Computer coin: " + computer.Coin);
                    Console.WriteLine("Computer card: " + computer.Card[0] + ", " + computer.Card[1] + ", " + computer.Card[2]);
                }

                // Disable game
                start = false;
            } while (start);
        }

    }
}
