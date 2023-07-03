using System;

namespace _20230703_Class3.src{
    public class UsingGeneric<T>{
        private List<T> items;

        public UsingGeneric(){
            items = new List<T>();
        }

        public void Add(T item){
            items.Add(item);
        }

        public void Display(){
            foreach(T item in items){
                Console.WriteLine(item);
            }
        }
    }
}