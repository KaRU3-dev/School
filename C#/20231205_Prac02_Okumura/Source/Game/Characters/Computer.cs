// .NET Framework
using System;

// Namespace
using Game.Characters.Interfaces;

namespace Game.Characters
{
    public record Computer : ICharacters
    {
        public string Name { get; init; }
        public int Score { get; set; }
        public int[] Cards { get; set; }

        public void ShowCards()
        {
            //
        }

        public void ShowScore()
        {
            //
        }

        public Computer(string name, int card, int score)
        {
            Name = name;
            Score = score;
            Cards = new int[card];
        }
    }
}
