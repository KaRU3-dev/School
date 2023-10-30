using System;
using System.Drawing;

namespace _20231030_Prac01_Okumura{
    internal class Index{

        interface IDrawable{
            void Draw();
        }

        class Circle : IDrawable{
            public void Draw(){
                Console.WriteLine("○");
            }
        }

        class Rectangle : IDrawable{
            public void Draw(){
                Console.WriteLine("□");
            }
        }

        public static void Main(string[] args){

            //　Init
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            //　Draw
            circle.Draw();
            rectangle.Draw();
        }
    }
}
