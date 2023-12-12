using System;

using GameCore.Characters;

namespace GameCore.Characters.Player{

    delegate int Calculator(int num1, int num2);

    public class Player : ICharacters{
        public static int num1 { get; set; } = 0;
        public static int num2 { get; set; } = 0;

        private char _selectedCalculator;
        private int _result;

        public int Add(int num1, int num2){
            return num1 + num2;
        }

        public int Subtract(int num1, int num2){
            return num1 - num2;
        }

        public int Multiply(int num1, int num2){
            return num1 * num2;
        }

        public int Divide(int num1, int num2){
            if (num1 == 0 && num2 == 0){
                Console.WriteLine("0で割ることはできません。");
                return 0;
            }

            return num1 / num2;
        }

        // 数字に対する計算をリクエストする
        public char RequestCalculator(){
            Console.WriteLine("数字に対する計算をリクエストしてください。");
            Console.WriteLine($"あなたの数字は、{num1}と{num2}です。");
            Console.WriteLine("足し算: +");
            Console.WriteLine("引き算: -");
            Console.WriteLine("掛け算: *");
            Console.WriteLine("割り算: /");
            Console.Write(">> ");

            do {
                _selectedCalculator = Convert.ToChar(Console.ReadLine());
            } while(_selectedCalculator != '+' && _selectedCalculator != '-' && _selectedCalculator != '*' && _selectedCalculator != '/');

            Console.WriteLine();
            return _selectedCalculator;
        }

        // 計算を実行する
        public int ExecuteCalculator(char serectedCalculator){
            switch(serectedCalculator){
                case '+':
                    Calculator _add = new Calculator(Add);

                    _result = _add(num1, num2);
                    break;
                case '-':
                    Calculator _subtract = new Calculator(Subtract);

                    _result = _subtract(num1, num2);
                    break;
                case '*':
                    Calculator _multiply = new Calculator(Multiply);

                    _result = _multiply(num1, num2);
                    break;
                case '/':
                    Calculator _divide = new Calculator(Divide);

                    _result = _divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("計算を実行できませんでした。");
                    break;
            }
            return _result;
        }
    }
}
