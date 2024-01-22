using System;

using GameEngine.Characters.Interface;
using GameEngine.Objects;
using GameEngine.Support;

namespace GameEngine.Characters {
    public class Player : ICharacter {

        public Player(int totalCard) {
            deck = new Card[totalCard];
        }

        public Card[] deck {get; set;}

        public void DrawCard(Card[] cards) {

            // Get random cards
            for (int i = 0; i < deck.Length; i++) {
                int num = new Generator().GenerateRandomNumber(1, cards.Length - 1);

                if (num == cards[num].index && cards[num].isDrawable == true) {
                    deck[i] = cards[num];
                    cards[num].isDrawable = false;
                } else {
                    i--;
                }
            }
            ShowCard();
        }

        public void ShowCard() {
            for (int i = 0; i < deck.Length; i++) {
                Console.WriteLine($"{i}: {deck[i].Number}");
            }
        }

        public void DropCard(Card[] cards) {
            do {
                int num = new Generator().GenerateRandomNumber(1, deck.Length - 1);
                if (deck[num] != null) {
                    deck[num].isDropped = true;

                    int index = deck[num].index;
                    cards[index].isDropped = true;

                    deck[num] = null;

                    DrawCard(cards);

                    break;
                } else {
                    continue;
                }
            } while (true);
        }

        public void Shout() {
            Console.WriteLine("九九じゃん!");
        }
    }
}
