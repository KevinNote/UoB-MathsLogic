using System;
namespace KevinZonda.UoB.Mathematics.Week2
{
    public class BezoutIdentity
    {
        public BezoutIdentity(int x = 288, int y = 150)
        {
            var result = GetBezoutIdentityWithCounter(x, y);
            
            Console.WriteLine($"x = {result.x}, u = {result.u}, v = {result.v}");
        }
        
        public static (int x, int u, int v) GetBezoutIdentityWithCounter(int x, int y)
        {
            int u_x = 1,
                v_x = 0;

            int u_y = 0,
                v_y = 1;

            int count = 0;

            Console.WriteLine(@"| Run |   x   |   y   |  v_x  |  u_y  |  v_y  |");
            Console.WriteLine(@"-----------------------------------------------");
            while (y != 0)
            {
                Console.WriteLine($"| {count,3} | {x, 5} | {y, 5} | {u_x, 5} | {u_y, 5} | {v_y, 5} |");
                int r = x % y;
                int k = x / y;

                int u = u_x;
                int v = v_x;

                u_x = u_y;
                v_x = v_y;

                u_y = u - k * u_y;
                v_y = v - k * v_y;

                x = y;
                y = r;

                ++count;
            }

            Console.WriteLine($"| {count,3} | {x, 5} | {y, 5} | {u_x, 5} | {u_y, 5} | {v_y, 5} |");
            
            return (x, u_x, v_x);
        }

        public static (int x, int u, int v) GetBezoutIdentity(int x, int y)
        {
            int u_x = 1,
                v_x = 0;

            int u_y = 0,
                v_y = 1;

            while (y != 0)
            {
                int r = x % y;
                int k = x / y;

                int u = u_x;
                int v = v_x;

                u_x = u_y;
                v_x = v_y;

                u_y = u - k * u_y;
                v_y = v - k * v_y;

                x = y;
                y = r;
            }

            return (x, u_x, v_x);
        }
    }
}