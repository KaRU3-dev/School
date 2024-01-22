using System;
using GameEngine.Characters;
using GameEngine.Characters.Interface;

namespace GameEngine.Support {
    public class Pair {
        public String Name { get; set;} = "User";
        public ICharacter Character { get; set; }
    }
}