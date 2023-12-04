using System;

namespace _20231204_Prac02_Okumura
{
    public interface IRectangle : IShape
    {
        /// <summary>
        /// 高さ
        /// </summary>
        /// <value>double</value>
        public double Height {get; set;}
        /// <summary>
        /// 幅
        /// </summary>
        /// <value>double</value>
        public double Width {get; set;}

    }
}
