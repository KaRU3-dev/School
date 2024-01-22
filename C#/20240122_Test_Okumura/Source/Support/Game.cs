using System;

using GameEngine.Support;
using GameEngine.Characters;
using GameEngine.Characters.Interface;
using GameEngine.Objects;
using System.ComponentModel;

namespace GameEngine {
    public class Game {

        public Generator generator = new();

        public bool isStart = false;
        public int totalCards = 36;
        public int totalCharacters = 4;
        public int totalHasCards = 4;

        public Card[] cards = new Card[1];
        public Pair[] characters = new Pair[1];

        public void StartGame() {
            // Initialize game
            // Resize arrays
            Array.Resize(ref cards, totalCards);
            Array.Resize(ref characters, totalCharacters);

            // Generate cards
            for (int i = 0; i < totalCards; i++) {
                cards[i] = new Card();

                int num1 = generator.GenerateRandomNumber(1, 9);
                int num2 = generator.GenerateRandomNumber(1, 9);

                cards[i].index = i;
                cards[i].Name = $"Card{i}";
                cards[i].Number = num1 * num2;
                cards[i].isDrawable = true;
                cards[i].isDropped = false;
            }

            // Generate characters
            for (int i = 0; i < characters.Length; i++) {
                if (i == 0) {
                    characters[i] = new Pair();

                    String name = "Player";
                    Player character = new Player(totalHasCards);

                    characters[i].Name = name;
                    characters[i].Character = character;
                }

                if (i != 0) {
                    characters[i] = new Pair();

                    String name = $"Computer {i}";
                    Computer character = new Computer(totalHasCards);

                    characters[i].Name = name;
                    characters[i].Character = character;
                }
            }

            // Show characters
            for (int i = 0; i < characters.Length; i++) {
                Console.WriteLine(characters[i].Name);

                characters[i].Character.DrawCard(cards);
            }

            // Game start
            isStart = true;
            Update();
        }

        public void Update() {

            // Winner
            bool win = false;

            while (isStart) {
                if (!CheckExistingCards()) {
                    Console.WriteLine("There is no card exists!");
                    break;
                }

                for (int i = 0; i < characters.Length; i++) {
                    characters[i].Character.DropCard(cards);

                    win = CheckWinner(characters[i].Character);

                    if (win) {
                        Console.WriteLine($"{characters[i].Name} is win!!");
                        break;
                    }
                }

                if (win) isStart = false;
            }
        }

        public bool CheckExistingCards() {
            for (int i = 0; i < cards.Length; i++) {
                if (cards[i].isDropped != false) {
                    isStart = false;
                    return true;
                }
            }
            return false;
        }

        public bool CheckWinner(ICharacter character) {
            int product = 0;

            for (int i = 0; i < character.deck.Length; i++) {
                product *= character.deck[i].Number;
            }

            Card[] characterCards = character.deck;

            if (
                product == characterCards[0].Number * characterCards[1].Number * characterCards[2].Number &&
                product == characterCards[0].Number * characterCards[1].Number * characterCards[3].Number &&
                product == characterCards[0].Number * characterCards[2].Number * characterCards[3].Number &&
                product == characterCards[1].Number * characterCards[2].Number * characterCards[3].Number
            ) {
                return true;
            } else {
                return false;
            }
        }
    }
}
