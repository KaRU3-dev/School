using System;

using GameCore.Characters;

namespace GameCore.Characters.Computer{

    delegate int Calculator(int num1, int num2);

    public class Computer : ICharacters{
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
                return 0;
            }

            return num1 / num2;
        }

        // 数字に対する計算をリクエストする
        public char RequestCalculator(){
            // ランダムな数字を生成する(0 ~ 3)
            Random _random = new Random();
            int s = _random.Next(0, 3);

            // ランダムな数字に対応する計算を選択する
            switch(s){
                case 0:
                    _selectedCalculator = '+';
                    break;
                case 1:
                    _selectedCalculator = '-';
                    break;
                case 2:
                    _selectedCalculator = '*';
                    break;
                case 3:
                    _selectedCalculator = '/';
                    break;
            }

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
            }

            return _result;
    }
}}
