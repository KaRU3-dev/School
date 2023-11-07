using System;
using _20231107_Prac02_Okumura.src;

namespace _20231107_Prac02_Okumura{
    public class Program{
        public static void Main(string[] args){
            // Create a new instance of Warrior
            Hero warrior = new Warrior();
            // Create a new instance of Wizard
            Hero wizard = new Wizard();
            // Create a new instance of ranger
            Hero ranger = new Ranger();

            // Call the Attack method of each instance
            warrior.Attack();
            wizard.Attack();
            ranger.Attack();
        }
    }
}
