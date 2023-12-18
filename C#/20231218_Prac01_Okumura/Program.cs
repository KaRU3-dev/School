using System;

namespace _20231218_Prac01_Okumura{
    public class Program{
        // List array limit
        static int limit = 10;

        public static void Main(string[] str){

            // 10 int list 1 ~ 100
            int[] list = new int[limit];

            // random
            Random rand = new Random();

            // 1 ~ 100
            for(int i = 0; i < list.Length; i++){
                list[i] = rand.Next(1, 101);
            }

            // Get list % 2 == 0
            int[] evenList = new int[limit];
            for(int i = 0; i < list.Length; i++){
                if(list[i] % 2 == 0){
                    evenList[i] = list[i];
                }
            }

            // Get evenList[i] >= 5
            int[] evenList2 = new int[limit];
            for(int i = 0; i < evenList.Length; i++){
                if(evenList[i] >= 5){
                    evenList2[i] = evenList[i];
                }
            }

            // Lambda expression for evenList2[i] * 2 and add to new list
            int[] resultList = new int[limit];
            Func<int, int> func = (x) => x * 2;
            for(int i = 0; i < evenList2.Length; i++){
                if(evenList2[i] != 0){
                    resultList[i] = func(evenList2[i]);
                }
            }

            // Show resultList
            for(int i = 0; i < resultList.Length; i++){
                if(resultList[i] != 0){
                    Console.WriteLine(resultList[i]);
                }
            }
        }
    }
}
