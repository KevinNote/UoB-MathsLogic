using KevinZonda.UoB.Mathematics.Helper;

namespace KevinZonda.UoB.Mathematics.Week2
{
    public class Entry
    {
        /// <summary>
        /// Lcf & BezoutIdentity
        /// </summary>
        /// <param name="lcfX">Lcf(x, y)'s x</param>
        /// <param name="lcfY">Lcf(x, y)'s y</param>
        /// <param name="biX">BezoutIdentity(x, y)'s x</param>
        /// <param name="biY">BezoutIdentity(x, y)'s y</param>
        public Entry(int lcfX = 32, int lcfY = 16, int biX = 288, int biY = 150)
        {
            Printer.PrintTitle(new[] { "最大公约数", "Lcf" });

            new Lcf(lcfX, lcfY);

            Printer.PrintTitle(new[] { "贝祖定理", "Bézout's Identity" });
            new BezoutIdentity(biX, biY);
        }
    }
}