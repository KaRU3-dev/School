using System;
using GameEngine.Objects;

namespace GameEngine.Characters.Interface {
    public interface ICharacter {
        public Card[] deck {get; set;}
        public void DrawCard(Card[] cards);
        public void DropCard(Card[] cards);
        public void ShowCard();
        public void Shout();
    }
}
