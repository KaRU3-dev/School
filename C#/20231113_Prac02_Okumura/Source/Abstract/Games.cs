using System;

namespace _20231113_Prac02_Okumura.Abstract{
    public abstract class Games{

        // Game start
        public abstract void Start();
        // Game update
        public abstract void Update();

        // Set the number
        public abstract int SetNum();

        // Action
        public abstract void PlayerAction();
        public abstract void ComputerAction();
    }
}
