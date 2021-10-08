using KevinZonda.UoB.Mathematics.Helper;

namespace KevinZonda.UoB.Mathematics.Week2
{
    public class Entry
    {
        public Entry()
        {
            Printer.PrintTitle(new[] { "最大公约数", "Lcf" });

            new Lcf(32, 16);

            Printer.PrintTitle(new[] { "贝祖定理", "Bézout's Identity" });

            new BezoutIdentity();
        }
    }
}