using System;

namespace _20231204_Prac02_Okumura
{
    public interface ICircle : IShape
    {
        /// <summary>
        /// 半径
        /// </summary>
        /// <value>double</value>
        public double Radius {get; set;}

    }
}
