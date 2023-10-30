using System;

namespace _20231030_Class{
    public class Program2{

        // Interface
        interface IFlyable{
            void Fly(); // Fly method declaration
            void MakeSound(); // MakeSound method declaration
        }

        // Bird class
        class Bird : IFlyable{
            public void Fly(){
                Console.WriteLine("鳥は飛んでいます。");
            }

            public void MakeSound(){
                Console.WriteLine("鳥は鳴いています。");
            }
        }

        // Airplane class
        class Airplane : IFlyable{
            public void Fly(){
                Console.WriteLine("飛行機は飛んでいます。");
            }

            public void MakeSound(){
                Console.WriteLine("飛行機はエンジン音を出しています。");
            }
        }
    }
}
