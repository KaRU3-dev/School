using System;

namespace GameEngine.Objects {
    public class Card {
        public int index;
        public String Name {get; set;} = "card";
        public int Number {get; set;} = 0;
        public bool isDrawable;
        public bool isDropped;
    }
}
