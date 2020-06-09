using System;

namespace Draw.Objects
{
    public static class Letters
    {
        public const string O = "O";
        public const string X = "X";
        public const string Y = "Y";
        public const string Z = "Z";
    }

    public class Letter
    {
        public static T Create<T>(int size) where T : new()
        {
            var obj = Activator.CreateInstance(typeof(T), new object[] {size});

            return (T)obj;
        }
    }
}
