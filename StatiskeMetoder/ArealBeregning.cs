namespace StatiskeMetoder
{
    public static class ArealBeregning
    {
        public static double BeregnArealFirkant(double højde,double brede)
        {
            return højde * brede;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return System.Math.PI * System.Math.Pow(radius,2);
        }
    }
}
