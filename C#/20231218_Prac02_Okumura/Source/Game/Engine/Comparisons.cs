using System;

namespace Game.Engine.Core{
    public class Comparisons{

        public Func<int, int, int> _2int = (a, b) => {
            if (a > b){
                return a;
            } else if (a < b){
                return b;
            } else {
                return 0;
            }
        };
    }
}
