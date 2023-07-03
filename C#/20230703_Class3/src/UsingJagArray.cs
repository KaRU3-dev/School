using System;

namespace _20230703_Class3.src{
    public class UsingJagArray{
        private int[][] JagArray = new int[3][];

        public void DisplayJagArray(){
            JagArray[0] = new int[2]{1, 2};
            JagArray[1] = new int[3]{1, 2, 3};
            JagArray[2] = new int[4]{1, 2, 3, 4};

            for(int i = 0; i < JagArray.Length; i++){
                for(int j = 0; j < JagArray[i].Length; j++){
                    Console.Write($"{JagArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}