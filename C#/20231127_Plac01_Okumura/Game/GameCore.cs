using System;
using System.ComponentModel;
using Game.Characters;

using Game.Characters.Interface;

namespace Game {
    public class GameCore {
        // Game variables

        // Game start
        public bool isStart { get; set; } = false;
        // Game round
        public int round { get; set; } = 0;
        // Out count
        public int outCount = 0;
        // Strike count
        public int strikeCount = 0;
        // Base status
        // 0 = home, 1 = first, 2 = second, 3 = third
        public bool[] baseStatus { get; set; } = new bool[3];

        // Player and computer
        public Player player { get; set; } = new();
        public Computer computer { get; set; } = new();

        // Game start method
        public void Start() {
            // Initialization
            isStart = true;

            round = 9;

            outCount = 0;
            strikeCount = 0;

            player.score = 0;
            computer.score = 0;

            // Print start
            Console.WriteLine("Game start!");
        }

        // Game loop method
        public void Update() {
            while (isStart) {

                while (round >= 0) {
                    // print round
                    Console.WriteLine("\n\n\n\nRound: " + round + "\n\n\n\n");

                    // Player round
                    while (outCount < 3) {

                        // Show status
                        Console.WriteLine("\n\n\nOut: " + outCount + "\nStrike: " + strikeCount + "\nBase: " + baseStatus[0] + " " + baseStatus[1] + " " + baseStatus[2] + "\n");
                        Console.WriteLine("Score: " + player.score + " : " + computer.score);

                        // Strike count
                        while (strikeCount < 3) {
                            // Check out count
                            if (outCount == 3) {
                                break;
                            }

                            // Show status
                            Console.WriteLine("\n\n\nOut: " + outCount + "\nStrike: " + strikeCount);

                            // Show tips
                            Console.WriteLine("[TIPS] Please enter a number between 0 and 3\n0 is vs strate, 1 is vs slider, 2 is vs fork");
                            Console.WriteLine("[TIPS] You are now batting");
                            // Player input
                            int playerNum = player.NumSelect();
                            // Computer input
                            int computerNum = computer.NumSelect();

                            // Compare
                            // If same number, hit
                            if (playerNum == computerNum) {
                                // If base is empty, go to first base
                                if (!baseStatus[1]) {
                                    baseStatus[1] = true;
                                }
                                // If first base is full, go to second base
                                else if (!baseStatus[2]) {
                                    baseStatus[2] = true;
                                }
                                // If third base is full, go to home base
                                else if (!baseStatus[0]) {
                                    baseStatus[0] = true;
                                }
                                // If home base is full, score + 1
                                else {
                                    player.score++;
                                }

                                strikeCount = 0;
                            }
                            // If different number, strike count + 1
                            else {
                                strikeCount++;
                                // If strike count is 3, out count + 1
                                if (strikeCount == 3) {
                                    outCount++;
                                    strikeCount = 0;
                                }
                            }
                        }
                    }

                    // Reset out count and strike count
                    outCount = 0;
                    strikeCount = 0;

                    // Show score
                    Console.WriteLine("\n\n\n\nScore: " + player.score + " : " + computer.score + "\n\n\n\n");

                    // Computer round
                    while (outCount < 3) {

                        // Show status
                        Console.WriteLine("\n\n\nOut: " + outCount + "\nStrike: " + strikeCount + "\nBase: " + baseStatus[0] + " " + baseStatus[1] + " " + baseStatus[2] + "\n");
                        Console.WriteLine("Score: " + player.score + " : " + computer.score);

                        // Strike count
                        while (strikeCount < 3) {
                            // Check out count
                            if (outCount == 3) {
                                break;
                            }

                            // Show status
                            Console.WriteLine("\n\n\nOut: " + outCount + "\nStrike: " + strikeCount);

                            // Show tips
                            Console.WriteLine("[TIPS] Please enter a number between 0 and 3\n0 is strate, 1 is slider, 2 is fork");
                            Console.WriteLine("[TIPS] You are now batting");
                            // Player input
                            int playerNum = player.NumSelect();
                            // Computer input
                            int computerNum = computer.NumSelect();

                            // Compare
                            // If same number, hit
                            if (playerNum == computerNum) {
                                // If base is empty, go to first base
                                if (!baseStatus[1]) {
                                    baseStatus[1] = true;
                                }
                                // If first base is full, go to second base
                                else if (!baseStatus[2]) {
                                    baseStatus[2] = true;
                                }
                                // If third base is full, go to home base
                                else if (!baseStatus[0]) {
                                    baseStatus[0] = true;
                                }
                                // If home base is full, score + 1
                                else {
                                    computer.score++;
                                }

                                strikeCount = 0;
                            }
                            // If different number, strike count + 1
                            else {
                                strikeCount++;
                                // If strike count is 3, out count + 1
                                if (strikeCount == 3) {
                                    outCount++;
                                    strikeCount = 0;
                                }
                            }
                        }
                    }

                    // Reset out count and strike count
                    outCount = 0;
                    strikeCount = 0;

                    // Round - 1
                    round--;
                }

                // Show score
                Console.WriteLine("\n\n\n\nScore: " + player.score + " : " + computer.score + "\n\n\n\n");

                // End game
                isStart = false;
            }
        }
    }
}
