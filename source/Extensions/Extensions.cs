namespace Draw.Extensions
{
    public static class Extensions
    {
        public static bool IsValidSize(this int value)
        {
            return value % 2 == 1 && value >= 3;
        }
    }
}
