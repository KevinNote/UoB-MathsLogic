using System;

namespace KevinZonda.UoB.Mathematics.Week2
{
    public class Lcf
    {
        public Lcf(int x, int y)
        {
            Console.WriteLine($"x = {x}, y = {y}");
            
            var resultE = EuclideanAlgorithmLcf(x, y);
            Console.WriteLine($"辗转相除法: {resultE}");

            var resultM = MinusEachLcf(x, y);
            Console.WriteLine($"更相减损术: {resultM}");
        }
        
        /// <summary>
        /// 辗转相除法/Euclidean Algorithm
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int EuclideanAlgorithmLcf(int x, int y)
        {
            while (y != 0)
            {
                int r = x % y;
                x = y;
                y = r;
            }
            return x;
        }
        
        /// <summary>
        /// 更相减损术
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int MinusEachLcf(int x, int y)
        {
            while (true)
            {
                if (x > y)
                    x -= y;
                else if (x < y)
                    y -= x;
                else
                    return x;
            }
        }
    }
}