using System;
using _20230703_Class3.src;

namespace _20230703_Class3{
    public class Program {
        public static void Main(string[] args) {
            // thisメソッドを使ったクラス
            UsingThisMethod person = new();
            person.DisplayInfo("John");

            // ジャグ配列を使ったクラス
            UsingJagArray jagArray = new();
            jagArray.DisplayJagArray();

            // ジェネリックを使ったクラス
            UsingGeneric<int> generic = new();
            generic.Add(1);
            generic.Add(2);
            generic.Add(3);
            generic.Display();
            UsingGeneric<string> generic2 = new();
            generic2.Add("Hello");
            generic2.Add("World");
            generic2.Display();
        }
    }
}
