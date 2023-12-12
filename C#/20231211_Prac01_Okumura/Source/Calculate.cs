namespace Main.Calculator{
    /// <summary>
    /// デリゲートを名前空間に定義
    /// </summary>
    /// <param name="a">double</param>
    /// <param name="b">double</param>
    /// <returns>double</returns>
    delegate double Operation(double a, double b);

    // 計算クラス
    public class Calculate{

        /// <summary>
        /// 足し算
        /// </summary>
        public static double Add(double a, double b){
            return a + b;
        }
        /// <summary>
        /// 引き算
        /// </summary>
        public static double Subtract(double a, double b){
            return a - b;
        }
        /// <summary>
        /// 掛け算
        /// </summary>
        public static double Multiply(double a, double b){
            return a * b;
        }
        /// <summary>
        /// 割り算
        /// </summary>
        public static double Divide(double a, double b){
            return a / b;
        }
    }
}