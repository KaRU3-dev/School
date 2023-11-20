using System;

using _20231113_Prac02_Okumura.Game.User;
using _20231113_Prac02_Okumura.Abstract;
using _20231113_Prac02_Okumura.Interface;

namespace _20231113_Prac02_Okumura.Game{
    public class RandomNumberGame : Games{

        private bool isStart = false;

        Users player = new Player();
        Users computer = new Computer();

        public override void Start(){
            // Set the number
            InitUsersNum();

            // Game start
            isStart = true;
            Update();
        }
        public override void Update(){
            // Do game
            do {
                // Check HP
                if (player.HP <= 0 || computer.HP <= 0){
                    isStart = false;
                    break;
                }

                // Action
                PlayerAction();
                ComputerAction();

                // Calculate number
                int playerNum = player.Num1 + player.Num2 + player.Num3;
                int computerNum = computer.Num1 + computer.Num2 + computer.Num3;

                // Which is bigger?
                if (playerNum > computerNum){
                    // Player win
                    computer.HP -= playerNum - computerNum;
                } else if (playerNum < computerNum){
                    // Computer win
                    player.HP -= computerNum - playerNum;
                } else {
                    // Draw
                    player.HP -= 10;
                    computer.HP -= 10;
                }
            } while (isStart);

            // Check HP
            if (player.HP <= 0){
                Console.WriteLine("Computer win");
            } else if (computer.HP <= 0){
                Console.WriteLine("Player win");
            } else {
                Console.WriteLine("Draw");
            }
        }

        private void InitUsersNum(){
            // Set the number
            player.Num1 = SetNum();
            player.Num2 = SetNum();
            player.Num3 = SetNum();
            computer.Num1 = SetNum();
            computer.Num2 = SetNum();
            computer.Num3 = SetNum();

            // Init HP
            player.HP = 500;
            computer.HP = 500;
        }

        public override int SetNum(){
            Random random = new Random();
            return random.Next(0, 99);
        }

        public override void PlayerAction(){
            // Show player's HP and number
            Console.WriteLine("Player HP: " + player.HP);
            Console.WriteLine("Player Num: " + player.Num1 + ", " + player.Num2 + ", " + player.Num3);

            // Select action
            Console.WriteLine("Select action (drop / keep): ");
            string action = Console.ReadLine();

            // Check action
            if (action == "drop"){

                // Select number
                Console.WriteLine("Select number (1 / 2 / 3): ");
                string num = Console.ReadLine();

                // Check number
                if (num == "1"){
                    player.Num1 = 0;
                    player.Num1 = SetNum();
                }
                else if (num == "2"){
                    player.Num2 = 0;
                    player.Num2 = SetNum();
                }
                else if (num == "3"){
                    player.Num3 = 0;
                    player.Num3 = SetNum();
                }
                else {
                    Console.WriteLine("Invalid number");
                }
            } else if (action == "keep"){
                Console.WriteLine("Keep");
            } else {
                Console.WriteLine("Invalid action");
            }
        }

        public override void ComputerAction(){
            // Show computer's HP and number
            Console.WriteLine("Computer HP: " + computer.HP);
            Console.WriteLine("Computer Num: " + computer.Num1 + ", " + computer.Num2 + ", " + computer.Num3);

            // Auto select action
            Random random = new Random();
            int action = random.Next(0, 1);

            // Check action
            if (action == 0){
                // Auto select number
                int num = random.Next(0, 3);

                // Check number
                if (num == 0){
                    computer.Num1 = 0;
                    computer.Num1 = SetNum();
                }
                else if (num == 1){
                    computer.Num2 = 0;
                    computer.Num2 = SetNum();
                }
                else if (num == 2){
                    computer.Num3 = 0;
                    computer.Num3 = SetNum();
                }
                else {
                    Console.WriteLine("Invalid number");
                }
            } else if (action == 1){
                Console.WriteLine("Keep");
            } else {
                Console.WriteLine("Invalid action");
            }
        }
    }
}
