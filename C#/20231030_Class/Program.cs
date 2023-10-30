using System;

namespace _20231030_Class{
    // Interface
    interface IPlayable{
        void Play();
    }

    // Player character class
    class PlayerCharacter : IPlayable{
        public void Play(){
            Console.WriteLine("プレイヤーキャラクターはプレイしています。");
        }
    }

    class NonPlayerCharacter : IPlayable{
        public void Play(){
            Console.WriteLine("ノンプレイヤーキャラクターはプレイしています。");
        }
    }

    internal class Program{
        public static void Main(string[] args){
            // Initialize

            // Create instance
            IPlayable playerCharacter = new PlayerCharacter();
            IPlayable nonPlayerCharacter = new NonPlayerCharacter();

            // Play
            playerCharacter.Play();
            nonPlayerCharacter.Play();

        }
    }
}
