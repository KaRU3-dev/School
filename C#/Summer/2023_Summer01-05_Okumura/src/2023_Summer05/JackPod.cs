using System;
using System.Collections.Generic;
using System.Linq;

namespace _2023_Summer
{
    public class JackPod
    {
        private List<Player> players;
        private List<int> tiles;
        private Random random = new();

        public void Start()
        {
            players = new List<Player>
            {
                new Player("Player 1"),
                new Player("Player 2"),
                new Player("Player 3"),
                new Player("Player 4")
            };
            tiles = Enumerable.Range(1, 9).ToList();

            while (true)
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"{player.Name}のターンです。");
                    var dice1 = RollDice();
                    var dice2 = RollDice();
                    Console.WriteLine($"サイコロの目は{dice1}と{dice2}です。");

                    if (!CanFlip(dice1) && !CanFlip(dice2) && !CanFlip(dice1 + dice2))
                    {
                        Console.WriteLine($"{player.Name}は負けです。");
                        players.Remove(player);
                        break;
                    }

                    int choice;
                    do
                    {
                        Console.WriteLine("ひっくり返す数字を選んでください。");
                        choice = int.Parse(Console.ReadLine());
                    } while (choice != dice1 && choice != dice2 && choice != dice1 + dice2);

                    FlipTile(choice);

                    if (tiles.Count == 0)
                    {
                        Console.WriteLine("JACK POD");
                        Console.WriteLine($"{player.Name}は勝ちです。");
                        return;
                    }
                }
            }
        }

        private int RollDice()
        {
            return random.Next(1, 7);
        }

        private bool CanFlip(int number)
        {
            return tiles.Contains(number);
        }

        private void FlipTile(int number)
        {
            tiles.Remove(number);
            Console.WriteLine($"数字{number}をひっくり返しました。");
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}