using System;

namespace integral
{
    public class IntegralClass
    {
        public static int integrate(int b, int m, int n)
        {
            return (int)Math.Round(Math.Pow(n,(b+1))-Math.Pow(m,(b+1)));
        }
    }
}
