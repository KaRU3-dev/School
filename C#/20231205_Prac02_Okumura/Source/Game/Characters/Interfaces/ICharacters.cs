using System;

namespace Game.Characters.Interfaces
{
    public interface ICharacters
    {
        public string Name { get; }
        public int Score {get; set; }
        public int[] Cards { get; set; }

        public void ShowCards();
        public void ShowScore();

    }
}
